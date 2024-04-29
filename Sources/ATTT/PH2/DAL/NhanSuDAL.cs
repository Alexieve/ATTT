using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class NhanSuDAL
    {
        private DbConnection conn;

        public NhanSuDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getProfile()
        {
            string ProcName = "USP_NHANSU_GET_PROFILE";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
        }

        public bool updateSDTProfile(string SDT)
        {
            try
            {
                string ProcName = "USP_NHANSU_UPDATE_SDT_PROFILE";
                OracleParameter[] Parameters =
                {
                    new("P_SDT", OracleDbType.Varchar2, SDT, ParameterDirection.Input)
                };
                conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public DataTable getAll()
        {
            string ProcName = "USP_NHANSU_GET_ALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
        }

        public string insert(string MANV, string HOTEN, string PHAI, DateTime NGSINH, float PHUCAP, string SDT, string VAITRO, string MADV, string COSO)
        {
            try
            {
                string ProcName = "USP_NHANSU_INSERT";
                OracleParameter[] Parameters =
                {
                    new("vMANV", OracleDbType.Char, MANV, ParameterDirection.Input),
                    new("vHOTEN", OracleDbType.NVarchar2, HOTEN, ParameterDirection.Input),
                    new("vPHAI", OracleDbType.NVarchar2, PHAI, ParameterDirection.Input),
                    new("vNGSINH", OracleDbType.Date, NGSINH, ParameterDirection.Input),
                    new("vPHUCAP", OracleDbType.BinaryFloat, PHUCAP, ParameterDirection.Input),
                    new("vSDT", OracleDbType.Char, SDT, ParameterDirection.Input),
                    new("vVAITRO", OracleDbType.Varchar2, VAITRO, ParameterDirection.Input),
                    new("vMADV", OracleDbType.Char, MADV, ParameterDirection.Input),
                    new("vCOSO", OracleDbType.Char, COSO, ParameterDirection.Input),
                };
                conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string update(string MANV, string HOTEN, string PHAI, DateTime NGSINH, float PHUCAP, string SDT, string VAITRO, string MADV, string COSO)
        {
            try
            {
                string ProcName = "USP_NHANSU_UPDATE";
                OracleParameter[] Parameters =
                {
                    new("vMANV", OracleDbType.Char, MANV, ParameterDirection.Input),
                    new("vHOTEN", OracleDbType.NVarchar2, HOTEN, ParameterDirection.Input),
                    new("vPHAI", OracleDbType.NVarchar2, PHAI, ParameterDirection.Input),
                    new("vNGSINH", OracleDbType.Date, NGSINH, ParameterDirection.Input),
                    new("vPHUCAP", OracleDbType.BinaryFloat, PHUCAP, ParameterDirection.Input),
                    new("vSDT", OracleDbType.Char, SDT, ParameterDirection.Input),
                    new("vVAITRO", OracleDbType.Varchar2, VAITRO, ParameterDirection.Input),
                    new("vMADV", OracleDbType.Char, MADV, ParameterDirection.Input),
                    new("vCOSO", OracleDbType.Char, COSO, ParameterDirection.Input),
                };
                conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public bool delete(string MANV)
        {
            try
            {
                string ProcName = "USP_NHANSU_DELETE";
                OracleParameter[] Parameters =
                {
                    new("P_SDT", OracleDbType.Char, MANV, ParameterDirection.Input)
                };
                conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public DataTable getNhanSuOLS()
        {
            string ProcName = "USP_OLS_QUANLY";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
        }
    }
}
