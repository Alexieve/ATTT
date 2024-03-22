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
