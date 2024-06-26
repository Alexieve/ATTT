CREATE OR REPLACE PROCEDURE USP_DONVI_SEARCH(P_KEYWORD IN VARCHAR2, P_RES OUT SYS_REFCURSOR)
AS
    V_KEYWORD VARCHAR2(100);
BEGIN
    V_KEYWORD := P_KEYWORD || '%';
    OPEN P_RES FOR
        SELECT *
        FROM DONVI
        WHERE MADV LIKE V_KEYWORD;
END;
/
GRANT EXECUTE ON USP_DONVI_SEARCH TO PUBLIC;
/
CREATE OR REPLACE PROCEDURE USP_DONVI_ADD (
  P_MADV IN VARCHAR2,
  P_TENDV IN VARCHAR2,
  P_TRUONGDV IN VARCHAR2,
  P_ErrCode OUT NUMBER
)
AS
BEGIN
  -- Insert with error handling
  INSERT INTO DONVI
  VALUES (P_MADV, P_TENDV, P_TRUONGDV);
  
  -- Handle potential errors during insert
   P_ErrCode := 0;
  EXCEPTION
    WHEN OTHERS THEN
      P_ErrCode := 1; -- Set error code to 1
      RETURN; -- Terminate procedure
END;
/
GRANT EXECUTE ON USP_DONVI_ADD TO RL_GIAOVU;
/
CREATE OR REPLACE PROCEDURE USP_DONVI_GET_PROFILE_MADV (P_MADV IN VARCHAR2,P_RES OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN P_RES FOR
        SELECT *
        FROM DONVI
        WHERE MADV = P_MADV;
END;
/
GRANT EXECUTE ON USP_DONVI_GET_PROFILE_MADV TO RL_GIAOVU;
/
CREATE OR REPLACE PROCEDURE USP_DONVI_UPDATE (
  P_MADV IN VARCHAR2,
  P_TENDV IN VARCHAR2,
  P_TRUONGDV IN VARCHAR2,
  P_ErrCode OUT NUMBER
)
AS
BEGIN
  -- Insert with error handling
UPDATE DONVI
SET 
    TENDV = P_TENDV,
    TRUONGDV = P_TRUONGDV
WHERE
    MADV = P_MADV;
  
  -- Handle potential errors during insert
   P_ErrCode := 0;
  EXCEPTION
    WHEN OTHERS THEN
      P_ErrCode := 1; -- Set error code to 1
      RETURN; -- Terminate procedure
END;
/
GRANT EXECUTE ON USP_DONVI_UPDATE TO RL_GIAOVU;