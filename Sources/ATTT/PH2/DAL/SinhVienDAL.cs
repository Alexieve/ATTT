using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PH2.DAL
{
    internal class SinhVienDAL
    {
        private DbConnection conn;
        public SinhVienDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getProfile()
        {
            string ProcName = "USP_SINHVIEN_GET_PROFILE";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
        }

        public bool updateSDTProfile(string SDT)
        {
            string ProcName = "USP_SINHVIEN_UPDATE_SDT_PROFILE";
            OracleParameter[] Parameters =
            {
                new("P_SDT", OracleDbType.Varchar2, SDT, ParameterDirection.Input)
            };
            conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
            return true;
        }

        public DataTable getAll()
        {
            string ProcName = "USP_SINHVIEN_GET_ALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
        }
    }
}
