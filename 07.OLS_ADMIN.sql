ALTER SESSION SET CONTAINER=ATTT; 

-- XOÁ CHÍNH SÁCH OLS
EXECUTE SA_SYSDBA.DROP_POLICY(policy_name => 'BRANCH_POLICY');

-- TẠO CHÍNH SÁCH OLS 
EXECUTE SA_SYSDBA.CREATE_POLICY( policy_name => 'BRANCH_POLICY', column_name => 'BRANCH_LABEL'); 

--GRANT BRANCH_POLICY_DBA TO OLS_ADMIN;


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
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 110, short_name => 'VPK', long_name => 'Van phong khoa'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 120, short_name => 'HTTT', long_name => 'Bo mon HTTT');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 130, short_name => 'CNPM', long_name => 'Bo mon CNPM'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 140, short_name => 'KHMT', long_name => 'Bo mon KHMT'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 150, short_name => 'CNTT', long_name => 'Bo mon CNTT'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 160, short_name => 'TGMT', long_name => 'Bo mon TGMT'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT(policy_name => 'BRANCH_POLICY', comp_num => 170, short_name => 'MMT', long_name => 'Bo mon MMT va Vien thong'); 

--Tao Group
EXECUTE SA_COMPONENTS.CREATE_GROUP(policy_name => 'BRANCH_POLICY', group_num => 10, short_name => 'CS0', long_name => 'Tong co so', parent_name => NULL); 
EXECUTE SA_COMPONENTS.CREATE_GROUP(policy_name => 'BRANCH_POLICY', group_num => 20, short_name => 'CS1', long_name => 'Co so 1', parent_name => 'CS0'); 
EXECUTE SA_COMPONENTS.CREATE_GROUP(policy_name => 'BRANCH_POLICY', group_num => 30, short_name => 'CS2', long_name => 'Co so 2', parent_name => 'CS0'); 

--Tao Label
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '110', label_value => 'TRUONGKHOA:VPK,HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS0'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '120', label_value => 'TRUONGKHOA:VPK,HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '130', label_value => 'TRUONGKHOA:VPK,HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS2'); 



EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '210', label_value => 'TRUONGDV:VPK:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '220', label_value => 'TRUONGDV:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '230', label_value => 'TRUONGDV:CNPM:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '240', label_value => 'TRUONGDV:KHMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '250', label_value => 'TRUONGDV:CNTT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '260', label_value => 'TRUONGDV:TGMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '270', label_value => 'TRUONGDV:MMT:CS1'); 

EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '211', label_value => 'TRUONGDV:VPK:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '221', label_value => 'TRUONGDV:HTTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '231', label_value => 'TRUONGDV:CNPM:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '241', label_value => 'TRUONGDV:KHMT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '251', label_value => 'TRUONGDV:CNTT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '261', label_value => 'TRUONGDV:TGMT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '271', label_value => 'TRUONGDV:MMT:CS2'); 



EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '310', label_value => 'GIANGVIEN:VPK:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '320', label_value => 'GIANGVIEN:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '330', label_value => 'GIANGVIEN:CNPM:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '340', label_value => 'GIANGVIEN:KHMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '350', label_value => 'GIANGVIEN:CNTT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '360', label_value => 'GIANGVIEN:TGMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '370', label_value => 'GIANGVIEN:MMT:CS1'); 

EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '311', label_value => 'GIANGVIEN:VPK:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '321', label_value => 'GIANGVIEN:HTTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '331', label_value => 'GIANGVIEN:CNPM:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '341', label_value => 'GIANGVIEN:KHMT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '351', label_value => 'GIANGVIEN:CNTT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '361', label_value => 'GIANGVIEN:TGMT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '371', label_value => 'GIANGVIEN:MMT:CS2'); 



EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '410', label_value => 'GIAOVU:VPK:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '420', label_value => 'GIAOVU:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '430', label_value => 'GIAOVU:CNPM:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '440', label_value => 'GIAOVU:KHMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '450', label_value => 'GIAOVU:CNTT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '460', label_value => 'GIAOVU:TGMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '470', label_value => 'GIAOVU:MMT:CS1'); 

EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '411', label_value => 'GIAOVU:VPK:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '421', label_value => 'GIAOVU:HTTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '431', label_value => 'GIAOVU:CNPM:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '441', label_value => 'GIAOVU:KHMT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '451', label_value => 'GIAOVU:CNTT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '461', label_value => 'GIAOVU:TGMT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '471', label_value => 'GIAOVU:MMT:CS2'); 



EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '510', label_value => 'NVCOBAN:VPK:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '520', label_value => 'NVCOBAN:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '530', label_value => 'NVCOBAN:CNPM:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '540', label_value => 'NVCOBAN:KHMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '550', label_value => 'NVCOBAN:CNTT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '560', label_value => 'NVCOBAN:TGMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '570', label_value => 'NVCOBAN:MMT:CS1'); 

EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '511', label_value => 'NVCOBAN:VPK:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '521', label_value => 'NVCOBAN:HTTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '531', label_value => 'NVCOBAN:CNPM:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '541', label_value => 'NVCOBAN:KHMT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '551', label_value => 'NVCOBAN:CNTT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '561', label_value => 'NVCOBAN:TGMT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '571', label_value => 'NVCOBAN:MMT:CS2'); 



EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '610', label_value => 'SINHVIEN:VPK:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '620', label_value => 'SINHVIEN:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '630', label_value => 'SINHVIEN:CNPM:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '640', label_value => 'SINHVIEN:KHMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '650', label_value => 'SINHVIEN:CNTT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '660', label_value => 'SINHVIEN:TGMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '670', label_value => 'SINHVIEN:MMT:CS1'); 

EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '611', label_value => 'SINHVIEN:VPK:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '621', label_value => 'SINHVIEN:HTTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '631', label_value => 'SINHVIEN:CNPM:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '641', label_value => 'SINHVIEN:KHMT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '651', label_value => 'SINHVIEN:CNTT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '661', label_value => 'SINHVIEN:TGMT:CS2'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'BRANCH_POLICY', label_tag => '671', label_value => 'SINHVIEN:MMT:CS2'); 
 

--
EXECUTE SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('BRANCH_POLICY','C##ADMIN','THONGBAO');
EXECUTE SA_POLICY_ADMIN.APPLY_TABLE_POLICY (policy_name => 'BRANCH_POLICY', schema_name => 'C##ADMIN', table_name => 'THONGBAO', table_options => 'LABEL_DEFAULT, READ_CONTROL'); 


--B16:CẤP QUYỀN CHO ADMIN TRÊN OLS POLICY 
EXECUTE SA_USER_ADMIN.SET_USER_PRIVS('BRANCH_POLICY','OLS_ADMIN','FULL,PROFILE_ACCESS');