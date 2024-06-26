-- Hành vi Cập nhật quan hệ ĐANGKY tại các trường liên quan đến điểm số 
-- nhưng người đó không thuộc vai trò Giảng viên

-- Drop policy
BEGIN
    DBMS_FGA.DROP_POLICY(
      object_schema      => 'C##ADMIN',
      object_name        => 'DANGKY',
      policy_name        => 'FGA_CHECK_UPDATE_DIEM_DANGKY_GIANGVIEN');
END;
/
-- Add policy
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'C##ADMIN',
   object_name        => 'DANGKY',
   policy_name        => 'FGA_CHECK_UPDATE_DIEM_DANGKY_GIANGVIEN',
   enable             =>  TRUE,
   statement_types    => 'UPDATE',
   audit_column       => 'DIEMTH, DIEMQT, DIEMCK, DIEMTK',
   audit_condition    => 'SYS_CONTEXT(''SYS_SESSION_ROLES'', ''RL_GIANGVIEN'') = ''FALSE''',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/


-- Hành vi của người dùng này có thể đọc trên trường PHUCAP của người khác 
-- ở quan hệ NHANSU.
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'C##ADMIN',
  object_name        => 'NHANSU',
  policy_name        => 'FGA_CHECK_SELECT_PHUCAP_USER');
END;
/
-- Add policy
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'C##ADMIN',
   object_name        => 'NHANSU',
   policy_name        => 'FGA_CHECK_SELECT_PHUCAP_USER',
   enable             =>  TRUE,
   statement_types    => 'SELECT',
   audit_column       => 'PHUCAP',
   audit_condition    => 'SYS_CONTEXT(''USERENV'', ''SESSION_USER'') != MANV',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/

--TESTING

-- Tạo user test
--REVOKE SELECT ON NHANSU FROM FGA_TEST;
--REVOKE CREATE SESSION FROM FGA_TEST;
--DROP USER FGA_TEST;
--
--CREATE USER FGA_TEST IDENTIFIED BY 123;
--GRANT CREATE SESSION TO FGA_TEST;
--GRANT SELECT ON NHANSU TO FGA_TEST;


SELECT * FROM C##ADMIN.NHANSU;
SELECT DB_USER, EXTENDED_TIMESTAMP, OBJECT_NAME, STATEMENT_TYPE, SQL_TEXT
FROM DBA_FGA_AUDIT_TRAIL 
ORDER BY EXTENDED_TIMESTAMP;