using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Net;

namespace ATTT
{
    public class Connection
    {
        public static string username = "";
        public static string role = "";
        public static OracleConnection con = null;
        private static string host = "localhost";
        private static OracleDataAdapter adapter;

        public static void Connect(string username, string password)
        {
            string connectionString = "User ID=" + username + "; Password=" + password + "; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = " + host + ")(PORT = 1521))(CONNECT_DATA=(SERVER = DEDICATED)(SERVICE_NAME = ATTT)));";

            con = new OracleConnection();
            con.ConnectionString = connectionString;

            try
            {
                con.Open();
                // set default schema to C##ADMIN
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "ALTER SESSION SET CURRENT_SCHEMA = C##ADMIN";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();

                Connection.username = username;
                Connection.role = GetRole();
                adapter = new OracleDataAdapter();

            }
            catch (OracleException err)
            {
                Connection.username = "";
                Connection.role = "";
                con = null;
                adapter = null;
            }
        }
        public static void Close()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        public static bool Disconnect()
        {
            try
            {
                Close();
                con.Dispose();
                return true;
            }
            catch (OracleException)
            {
                return false;
            }
        }

        // get role from a function in the database
        public static string GetRole()
        {
            string role = "";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT USP_GET_USER_MAIN_ROLE FROM DUAL";
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                role = dr.GetString(0);
            }
            dr.Close();
            return role;
        }

        public static DataTable ExecuteQuery(string sql, CommandType cmdType, OracleParameter[]? parameters)
        {
            DataTable dt;
            DataSet ds = new DataSet();
            try
            {
                // Open conn if it is closed
                if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                    con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.CommandType = cmdType;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (OracleException ex)
            {
                throw new Exception("Error executing: " + ex.Message);
            }
            finally
            {
                Close();
            }
            return dt;
        }

        public static void ExecuteNonQuery(string sql, CommandType cmdType, OracleParameter[]? parameters)
        {
            try
            {
                if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                    con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.CommandType = cmdType;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                throw new Exception("Error executing: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}


