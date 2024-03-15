-- Drop list user hiện tại
CREATE OR REPLACE PROCEDURE USP_DROP_LIST_USERS
AS
    CURSOR CUR1 IS (
        SELECT SV.MASV 
        FROM SINHVIEN SV
        WHERE EXISTS (
            SELECT 1 
            FROM ALL_USERS
            WHERE USERNAME = SV.MASV
        )
    );
    CURSOR CUR2 IS (
        SELECT NV.MANV 
        FROM NHANSU NV
        WHERE EXISTS (
            SELECT 1 
            FROM ALL_USERS
            WHERE USERNAME = NV.MANV
        )
    );
    STRSQL VARCHAR(5000);
    SP_USER CHAR(10);
BEGIN
    OPEN CUR1;
    LOOP
        FETCH CUR1 INTO SP_USER;
        EXIT WHEN CUR1%NOTFOUND;
        
        STRSQL := 'DROP USER ' || SP_USER;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR1;
    
    OPEN CUR2;
    LOOP
        FETCH CUR2 INTO SP_USER;
        EXIT WHEN CUR2%NOTFOUND;
        
        STRSQL := 'DROP USER ' || SP_USER;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR2;
END; 
/

-- Tạo list user cho database
CREATE OR REPLACE PROCEDURE USP_CREATE_LIST_USERS
AS
    CURSOR CUR1 IS (
        SELECT SV.MASV 
        FROM SINHVIEN SV
        WHERE NOT EXISTS (
            SELECT 1 
            FROM ALL_USERS
            WHERE USERNAME = SV.MASV
        )
    );
    
    CURSOR CUR2 IS (
        SELECT NV.MANV, NV.VAITRO
        FROM NHANSU NV
        WHERE NOT EXISTS (
            SELECT 1 
            FROM ALL_USERS
            WHERE USERNAME = NV.MANV
        )
    );
    STRSQL VARCHAR(5000);
    SP_USER CHAR(10);
    SP_USER_RL NVARCHAR2(20);
BEGIN
    OPEN CUR1;
    LOOP
        FETCH CUR1 INTO SP_USER;
        EXIT WHEN CUR1%NOTFOUND;
        
        USP_CREATE_USER(SP_USER, SP_USER);        
        EXECUTE IMMEDIATE ('GRANT RL_SINHVIEN TO ' || SP_USER);
    END LOOP;
    CLOSE CUR1;
    
    OPEN CUR2;
    LOOP
        FETCH CUR2 INTO SP_USER, SP_USER_RL;
        EXIT WHEN CUR2%NOTFOUND;
        
        USP_CREATE_USER(SP_USER, SP_USER);
        
        IF SP_USER_RL = N'Nhân viên cơ bản' THEN 
            EXECUTE IMMEDIATE ('GRANT RL_NVCOBAN TO ' || SP_USER);
        ELSIF SP_USER_RL = N'Giảng viên' THEN
            EXECUTE IMMEDIATE ('GRANT RL_GIANGVIEN TO ' || SP_USER);
        ELSIF SP_USER_RL = N'Giáo vụ' THEN
            EXECUTE IMMEDIATE ('GRANT RL_GIAOVU TO ' || SP_USER);
        ELSIF SP_USER_RL = N'Trưởng đơn vị' THEN
            EXECUTE IMMEDIATE ('GRANT RL_TRUONGDV TO ' || SP_USER);
        ELSIF SP_USER_RL = N'Trưởng khoa' THEN
            EXECUTE IMMEDIATE ('GRANT RL_TRUONGKHOA TO ' || SP_USER);
        END IF;
    END LOOP;
    CLOSE CUR2;
END; 
/

-- Kiểm tra Role A có phải cha của Role B không
CREATE OR REPLACE FUNCTION IS_ROLE_SUBROLE(
    F_PARENT_ROLE IN VARCHAR2,
    F_CHILD_ROLE IN VARCHAR2
)
RETURN VARCHAR2
IS
    CHECK_ROLE VARCHAR2(20);
BEGIN
    IF F_PARENT_ROLE = F_CHILD_ROLE THEN
        RETURN F_CHILD_ROLE;
    END IF;
    SELECT CHILD_ROLE INTO CHECK_ROLE
    FROM (
        SELECT GRANTED_ROLE AS child_role, ROLE AS parent_role
        FROM ROLE_ROLE_PRIVS
        WHERE ROLE = F_PARENT_ROLE -- Thay 'ROLE_NAME' bằng tên role bạn quan tâm
        
        UNION ALL
        
        SELECT rrp.GRANTED_ROLE, rrp.ROLE
        FROM ROLE_ROLE_PRIVS rrp
        JOIN (
          SELECT GRANTED_ROLE, ROLE
          FROM ROLE_ROLE_PRIVS
          WHERE ROLE = F_PARENT_ROLE -- Thay 'ROLE_NAME' bằng tên role bạn quan tâm
        ) rh ON rrp.ROLE = rh.GRANTED_ROLE
    )
    WHERE CHILD_ROLE = F_CHILD_ROLE;
    RETURN CHECK_ROLE;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN 'RL_NONE'; -- Trả về FALSE nếu không tìm thấy dữ liệu
END;
/