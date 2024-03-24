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
    public partial class GrantPrivColForm : Form
    {
        public GrantPrivColForm()
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
                TableBox.Items.Add(tableName);
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
            string TableName = TableBox.Text.ToUpper().Trim();
            if (TableName == "")
            {
                MessageBox.Show("Vui lòng chọn bảng!");
                return;
            }

            // Clear Table
            GrantPrivTable.Rows.Clear();

            try
            {
                // Load các cột của bảng
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_GET_COLUMN_NAME";
                cmd.Parameters.Add("P_TABLE_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = TableName;
                cmd.Parameters.Add("P_COLUMN_NAMES", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string colName = dr["COLUMN_NAME"].ToString();
                    GrantPrivTable.Rows.Add(colName, false, CheckState.Unchecked);
                }
                dr.Close();

                // Load các quyền của user trên từng cột
                cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_GET_PRIV_COL";
                cmd.Parameters.Add("P_ROLE_USER_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = UserRoleValue;
                cmd.Parameters.Add("P_TABLE_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = TableName;
                cmd.Parameters.Add("P_ROLE_USER_PRIV", OracleDbType.RefCursor, ParameterDirection.Output);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string colName = dr["COLUMN_NAME"].ToString();
                    string privilege = dr["PRIVILEGE"].ToString();
                    string grantable = dr["GRANTABLE"].ToString();
                    for (int i = 0; i < GrantPrivTable.Rows.Count; i++)
                    {
                        if (GrantPrivTable.Rows[i].Cells[0].Value.ToString() == colName)
                        {
                            if (privilege == "SELECT")
                            {
                                if (grantable == "YES")
                                {
                                    GrantPrivTable.Rows[i].Cells[1].Value = CheckState.Indeterminate;
                                }
                                else
                                {
                                    GrantPrivTable.Rows[i].Cells[1].Value = CheckState.Checked;
                                }
                            }
                            if (privilege == "UPDATE")
                            {
                                if (grantable == "YES")
                                {
                                    GrantPrivTable.Rows[i].Cells[2].Value = CheckState.Indeterminate;
                                }
                                else
                                {
                                    GrantPrivTable.Rows[i].Cells[2].Value = CheckState.Checked;
                                }
                            }
                        }
                    }
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
            string UserRoleValue = UserRoleBox.Text.ToUpper().Trim();
            if (UserRoleValue == "")
            {
                MessageBox.Show("Vui lòng nhập Role/User!");
                return;
            }
            string TableName = TableBox.Text.ToUpper().Trim();
            if (TableName == "")
            {
                MessageBox.Show("Vui lòng chọn bảng!");
                return;
            }

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_REVOKE_UPDATE_PRIV";
                cmd.Parameters.Add("P_ROLE_USER_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = UserRoleValue;
                cmd.Parameters.Add("P_TABLE_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = TableName;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                for (int i = 0; i < GrantPrivTable.Rows.Count; i++)
                {
                    string colName = GrantPrivTable.Rows[i].Cells[0].Value.ToString().ToUpper();
                    string select = GrantPrivTable.Rows[i].Cells[1].Value.ToString().ToUpper();
                    string update = GrantPrivTable.Rows[i].Cells[2].Value.ToString().ToUpper();
                    //MessageBox.Show(colName + " " + select  + " " + update);

                    cmd = new OracleCommand();
                    cmd.Connection = Connection.con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "USP_GRANT_PRIV_COL";
                    cmd.Parameters.Add("P_ROLE_USER_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = UserRoleValue;
                    cmd.Parameters.Add("P_TABLE_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = TableName;
                    cmd.Parameters.Add("P_COLUMN_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = colName;
                    cmd.Parameters.Add("P_SELECT", OracleDbType.Varchar2, ParameterDirection.Input).Value = select;
                    cmd.Parameters.Add("P_UPDATE", OracleDbType.Varchar2, ParameterDirection.Input).Value = update;
                    cmd.ExecuteNonQuery();
                }

                cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_APPLY_VPD_FOR_COL_PRIV";
                cmd.Parameters.Add("P_ROLE_USER_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = UserRoleValue;
                cmd.Parameters.Add("P_TABLE_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = TableName;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cấp quyền thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
