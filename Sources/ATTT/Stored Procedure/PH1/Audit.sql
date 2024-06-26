CREATE OR REPLACE PROCEDURE USP_AUDIT_GET_STMT(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT USER_NAME, AUDIT_OPTION, SUCCESS, FAILURE
        FROM DBA_STMT_AUDIT_OPTS
        ORDER BY USER_NAME, AUDIT_OPTION;
END;
/

CREATE OR REPLACE PROCEDURE USP_AUDIT_GET_OBJ(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT OBJECT_NAME, OBJECT_TYPE, ALT, AUD, COM, DEL, GRA, IND, INS, LOC, REN, SEL, UPD, EXE, CRE, FBK
        FROM USER_OBJ_AUDIT_OPTS
        ORDER BY OBJECT_TYPE DESC;
END;
/


CREATE OR REPLACE FUNCTION USP_GET_VIEW_NAME
RETURN SYS_REFCURSOR
AS
    P_TABLE_NAMES SYS_REFCURSOR;
BEGIN
    OPEN P_TABLE_NAMES FOR
        SELECT VIEW_NAME
        FROM USER_VIEWS;
    RETURN P_TABLE_NAMES;
END;
/

CREATE OR REPLACE FUNCTION USP_GET_PROCEDURE_FUNCTION_NAME
RETURN SYS_REFCURSOR
AS
    P_TABLE_NAMES SYS_REFCURSOR;
BEGIN
    OPEN P_TABLE_NAMES FOR
        SELECT OBJECT_NAME
        FROM USER_OBJECTS 
        WHERE OBJECT_TYPE IN ('FUNCTION','PROCEDURE')
        ORDER BY OBJECT_TYPE, OBJECT_NAME;
    RETURN P_TABLE_NAMES;
END;
/


CREATE OR REPLACE PROCEDURE USP_AUDIT_ADD_STMT(
    P_AUDIT_OPTION IN VARCHAR2,
    P_USER_NAME IN VARCHAR2,
    P_WHEN IN VARCHAR2
)
AS
    SQL_STR VARCHAR2(100) := '';
BEGIN
    SQL_STR := 'AUDIT ' || P_AUDIT_OPTION || ' BY ' || P_USER_NAME || ' BY ACCESS ';
    IF (P_WHEN != 'ALL') THEN
        SQL_STR := SQL_STR || ' WHENEVER ' || P_WHEN;
    END IF;
    EXECUTE IMMEDIATE SQL_STR;
END;
/

CREATE OR REPLACE PROCEDURE USP_AUDIT_DELETE_STMT(
    P_AUDIT_OPTION IN VARCHAR2,
    P_USER_NAME IN VARCHAR2
)
AS
    SQL_STR VARCHAR2(100) := '';
BEGIN
    SQL_STR := 'NOAUDIT ' || P_AUDIT_OPTION || ' BY ' || P_USER_NAME;
    EXECUTE IMMEDIATE SQL_STR;
END;
/


CREATE OR REPLACE PROCEDURE USP_AUDIT_ADD_OBJ(
    P_AUDIT_OPTION IN VARCHAR2,
    P_OBJ_NAME IN VARCHAR2,
    P_WHEN IN VARCHAR2
)
AS
    SQL_STR VARCHAR2(100) := '';
BEGIN
    SQL_STR := 'AUDIT ' || P_AUDIT_OPTION || ' ON ' || P_OBJ_NAME || ' BY ACCESS ';
    IF (P_WHEN != 'ALL') THEN
        SQL_STR := SQL_STR || ' WHENEVER ' || P_WHEN;
    END IF;
    EXECUTE IMMEDIATE SQL_STR;
END;
/

CREATE OR REPLACE PROCEDURE USP_AUDIT_DELETE_OBJ(
    P_AUDIT_OPTION IN VARCHAR2,
    P_OBJ_NAME IN VARCHAR2
)
AS
    SQL_STR VARCHAR2(100) := '';
BEGIN
    SQL_STR := 'NOAUDIT ' || P_AUDIT_OPTION || ' ON ' || P_OBJ_NAME;
    EXECUTE IMMEDIATE SQL_STR;
END;
/

CREATE OR REPLACE PROCEDURE USP_AUDIT_GET_USER_AUDIT_TRAIL(
    P_RES OUT SYS_REFCURSOR,
    P_KEYWORD IN VARCHAR2
)
AS
BEGIN
    IF P_KEYWORD IS NULL THEN
        OPEN P_RES FOR
            SELECT USERNAME, EXTENDED_TIMESTAMP ,OBJ_NAME, ACTION_NAME,
                CASE RETURNCODE
                WHEN 0 THEN 'SUCCESSSFUL'
                WHEN 2004 THEN 'NOT SUCCESSFUL' END AS ACCESS_STATUS,
                SQL_TEXT
            FROM USER_AUDIT_TRAIL
            ORDER BY EXTENDED_TIMESTAMP DESC;
    ELSE
        OPEN P_RES FOR
            SELECT USERNAME, EXTENDED_TIMESTAMP ,OBJ_NAME, ACTION_NAME,
                CASE RETURNCODE
                WHEN 0 THEN 'SUCCESSSFUL'
                WHEN 2004 THEN 'NOT SUCCESSFUL' END AS ACCESS_STATUS,
                SQL_TEXT
            FROM USER_AUDIT_TRAIL
            WHERE USERNAME = P_KEYWORD OR OBJ_NAME = P_KEYWORD
            ORDER BY EXTENDED_TIMESTAMP DESC;
    END IF;
END;
/


CREATE OR REPLACE PROCEDURE USP_AUDIT_GET_DBA_FGA_AUDIT_TRAIL(
    P_RES OUT SYS_REFCURSOR,
    P_KEYWORD IN VARCHAR2
)
AS
BEGIN
    IF P_KEYWORD IS NULL THEN
        OPEN P_RES FOR
            SELECT DB_USER, EXTENDED_TIMESTAMP, OBJECT_NAME, STATEMENT_TYPE, SQL_TEXT
            FROM DBA_FGA_AUDIT_TRAIL 
            ORDER BY EXTENDED_TIMESTAMP DESC;
    ELSE
        OPEN P_RES FOR
            SELECT DB_USER, EXTENDED_TIMESTAMP, OBJECT_NAME, STATEMENT_TYPE, SQL_TEXT
            FROM DBA_FGA_AUDIT_TRAIL 
            WHERE DB_USER = P_KEYWORD OR OBJECT_NAME = P_KEYWORD
            ORDER BY EXTENDED_TIMESTAMP DESC;
    END IF;
END;
/
