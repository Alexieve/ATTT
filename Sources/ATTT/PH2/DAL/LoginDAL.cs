using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DAL
{
    internal class LoginDAL
    {
        DbConnection conn;
        public LoginDAL()
        {
            conn = new DbConnection();
        }

        public DbConnection Connect(string username, string password)
        {
            if (!conn.Connect(username, password))
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo");
            }
            return conn;
        }
    }
}
