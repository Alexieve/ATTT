using Oracle.ManagedDataAccess.Client;
using PH2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class GVU_PhanCongDAL
    {
        private DbConnection conn;

        public GVU_PhanCongDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getAll()
        {
            string ProcName = "USP_GVU_PHANCONG_GETALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
        }
        public DataTable search(string keyword)
        {
            string procName = "USP_GVU_PHANCONG_SEARCH";
            OracleParameter[] Parameters =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public int UpdatePhanCong(GVU_PhanCongDTO sinhVien, GVU_PhanCongDTO sinhVien2)
        {
            string ProcName = "USP_GVU_PHANCONG_UPDATE";
            OracleParameter[] Parameters =
            {
                    new OracleParameter("P_MAGV", OracleDbType.Varchar2, sinhVien.MAGV, ParameterDirection.Input ),
                    new OracleParameter("P_MAGV2", OracleDbType.Varchar2, sinhVien2.MAGV, ParameterDirection.Input ),
                    new OracleParameter("P_MAHP2", OracleDbType.Varchar2, sinhVien2.MAHP, ParameterDirection.Input ),
                    new OracleParameter("P_HK2", OracleDbType.Int32, sinhVien2.HK, ParameterDirection.Input ),
                    new OracleParameter("P_NAM2", OracleDbType.Int32, sinhVien2.NAM, ParameterDirection.Input),
                    new OracleParameter("P_MACT2", OracleDbType.Varchar2, sinhVien2.MACT, ParameterDirection.Input),
                    new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
            };
            conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
            object resValue = Parameters[Parameters.Length - 1].Value; // Lấy giá trị của tham số đầu ra P_RES
            if (resValue.ToString() == "1")
                return 0;
            return 1;
        }

        public DataTable getAllMAGV()
        {
            string procName = "USP_GVU_PHANCONG_GET_ALL_MAGV";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}