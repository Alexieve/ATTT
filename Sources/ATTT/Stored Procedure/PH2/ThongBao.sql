CREATE OR REPLACE PROCEDURE USP_THONGBAO_GETALL(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT NGAY, NOIDUNG
        FROM THONGBAO;
END;
/
GRANT EXECUTE ON USP_THONGBAO_GETALL TO PUBLIC;