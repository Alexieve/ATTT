using Oracle.ManagedDataAccess.Client;
using System.Net;

namespace ATTT
{
    public class Connection
    {
        public static string username = "";
        public static string role = "";
        public static OracleConnection con = null;
        private static string host = "localhost";
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

            }
            catch (OracleException err)
            {
                Connection.username = "";
                Connection.role = "";
                con = null;
                //throw new Exception(err.Message);
                //MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo");
            }
        }
        public static void Close()
        {
            if (con != null)
            {
                Connection.username = "";
                con.Close();
                con.Dispose();
                con = null;
            }
        }

        public static bool IsConnected()
        {
            if (con == null)
            {
                return false;
            }
            return con.State == System.Data.ConnectionState.Open;
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
    }
}


