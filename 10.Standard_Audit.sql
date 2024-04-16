-- Chạy với SYS
-- Bật audit_trail
ALTER SYSTEM SET AUDIT_TRAIL = DB, EXTENDED SCOPE = SPFILE;

-- Cho phép audit user sys
ALTER SYSTEM SET AUDIT_SYS_OPERATIONS = TRUE SCOPE = SPFILE;

-- Khởi động lại Instance
SHUTDOWN IMMEDIATE;
STARTUP;


-- Chạy với C##ADMIN

-- Tắt Standard Audit
NOAUDIT ALL ON C##ADMIN.DANGKY;
NOAUDIT ALL ON C##ADMIN.PHANCONG;
NOAUDIT ALL ON C##ADMIN.KHMO;
NOAUDIT ALL ON C##ADMIN.HOCPHAN;
NOAUDIT ALL ON C##ADMIN.DONVI;
NOAUDIT ALL ON C##ADMIN.NHANSU;
NOAUDIT ALL ON C##ADMIN.SINHVIEN;
NOAUDIT ALL ON USP_GET_USER;
NOAUDIT ALL ON USP_GET_USER_MAIN_ROLE;
NOAUDIT ALL BY NV00000001;




-- Bật Standard Audit
AUDIT ALL ON C##ADMIN.DANGKY BY ACCESS WHENEVER SUCCESSFUL;
AUDIT ALL ON C##ADMIN.PHANCONG BY ACCESS;
AUDIT ALL ON C##ADMIN.KHMO BY ACCESS;
AUDIT ALL ON C##ADMIN.HOCPHAN BY ACCESS;
AUDIT ALL ON C##ADMIN.DONVI BY ACCESS;
AUDIT ALL ON C##ADMIN.NHANSU BY ACCESS;
AUDIT ALL ON C##ADMIN.SINHVIEN BY ACCESS;
AUDIT ALL ON USP_GET_USER;
AUDIT ALL BY NV00000001 BY ACCESS WHENEVER SUCCESSFUL;
AUDIT ALL BY NV00000001 BY ACCESS WHENEVER NOT SUCCESSFUL;
AUDIT ALL ON V_TMP;
AUDIT ALL ON USP_GET_USER_MAIN_ROLE;









-- Thực hiện câu lệnh để kiểm tra
SELECT * FROM C##ADMIN.NHANSU;
DECLARE
    TEMP SYS_REFCURSOR;

BEGIN
    USP_GET_USER(TEMP);
END;
/
DROP VIEW V_TMP;
CREATE VIEW V_TMP AS
    SELECT *
    FROM DANGKY;


-- Kiểm tra nhật ký
SELECT USERNAME, EXTENDED_TIMESTAMP ,OBJ_NAME, ACTION_NAME,
    CASE RETURNCODE
    WHEN 0 THEN 'SUCCESSSFUL'
    WHEN 2004 THEN 'NOT SUCCESSFUL' END AS ACCESS_STATUS,
    SQL_TEXT
FROM USER_AUDIT_TRAIL
--WHERE OBJ_NAME = 'NHANSU'
ORDER BY EXTENDED_TIMESTAMP DESC;

