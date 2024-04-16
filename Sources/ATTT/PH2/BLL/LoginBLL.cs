using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PH2.DAL;

namespace PH2.BLL
{
    internal class LoginBLL
    {
        private LoginDAL loginDal;
        public LoginBLL()
        {
            loginDal = new LoginDAL();
        }

        public DbConnection Connect(string username, string password)
        {
            if (username == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo");
                return null;
            }
            else if (password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
                return null;
            }
            return loginDal.Connect(username, password);
        }
    }
}
