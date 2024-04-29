using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using PH2.DTO;
namespace PH2.DAL
{
    internal class TaiLieuDAL
    {
        private DbConnection conn;
        public TaiLieuDAL()
        {
            conn = new DbConnection();
        }
        public DataTable getAll()
        {
            string procName = "USP_TAILIEU_GETALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

    }
}
