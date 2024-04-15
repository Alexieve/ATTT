CREATE OR REPLACE FUNCTION USP_COUNT_SINHVIEN_IN_HOCPHAN(
	P_MAGV IN VARCHAR2,
	P_HK IN NUMBER,
	P_NAM IN NUMBER,
    P_MACT IN VARCHAR2,
    P_MAHP IN VARCHAR2
)
RETURN NUMBER
AUTHID DEFINER
AS
    P_COUNT NUMBER := 0;
BEGIN
    SELECT COUNT(*) INTO P_COUNT
	FROM DANGKY
	WHERE MAGV = P_MAGV
	AND HK = P_HK
	AND NAM = P_NAM
    AND MACT = P_MACT
    AND MAHP = P_MAHP;
		
	RETURN P_COUNT;
END;
/



CREATE OR REPLACE PROCEDURE USP_DANGKYHP_GET_DADK(P_RES OUT SYS_REFCURSOR)
AS
    P_DAY NUMBER := EXTRACT(DAY FROM SYSDATE);
    P_MONTH NUMBER := EXTRACT(MONTH FROM SYSDATE);
    P_NAM NUMBER := EXTRACT(YEAR FROM SYSDATE);
    P_HK NUMBER := 0;
BEGIN
    IF P_DAY > 15 THEN
        OPEN P_RES FOR SELECT * FROM DUAL WHERE 1 = 0;
    ELSE
        IF P_MONTH = 1 THEN
            P_HK := 1;
        ELSIF P_MONTH = 4 THEN
            P_HK := 2;
        ELSIF P_MONTH = 9 THEN
            P_HK := 3;
        END IF;
    
        IF P_HK = 0 THEN
            OPEN P_RES FOR SELECT * FROM DUAL WHERE 1 = 0;
        ELSE
            OPEN P_RES FOR
            WITH DANGKY_FILTERED AS (
                SELECT MAHP, MAGV, HK, NAM, MACT
                FROM DANGKY
                WHERE NAM = P_NAM
                AND HK = P_HK
            ),
            HOCPHAN_INFO AS (
                SELECT HP.MAHP, HP.TENHP, HP.SOTC, HP.SOSVTD
                FROM HOCPHAN HP
                JOIN DANGKY_FILTERED DK ON HP.MAHP = DK.MAHP
            ),
            NHANSU_INFO AS (
                SELECT NS.MANV, NS.HOTEN
                FROM NHANSU NS
                JOIN DANGKY_FILTERED DK ON NS.MANV = DK.MAGV
            )
            SELECT HP.MAHP, HP.TENHP, DK.MAGV, NS.HOTEN AS TENGV, 
                   HP.SOTC, HP.SOSVTD,
                   USP_COUNT_SINHVIEN_IN_HOCPHAN(DK.MAGV, DK.HK, DK.NAM, DK.MACT, DK.MAHP) AS SOSVDK
            FROM DANGKY_FILTERED DK 
            JOIN HOCPHAN_INFO HP ON DK.MAHP = HP.MAHP
            JOIN NHANSU_INFO NS ON DK.MAGV = NS.MANV;
            
        END IF;
    END IF;
END;
/
GRANT EXECUTE ON USP_DANGKYHP_GET_DADK TO RL_SINHVIEN;



CREATE OR REPLACE PROCEDURE USP_DANGKYHP_GET_CHUADK(P_RES OUT SYS_REFCURSOR)
AUTHID DEFINER
AS
    P_MASV VARCHAR2(20) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    P_MACT VARCHAR2(20);
    P_DAY NUMBER := EXTRACT(DAY FROM SYSDATE);
    P_MONTH NUMBER := EXTRACT(MONTH FROM SYSDATE);
    P_NAM NUMBER := EXTRACT(YEAR FROM SYSDATE);
    P_HK NUMBER := 0;
BEGIN
    IF P_DAY > 15 THEN
        OPEN P_RES FOR SELECT * FROM DUAL WHERE 1 = 0;
    ELSE
        IF P_MONTH = 1 THEN
            P_HK := 1;
        ELSIF P_MONTH = 4 THEN
            P_HK := 2;
        ELSIF P_MONTH = 9 THEN
            P_HK := 3;
        END IF;
        
        IF P_HK = 0 THEN
            OPEN P_RES FOR SELECT * FROM DUAL WHERE 1 = 0;
        ELSE
            -- Lấy MACT của Sinh viên
            SELECT MACT INTO P_MACT
            FROM SINHVIEN
            WHERE MASV = P_MASV;
        
            OPEN P_RES FOR
                WITH PHANCONG_FILTERED AS (
                    SELECT MAHP, MAGV, HK, NAM, MACT
                    FROM PHANCONG
                    WHERE MACT = P_MACT
                    AND HK = P_HK
                    AND NAM = P_NAM
                    EXCEPT 
                    SELECT MAHP, MAGV, HK, NAM, MACT
                    FROM DANGKY
                    WHERE MASV = P_MASV
                    AND HK = P_HK
                    AND NAM = P_NAM
                ),
                HOCPHAN_INFO AS (
                    SELECT HP.MAHP, HP.TENHP, HP.SOTC, HP.SOSVTD
                    FROM HOCPHAN HP
                    JOIN PHANCONG_FILTERED PC ON HP.MAHP = PC.MAHP
                ),
                NHANSU_INFO AS (
                    SELECT NS.MANV, NS.HOTEN
                    FROM NHANSU NS
                    JOIN PHANCONG_FILTERED PC ON NS.MANV = PC.MAGV
                )
                SELECT HP.MAHP, HP.TENHP, PC.MAGV, NS.HOTEN AS TENGV, 
                       HP.SOTC, HP.SOSVTD,
                       USP_COUNT_SINHVIEN_IN_HOCPHAN(PC.MAGV, PC.HK, PC.NAM, PC.MACT, PC.MAHP) AS SOSVDK
                FROM PHANCONG_FILTERED PC 
                JOIN HOCPHAN_INFO HP ON PC.MAHP = HP.MAHP
                JOIN NHANSU_INFO NS ON PC.MAGV = NS.MANV;
        END IF;
    END IF;
END;
/
GRANT EXECUTE ON USP_DANGKYHP_GET_CHUADK TO RL_SINHVIEN;




CREATE OR REPLACE PROCEDURE USP_DANGKYHP_HUY_SV (P_MAGV IN VARCHAR2, P_MAHP IN VARCHAR2)
AS
    P_MASV VARCHAR2(20) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    P_MACT VARCHAR2(20);
    P_MONTH NUMBER := EXTRACT(MONTH FROM SYSDATE);
    P_NAM NUMBER := EXTRACT(YEAR FROM SYSDATE);
    P_HK NUMBER := 0;
BEGIN
    SELECT MACT INTO P_MACT
    FROM SINHVIEN;
    
    IF P_MONTH = 1 THEN
        P_HK := 1;
    ELSIF P_MONTH = 4 THEN
        P_HK := 2;
    ELSIF P_MONTH = 9 THEN
        P_HK := 3;
    END IF;
    
    DELETE FROM DANGKY
    WHERE MAGV = P_MAGV
    AND HK = P_HK
    AND NAM = P_NAM
    AND MACT = P_MACT
    AND MAHP = P_MAHP;
    
END;
/
GRANT EXECUTE ON USP_DANGKYHP_HUY_SV TO RL_SINHVIEN;



CREATE OR REPLACE PROCEDURE USP_DANGKYHP_DANGKY_SV (P_MAGV IN VARCHAR2, P_MAHP IN VARCHAR2)
AS
    P_MASV VARCHAR2(20) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    P_MACT VARCHAR2(20);
    P_MONTH NUMBER := EXTRACT(MONTH FROM SYSDATE);
    P_NAM NUMBER := EXTRACT(YEAR FROM SYSDATE);
    P_HK NUMBER := 0;
BEGIN
    SELECT MACT INTO P_MACT
    FROM SINHVIEN;
    
    IF P_MONTH = 1 THEN
        P_HK := 1;
    ELSIF P_MONTH = 4 THEN
        P_HK := 2;
    ELSIF P_MONTH = 9 THEN
        P_HK := 3;
    END IF;
    
    INSERT INTO DANGKY(MASV, MAGV, HK, NAM, MACT, MAHP) VALUES
    (SYS_CONTEXT('USERENV', 'SESSION_USER'), P_MAGV, P_HK, P_NAM, P_MACT, P_MAHP);
END;
/
GRANT EXECUTE ON USP_DANGKYHP_DANGKY_SV TO RL_SINHVIEN;