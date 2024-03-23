-- Lấy các tên các cột của bảng
CREATE OR REPLACE PROCEDURE USP_GET_COLUMN_NAME
(
    P_TABLE_NAME IN VARCHAR2, 
    P_COLUMN_NAMES OUT SYS_REFCURSOR
) 
AS
BEGIN
    OPEN P_COLUMN_NAMES FOR
        SELECT COLUMN_NAME
        FROM USER_TAB_COLUMNS
        WHERE TABLE_NAME = P_TABLE_NAME;
END;
/

-- Lấy quyền của user trên bảng
CREATE OR REPLACE PROCEDURE USP_GET_PRIV_COL
(
    P_ROLE_USER_NAME IN VARCHAR2, 
    P_TABLE_NAME IN VARCHAR2, 
    P_ROLE_USER_PRIV OUT SYS_REFCURSOR
) 
AS
BEGIN
    OPEN P_ROLE_USER_PRIV FOR
        SELECT COLUMN_NAME, PRIVILEGE, GRANTABLE
        FROM USER_COL_PRIVS
        WHERE TABLE_NAME = P_TABLE_NAME
        AND GRANTEE = P_ROLE_USER_NAME
        ORDER BY COLUMN_NAME;
END;
/

-- Tạo bảng chứa các cột mà user/role được cấp
CREATE TABLE USER_ROLE_ACCESS_CONDITIONS (
    USER_ROLE VARCHAR2(20),
    TABLE_NAME VARCHAR2(20),
    COLUMN_NAME VARCHAR2(20),
    CONSTRAINT PK_USER_ROLE_ACCESS_CONDITIONS PRIMARY KEY (USER_ROLE, TABLE_NAME, COLUMN_NAME)
)


-- Thu hồi tất cả các quyền SELECT trên bảng
CREATE OR REPLACE PROCEDURE USP_REVOKE_UPDATE_PRIV(
    P_ROLE_USER_NAME IN VARCHAR2,
    P_TABLE_NAME IN VARCHAR2
)
AS
BEGIN
    DELETE FROM USER_ROLE_ACCESS_CONDITIONS
    WHERE USER_ROLE = P_ROLE_USER_NAME AND TABLE_NAME = P_TABLE_NAME;
END;
/



-- Thu hồi tất cả các quyền UPDATE trên bảng
CREATE OR REPLACE PROCEDURE USP_REVOKE_UPDATE_PRIV(
    P_ROLE_USER_NAME IN VARCHAR2,
    P_TABLE_NAME IN VARCHAR2
)
AS
BEGIN
    EXECUTE IMMEDIATE 'REVOKE UPDATE ON ' || UPPER(P_TABLE_NAME) || ' FROM ' || UPPER(P_ROLE_USER_NAME);
END;
/


-- Hàm Chính sách chung cho quyền Select của user/role
CREATE OR REPLACE FUNCTION POL_FUNC_USER_ROLE_ACCESS_CONDITIONS (
    P_SCHEMA_NAME VARCHAR2,
    P_TABLE_NAME VARCHAR2
) 
RETURN VARCHAR2 
AS
    V_CONDITION BOOLEAN := FALSE;
BEGIN
    SELECT TRUE
    INTO V_CONDITION
    FROM USER_ROLE_ACCESS_CONDITIONS
    WHERE (USER_ROLE = SYS_CONTEXT('USERENV', 'SESSION_USER')
        OR EXISTS
        (
            SELECT 1
            FROM DBA_ROLE_PRIVS
            WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER')
            AND GRANTED_ROLE = USER_ROLE
    ))
    AND TABLE_NAME = P_TABLE_NAME;
    
    IF V_CONDITION = TRUE THEN
        RETURN '1 = 2';
    END IF;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1 = 1';
END;
/


-- Hàm lấy các cột mà user được xem
CREATE OR REPLACE FUNCTION USP_GET_COL_USER_ROLE_ACCESS_CONDITIONS(
    P_USER_ROLE IN VARCHAR2,
    P_TABLE_NAME IN VARCHAR2
)
RETURN VARCHAR2
IS
    V_COLUMN_NAMES VARCHAR2(4000);
BEGIN
    FOR REC IN (SELECT COLUMN_NAME
                FROM USER_ROLE_ACCESS_CONDITIONS
                WHERE USER_ROLE = P_USER_ROLE AND TABLE_NAME = P_TABLE_NAME)
    LOOP
        IF V_COLUMN_NAMES IS NULL THEN
            V_COLUMN_NAMES := REC.COLUMN_NAME;
        ELSE
            V_COLUMN_NAMES := V_COLUMN_NAMES || ', ' || REC.COLUMN_NAME;
        END IF;
    END LOOP;

    RETURN '''' || V_COLUMN_NAMES || '''';
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN NULL;
END;
/

-- Cấp quyền trên cột cho user
CREATE OR REPLACE PROCEDURE USP_GRANT_PRIV_COL
(
    P_ROLE_USER_NAME IN VARCHAR2, 
	P_TABLE_NAME IN VARCHAR2, 
	P_COLUMN_NAME IN VARCHAR2, 
	P_SELECT IN VARCHAR2,
    P_UPDATE IN VARCHAR2
)
AS

BEGIN
--    IF P_SELECT = 'UNCHECKED' THEN
--		EXECUTE IMMEDIATE 'REVOKE SELECT (' || P_COLUMN_NAME ||  ') ON ' || P_TABLE_NAME || ' FROM ' || P_ROLE_USER_NAME;
--    ELSIF P_SELECT = 'CHECKED' THEN
--        EXECUTE IMMEDIATE 'GRANT SELECT (' || P_COLUMN_NAME ||  ') ON ' || P_TABLE_NAME || ' TO ' || P_ROLE_USER_NAME;
--    ELSIF P_SELECT = 'INDETERMINATE' THEN
--        EXECUTE IMMEDIATE 'GRANT SELECT (' || P_COLUMN_NAME ||  ') ON ' || P_TABLE_NAME || ' TO ' || P_ROLE_USER_NAME || ' WITH GRANT OPTION';
--    END IF;
    
    

    IF P_UPDATE = 'CHECKED' THEN
        EXECUTE IMMEDIATE 'GRANT UPDATE (' || P_COLUMN_NAME ||  ') ON ' || P_TABLE_NAME || ' TO ' || P_ROLE_USER_NAME;
    ELSIF P_UPDATE = 'INDETERMINATE' THEN
        EXECUTE IMMEDIATE 'GRANT UPDATE (' || P_COLUMN_NAME ||  ') ON ' || P_TABLE_NAME || ' TO ' || P_ROLE_USER_NAME || ' WITH GRANT OPTION';
    END IF;

END;
/



--DROP FUNCTION vpd_TEST;
--CREATE OR REPLACE FUNCTION vpd_TEST (
--    p_schema_name VARCHAR2,
--    p_table_name VARCHAR2
--) 
--RETURN VARCHAR2 
--AS
--    v_condition VARCHAR2(4000);
--BEGIN
--    RETURN '1 = 2';
--
--END;
--/
--
--BEGIN
--    DBMS_RLS.DROP_POLICY(
--        OBJECT_SCHEMA => 'C##ADMIN',
--        OBJECT_NAME => 'NHANSU',
--        POLICY_NAME => 'POL_TEST'
--    );
--END;
--/
--BEGIN
--    DBMS_RLS.ADD_POLICY(
--        OBJECT_SCHEMA => 'C##ADMIN',
--        OBJECT_NAME => 'NHANSU',
--        POLICY_NAME => 'POL_TEST',
--        POLICY_FUNCTION => 'vpd_TEST',
--        sec_relevant_cols=> 'VAITRO',
--        sec_relevant_cols_opt=> DBMS_RLS.ALL_ROWS,
--        STATEMENT_TYPES => 'SELECT'
--    );
--END;
--/
--
--SELECT * FROM C##ADMIN.NHANSU 

