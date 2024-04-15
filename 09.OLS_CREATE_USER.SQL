-- RUN WITH OLS_ADMIN
GRANT SELECT ON C##ADMIN.THONGBAO TO RL_TRUONGKHOA, RL_TRUONGDV, RL_GIANGVIEN, RL_GIAOVU, RL_NVCOBAN, RL_SINHVIEN;

BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'BRANCH_POLICY', 
        user_name => 'NV00000001', 
        max_read_label => 'TRUONGKHOA:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2' 
    );
END;
/
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'BRANCH_POLICY', 
        user_name => 'NV00000002', 
        max_read_label => 'TRUONGDV:HTTT:CS2'
    );
END;
/
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'BRANCH_POLICY', 
        user_name => 'NV00000004', 
        max_read_label => 'TRUONGDV:KHMT:CS1'
    );
END;
/
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'BRANCH_POLICY', 
        user_name => 'NV00000008', 
        max_read_label => 'GIAOVU::CS1,CS2'
    );
END;
/
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'BRANCH_POLICY', 
        user_name => 'SV00000018', 
        max_read_label => 'SINHVIEN:HTTT:CS1'
    );
END;
/
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'BRANCH_POLICY', 
        user_name => 'SV00000102', 
        max_read_label => 'SINHVIEN:CNTT:CS1'
    );
END;
/

-- TEST
SELECT * FROM ALL_SA_LABELS;
--SELECT BRANCH_LABEL, label_to_char (BRANCH_LABEL) AS label,  NGAY, NOIDUNG FROM C##ADMIN.THONGBAO;
--EXECUTE sa_session.set_access_profile ('BRANCH_POLICY', 'NV00000001')
SELECT * FROM C##ADMIN.THONGBAO;
SELECT sa_session.read_label('BRANCH_POLICY') "Read Label" From DUAL;

