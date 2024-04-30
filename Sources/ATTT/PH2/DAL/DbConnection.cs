using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace PH2.DAL
{
    public class DbConnection // Oracle
    {
        private static OracleConnection conn;
        private OracleDataAdapter adapter;
        private static string _username;
        private static string _role;

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string role
        {
            get { return _role; }
            set { _role = value; }
        }

        public DbConnection()
        {
            if (conn != null) adapter = new OracleDataAdapter();
        }
        public bool Connect(string username, string password)
        {
            try
            {
                string connectionString = "User ID=" + username + "; Password=" + password +
                                          "; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = " +
                                          "localhost" +
                                          ")(PORT = 1521))(CONNECT_DATA=(SERVER = DEDICATED)(SERVICE_NAME = ATTT)));";
                conn = new OracleConnection(connectionString);
                adapter = new OracleDataAdapter();
                _username = username;

                // Set Schema
                string sql = "ALTER SESSION SET CURRENT_SCHEMA = C##ADMIN";
                ExecuteNonQuery(sql, CommandType.Text, null);

                // Get Role
                sql = "SELECT USP_GET_USER_MAIN_ROLE FROM DUAL";
                DataTable dt = ExecuteQuery(sql, CommandType.Text, null);
                _role = dt.Rows[0][0].ToString();
                return true;
            }
            catch
            {
                conn = null;
                adapter = null;
                username = null;
                _role = null;
                return false;
            }
        }

        public void Disconnect()
        {
            Close();
            conn = null;
            adapter = null;
            username = null;
            _role = null;
        }

        private OracleConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed
                || conn.State == ConnectionState.Broken)
                conn.Open();
            return conn;
        }

        private void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable ExecuteQuery(string sql, CommandType cmdType, OracleParameter[]? parameters)
        {
            DataTable dt;
            DataSet ds = new DataSet();
            try
            {
                OracleCommand cmd = new OracleCommand(sql, OpenConnection());
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

        public void ExecuteNonQuery(string sql, CommandType cmdType, OracleParameter[]? parameters)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(sql, OpenConnection());
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
