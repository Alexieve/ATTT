--B1. KIỂM OLS ĐÃ ĐƯỢC BẬT CHƯA 
SELECT VALUE FROM v$option WHERE parameter = 'Oracle Label Security'; 
SELECT status FROM dba_ols_status WHERE name = 'OLS_CONFIGURE_STATUS'; 

--B2: BẬT OLS NẾU CHƯA BẬT 
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS; 
EXEC LBACSYS.CONFIGURE_OLS; 

--B3: KHỞI ĐỘNG LẠI 
shutdown IMMEDIATE; 
startup; 

--B7: CHUYỂN QUA PDB 
alter session set container=ATTT; 
SHOW CON_NAME; 


--B8: UNLOCK LBACSYS 
ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;
ALTER USER "LBACSYS" DEFAULT TABLESPACE "SYSTEM" TEMPORARY TABLESPACE "TEMP" ACCOUNT UNLOCK;
ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE;

--B9: TẠO ADMIN OLS 
CREATE USER OLS_ADMIN IDENTIFIED BY "123" CONTAINER = CURRENT; 
GRANT CONNECT,RESOURCE TO OLS_ADMIN; 
GRANT UNLIMITED TABLESPACE TO OLS_ADMIN; 
GRANT SELECT ANY DICTIONARY TO OLS_ADMIN; 

--B10: CẤP QUYỀN CHO ADMIN OLS 
GRANT EXECUTE ON sa_components TO OLS_ADMIN WITH GRANT OPTION; 
GRANT EXECUTE ON sa_user_admin TO OLS_ADMIN WITH GRANT OPTION; 
GRANT EXECUTE ON sa_label_admin TO OLS_ADMIN WITH GRANT OPTION; 
GRANT EXECUTE ON sa_policy_admin TO OLS_ADMIN WITH GRANT OPTION; 
GRANT EXECUTE ON char_to_label TO OLS_ADMIN WITH GRANT OPTION; 

-- ADD ADMIN_OLS VÀO LBAC_DBA 
--GRANT EXECUTE ON sa_audit_admin TO OLS_ADMIN W ITH GRANT OPTION; 
--GRANT EXECUTE ON SA_SESSION TO OLS_ADMIN WITH GRANT OPTION; 
GRANT LBAC_DBA TO OLS_ADMIN; 
GRANT EXECUTE ON sa_sysdba TO OLS_ADMIN; 
GRANT EXECUTE ON to_lbac_data_label TO OLS_ADMIN; 

--CONNECT VÀO SYS XEM CÁC COMPONENT ĐÃ TẠO ĐÚNG CHƯA 
SELECT * FROM dba_sa_levels; 
SELECT * FROM DBA_SA_COMPARTMENTS; 
SELECT * FROM DBA_SA_GROUPS; 
SELECT * FROM DBA_SA_GROUP_HIERARCHY