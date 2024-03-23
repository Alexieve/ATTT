using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class roleManageForm : Form
    {
        public roleManageForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roleManageForm_Load(object sender, EventArgs e)
        {
            Show("RL");
        }
        public void Show(string param)
        {
            listView1.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = "USP_GET_ROLE_LIST";
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter p_user = new OracleParameter();
            //p_user.OracleDbType = OracleDbType.Varchar2;
            //p_user.Direction = ParameterDirection.Input;
            //p_user.Value = param;
            cmd.Parameters.Add("v_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(new("p_role", OracleDbType.Varchar2, ParameterDirection.Input)).Value = param;
            OracleDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                listView1.Items.Add(dr[0].ToString());

                i++;
            }
            dr.Close();

        }

        private void findUser_TextChanged(object sender, EventArgs e)
        {
            string roleName = findUser.Text.Trim();
            if (roleName == "")
            {
                roleManageForm_Load(sender, e);
            }
            else
            {
                Show(roleName);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            Role.Text = listView1.SelectedItems[0].SubItems[0].Text;
            Password.Text = "***";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string roleName = Role.Text.Trim().ToUpper();
            string password = Password.Text.Trim();
            if (roleName == "")
            {
                MessageBox.Show("Vui lòng nhập tên role!", "Thông báo");
                return;
            }
            else
            {
                
                if (roleName.Length < 3 || roleName[0] != 'R' || roleName[1] != 'L' || roleName[2] != '_')
                {
                    MessageBox.Show("Tên role phải bắt đầu bằng RL_!", "Thông báo");
                    Show("RL");
                    return;
                }
            }
            if (password == "")
            {
                try
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "CREATE ROLE " + roleName; ;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm Role thành công!", "Thông báo");
                }
                catch (OracleException err)
                {
                    MessageBox.Show("Role đã được tạo hoặc lỗi hệ thống", "Thông báo");
                }
            }
            else
            {
                try
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "CREATE ROLE " + roleName + " IDENTIFIED BY " + password;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm Role thành công!", "Thông báo");
                }
                catch (OracleException err)
                {
                    MessageBox.Show("Role đã được tạo hoặc lỗi hệ thống", "Thông báo");
                }
            }
            Show(roleName);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string roleName = Role.Text.Trim().ToUpper();
            //string password = Password.Text.Trim();
            if (roleName == "")
            {
                MessageBox.Show("Vui lòng nhập tên role!", "Thông báo");
                return;
            }
            else
            {
                if (roleName.Length < 3 || roleName[0] != 'R' || roleName[1] != 'L' || roleName[2] != '_')
                {
                    MessageBox.Show("Tên role phải bắt đầu bằng RL_!", "Thông báo");
                    Show("RL");
                    return;
                }
            }
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandText = "DROP ROLE " + roleName;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Role thành công!", "Thông báo");
            }
            catch (OracleException err)
            {
                MessageBox.Show("Role không tồn tại hoặc lỗi hệ thống", "Thông báo");
            }
            Show("RL");
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string roleName = Role.Text.Trim();
            string password = Password.Text.Trim();
            if (roleName == "")
            {
                MessageBox.Show("Vui lòng nhập tên role!", "Thông báo");
                return;
            }
            else
            {
                if (roleName.Length < 3 || roleName[0] != 'R' || roleName[1] != 'L' || roleName[2] != '_')
                {
                    MessageBox.Show("Tên role phải bắt đầu bằng RL_!", "Thông báo");
                    Show("RL");
                    return;
                }
            }
            if (password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo");
                return;
            }
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandText = "ALTER ROLE " + roleName + " IDENTIFIED BY " + password;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu Role thành công!", "Thông báo");
            }
            catch (OracleException err)
            {
                MessageBox.Show("Role không tồn tại hoặc lỗi hệ thống", "Thông báo");
            }
            Show("RL");
        }
    }
}
