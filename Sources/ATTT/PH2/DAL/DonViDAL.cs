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
                
        public DataTable search(string keyword)
        {
            string procName = "USP_DONVI_SEARCH";
            OracleParameter[] Parameters =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public int AddDonVi(DonViDTO DV)
        {
            string ProcName = "USP_DONVI_ADD";
            OracleParameter[] Parameters =
            {
                    new OracleParameter("P_MADV", OracleDbType.Varchar2, DV.MADV, ParameterDirection.Input ),
                    new OracleParameter("P_TENDV", OracleDbType.Varchar2, DV.TENDV, ParameterDirection.Input ),
                    new OracleParameter("P_TRUONGDV", OracleDbType.Varchar2, DV.TRUONGDV, ParameterDirection.Input ),
                    new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
            };
            conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
            object resValue = Parameters[Parameters.Length - 1].Value; // Lấy giá trị của tham số đầu ra P_RES
            if (resValue.ToString() == "1")
                return 0;
            return 1;
        }
        public DataTable getProfile2(string madv)
        {
            string ProcName = "USP_DONVI_GET_PROFILE_MADV";
            
            OracleParameter[] Parameters =
            {
                new OracleParameter("P_MADV", OracleDbType.Varchar2, madv, ParameterDirection.Input ),
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
        }
        public int UpdateDonVi(DonViDTO dv)
        {
            string ProcName = "USP_DONVI_UPDATE";
            OracleParameter[] Parameters =
            {
                    new OracleParameter("P_MADV", OracleDbType.Varchar2, dv.MADV, ParameterDirection.Input ),
                    new OracleParameter("P_TENDV", OracleDbType.Varchar2, dv.TENDV, ParameterDirection.Input ),
                    new OracleParameter("P_TRUONGDV", OracleDbType.Varchar2, dv.TRUONGDV, ParameterDirection.Input ),
                    new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
            };
            conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
            object resValue = Parameters[Parameters.Length - 1].Value; // Lấy giá trị của tham số đầu ra P_RES
            if (resValue.ToString() == "1")
                return 0;
            return 1;
        }
    }
}
