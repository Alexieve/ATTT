using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class XemPhanCongDAL
    {
        private DbConnection conn;
        public XemPhanCongDAL()
        {
            conn = new DbConnection();
        }
        public DataTable GetPhanCong()
        {
            string procName = "USP_GET_PHAN_CONG";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
