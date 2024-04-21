using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PH2.DAL
{
    internal class KHMODAL
    {
        private DbConnection conn;
        public KHMODAL()
        {
            conn = new DbConnection();
        }

        public DataTable getAll()
        {
            string procName = "USP_KHMO_GETALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable getByNamHK(int Nam, int Hk)
        {
            string procName = "USP_KHMO_GET_BY_NAM_HK";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_NAM", OracleDbType.Int32, ParameterDirection.Input) {Value = Nam},
                new("P_HK", OracleDbType.Int32, ParameterDirection.Input) {Value = Hk}
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable getAllNamHK()
        {
            string procName = "USP_KHMO_GET_ALL_NAM_HK";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable getAll_TRUONGKHOA()
        {
            string procName = "USP_KHMO_GETALL_TRUONGKHOA";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
