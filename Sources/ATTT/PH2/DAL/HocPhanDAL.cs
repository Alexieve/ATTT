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
    internal class HocPhanDAL
    {
        private DbConnection conn;
        public HocPhanDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getAll()
        {
            string procName = "USP_HOCPHAN_GETALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable search(string keyword)
        {
            string procName = "USP_HOCPHAN_SEARCH";
            OracleParameter[] Parameters =
            {
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
               
        public int AddHocPhan(HocPhanDTO hocPhan)
       {
           string ProcName = "USP_HOCPHAN_ADD";
           OracleParameter[] Parameters =
           {
                   new OracleParameter("P_MAHP", OracleDbType.Varchar2, hocPhan.MAHP, ParameterDirection.Input ),
                   new OracleParameter("P_TENHP", OracleDbType.Varchar2, hocPhan.TENHP, ParameterDirection.Input ),
                   new OracleParameter("P_SOTC", OracleDbType.Int32, hocPhan.SOTC, ParameterDirection.Input ),
                   new OracleParameter("P_STLT", OracleDbType.Int32, hocPhan.STLT, ParameterDirection.Input ),
                   new OracleParameter("P_STTH", OracleDbType.Int32, hocPhan.STTH, ParameterDirection.Input ),
                   new OracleParameter("P_SOSVTD", OracleDbType.Int32, hocPhan.SOSVTD, ParameterDirection.Input ),
                   new OracleParameter("P_MADV", OracleDbType.Varchar2, hocPhan.MADV, ParameterDirection.Input ),
                   new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
           };
           conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
           object resValue = Parameters[Parameters.Length - 1].Value; // Lấy giá trị của tham số đầu ra P_RES
           if (resValue.ToString() == "1")
               return 0;
           return 1;
       }
       public DataTable getProfile2(string masv)
       {
           string ProcName = "USP_HOCPHAN_GET_PROFILE_MAHP";
           OracleParameter[] Parameters =
           {
               new OracleParameter("P_MAHP", OracleDbType.Varchar2, masv, ParameterDirection.Input ),
               new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
           };
           return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
       }
       public int UpdateHocPhan(HocPhanDTO hocPhan)
       {
           string ProcName = "USP_HOCPHAN_UPDATE";
           OracleParameter[] Parameters =
           {
                   new OracleParameter("P_MAHP", OracleDbType.Varchar2, hocPhan.MAHP, ParameterDirection.Input ),
                   new OracleParameter("P_TENHP", OracleDbType.Varchar2, hocPhan.TENHP, ParameterDirection.Input ),
                   new OracleParameter("P_SOTC", OracleDbType.Int32, hocPhan.SOTC, ParameterDirection.Input ),
                   new OracleParameter("P_STLT", OracleDbType.Int32, hocPhan.STLT, ParameterDirection.Input ),
                   new OracleParameter("P_STTH", OracleDbType.Int32, hocPhan.STTH, ParameterDirection.Input ),
                   new OracleParameter("P_SOSVTD", OracleDbType.Int32, hocPhan.SOSVTD, ParameterDirection.Input ),
                   new OracleParameter("P_MADV", OracleDbType.Varchar2, hocPhan.MADV, ParameterDirection.Input ),
                   new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
           };
           conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
           object resValue = Parameters[Parameters.Length - 1].Value; // Lấy giá trị của tham số đầu ra P_RES
           if (resValue.ToString() == "1")
               return 0;
           return 1;
       }
        public DataTable getAllMaNganh()
        {
            string procName = "USP_GVU_SINHVIEN_GET_ALL_MANGANH";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
    }
}
