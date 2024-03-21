SET SERVEROUTPUT ON;
------------------------------ PHANHE1 ----------------------------------------
-- 1.Xem danh sách tài khoản người dùng
CREATE OR REPLACE PROCEDURE USP_VIEW_USER_ACCOUNT(
    RES_CURSOR OUT SYS_REFCURSOR
)
AS
BEGIN
    OPEN RES_CURSOR FOR
    SELECT USERNAME, USER_ID, CREATED, GRANTED_ROLE
    FROM ALL_USERS JOIN DBA_ROLE_PRIVS
    ON USERNAME = GRANTEE
    WHERE (USERNAME LIKE 'SV%' OR USERNAME LIKE 'NV%')
    AND GRANTED_ROLE != 'CONNECT'
    ORDER BY USERNAME, GRANTED_ROLE, CREATED;
END;
/

-- Test 1.
--DECLARE
--    RES_CURSOR SYS_REFCURSOR;
--    username VARCHAR2(100);
--    user_id NUMBER;
--    created DATE;
--    granted_role VARCHAR2(100);
--BEGIN
--    USP_VIEW_USER_ACCOUNT(RES_CURSOR);
--    LOOP
--        FETCH RES_CURSOR INTO username, user_id, created, granted_role;
--        EXIT WHEN RES_CURSOR%NOTFOUND;
--        
--        DBMS_OUTPUT.PUT_LINE('Username: ' || username || ', User ID: ' || user_id || ', Created: ' || TO_CHAR(created, 'DD-MM-YYYY') || ', Granted Role: ' || granted_role);
--    END LOOP;
--    
--    CLOSE RES_CURSOR;
--END;
--/

-- 2.Xem thông tin về quyền (privileges) của mỗi user/ role trên các đối tượng dữ liệu.
-- Xem các quyền được cấp theo mức độ bảng
--SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE, GRANTABLE
--FROM dba_tab_privs
--WHERE grantee LIKE 'RL%'
--ORDER BY grantee, table_name;
---- Xem các quyền được cấp theo mức độ cột
SELECT *
FROM dba_col_privs
WHERE grantee = 'RL_GIAOVU'
ORDER BY grantee, table_name, column_name;
---- Xem các quyền hệ thống 
SELECT grantee, privilege
FROM dba_sys_privs
WHERE grantee = 'NV00000008'
ORDER BY grantee;
---- Xem các quyền của role được cấp cho User
--SELECT *
--FROM dba_role_privs
--WHERE grantee = 'NV00000008'
--ORDER BY grantee;
--
SELECT * FROM USER_TAB_PRIVS
WHERE GRANTEE = 'NV0000001';

-- 3.Tạo mới, Xóa, Sửa (hiệu chỉnh) user hoặc role. 
-- Tạo user
CREATE OR REPLACE PROCEDURE USP_CREATE_USER (
    SP_USERNAME IN VARCHAR2,
    SP_PASSWORD IN VARCHAR2
)
AS
BEGIN
    EXECUTE IMMEDIATE 'CREATE USER ' || SP_USERNAME || ' IDENTIFIED BY ' || SP_PASSWORD;
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || SP_USERNAME;
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || SP_USERNAME;
    EXECUTE IMMEDIATE 'GRANT CREATE TABLE TO ' || SP_USERNAME;
    EXECUTE IMMEDIATE 'GRANT UNLIMITED TABLESPACE TO ' || SP_USERNAME;
END;
/

-- Xoá user
CREATE OR REPLACE PROCEDURE USP_DROP_USER (
    SP_USERNAME IN VARCHAR2,
    CHECK_CASCADE IN VARCHAR2
)
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP USER ' || SP_USERNAME || ' ' || CHECK_CASCADE;
END;
/

-- Đổi mật khẩu user
CREATE OR REPLACE PROCEDURE USP_ALTER_USER_CHANGE_PASSWORD (
    SP_USERNAME IN VARCHAR2, 
    NEW_PASSWORD IN VARCHAR2
)
AS
BEGIN
    EXECUTE IMMEDIATE 'ALTER USER ' || SP_USERNAME || ' IDENTIFIED BY ' || NEW_PASSWORD;
END;
/

-- Tạo role
CREATE OR REPLACE PROCEDURE USP_ADD_ROLE (
    ROLE_NAME IN VARCHAR2
)
AS
BEGIN
    EXECUTE IMMEDIATE 'CREATE ROLE ' || ROLE_NAME;
END;
/

-- Xoá role
CREATE OR REPLACE PROCEDURE USP_DROP_ROLE (
    ROLE_NAME IN VARCHAR2
)
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP ROLE ' || ROLE_NAME;
END;
/


-- 4-5.Thực hiện cấp quyền
-- Cấp role cho user
CREATE OR REPLACE PROCEDURE USP_GRANT_ROLE (
    ROLE_NAME IN VARCHAR2,
    USERNAME IN VARCHAR2
)
AS
BEGIN
    EXECUTE IMMEDIATE 'GRANT ' || ROLE_NAME || ' TO ' || USERNAME;
END;
/

-- Thu hồi role của user
CREATE OR REPLACE PROCEDURE USP_REVOKE_ROLE (
    ROLE_NAME IN VARCHAR2,
    USERNAME IN VARCHAR2
)
AS
BEGIN
    EXECUTE IMMEDIATE 'REVOKE ' || ROLE_NAME || ' FROM ' || USERNAME;
END;
/


-- Cấp / Thu hồi quyền INSERT, DELETE cho user / role theo mức bảng

-- Cấp / Thu hồi quyền SELECT, UPDATE cho user / role theo mức cột










