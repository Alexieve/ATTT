using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTT
{
    public partial class userListForm : Form
    {
        public userListForm()
        {
            InitializeComponent();
            GrantPrivTable.Rows.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = "USP_GET_USER_NAME";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_USER_NAMES", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string USERNAME = dr["USERNAME"].ToString();
                string ACCOUNT_STATUS = dr["ACCOUNT_STATUS"].ToString();
                string DEFAULT_TABLESPACE = dr["DEFAULT_TABLESPACE"].ToString();
                string CREATED = dr["CREATED"].ToString();
                string AUTHENTICATION_TYPE = dr["AUTHENTICATION_TYPE"].ToString();
                GrantPrivTable.Rows.Add(USERNAME, ACCOUNT_STATUS, DEFAULT_TABLESPACE, CREATED, AUTHENTICATION_TYPE);
            }
            dr.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToUpper();
            GrantPrivTable.Rows.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = "USP_GET_USER_NAME_LIST";
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter p_user = new OracleParameter();
            cmd.Parameters.Add("v_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(new("p_user", OracleDbType.Varchar2, ParameterDirection.Input)).Value = keyword;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string USERNAME = dr["USERNAME"].ToString();
                string ACCOUNT_STATUS = dr["ACCOUNT_STATUS"].ToString();
                string DEFAULT_TABLESPACE = dr["DEFAULT_TABLESPACE"].ToString();
                string CREATED = dr["CREATED"].ToString();
                string AUTHENTICATION_TYPE = dr["AUTHENTICATION_TYPE"].ToString();
                GrantPrivTable.Rows.Add(USERNAME, ACCOUNT_STATUS, DEFAULT_TABLESPACE, CREATED, AUTHENTICATION_TYPE);
            }
            dr.Close();
        }


    }
}
