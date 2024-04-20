CREATE OR REPLACE PROCEDURE USP_GVU_KHMO_GETALL(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT *
        FROM KHMO 
        ORDER BY NAM DESC, HK DESC;
END;
/
GRANT EXECUTE ON USP_GVU_KHMO_GETALL TO PUBLIC;




CREATE OR REPLACE PROCEDURE USP_GVU_KHMO_GET_BY_NAM_HK(
    P_RES OUT SYS_REFCURSOR,
    P_NAM IN NUMBER,
    P_HK IN NUMBER
)
AS
BEGIN
    OPEN P_RES FOR
        SELECT *
        FROM KHMO
        WHERE KHMO.NAM = P_NAM AND KHMO.HK = P_HK
        ORDER BY NAM DESC, HK DESC;
END;
/
GRANT EXECUTE ON USP_GVU_KHMO_GET_BY_NAM_HK TO PUBLIC;
/




CREATE OR REPLACE PROCEDURE USP_GVU_KHMO_GET_ALL_NAM_HK(P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT DISTINCT NAM, HK
        FROM KHMO
        ORDER BY NAM DESC, HK DESC;
END;
/
GRANT EXECUTE ON USP_GVU_KHMO_GET_ALL_NAM_HK TO PUBLIC;
/
CREATE OR REPLACE PROCEDURE USP_GVU_KHMO_ADD (
  P_MAHP IN VARCHAR2,
  P_HK IN INT,
  P_NAM IN INT,
  P_MACT IN VARCHAR2,
  P_ErrCode OUT NUMBER
)
AS
BEGIN
  -- Insert with error handling
  INSERT INTO KHMO
  VALUES (P_MAHP, P_HK,  P_NAM, P_MACT);
  
  -- Handle potential errors during insert
   P_ErrCode := 0;
  EXCEPTION
    WHEN OTHERS THEN
      P_ErrCode := 1; -- Set error code to 1
      RETURN; -- Terminate procedure
END;
/
GRANT EXECUTE ON USP_GVU_KHMO_ADD TO RL_GIAOVU;
/
CREATE OR REPLACE PROCEDURE USP_GVU_KHMO_UPDATE (
  P_MAHP IN VARCHAR2,
  P_HK IN INT,
  P_NAM IN INT,
  P_MACT IN VARCHAR2,
    P_MAHP2 IN VARCHAR2,
  P_HK2 IN INT,
  P_NAM2 IN INT,
  P_MACT2 IN VARCHAR2,
  P_ErrCode OUT NUMBER
)
AS
BEGIN
  -- Insert with error handling
UPDATE KHMO
SET 
    MAHP = P_MAHP,
    HK = P_HK,
    NAM = P_NAM,
    MACT = P_MACT
WHERE
     MAHP = P_MAHP2 AND
    HK = P_HK2 AND
    NAM = P_NAM2 AND
    MACT = P_MACT2;
  
  -- Handle potential errors during insert
   P_ErrCode := 0;
  EXCEPTION
    WHEN OTHERS THEN
      P_ErrCode := 1; -- Set error code to 1
      RETURN; -- Terminate procedure
END;
/
GRANT EXECUTE ON USP_GVU_KHMO_UPDATE TO RL_GIAOVU;