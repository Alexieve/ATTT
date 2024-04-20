using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class GVU_DANGKYDAL
    {
        private DbConnection conn;

        public GVU_DANGKYDAL()
        {
            conn = new DbConnection();
        }
        public DataTable getAll()
        {
            string procName = "USP_GVU_DANGKY_GETALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public DataTable search(string keyword)
        {
            string procName = "USP_GVU_DANGKY_SEARCH";
            OracleParameter[] Parameters =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        //public DataTable getChuaDK()
        //{
        //    string procName = "USP_DANGKYHP_GET_CHUADK";
        //    OracleParameter[] Parameters =
        //    {
        //        new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
        //    };
        //    return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        //}

        //public DataTable getDaDK()
        //{
        //    string procName = "USP_DANGKYHP_GET_DADK";
        //    OracleParameter[] Parameters =
        //    {
        //        new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
        //    };
        //    return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        //}

        //public void HuyHP(string MAGV, string MAHP)
        //{
        //    string procName = "USP_DANGKYHP_HUY_SV";
        //    OracleParameter[] Parameters =
        //    {
        //        new("P_MAGV", OracleDbType.Varchar2, MAGV, ParameterDirection.Input),
        //        new("P_MAHP", OracleDbType.Varchar2, MAHP, ParameterDirection.Input)
        //    };
        //    conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        //}
        //public void DangKyHP(string MAGV, string MAHP)
        //{
        //    string procName = "USP_DANGKYHP_DANGKY_SV";
        //    OracleParameter[] Parameters =
        //    {
        //        new("P_MAGV", OracleDbType.Varchar2, MAGV, ParameterDirection.Input),
        //        new("P_MAHP", OracleDbType.Varchar2, MAHP, ParameterDirection.Input)
        //    };
        //    conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        //}
    }
}
