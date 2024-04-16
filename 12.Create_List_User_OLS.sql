CREATE OR REPLACE FUNCTION USP_GET_USER_LABEL(
    P_ROLE IN VARCHAR2,
    P_MADV IN VARCHAR2,
    P_COSO IN VARCHAR2
)
RETURN VARCHAR2
AS
    V_LABEL VARCHAR2(80) := '';
BEGIN
    IF P_ROLE = 'RL_SINHVIEN' THEN
        V_LABEL := 'SINHVIEN:';
    ELSIF P_ROLE = 'RL_NVCOBAN' THEN
        V_LABEL := 'NVCOBAN:';
    ELSIF P_ROLE = 'RL_GIAOVU' THEN
        V_LABEL := 'GIAOVU:';
    ELSIF P_ROLE = 'RL_GIANGVIEN' THEN
        V_LABEL := 'GIANGVIEN:';
    ELSIF P_ROLE = 'RL_TRUONGDV' THEN
        V_LABEL := 'TRUONGDV:';
    ELSIF P_ROLE = 'RL_TRUONGKHOA' THEN
        V_LABEL := 'TRUONGKHOA:';
    END IF;
    
    V_LABEL := V_LABEL || P_MADV || ':' || P_COSO;
    V_LABEL := REPLACE(V_LABEL, ' ', '');
    V_LABEL := REPLACE(V_LABEL, 'VPK', '');
    
    RETURN V_LABEL;
END;
/




CREATE OR REPLACE PROCEDURE USP_CREATE_LABEL_FOR_LIST_USER
AS
    CURSOR CUR1 IS (
        SELECT SV.MASV, SV.MANGANH, SV.COSO
        FROM C##ADMIN.SINHVIEN SV
    );
    CURSOR CUR2 IS (
        SELECT NV.MANV, RL.GRANTED_ROLE, NV.MADV, NV.COSO
        FROM C##ADMIN.NHANSU NV
        JOIN SYS.DBA_ROLE_PRIVS RL ON NV.MANV = RL.GRANTEE
    );
    V_ID CHAR(10);
    V_RL VARCHAR2(20);
    V_MADV VARCHAR2(10);
    V_COSO CHAR(3);
    V_LABEL VARCHAR2(80);
BEGIN
    OPEN CUR1;
    LOOP
        FETCH CUR1 INTO V_ID, V_MADV, V_COSO;
        EXIT WHEN CUR1%NOTFOUND;

        V_LABEL := USP_GET_USER_LABEL('RL_SINHVIEN', V_MADV, V_COSO);
        
        BEGIN
            SA_USER_ADMIN.SET_USER_LABELS(
                policy_name => 'BRANCH_POLICY', 
                user_name => V_ID, 
                max_read_label => V_LABEL
            );
        END;
    END LOOP;
    CLOSE CUR1;
    
    
    OPEN CUR2;
    LOOP
        FETCH CUR2 INTO V_ID, V_RL, V_MADV, V_COSO;
        EXIT WHEN CUR2%NOTFOUND;

        V_LABEL := USP_GET_USER_LABEL(V_RL, V_MADV, V_COSO);
        
        BEGIN
            SA_USER_ADMIN.SET_USER_LABELS(
                policy_name => 'BRANCH_POLICY', 
                user_name => V_ID, 
                max_read_label => V_LABEL
            );
        END;
    END LOOP;
    CLOSE CUR2;
END;
/

EXEC USP_CREATE_LABEL_FOR_LIST_USER;
