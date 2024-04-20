using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PH2.DTO;
namespace PH2.DAL
{
    internal class DangKyHPDAL
    {
        private DbConnection conn;

        public DangKyHPDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getChuaDK()
        {
            string procName = "USP_DANGKYHP_GET_CHUADK";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable getDaDK()
        {
            string procName = "USP_DANGKYHP_GET_DADK";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public void HuyHP(string MAGV, string MAHP)
        {
            string procName = "USP_DANGKYHP_HUY_SV";
            OracleParameter[] Parameters =
            {
                new("P_MAGV", OracleDbType.Varchar2, MAGV, ParameterDirection.Input),
                new("P_MAHP", OracleDbType.Varchar2, MAHP, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public void DangKyHP(string MAGV, string MAHP)
        {
            string procName = "USP_DANGKYHP_DANGKY_SV";
            OracleParameter[] Parameters =
            {
                new("P_MAGV", OracleDbType.Varchar2, MAGV, ParameterDirection.Input),
                new("P_MAHP", OracleDbType.Varchar2, MAHP, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }
                
        public DataTable getChuaDK(string a)
        {
            string procName = "USP_DANGKYHP_GET_CHUADK_GVU";
            OracleParameter[] Parameters =
            {
                new OracleParameter("P_MASV", OracleDbType.Varchar2, a, ParameterDirection.Input ),
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
                
        public DataTable getDaDK2(string a)
        {
            string procName = "USP_DANGKYHP_GET_DADK_GVU";
            //string tmp = "SV00000102";
            OracleParameter[] Parameters =
            {
                new("P_MASV", OracleDbType.Varchar2, a, ParameterDirection.Input ),
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
                
        public void HuyHP(string MAGV, string MAHP, string a)
        {
            string procName = "USP_DANGKYHP_HUY_SV_GVU";
            OracleParameter[] Parameters =
            {
                new OracleParameter("P_MASV", OracleDbType.Varchar2, a, ParameterDirection.Input ),
                new("P_MAGV", OracleDbType.Varchar2, MAGV, ParameterDirection.Input),
                new("P_MAHP", OracleDbType.Varchar2, MAHP, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }
                
        public void DangKyHP(string MAGV, string MAHP, string a)
        {
            string procName = "USP_DANGKYHP_DANGKY_SV_GVU";
            OracleParameter[] Parameters =
            {
                new OracleParameter("P_MASV", OracleDbType.Varchar2, a, ParameterDirection.Input ),
                new("P_MAGV", OracleDbType.Varchar2, MAGV, ParameterDirection.Input),
                new("P_MAHP", OracleDbType.Varchar2, MAHP, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
