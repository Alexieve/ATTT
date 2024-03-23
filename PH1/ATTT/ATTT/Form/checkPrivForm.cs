using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATTT
{
    public partial class checkPrivForm : Form
    {
        string choice = null;
        private List<string> cbbRoleData = new List<string>();
        private List<string> cbbUserData = new List<string>();

        private void CreateCbbRoleData()
        {
            cbbRoleData.Add(new string("RL_NVCOBAN"));
            cbbRoleData.Add(new string("RL_GIANGVIEN"));
            cbbRoleData.Add(new string("RL_GIAOVU"));
            cbbRoleData.Add(new string("RL_TRUONGDV"));
            cbbRoleData.Add(new string("RL_TRUONGKHOA"));
            cbbRoleData.Add(new string("RL_SINHVIEN"));
        }
        private void CreateCbbUserData()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = "USP_GET_USER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new("CUR_USER", OracleDbType.RefCursor, ParameterDirection.Output));
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbbUserData.Add(new string(dr["USERNAME"].ToString()));
            }
            dr.Close();
        }

        public checkPrivForm()
        {
            InitializeComponent();
            CreateCbbRoleData();
            CreateCbbUserData();
        }

        private void btnTabRole_Click(object sender, EventArgs e)
        {
            string role_user_input = tbInputTab.SelectedItem.ToString().Trim();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = "USP_GET_PRIVS_USER_ROLE_TAB";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new("V_USER_ROLE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = role_user_input;
            cmd.Parameters.Add(new("CHOICE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = choice;
            cmd.Parameters.Add(new("CUR_TAB_PRIVS_USER", OracleDbType.RefCursor, ParameterDirection.Output));
            cmd.Parameters.Add(new("CUR_TAB_PRIVS_ROLE", OracleDbType.RefCursor, ParameterDirection.Output));
            cmd.ExecuteNonQuery();

            string para, type;
            if (choice == "ROLE")
                para = "CUR_TAB_PRIVS_ROLE";
            else
                para = "CUR_TAB_PRIVS_USER";

            OracleDataReader dr = ((OracleRefCursor)cmd.Parameters[para].Value).GetDataReader();

            // Reset
            dtgTab.Rows.Clear();

            while (dr.Read())
            {
                string GRANTEE = dr["GRANTEE"].ToString();
                string TABLE_NAME = dr["TABLE_NAME"].ToString();
                string PRIVILEGE = dr["PRIVILEGE"].ToString();
                string GRANTOR = dr["GRANTOR"].ToString();
                string GRANTABLE = dr["GRANTABLE"].ToString();


                if (choice == "ROLE")
                {
                    type = "Granted";
                    if (GRANTEE != role_user_input)
                        type = "Hierarchy: " + GRANTEE;
                }
                else
                {
                    type = "DAC";
                    if (GRANTEE != role_user_input)
                        type = "RBAC: " + GRANTEE;
                }
                dtgTab.Rows.Add(role_user_input, TABLE_NAME, PRIVILEGE, GRANTOR, GRANTABLE, type);
            }
        }


        private void btnCol_Click(object sender, EventArgs e)
        {
            string role_user_input = comboBox1.SelectedItem.ToString().Trim();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = "USP_GET_PRIVS_USER_ROLE_COL";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new("V_USER_ROLE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = role_user_input;
            cmd.Parameters.Add(new("CHOICE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = choice;
            cmd.Parameters.Add(new("CUR_COL_PRIVS_USER", OracleDbType.RefCursor, ParameterDirection.Output));
            cmd.Parameters.Add(new("CUR_COL_PRIVS_ROLE", OracleDbType.RefCursor, ParameterDirection.Output));
            cmd.ExecuteNonQuery();

            string para, type;
            if (choice == "ROLE")
                para = "CUR_COL_PRIVS_ROLE";
            else
                para = "CUR_COL_PRIVS_USER";

            OracleDataReader dr = ((OracleRefCursor)cmd.Parameters[para].Value).GetDataReader();

            // Reset
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                string GRANTEE = dr["GRANTEE"].ToString();
                string TABLE_NAME = dr["TABLE_NAME"].ToString();
                string COLUMN_NAME = dr["COLUMN_NAME"].ToString();
                string PRIVILEGE = dr["PRIVILEGE"].ToString();
                string GRANTOR = dr["GRANTOR"].ToString();
                string GRANTABLE = dr["GRANTABLE"].ToString();


                if (choice == "ROLE")
                {
                    type = "Granted";
                    if (GRANTEE != role_user_input)
                        type = "Hierarchy: " + GRANTEE;
                }
                else
                {
                    type = "DAC";
                    if (GRANTEE != role_user_input)
                        type = "RBAC: " + GRANTEE;
                }
                dataGridView1.Rows.Add(role_user_input, TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTOR, GRANTABLE, type);
            }
        }

        private void lbTab_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choice = "USER";
            tbInputTab.Items.Clear();
            tbInputTab.Items.AddRange(cbbUserData.ToArray());
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choice = "ROLE";
            tbInputTab.Items.Clear();
            tbInputTab.Items.AddRange(cbbRoleData.ToArray());
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            choice = "USER";
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(cbbUserData.ToArray());
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            choice = "ROLE";
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(cbbRoleData.ToArray());
        }
    }
}
