using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class DonViDAL
    {
        private DbConnection conn;

        public DonViDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getALL()
        {
            string ProcName = "USP_DONVI_GET_ALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
        }
    }
}
