using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class DangKyDAL
    {
        private DbConnection conn;
        public DangKyDAL()
        {
            conn = new DbConnection();
        }
        public DataTable GetDangKyGV()
        {
            string procName = "USP_GET_DANG_KY_GV";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public DataTable GetDangKyGVSearch(string MASV, string MAHP, string NAM, string HK, string MACT)
        {
            string procName = "USP_GET_DANG_KY_GV_SEARCH";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_MASV", OracleDbType.Varchar2, MASV, ParameterDirection.Input),
                new("P_MAHP", OracleDbType.Varchar2, MAHP, ParameterDirection.Input),
                new("P_NAM", OracleDbType.Varchar2, NAM, ParameterDirection.Input),
                new("P_HK", OracleDbType.Varchar2, HK, ParameterDirection.Input),
                new("P_MACT", OracleDbType.Varchar2, MACT, ParameterDirection.Input),
            };
             return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public int UpdateDiem(string MASV, string MAGV, string MAHP, int HK, int NAM, string MACT, float DIEMTH, float DIEMQT, float DIEMCK, float DIEMTK)
        {
            string procName = "USP_GV_UPDATE_DIEM";
            OracleParameter[] Parameters =
            {
                new("P_MASV", OracleDbType.Varchar2, MASV, ParameterDirection.Input),
                new("P_MAGV", OracleDbType.Varchar2, MAGV, ParameterDirection.Input),
                new("P_MAHP", OracleDbType.Varchar2, MAHP, ParameterDirection.Input),
                new("P_HK", OracleDbType.Int32, HK, ParameterDirection.Input),
                new("P_NAM", OracleDbType.Int32, NAM, ParameterDirection.Input),
                new("P_MACT", OracleDbType.Varchar2, MACT, ParameterDirection.Input),
                new("P_DIEMTH", OracleDbType.Single, DIEMTH, ParameterDirection.Input),
                new("P_DIEMQT", OracleDbType.Single, DIEMQT, ParameterDirection.Input),
                new("P_DIEMCK", OracleDbType.Single, DIEMCK, ParameterDirection.Input),
                new("P_DIEMTK", OracleDbType.Single, DIEMTK, ParameterDirection.Input),
                new ("P_CHECK", OracleDbType.Int32, ParameterDirection.Output)
            };
            conn.ExecuteNonQuery(procName, CommandType.StoredProcedure, Parameters);
            return int.Parse(Parameters[10].Value.ToString());
        }

        public DataTable getAll()
        {
            string ProcName = "USP_DANGKY_GET_ALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
        }
    }
}
