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
    internal class GVU_KHMODAL
    {
        private DbConnection conn;
        public GVU_KHMODAL()
        {
            conn = new DbConnection();
        }

        public DataTable getAll()
        {
            string procName = "USP_GVU_KHMO_GETALL";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable getByNamHK(int Nam, int Hk)
        {
            string procName = "USP_GVU_KHMO_GET_BY_NAM_HK";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_NAM", OracleDbType.Int32, ParameterDirection.Input) {Value = Nam},
                new("P_HK", OracleDbType.Int32, ParameterDirection.Input) {Value = Hk}
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }

        public DataTable getAllNamHK()
        {
            string procName = "USP_GVU_KHMO_GET_ALL_NAM_HK";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public DataTable getAllHP()
        {
            string procName = "USP_GVU_KHMO_GET_ALL_HP";
            OracleParameter[] Parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            return conn.ExecuteQuery(procName, CommandType.StoredProcedure, Parameters);
        }
        public int AddKHMO(GVU_KHMODTO sinhVien)
        {
            string ProcName = "USP_GVU_KHMO_ADD";
            OracleParameter[] Parameters =
            {
                    new OracleParameter("P_MAHP", OracleDbType.Varchar2, sinhVien.MAHP, ParameterDirection.Input ),
                    new OracleParameter("P_HK", OracleDbType.Int32, sinhVien.HK, ParameterDirection.Input ),
                    new OracleParameter("P_NAM", OracleDbType.Int32, sinhVien.NAM, ParameterDirection.Input),
                    new OracleParameter("P_MACT", OracleDbType.Varchar2, sinhVien.MACT, ParameterDirection.Input),
                    new OracleParameter("P_RES", OracleDbType.Decimal, ParameterDirection.Output)
            };
            conn.ExecuteNonQuery(ProcName, CommandType.StoredProcedure, Parameters);
            object resValue = Parameters[Parameters.Length - 1].Value; // Lấy giá trị của tham số đầu ra P_RES
            if (resValue.ToString() == "1")
                return 0;
            return 1;
        }
        public int UpdateKHMO(GVU_KHMODTO sinhVien, GVU_KHMODTO sinhVien2)
        {
            string ProcName = "USP_GVU_KHMO_UPDATE";
            OracleParameter[] Parameters =
            {
                    new OracleParameter("P_MAHP", OracleDbType.Varchar2, sinhVien.MAHP, ParameterDirection.Input ),
                    new OracleParameter("P_HK", OracleDbType.Int32, sinhVien.HK, ParameterDirection.Input ),
                    new OracleParameter("P_NAM", OracleDbType.Int32, sinhVien.NAM, ParameterDirection.Input),
                    new OracleParameter("P_MACT", OracleDbType.Varchar2, sinhVien.MACT, ParameterDirection.Input),

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
            if (resValue.ToString() == "5")
                return 5;
            return 1;
        }
        public int UpdateKHMO2(GVU_KHMODTO sinhVien, GVU_KHMODTO sinhVien2)
        {
            string ProcName = "USP_GVU_KHMO_UPDATE_2";
            OracleParameter[] Parameters =
            {
                    new OracleParameter("P_MAHP", OracleDbType.Varchar2, sinhVien.MAHP, ParameterDirection.Input ),
                    new OracleParameter("P_HK", OracleDbType.Int32, sinhVien.HK, ParameterDirection.Input ),
                    new OracleParameter("P_NAM", OracleDbType.Int32, sinhVien.NAM, ParameterDirection.Input),
                    new OracleParameter("P_MACT", OracleDbType.Varchar2, sinhVien.MACT, ParameterDirection.Input),

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
    }
}
