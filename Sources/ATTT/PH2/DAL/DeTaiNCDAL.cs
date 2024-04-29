using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class DeTaiNCDAL
    {
        DbConnection conn;

        public DeTaiNCDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getAll()
        {
            string procName = "USP_DETAINC_GETALL";
            OracleParameter[] parameters =
            {
                new OracleParameter("P_RES", OracleDbType.RefCursor) { Direction = ParameterDirection.Output }
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
        }
    }
}
