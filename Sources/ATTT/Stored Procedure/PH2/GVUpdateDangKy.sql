CREATE OR REPLACE PROCEDURE USP_GET_DANG_KY_GV(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT DK.MASV, DK.MAGV, SV.HOTEN, DK.MAHP, HP.TENHP, DK.HK, DK.NAM, DK.MACT, DK.DIEMTH, DK.DIEMQT, DK.DIEMCK, DK.DIEMTK
        FROM DANGKY DK
        JOIN SINHVIEN SV ON DK.MASV = SV.MASV
        JOIN HOCPHAN HP ON DK.MAHP = HP.MAHP;
END;
/


CREATE OR REPLACE PROCEDURE USP_GV_UPDATE_DIEM(P_MASV IN VARCHAR2, P_MAGV IN VARCHAR2, P_MAHP IN VARCHAR2, P_HK IN INT, P_NAM IN INT, P_MACT IN VARCHAR2, P_DIEMTH IN FLOAT, P_DIEMQT IN FLOAT, P_DIEMCK IN FLOAT, P_DIEMTK IN FLOAT)
AS

BEGIN
    UPDATE DANGKY
    SET DIEMTH = P_DIEMTH,
        DIEMQT = P_DIEMQT,
        DIEMCK = P_DIEMCK,
        DIEMTK = P_DIEMTK
    WHERE MASV = P_MASV AND MAGV = P_MAGV  AND HK = P_HK AND NAM = P_NAM AND MACT = CAST(P_MACT as CHAR(5)) AND MAHP = CAST(P_MAHP as CHAR(10));
END;
/

GRANT EXECUTE ON USP_GV_UPDATE_DIEM TO RL_GIANGVIEN;
GRANT EXECUTE ON USP_GET_DANG_KY_GV TO RL_GIANGVIEN;
GRANT EXECUTE ON USP_GV_UPDATE_DIEM TO RL_TRUONGDV;
GRANT EXECUTE ON USP_GET_DANG_KY_GV TO RL_TRUONGDV;
