using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTT
{
    public partial class GrantRoleForm : Form
    {
        public GrantRoleForm()
        {
            InitializeComponent();
            // Load danh sách Role
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = "USP_GET_ROLE_NAME";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_ROLE_NAMES", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string roleName = dr["GRANTED_ROLE"].ToString();
                RoleBox.Items.Add(roleName);
            }
            dr.Close();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string UserRoleValue = UserRoleBox.Text.ToUpper().Trim();
            if (UserRoleValue == "")
            {
                MessageBox.Show("Vui lòng nhập Role/User!");
                return;
            }

            RoleTable.Rows.Clear();

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_GET_ROLE_PRIVILEGES";
                cmd.Parameters.Add("P_ROLE_PRIVS", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("P_USER_ROLE", OracleDbType.Varchar2, ParameterDirection.Input).Value = UserRoleValue;

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string grantee = dr["GRANTEE"].ToString();
                    string granted_role = dr["GRANTED_ROLE"].ToString();
                    RoleTable.Rows.Add(grantee, granted_role);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void GrantButton_Click(object sender, EventArgs e)
        {
            string userRoleValue = UserRoleBox.Text.ToUpper().Trim();
            if (userRoleValue == "")
            {
                MessageBox.Show("Vui lòng nhập Role/User!");
                return;
            }

            // RoleValue is not in RoleBox
            string RoleValue = RoleBox.Text.ToUpper().Trim();
            if (RoleValue == "")
            {
                MessageBox.Show("Vui lòng chọn Role!");
                return;
            }


            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_GRANT_ROLE";
                cmd.Parameters.Add("P_ROLE_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = RoleValue;
                cmd.Parameters.Add("P_USER_ROLE", OracleDbType.Varchar2, ParameterDirection.Input).Value = userRoleValue;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cấp quyền thành công!");
                CheckButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RevokeButton_Click(object sender, EventArgs e)
        {
            string userRoleValue = UserRoleBox.Text.ToUpper().Trim();
            if (userRoleValue == "")
            {
                MessageBox.Show("Vui lòng nhập Role/User!");
                return;
            }

            string RoleValue = RoleBox.Text.ToUpper().Trim();
            if (RoleValue == "")
            {
                MessageBox.Show("Vui lòng chọn Role!");
                return;
            }

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_REVOKE_ROLE";
                cmd.Parameters.Add("P_ROLE_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = RoleValue;
                cmd.Parameters.Add("P_USER_ROLE", OracleDbType.Varchar2, ParameterDirection.Input).Value = userRoleValue;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thu hồi quyền thành công!");

                CheckButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                // Show error code -20001 only
                if (ex.Message.Contains("-20001"))
                {
                    MessageBox.Show("Đối tượng không có Role này!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
