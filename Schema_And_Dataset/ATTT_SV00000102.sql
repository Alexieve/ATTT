-- 6.1
SELECT * FROM C##ADMIN.SINHVIEN;

-- 6.2
SELECT * FROM C##ADMIN.HOCPHAN;
SELECT * FROM C##ADMIN.KHMO;


-- 6.5
SELECT * FROM C##ADMIN.DANGKY;
UPDATE C##ADMIN.DANGKY
SET
    DIEMTH = 6.75,
    DIEMQT = 5.25,
    DIEMCK = 6.25,
    DIEMTK = 6.1
WHERE MAGV = 'NV00000060' AND MAHP = 'CSC13008';