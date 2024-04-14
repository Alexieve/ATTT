using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PH2.DAL
{
    internal class KetQuaHPDAL
    {
        private DbConnection conn;

        public KetQuaHPDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getAllNamHK()
        {
            string procName = "USP_KETQUAHP_GET_ALL_NAM_HK";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable getAll()
        {
            string procName = "USP_KETQUAHP_GET_ALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable getByNamHK(int nam, int hk)
        {
            string procName = "USP_KETQUAHP_GET_BY_NAM_HK";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_NAM", OracleDbType.Int32, nam, ParameterDirection.Input),
                new("P_HK", OracleDbType.Int32, hk, ParameterDirection.Input)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
