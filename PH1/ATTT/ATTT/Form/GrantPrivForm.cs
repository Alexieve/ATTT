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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATTT
{
    public partial class GrantPrivForm : Form
    {

        public GrantPrivForm()
        {
            InitializeComponent();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = "USP_GET_TABLE_NAME";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_TABLE_NAMES", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tableName = dr["TABLE_NAME"].ToString();
                GrantPrivTable.Rows.Add(tableName, false, false, false, false);
            }
            dr.Close();

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string userRoleValue = UserRoleBox.Text.ToUpper().Trim();
            if (userRoleValue == "")
            {
                MessageBox.Show("Vui lòng nhập Role/User!");
                return;
            }

            // Reset
            for (int i = 0; i < GrantPrivTable.Rows.Count; i++)
            {
                GrantPrivTable.Rows[i].Cells[1].Value = CheckState.Unchecked;
                GrantPrivTable.Rows[i].Cells[2].Value = CheckState.Unchecked;
                GrantPrivTable.Rows[i].Cells[3].Value = CheckState.Unchecked;
                GrantPrivTable.Rows[i].Cells[4].Value = CheckState.Unchecked;
            }

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "USP_GET_PRIV";
                cmd.Parameters.Add(new("P_ROLE_USER_NAME", OracleDbType.Varchar2, ParameterDirection.Input)).Value = userRoleValue;
                cmd.Parameters.Add(new("P_ROLE_USER_PRIV", OracleDbType.RefCursor, ParameterDirection.Output));

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string tableName = dr["TABLE_NAME"].ToString();
                    string privilege = dr["PRIVILEGE"].ToString();
                    string grantable = dr["GRANTABLE"].ToString();

                    for (int i = 0; i < GrantPrivTable.Rows.Count; i++)
                    {
                        if (GrantPrivTable.Rows[i].Cells[0].Value.ToString() == tableName)
                        {
                            if (privilege == "SELECT")
                            {
                                GrantPrivTable.Rows[i].Cells[1].Value = grantable == "YES" ? CheckState.Indeterminate : CheckState.Checked;
                            }
                            else if (privilege == "INSERT")
                            {
                                GrantPrivTable.Rows[i].Cells[2].Value = grantable == "YES" ? CheckState.Indeterminate : CheckState.Checked;
                            }
                            else if (privilege == "UPDATE")
                            {
                                GrantPrivTable.Rows[i].Cells[3].Value = grantable == "YES" ? CheckState.Indeterminate : CheckState.Checked;
                            }
                            else if (privilege == "DELETE")
                            {
                                GrantPrivTable.Rows[i].Cells[4].Value = grantable == "YES" ? CheckState.Indeterminate : CheckState.Checked;
                            }
                        }
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có Role/User nào tương ứng!");
            }
        }

        private void GrantButton_Click(object sender, EventArgs e)
        {
            string userRoleValue = UserRoleBox.Text.ToUpper().Trim();

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_REVOKE_ALL_PRIV_ON_SCHEMA";
                cmd.Parameters.Add(new("P_ROLE_USER_NAME", OracleDbType.Varchar2, ParameterDirection.Input)).Value = userRoleValue;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                for (int i = 0; i < GrantPrivTable.Rows.Count; i++)
                {
                    string tableName = GrantPrivTable.Rows[i].Cells[0].Value.ToString().ToUpper();
                    for (int j = 1; j < 5; j++)
                    {
                        string privilege = GrantPrivTable.Columns[j].HeaderText.ToUpper();
                        string grantable = " ";
                        if (GrantPrivTable.Rows[i].Cells[j].Value is CheckState.Unchecked)
                        {
                            continue;
                        }
                        else if (GrantPrivTable.Rows[i].Cells[j].Value is CheckState.Checked)
                        {
                            grantable = "NO";
                        }
                        else if (GrantPrivTable.Rows[i].Cells[j].Value is CheckState.Indeterminate)
                        {
                            grantable = "YES";
                        }

                        cmd = new OracleCommand();
                        cmd.Connection = Connection.con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "USP_GRANT_PRIV";
                        cmd.Parameters.Add(new("P_ROLE_USER_NAME", OracleDbType.Varchar2, ParameterDirection.Input)).Value = userRoleValue;
                        cmd.Parameters.Add(new("P_TABLE_NAME", OracleDbType.Varchar2, ParameterDirection.Input)).Value = tableName;
                        cmd.Parameters.Add(new("P_PRIVILEGE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = privilege;
                        cmd.Parameters.Add(new("P_GRANTABLE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = grantable;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                }
                MessageBox.Show("Cấp quyền thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có Role/User nào tương ứng!");
            }
        }
    }
}
