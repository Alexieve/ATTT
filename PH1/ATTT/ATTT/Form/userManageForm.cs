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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATTT
{
    public partial class userManageForm : Form
    {
        public userManageForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string username = User.Text.Trim();
            string password = Password.Text.Trim();
            if (username == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo");
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
                return;
            }
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandText = "CREATE USER " + username + " IDENTIFIED BY " + password;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm user thành công!", "Thông báo");
            }
            catch (OracleException err)
            {
                MessageBox.Show("User đã được tạo hoặc lỗi hệ thống", "Thông báo");
            }
            Show(username);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void userManageForm_Load(object sender, EventArgs e)
        {
            Show("SYS");
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }
        public void Show(string param)
        {
            listView1.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = "USP_GET_USER_LIST";
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter p_user = new OracleParameter();
            //p_user.OracleDbType = OracleDbType.Varchar2;
            //p_user.Direction = ParameterDirection.Input;
            //p_user.Value = param;
            cmd.Parameters.Add("v_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(new("p_user", OracleDbType.Varchar2, ParameterDirection.Input)).Value = param;
            OracleDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                listView1.Items.Add(dr[0].ToString());

                i++;
            }
            dr.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void findUser_TextChanged(object sender, EventArgs e)
        {
            string userName = findUser.Text.Trim();
            if (userName == "")
            {
                userManageForm_Load(sender, e);
            }
            else
            {
                Show(userName);
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            User.Text = listView1.SelectedItems[0].SubItems[0].Text;
            Password.Text = "***";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string username = User.Text.Trim();
            //string password = Password.Text.Trim();
            if (username == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo");
                return;
            }
            //else if (password == "")
            //{
            //MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
            //}
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandText = "DROP USER " + username;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa user thảnh công!", "Thông báo");
            }
            catch (OracleException err)
            {
                MessageBox.Show("User không tồn tại hoặc lỗi hệ thống", "Thông báo");
            }
            Show("");
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string username = User.Text.Trim();
            string password = Password.Text.Trim();
            if (username == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo");
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
                return;
            }
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection.con;
                cmd.CommandText = "ALTER USER " + username + " IDENTIFIED BY " + password;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
            }
            catch (OracleException err)
            {
                MessageBox.Show("Lỗi hệ thống", "Thông báo");
            }
            Show(username);
        }
    }
}
