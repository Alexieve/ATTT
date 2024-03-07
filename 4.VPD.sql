/*
 CS1 - Nhân viên cơ bản
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
    -- Kiểm tra có phải là DBA không
    P_USER_ROLE := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
--    -- Kiểm tra role của các tài khoản còn lại
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM USER_ROLE_PRIVS 
    WHERE GRANTED_ROLE = 'RL_NVCOBAN';
    IF P_USER_ROLE = 'RL_NVCOBAN' THEN
        RETURN 'MANV = ''' || SYS_CONTEXT('USERENV', 'SESSION_USER') || '''';
    ELSE
        RETURN '';
    END IF;
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
-- Cấp quyền xem thông tin của tất cả SINHVIEN, ĐƠNVỊ, HOCPHAN, KHMO
GRANT SELECT ON SINHVIEN TO RL_NVCOBAN;
GRANT SELECT ON DONVI TO RL_NVCOBAN;
GRANT SELECT ON HOCPHAN TO RL_NVCOBAN;
GRANT SELECT ON KHMO TO RL_NVCOBAN;
/





/*
 CS2 - Giảng viên
*/

-- CS2.1


-- CS2.2


-- CS2.3


-- CS2.4



/*
 CS3 - Giáo vụ
*/

-- CS3.1


-- CS3.2


-- CS3.3


-- CS3.4



/*
 CS4 - Trưởng đơn vị
*/

-- CS4.1


-- CS4.2


-- CS4.3
 


/*
 CS5 - Trưởng khoa
*/

-- CS5.1


-- CS5.2


-- CS5.3


-- CS5.4



/*
 CS6 - Sinh viên
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
    -- Kiểm tra có phải là DBA không
    SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') INTO P_USER_ROLE
    FROM DUAL;
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    -- Kiểm tra role của các tài khoản còn lại
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM USER_ROLE_PRIVS 
    WHERE GRANTED_ROLE = 'RL_SINHVIEN';
    IF P_USER_ROLE = 'RL_SINHVIEN' THEN
        RETURN 'MASV = ''' || SYS_CONTEXT('USERENV', 'SESSION_USER') || '''';
    ELSE
        RETURN '';
    END IF;
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
    -- Kiểm tra có phải là DBA không
    SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') INTO P_USER_ROLE
    FROM DUAL;
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    -- Kiểm tra role của các tài khoản còn lại
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM USER_ROLE_PRIVS 
    WHERE GRANTED_ROLE = 'RL_SINHVIEN';
    IF P_USER_ROLE = 'RL_SINHVIEN' THEN
        SELECT MANGANH INTO P_SINHVIEN_MANGANH
        FROM SINHVIEN;
        RETURN 'MADV = ''' || P_SINHVIEN_MANGANH || '''';
    ELSE
        RETURN '';
    END IF;
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
    P_HOCPHAN_LIST_MAHP VARCHAR2(5000) := '';
BEGIN
    -- Kiểm tra có phải là DBA không
    SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') INTO P_USER_ROLE
    FROM DUAL;
    IF P_USER_ROLE = 'C##ADMIN' THEN
        RETURN '';
    END IF;
    
    -- Kiểm tra role của các tài khoản còn lại
    SELECT GRANTED_ROLE INTO P_USER_ROLE
    FROM USER_ROLE_PRIVS 
    WHERE GRANTED_ROLE = 'RL_SINHVIEN';
    IF P_USER_ROLE = 'RL_SINHVIEN' THEN
        FOR c_row IN (SELECT MAHP FROM HOCPHAN) LOOP
        P_HOCPHAN_LIST_MAHP := P_HOCPHAN_LIST_MAHP || '''' || c_row.MAHP || ''', ';
        END LOOP;
        P_HOCPHAN_LIST_MAHP := RTRIM(P_HOCPHAN_LIST_MAHP, ', ');
        RETURN 'MAHP IN (' || P_HOCPHAN_LIST_MAHP || ')';
    ELSE
        RETURN '';
    END IF;
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
        STATEMENT_TYPES => 'SELECT, INSERT, UPDATE, DELETE',
        UPDATE_CHECK => TRUE
    );
END;
/
GRANT SELECT, INSERT, DELETE ON DANGKY TO RL_SINHVIEN;



