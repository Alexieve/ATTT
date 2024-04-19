CREATE OR REPLACE PROCEDURE USP_NHANSU_GET_PROFILE (P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT *
        FROM NHANSU
        WHERE MANV = SYS_CONTEXT ('USERENV', 'SESSION_USER');
END;
/
GRANT EXECUTE ON USP_NHANSU_GET_PROFILE TO RL_NVCOBAN;

CREATE OR REPLACE PROCEDURE USP_NHANSU_UPDATE_SDT_PROFILE (P_SDT IN CHAR)
AS
BEGIN
    UPDATE NHANSU
    SET SDT = P_SDT
    WHERE MANV = SYS_CONTEXT ('USERENV', 'SESSION_USER');
END;
/
GRANT EXECUTE ON USP_NHANSU_UPDATE_SDT_PROFILE TO RL_NVCOBAN;

CREATE OR REPLACE PROCEDURE USP_NHANSU_GET_GIANGVIEN (P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT MANV as MAGV, HOTEN, SDT, MADV, COSO
        FROM NHANSU
        WHERE VAITRO = 'Giảng viên';
END;
/
GRANT EXECUTE ON USP_NHANSU_GET_GIANGVIEN TO RL_TRUONGKHOA;

CREATE OR REPLACE PROCEDURE USP_NHANSU_GET_ALL (P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT *
        FROM NHANSU;
END;
/
GRANT EXECUTE ON USP_NHANSU_GET_ALL TO RL_TRUONGKHOA;

CREATE OR REPLACE PROCEDURE USP_NHANSU_INSERT 
(
    vMANV IN CHAR, vHOTEN IN NVARCHAR2, 
    vPHAI IN NVARCHAR2, vNGSINH IN DATE, 
    vPHUCAP IN FLOAT, vSDT IN CHAR, 
    vVAITRO IN NVARCHAR2, vMADV IN CHAR, vCOSO IN CHAR
)
AS
BEGIN
    INSERT INTO NHANSU
    VALUES (vMANV, vHOTEN, vPHAI, vNGSINH, vPHUCAP, vSDT, vVAITRO, vMADV, vCOSO);
END;
/
GRANT EXECUTE ON USP_NHANSU_INSERT TO RL_TRUONGKHOA;

CREATE OR REPLACE PROCEDURE USP_NHANSU_UPDATE
(
    vMANV IN CHAR, vHOTEN IN NVARCHAR2, 
    vPHAI IN NVARCHAR2, vNGSINH IN DATE, 
    vPHUCAP IN FLOAT, vSDT IN CHAR, 
    vVAITRO IN NVARCHAR2, vMADV IN CHAR, vCOSO IN CHAR
)
AS
BEGIN
    UPDATE NHANSU
    SET HOTEN = vHOTEN, PHAI = vPHAI, NGSINH = vNGSINH, 
    PHUCAP = vPHUCAP, SDT = vSDT, VAITRO = vVAITRO, MADV = vMADV, COSO = vCOSO
    WHERE MANV = vMANV;
END;
/
GRANT EXECUTE ON USP_NHANSU_UPDATE TO RL_TRUONGKHOA;


CREATE OR REPLACE PROCEDURE USP_NHANSU_DELETE (vMANV IN CHAR)
AS
BEGIN
    DELETE FROM NHANSU
    WHERE MANV = vMANV;
END;
/
GRANT EXECUTE ON USP_NHANSU_DELETE TO RL_TRUONGKHOA;