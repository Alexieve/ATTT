-- Lấy các tên bảng của Schema C##ADMIN
CREATE OR REPLACE FUNCTION USP_GET_TABLE_NAME 
RETURN SYS_REFCURSOR
AS
    P_TABLE_NAMES SYS_REFCURSOR;
BEGIN
    OPEN P_TABLE_NAMES FOR
        SELECT TABLE_NAME
        FROM USER_TABLES
        WHERE TABLE_NAME != 'USER_ROLE_ACCESS_CONDITIONS';
    RETURN P_TABLE_NAMES;
END;
/

-- Lấy các quyền của một role/user
CREATE OR REPLACE PROCEDURE USP_GET_PRIV(P_ROLE_USER_NAME IN VARCHAR2, P_ROLE_USER_PRIV OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_ROLE_USER_PRIV FOR
        SELECT TABLE_NAME, PRIVILEGE, GRANTABLE
        FROM DBA_TAB_PRIVS
        WHERE GRANTEE = UPPER(P_ROLE_USER_NAME)
        AND GRANTOR = 'C##ADMIN'
        AND TABLE_NAME != 'USER_ROLE_ACCESS_CONDITIONS'
        ORDER BY TABLE_NAME, PRIVILEGE;    
END;
/


-- Thu hồi tất cả các quyền trên các bảng của C##ADMIN
CREATE OR REPLACE PROCEDURE USP_REVOKE_ALL_PRIV_ON_SCHEMA(P_ROLE_USER_NAME IN VARCHAR2)
AS
BEGIN
    FOR TAB_PRIV IN (SELECT * FROM DBA_TAB_PRIVS WHERE OWNER = 'C##ADMIN' AND GRANTEE = UPPER(P_ROLE_USER_NAME)) LOOP
        EXECUTE IMMEDIATE 'REVOKE ALL PRIVILEGES ON ' || UPPER(TAB_PRIV.TABLE_NAME) || ' FROM ' || UPPER(P_ROLE_USER_NAME);
    END LOOP;
END;
/


-- Cấp/Thu hồi quyền của Role
CREATE OR REPLACE PROCEDURE USP_GRANT_PRIV
(
    P_ROLE_USER_NAME IN VARCHAR2, 
    P_TABLE_NAME IN VARCHAR2,
    P_PRIVILEGE IN VARCHAR2,
    P_GRANTABLE IN VARCHAR2
)
AS
    STRSQL VARCHAR2(2000) := '';
    GRANT_OPT VARCHAR2(100) := ' ';
BEGIN
    IF P_GRANTABLE = 'YES' THEN
        GRANT_OPT := ' WITH GRANT OPTION';
    END IF;
    STRSQL := 'GRANT ' || P_PRIVILEGE || ' ON ' || UPPER(P_TABLE_NAME) || ' TO ' || UPPER(P_ROLE_USER_NAME) || GRANT_OPT;
    EXECUTE IMMEDIATE STRSQL;
    
END;
/