using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class GiangVienDAL
    {
        private DbConnection conn;

        public GiangVienDAL()
        {
            conn = new DbConnection();
        }
        public DataTable getAll()
        {
            string procName = "USP_NHANSU_GET_GIANGVIEN";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
