ALTER SESSION SET CONTAINER=ATTT; 

-- XOÁ CHÍNH SÁCH OLS
EXECUTE SA_SYSDBA.DROP_POLICY(policy_name => 'BRANCH_POLICY');

-- TẠO CHÍNH SÁCH OLS 
EXECUTE SA_SYSDBA.CREATE_POLICY('BRANCH_POLICY', 'BRANCH_LABEL', 'NO_CONTROL'); 

GRANT BRANCH_POLICY_DBA TO OLS_ADMIN;


--B13: ENABLE POLICY VỪA TẠO 
EXEC SA_SYSDBA.ENABLE_POLICY ('BRANCH_POLICY');

--B14: KHỞI ĐỘNG LẠI MÁY TÍNH 
--B15: TẠO COMPONENT CỦA LABEL
--Tao Level
EXECUTE SA_COMPONENTS.CREATE_LEVEL(policy_name => 'BRANCH_POLICY', level_num => 100, short_name => 'SINHVIEN', long_name => 'Sinh vien'); 
EXECUTE SA_COMPONENTS.CREATE_LEVEL(policy_name => 'BRANCH_POLICY', level_num => 200, short_name => 'NVCOBAN', long_name => 'Nhan vien co ban'); 
EXECUTE SA_COMPONENTS.CREATE_LEVEL(policy_name => 'BRANCH_POLICY', level_num => 300, short_name => 'GIAOVU', long_name => 'Giao vu');
EXECUTE SA_COMPONENTS.CREATE_LEVEL(policy_name => 'BRANCH_POLICY', level_num => 400, short_name => 'GIANGVIEN', long_name => 'Giang vien'); 
EXECUTE SA_COMPONENTS.CREATE_LEVEL(policy_name => 'BRANCH_POLICY', level_num => 500, short_name => 'TRUONGDV', long_name => 'Truong don vi'); 
EXECUTE SA_COMPONENTS.CREATE_LEVEL(policy_name => 'BRANCH_POLICY', level_num => 600, short_name => 'TRUONGKHOA', long_name => 'Truong khoa'); 

--Tao Compartment 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 110, short_name => 'HTTT', long_name => 'Bo mon HTTT');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 120, short_name => 'CNPM', long_name => 'Bo mon CNPM'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 130, short_name => 'KHMT', long_name => 'Bo mon KHMT'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 140, short_name => 'CNTT', long_name => 'Bo mon CNTT'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 150, short_name => 'TGMT', long_name => 'Bo mon TGMT'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 160, short_name => 'MMT', long_name => 'Bo mon MMT va Vien thong'); 

--Tao Group
EXECUTE SA_COMPONENTS.CREATE_GROUP(policy_name => 'BRANCH_POLICY', group_num => 20, short_name => 'CS1', long_name => 'Co so 1', parent_name => NULL); 
EXECUTE SA_COMPONENTS.CREATE_GROUP(policy_name => 'BRANCH_POLICY', group_num => 30, short_name => 'CS2', long_name => 'Co so 2', parent_name => NULL); 

--Tao Label cho Data
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => 100, label_value => 'TRUONGKHOA'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => 102, label_value => 'TRUONGDV::CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => 400, label_value => 'GIAOVU');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => 200, label_value => 'TRUONGDV'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => 611, label_value => 'SINHVIEN:HTTT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => 231, label_value => 'TRUONGDV:KHMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => 230, label_value => 'TRUONGDV:KHMT');




--B16:CẤP QUYỀN CHO ADMIN TRÊN OLS POLICY 
EXECUTE SA_USER_ADMIN.SET_USER_PRIVS('BRANCH_POLICY','OLS_ADMIN','FULL,PROFILE_ACCESS');