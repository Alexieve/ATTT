-- Change Date format
ALTER SESSION SET nls_date_format='dd-mm-yyyy';

/*
    DROP TABLE
*/
DROP TABLE THONGBAO CASCADE CONSTRAINTS;

/*
    CREATE TABLE
*/
CREATE TABLE THONGBAO
(
    NGAY DATE NOT NULL,
    NOIDUNG NVARCHAR2(2000) NOT NULL
);

/*
    INSERT DATASET
*/
--INSERT INTO THONGBAO VALUES ('01-01-2024',  N'Thông báo dành cho Trưởng khoa');
--INSERT INTO THONGBAO VALUES ('02-01-2024',  N'Thông báo cho tất cả các Trưởng đơn vị của CS2');
--INSERT INTO THONGBAO VALUES ('03-01-2024',  N'Thông báo cho Giáo vụ tổng');
INSERT INTO THONGBAO VALUES ('04-01-2024',  N'Thông báo cho tất cả các Trưởng đơn vị');
INSERT INTO THONGBAO VALUES ('05-01-2024',  N'Thông báo cho tất cả SINHVIEN thuộc ngành HTTT của CS1');
INSERT INTO THONGBAO VALUES ('06-01-2024',  N'Thông báo cho tất cả Trưởng bộ môn KHMT của CS1');
INSERT INTO THONGBAO VALUES ('07-01-2024',  N'Thông báo cho tất cả Trưởng bộ môn KHMT của CS1 và CS2');

-- Run with C##ADMIN --
GRANT CREATE SESSION TO OLS_ADMIN;
GRANT SELECT, UPDATE, INSERT, DELETE ON THONGBAO TO OLS_ADMIN WITH GRANT OPTION;