using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PH2.DAL
{
    internal class ThongBaoDAL
    {
        DbConnection conn;

        public ThongBaoDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getAll()
        {
            string procName = "USP_THONGBAO_GETALL";
            OracleParameter[] parameters =
            {
                new OracleParameter("P_RES", OracleDbType.RefCursor) { Direction = ParameterDirection.Output }
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
        }
    }
}
