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
               
        public DataTable getProfile2(string masv)
       {
           string ProcName = "USP_SINHVIEN_GET_PROFILE_MASV";
           string tmp2 = "SV00001074";
           OracleParameter[] Parameters =
           {
               new OracleParameter("P_MaSV", OracleDbType.Varchar2, masv, ParameterDirection.Input ),
               new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
           };
           return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
       }
       public int AddSinhVien(SinhVienDTO sinhVien)
       {
               string ProcName = "USP_SINHVIEN_ADD";
               OracleParameter[] Parameters =
               {
                   new OracleParameter("P_MaSinhVien", OracleDbType.Varchar2, sinhVien.MASV, ParameterDirection.Input ),
                   new OracleParameter("P_HoTen", OracleDbType.Varchar2, sinhVien.HOTEN, ParameterDirection.Input ),
                   new OracleParameter("P_Phai", OracleDbType.Varchar2, sinhVien.PHAI, ParameterDirection.Input ),
                   new OracleParameter("P_NgaySinh", OracleDbType.Varchar2, sinhVien.NGSINH, ParameterDirection.Input ),
                   new OracleParameter("P_DiaChi", OracleDbType.Varchar2, sinhVien.DCHI, ParameterDirection.Input ),
                   new OracleParameter("P_SDT", OracleDbType.Varchar2, sinhVien.SDT, ParameterDirection.Input ),
                   new OracleParameter("P_MaChuongTrinh", OracleDbType.Varchar2, sinhVien.MACT, ParameterDirection.Input ),
                   new OracleParameter("P_MaNganh", OracleDbType.Varchar2, sinhVien.MANGANH, ParameterDirection.Input ),
                   new OracleParameter("P_TCTichLuy", OracleDbType.Int32, sinhVien.SOTCTL, ParameterDirection.Input ),
                   new OracleParameter("P_DiemTB", OracleDbType.Decimal, sinhVien.DTBTL, ParameterDirection.Input),
                   new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
           };
               conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
                object resValue = Parameters[Parameters.Length - 1].Value; // Lấy giá trị của tham số đầu ra P_RES
           if (resValue.ToString() == "1")
               return 0;
           return 1;
       }
       public int UpdateSinhVien(SinhVienDTO sinhVien)
       {
           string ProcName = "USP_SINHVIEN_UPDATE";
           OracleParameter[] Parameters =
           {
                   new OracleParameter("P_MaSinhVien", OracleDbType.Varchar2, sinhVien.MASV, ParameterDirection.Input ),
                   new OracleParameter("P_HoTen", OracleDbType.Varchar2, sinhVien.HOTEN, ParameterDirection.Input ),
                   new OracleParameter("P_Phai", OracleDbType.Varchar2, sinhVien.PHAI, ParameterDirection.Input ),
                   new OracleParameter("P_NgaySinh", OracleDbType.Varchar2, sinhVien.NGSINH, ParameterDirection.Input ),
                   new OracleParameter("P_DiaChi", OracleDbType.Varchar2, sinhVien.DCHI, ParameterDirection.Input ),
                   new OracleParameter("P_SDT", OracleDbType.Varchar2, sinhVien.SDT, ParameterDirection.Input ),
                   new OracleParameter("P_MaChuongTrinh", OracleDbType.Varchar2, sinhVien.MACT, ParameterDirection.Input ),
                   new OracleParameter("P_MaNganh", OracleDbType.Varchar2, sinhVien.MANGANH, ParameterDirection.Input ),
                   new OracleParameter("P_TCTichLuy", OracleDbType.Int32, sinhVien.SOTCTL, ParameterDirection.Input ),
                   new OracleParameter("P_DiemTB", OracleDbType.Decimal, sinhVien.DTBTL, ParameterDirection.Input),
                   new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
           };
           conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
           object resValue = Parameters[Parameters.Length - 1].Value; // Lấy giá trị của tham số đầu ra P_RES
           if (resValue.ToString() == "1")
               return 0;
           return 1;
       }
       
       public DataTable search(string keyword)
       {
           string procName = "USP_SINHVIEN_SEARCH";
           OracleParameter[] Parameters =
           {
               new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) {Value = keyword},
               new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
           };
           return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
       }
    }
}
