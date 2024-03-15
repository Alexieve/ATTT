/*
 CS1 - Nhân viên cơ bản --------------------------------------------------------------------
*/
-- CS1.1
-- Tạo Policy function lấy Username của Sinh viên hiện tại
CREATE OR REPLACE FUNCTION POL_FUNC_CURRENT_USER_NHANSU (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    P_USER_ROLE VARCHAR2(20) DEFAULT '';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_TRUONGKHOA') = 'RL_TRUONGKHOA' THEN
        RETURN '1 = 1';
    ELSIF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_TRUONGDV') = 'RL_TRUONGDV' THEN
        RETURN '1 = 1';
    ELSIF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_NVCOBAN') = 'RL_NVCOBAN' THEN
        RETURN 'MANV = ''' || SYS_CONTEXT('USERENV', 'SESSION_USER') || '''';
    ELSE
        RETURN '1 = 1';
    END IF;
    
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1 = 1';
END;
/
-- Thêm chính sách cho policy function POL_FUNC_CURRENT_USER_NHANSU
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'NHANSU',
        POLICY_NAME => 'POL_NHANSU_CURRENT_USER'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'NHANSU',
        POLICY_NAME => 'POL_NHANSU_CURRENT_USER',
        POLICY_FUNCTION => 'POL_FUNC_CURRENT_USER_NHANSU',
        STATEMENT_TYPES => 'SELECT, UPDATE',
        UPDATE_CHECK => TRUE
    );
END;
/

-- Cấp quyền trên bảng NHANSU
GRANT SELECT ON NHANSU TO RL_NVCOBAN;
GRANT UPDATE (SDT) ON NHANSU TO RL_NVCOBAN;


-- CS1.2
-- Cấp quyền xem thông tin của tất cả SINHVIEN, DONVI, HOCPHAN, KHMO
GRANT SELECT ON SINHVIEN TO RL_NVCOBAN;
GRANT SELECT ON DONVI TO RL_NVCOBAN;
GRANT SELECT ON HOCPHAN TO RL_NVCOBAN;
GRANT SELECT ON KHMO TO RL_NVCOBAN;
/





/*
 CS2 - Giảng viên --------------------------------------------------------------------
*/

-- CS2.1
GRANT RL_NVCOBAN TO RL_GIANGVIEN;

-- CS2.2
-- Tạo Policy function lấy MANV của GIANGVIEN trong PHANCONG
CREATE OR REPLACE FUNCTION POL_FUNC_CURRENT_GIANGVIEN_PHANCONG_DANGKY (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    P_USER_ROLE VARCHAR2(20) DEFAULT 'RL_NONE';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_TRUONGKHOA') = 'RL_TRUONGKHOA' THEN
        RETURN '1 = 1';
    ELSIF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_TRUONGDV') = 'RL_TRUONGDV' THEN
        RETURN '1 = 1';
    ELSIF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_GIANGVIEN') = 'RL_GIANGVIEN' THEN
        RETURN 'MAGV = ''' || SYS_CONTEXT('USERENV', 'SESSION_USER') || '''';
    ELSE
        RETURN '1 = 1';
    END IF;
    
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1 = 1';
END;
/

-- Thêm chính sách cho policy function POL_FUNC_CURRENT_GIANGVIEN_PHANCONG
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'PHANCONG',
        POLICY_NAME => 'POL_PHANCONG_CURRENT_GIANGVIEN'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'PHANCONG',
        POLICY_NAME => 'POL_PHANCONG_CURRENT_GIANGVIEN',
        POLICY_FUNCTION => 'POL_FUNC_CURRENT_GIANGVIEN_PHANCONG_DANGKY',
        STATEMENT_TYPES => 'SELECT'
    );
END;
/
GRANT SELECT ON PHANCONG TO RL_GIANGVIEN;



-- CS2.3
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'DANGKY',
        POLICY_NAME => 'POL_DANGKY_CURRENT_GIANGVIEN'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'DANGKY',
        POLICY_NAME => 'POL_DANGKY_CURRENT_GIANGVIEN',
        POLICY_FUNCTION => 'POL_FUNC_CURRENT_GIANGVIEN_PHANCONG_DANGKY',
        STATEMENT_TYPES => 'SELECT, UPDATE',
        UPDATE_CHECK => TRUE
    );
END;
/
GRANT SELECT ON DANGKY TO RL_GIANGVIEN;
-- CS2.4
GRANT UPDATE (DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON DANGKY TO RL_GIANGVIEN;





/*
 CS3 - Giáo vụ --------------------------------------------------------------------
*/

-- CS3.1
GRANT RL_NVCOBAN TO RL_GIAOVU;

-- CS3.2
GRANT SELECT, INSERT, UPDATE ON SINHVIEN TO RL_GIAOVU;
GRANT SELECT, INSERT, UPDATE ON DONVI TO RL_GIAOVU;
GRANT SELECT, INSERT, UPDATE ON HOCPHAN TO RL_GIAOVU;
GRANT SELECT, INSERT, UPDATE ON KHMO TO RL_GIAOVU;


-- CS3.3
CREATE OR REPLACE FUNCTION POL_FUNC_UPDATE_PHANCONG_VPK (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    P_USER_ROLE VARCHAR2(20) DEFAULT 'RL_NONE';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_GIAOVU') = 'RL_GIAOVU' THEN
        RETURN 'MAHP IN (SELECT MAHP FROM HOCPHAN WHERE MADV = (SELECT MADV FROM DONVI WHERE TENDV = N''Văn phòng khoa'' ))';
    ELSE
        RETURN '1 = 1';
    END IF;
    
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1 = 1';
END;
/
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'PHANCONG',
        POLICY_NAME => 'POL_UPDATE_PHANCONG_VPK'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'PHANCONG',
        POLICY_NAME => 'POL_UPDATE_PHANCONG_VPK',
        POLICY_FUNCTION => 'POL_FUNC_UPDATE_PHANCONG_VPK',
        STATEMENT_TYPES => 'UPDATE',
        UPDATE_CHECK => TRUE
    );
END;
/
GRANT SELECT, UPDATE ON PHANCONG TO RL_GIAOVU;

-- CS3.4
-- VPD dưới CS#6
GRANT SELECT, INSERT, DELETE ON DANGKY TO RL_GIAOVU;
REVOKE SELECT ON DANGKY FROM RL_GIAOVU;












/*
    CS4: TRUONG DONVI  --------------------------------------------------------------------
*/
-- CS4.1
GRANT RL_GIANGVIEN TO RL_TRUONGDV;
/



-- CS4.2
CREATE OR REPLACE FUNCTION POL_FUNC_PHANCONG_TRUONGDV_CRUD_HOCPHAN (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT  IN VARCHAR2
)
RETURN VARCHAR2
IS
    P_USER_ROLE VARCHAR2(20) DEFAULT 'RL_NONE';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_TRUONGDV') = 'RL_TRUONGDV' THEN
        RETURN 'MAHP IN (SELECT MAHP FROM HOCPHAN WHERE MADV = (SELECT MADV FROM NHANSU)))';
    ELSE
        RETURN '1 = 1';
    END IF;
END;
/
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'PHANCONG',
        POLICY_NAME => 'POL_PHANCONG_TRUONGDV_CRUD_HOCPHAN'
    );
END;
/
BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema   => 'C##ADMIN',
    object_name     => 'PHANCONG',
    policy_name     => 'POL_PHANCONG_TRUONGDV_CRUD_HOCPHAN',
    policy_function => 'POL_FUNC_PHANCONG_TRUONGDV_CRUD_HOCPHAN',
    statement_types => 'INSERT, UPDATE, DELETE',
    UPDATE_CHECK => TRUE
  );
END;
/
GRANT INSERT, UPDATE, DELETE ON PHANCONG TO RL_TRUONGDV;
/



--CS4.3
--
CREATE OR REPLACE FUNCTION POL_FUNC_CURRENT_TRUONGDV_NHANSU (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    P_USER_ROLE VARCHAR2(20) DEFAULT '';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_TRUONGDV') = 'RL_TRUONGDV' THEN
        RETURN 'MANV = ''' || SYS_CONTEXT('USERENV', 'SESSION_USER') || '''';
    ELSE
        RETURN '1 = 1';
    END IF;
    
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1 = 1';
END;
/
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'NHANSU',
        POLICY_NAME => 'POL_NHANSU_CURRENT_TRUONGDV'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'NHANSU',
        POLICY_NAME => 'POL_NHANSU_CURRENT_TRUONGDV',
        POLICY_FUNCTION => 'POL_FUNC_CURRENT_TRUONGDV_NHANSU',
        STATEMENT_TYPES => 'UPDATE',
        UPDATE_CHECK => TRUE
    );
END;
/

--
CREATE OR REPLACE FUNCTION POL_FUNC_LIST_USER_NHANSU_TRUONGDV (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    P_USER_ROLE VARCHAR2(20) DEFAULT '';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_TRUONGDV') = 'RL_TRUONGDV' THEN
        RETURN 'MADV = (SELECT MADV FROM DONVI WHERE TRUONGDV = ''' || SYS_CONTEXT('USERENV', 'SESSION_USER') || ''')';
    ELSE
        RETURN '1 = 1';
    END IF;
    
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1 = 1';
END;
/
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'NHANSU',
        POLICY_NAME => 'POL_NHANSU_LIST_USER_TRUONGDV'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'NHANSU',
        POLICY_NAME => 'POL_NHANSU_LIST_USER_TRUONGDV',
        POLICY_FUNCTION => 'POL_FUNC_LIST_USER_NHANSU_TRUONGDV',
        STATEMENT_TYPES => 'SELECT'
    );
END;
/

--
CREATE OR REPLACE FUNCTION POL_FUNC_PHANCONG_TRUONGDV (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT  IN VARCHAR2
)
RETURN VARCHAR2
IS
    P_USER_ROLE VARCHAR2(20) DEFAULT 'RL_NONE';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_TRUONGDV') = 'RL_TRUONGDV' THEN
        RETURN 'MAGV IN (SELECT MANV FROM NHANSU)';
    ELSE
        RETURN '1 = 1';
    END IF;
END;
/
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'PHANCONG',
        POLICY_NAME => 'POL_PHANCONG_TRUONGDV'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'C##ADMIN',
        object_name     => 'PHANCONG',
        policy_name     => 'POL_PHANCONG_TRUONGDV',
        policy_function => 'POL_FUNC_PHANCONG_TRUONGDV',
        statement_types => 'SELECT'
    );
END;
/
GRANT SELECT ON PHANCONG TO RL_TRUONGDV;
/









/*
    CS5: TRUONG KHOA --------------------------------------------------------------------
*/
-- CS5.1
GRANT RL_GIANGVIEN TO RL_TRUONGKHOA;

/
-- CS5.2
-- POLICY function ở CS3.3
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'PHANCONG',
        POLICY_NAME => 'POL_PHANCONG_TRUONGKHOA'
    );
END;
/
BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema   => 'C##ADMIN',
    object_name     => 'PHANCONG',
    policy_name     => 'POL_PHANCONG_TRUONGKHOA',
    policy_function => 'POL_FUNC_UPDATE_PHANCONG_VPK',
    statement_types => 'INSERT, UPDATE, DELETE',
    UPDATE_CHECK => TRUE
  );
END;
/
GRANT INSERT, UPDATE, DELETE ON PHANCONG TO RL_TRUONGKHOA;
/



--CS5.3
GRANT SELECT, INSERT, UPDATE, DELETE ON NHANSU TO RL_TRUONGKHOA;

--CS5.4
GRANT SELECT ANY TABLE TO RL_TRUONGKHOA;






/*
 CS6 - Sinh viên  --------------------------------------------------------------------
*/

-- CS6.1
-- Tạo Policy function lấy Username của Sinh viên hiện tại
CREATE OR REPLACE FUNCTION POL_FUNC_CURRENT_USER_SINHVIEN (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    P_USER_ROLE VARCHAR2(20) DEFAULT '';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_SINHVIEN') = 'RL_SINHVIEN' THEN
        RETURN 'MASV = ''' || SYS_CONTEXT('USERENV', 'SESSION_USER') || '''';
    ELSE
        RETURN '1 = 1';
    END IF;
    
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1 = 1';
END;
/

-- Thêm chính sách cho policy function POL_FUNC_CURRENT_USER_SINHVIEN
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'SINHVIEN',
        POLICY_NAME => 'POL_SINHVIEN_CURRENT_USER'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'SINHVIEN',
        POLICY_NAME => 'POL_SINHVIEN_CURRENT_USER',
        POLICY_FUNCTION => 'POL_FUNC_CURRENT_USER_SINHVIEN',
        STATEMENT_TYPES => 'SELECT, UPDATE',
        UPDATE_CHECK => TRUE
    );
END;
/
-- Cấp quyền trên bảng SINHVIEN
GRANT SELECT ON SINHVIEN TO RL_SINHVIEN;
GRANT UPDATE (DCHI, SDT) ON SINHVIEN TO RL_SINHVIEN;

-- CS6.2
-- Tạo Policy function lấy MANGANH của Sinh viên hiện tại
CREATE OR REPLACE FUNCTION POL_FUNC_CURRENT_MANGANH_SINHVIEN (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    P_USER_ROLE VARCHAR2(20) := '';
    P_SINHVIEN_MANGANH SINHVIEN.MANGANH%TYPE := '';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_SINHVIEN') = 'RL_SINHVIEN' THEN
        SELECT MANGANH INTO P_SINHVIEN_MANGANH
        FROM SINHVIEN;
        RETURN 'MADV = ''' || P_SINHVIEN_MANGANH || '''';
    ELSE
        RETURN '1 = 1';
    END IF;
    
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1 = 1';
END;
/
-- Thêm chính sách cho policy function POL_FUNC_CURRENT_MANGANH_SINHVIEN
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'HOCPHAN',
        POLICY_NAME => 'POL_HOCPHAN_OF_MANGANH'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'HOCPHAN',
        POLICY_NAME => 'POL_HOCPHAN_OF_MANGANH',
        POLICY_FUNCTION => 'POL_FUNC_CURRENT_MANGANH_SINHVIEN',
        STATEMENT_TYPES => 'SELECT'
    );
END;
/
GRANT SELECT ON HOCPHAN TO RL_SINHVIEN;

-- Tạo Policy function lấy MAHP của một đơn vị
CREATE OR REPLACE FUNCTION POL_FUNC_CURRENT_MAHP_HOCPHAN (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    P_USER_ROLE VARCHAR2(20) := '';
    P_SINHVIEN_MACT SINHVIEN.MACT%TYPE := '';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_SINHVIEN') = 'RL_SINHVIEN' THEN
        SELECT MACT INTO P_SINHVIEN_MACT
        FROM SINHVIEN;
        RETURN 'MACT = ''' || P_SINHVIEN_MACT || '''';
    ELSE
        RETURN '1 = 1';
    END IF;
    
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1 = 1';
END;
/
-- Thêm chính sách cho policy function POL_FUNC_CURRENT_MAHP_HOCPHAN
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'KHMO',
        POLICY_NAME => 'POL_KHMO_OF_MADV'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'KHMO',
        POLICY_NAME => 'POL_KHMO_OF_MADV',
        POLICY_FUNCTION => 'POL_FUNC_CURRENT_MAHP_HOCPHAN',
        STATEMENT_TYPES => 'SELECT'
    );
END;
/
GRANT SELECT ON KHMO TO RL_SINHVIEN;


-- CS6.3 ,6.4, 6.5
BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'DANGKY',
        POLICY_NAME => 'POL_DANGKY_CURRENT_USER'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'DANGKY',
        POLICY_NAME => 'POL_DANGKY_CURRENT_USER',
        POLICY_FUNCTION => 'POL_FUNC_CURRENT_USER_SINHVIEN',
        STATEMENT_TYPES => 'SELECT, INSERT, DELETE',
        UPDATE_CHECK => TRUE
    );
END;
/


-- Tạo Policy function lấy chỉ cho phép hiệu chỉnh học phần trong khoảng thời gian cho phép
CREATE OR REPLACE FUNCTION POL_FUNC_CRUD_DANGKY (
    P_SCHEMA IN VARCHAR2, 
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    P_USER_ROLE VARCHAR2(20) := '';
    SQLSTR VARCHAR2(5000) := '';
BEGIN
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = P_USER_ROLE
    AND GRANTED_ROLE LIKE 'RL%';
    
    IF IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_SINHVIEN') = 'RL_SINHVIEN' OR
    IS_ROLE_SUBROLE(P_USER_ROLE, 'RL_GIAOVU') = 'RL_GIAOVU'THEN
        SQLSTR := 'SYSDATE - TO_DATE(';
        SQLSTR := SQLSTR || '''1-'' || TO_CHAR((TO_NUMBER(HK) * 3 - (TO_NUMBER(HK) - 1)), ''FM00'') || ''-'' || NAM, ''DD-MM-YYYY'') <= 14';
        RETURN SQLSTR;
    ELSE
        RETURN '1 = 1';
    END IF;
    
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1 = 1';
END;
/

BEGIN
    DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'DANGKY',
        POLICY_NAME => 'POL_FUNC_CRUD_DANGKY'
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'C##ADMIN',
        OBJECT_NAME => 'DANGKY',
        POLICY_NAME => 'POL_FUNC_CRUD_DANGKY',
        POLICY_FUNCTION => 'POL_FUNC_CRUD_DANGKY',
        STATEMENT_TYPES => 'INSERT, DELETE',
        UPDATE_CHECK => TRUE
    );
END;
/
GRANT SELECT, INSERT, DELETE ON DANGKY TO RL_SINHVIEN;