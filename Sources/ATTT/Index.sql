-- DANGKY
DROP INDEX IDX_DANGKY_MAHP;
DROP INDEX IDX_DANGKY_MASV;
DROP INDEX IDX_DANGKY_MAGV;



CREATE INDEX IDX_DANGKY_MAHP ON DANGKY(MAHP);
CREATE INDEX IDX_DANGKY_MASV ON DANGKY(MASV);
CREATE INDEX IDX_DANGKY_MAGV ON DANGKY(MAGV);



-- PHANCONG
DROP INDEX IDX_PHANCONG_MAHP;
DROP INDEX IDX_PHANCONG_MAGV;
DROP INDEX IDX_PHANCONG_MACT;



CREATE INDEX IDX_PHANCONG_MAHP ON PHANCONG(MAHP);
CREATE INDEX IDX_PHANCONG_MAGV ON PHANCONG(MAGV);
CREATE INDEX IDX_PHANCONG_MACT ON PHANCONG(MACT);



-- KHMO