using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class PhanCongDAL
    {
        private DbConnection conn;

        public PhanCongDAL()
        {
            conn = new DbConnection();
        }

        public DataTable getAll()
        {
            string ProcName = "USP_PHANCONG_TRUONGKHOA_GET_ALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(ProcName, CommandType.StoredProcedure, Parameters);
        }

        public int delete(string MAGV, string MAHP, int HK, int NAM, string MACT)
        {
            try
            {
                string ProcName = "USP_PHANCONG_DELETE";
                OracleParameter[] Parameters =
                {
                    new("vMAGV", OracleDbType.Char, MAGV, ParameterDirection.Input),
                    new("vMAHP", OracleDbType.Char, MAHP, ParameterDirection.Input),
                    new("vHK", OracleDbType.Int32, HK, ParameterDirection.Input),
                    new("vNAM", OracleDbType.Int32, NAM, ParameterDirection.Input),
                    new("vMACT", OracleDbType.Char, MACT, ParameterDirection.Input),
                    new ("vDeleteCount", OracleDbType.Int32, ParameterDirection.Output)
                };
                conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
                return int.Parse(Parameters[5].Value.ToString());

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public string them(string MAGV, string MAHP, int HK, int NAM, string MACT)
        {
            try
            {
                string ProcName = "USP_PHANCONG_THEM";
                OracleParameter[] Parameters =
                {
                    new("vMAGV", OracleDbType.Char, MAGV, ParameterDirection.Input),
                    new("vMAHP", OracleDbType.Char, MAHP, ParameterDirection.Input),
                    new("vHK", OracleDbType.Int32, HK, ParameterDirection.Input),
                    new("vNAM", OracleDbType.Int32, NAM, ParameterDirection.Input),
                    new("vMACT", OracleDbType.Char, MACT, ParameterDirection.Input),
                };
                conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string doiMAGV(string MAGV, string MAHP, int HK, int NAM, string MACT, string MAGVNEW)
        {
            try
            {
                string ProcName = "USP_PHANCONG_CHANGE_MAGV";
                OracleParameter[] Parameters =
                {
                    new("vMAGV", OracleDbType.Char, MAGV, ParameterDirection.Input),
                    new("vMAHP", OracleDbType.Char, MAHP, ParameterDirection.Input),
                    new("vHK", OracleDbType.Int32, HK, ParameterDirection.Input),
                    new("vNAM", OracleDbType.Int32, NAM, ParameterDirection.Input),
                    new("vMACT", OracleDbType.Char, MACT, ParameterDirection.Input),
                    new("vMACTNEW", OracleDbType.Char, MAGVNEW, ParameterDirection.Input),
                };
                conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
                return "";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool checkDK(string cMAGV, string cMAHP, int cHK, int cNAM, string cMACT)
        {
            try
            {
                string ProcName = "USP_PHANCONG_CHECK_DANGKY";
                OracleParameter[] Parameters =
                {
                    new("vMAGV", OracleDbType.Char, cMAGV, ParameterDirection.Input),
                    new("vMAHP", OracleDbType.Char, cMAHP, ParameterDirection.Input),
                    new("vHK", OracleDbType.Int32, cHK, ParameterDirection.Input),
                    new("vNAM", OracleDbType.Int32, cNAM, ParameterDirection.Input),
                    new("vMACT", OracleDbType.Char, cMACT, ParameterDirection.Input),
                };
                conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}