using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class TruongDV_XemPCDAL
    {
        private DbConnection conn;
        public TruongDV_XemPCDAL()
        {
            conn = new DbConnection();
        }
        public DataTable GetPC()
        {
            string procName = "USP_GET_PHAN_CONG_TRUONGDV";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public DataTable GetMAGV()
        {
            string procName = "USP_GET_MAGV_TRUONGDV";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public DataTable GetMAHP()
        {
            string procName = "USP_GET_MAHP_TRUONGDV";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public void DeleteRow(string MAGV, string MAHP, int HK, int NAM, string MACT)
        {
            string procName = "USP_DELETE_PHAN_CONG_TRUONGDV";
            OracleParameter[] Parameters =
            {
                new("P_MAGV", OracleDbType.Varchar2, MAGV, ParameterDirection.Input),
                new("P_MAHP", OracleDbType.Varchar2, MAHP, ParameterDirection.Input),
                new("P_HK", OracleDbType.Int32, HK, ParameterDirection.Input),
                new("P_NAM", OracleDbType.Int32, NAM, ParameterDirection.Input),
                new("P_MACT", OracleDbType.Varchar2, MACT, ParameterDirection.Input),
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public void AddRow(string MAGV, string MAHP, int HK, int NAM, string MACT)
        {
            string procName = "USP_INSERT_PHAN_CONG_TRUONGDV";
            OracleParameter[] Parameters =
            {
                new("P_MAGV", OracleDbType.Varchar2, MAGV, ParameterDirection.Input),
                new("P_MAHP", OracleDbType.Varchar2, MAHP, ParameterDirection.Input),
                new("P_HK", OracleDbType.Int32, HK, ParameterDirection.Input),
                new("P_NAM", OracleDbType.Int32, NAM, ParameterDirection.Input),
                new("P_MACT", OracleDbType.Varchar2, MACT, ParameterDirection.Input),
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
