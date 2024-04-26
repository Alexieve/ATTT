CREATE OR REPLACE PROCEDURE USP_DELETE_PHAN_CONG_TRUONGDV(P_MAGV IN VARCHAR2, P_MAHP IN VARCHAR2, P_HK IN INT, P_NAM IN INT, P_MACT IN VARCHAR2)
AS
BEGIN
    DELETE FROM PHANCONG
    WHERE MAGV = P_MAGV
    AND MAHP = CAST(P_MAHP as CHAR(10))
    AND HK = P_HK
    AND NAM = P_NAM
    AND MACT = CAST(P_MACT as CHAR(5));
    COMMIT;
END;
/
GRANT EXECUTE ON USP_DELETE_PHAN_CONG_TRUONGDV TO RL_TRUONGDV;


CREATE OR REPLACE PROCEDURE USP_GET_MAGV_TRUONGDV(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
     OPEN P_RES FOR
        SELECT MANV FROM NHANSU;
END;
/
GRANT EXECUTE ON USP_GET_MAGV_TRUONGDV TO RL_TRUONGDV;


CREATE OR REPLACE PROCEDURE USP_GET_MAHP_TRUONGDV(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
     OPEN P_RES FOR
        SELECT MAHP FROM HOCPHAN;
END;
/
GRANT EXECUTE ON USP_GET_MAHP_TRUONGDV TO RL_TRUONGDV;


CREATE OR REPLACE PROCEDURE USP_INSERT_PHAN_CONG_TRUONGDV(P_MAGV IN VARCHAR2, P_MAHP IN VARCHAR2, P_HK IN INT, P_NAM IN INT, P_MACT IN VARCHAR2)
AS
BEGIN
    INSERT INTO PHANCONG VALUES(P_MAGV, P_MAHP, P_HK, P_NAM, P_MACT);
    COMMIT;
END;
/
GRANT EXECUTE ON USP_INSERT_PHAN_CONG_TRUONGDV TO RL_TRUONGDV;

CREATE OR REPLACE PROCEDURE USP_UPDATE_PHAN_CONG_TRUONGDV(
    P_MAGV IN VARCHAR2,
    P_MAHP IN VARCHAR2,
    P_HK IN INT,
    P_NAM IN INT,
    P_MACT IN VARCHAR2,
    Old_MAGV_Value IN VARCHAR2
)
AUTHID DEFINER
AS
    Check_Record NUMBER := 0;

BEGIN
    SELECT COUNT(*)
    INTO Check_Record
    FROM PHANCONG
    WHERE MAGV = P_MAGV
    AND MAHP = CAST(P_MAHP as CHAR(10))
    AND HK = P_HK
    AND NAM = P_NAM
    AND MACT = CAST(P_MACT as CHAR(5));

    IF Check_Record > 0 THEN
        RAISE_APPLICATION_ERROR(-20001, 'Tr�ng kh�a ch�nh');
    END IF;

    UPDATE PHANCONG
    SET MAGV = P_MAGV
    WHERE MAGV = Old_MAGV_Value
    AND MAHP = CAST(P_MAHP as CHAR(10))
    AND HK = P_HK
    AND NAM = P_NAM
    AND MACT = CAST(P_MACT as CHAR(5));    

    IF SQL%FOUND THEN
        COMMIT;
    END IF;
    
EXCEPTION
    WHEN OTHERS THEN
        BEGIN
            DELETE FROM PHANCONG
            WHERE MAGV = Old_MAGV_Value
            AND MAHP = CAST(P_MAHP as CHAR(10))
            AND HK = P_HK
            AND NAM = P_NAM
            AND MACT = CAST(P_MACT as CHAR(5)); 
        
            INSERT INTO PHANCONG VALUES(P_MAGV, P_MAHP, P_HK, P_NAM, P_MACT);
            COMMIT;
        END;
END;
/
GRANT EXECUTE ON USP_UPDATE_PHAN_CONG_TRUONGDV TO RL_TRUONGDV;