CREATE OR REPLACE FUNCTION USP_GET_USER_NAME 
RETURN SYS_REFCURSOR
AS
    P_USER_NAMES SYS_REFCURSOR;
BEGIN
    OPEN P_USER_NAMES  FOR
        SELECT USERNAME, ACCOUNT_STATUS, DEFAULT_TABLESPACE, CREATED, AUTHENTICATION_TYPE
        FROM DBA_USERS;
    RETURN P_USER_NAMES;
END;