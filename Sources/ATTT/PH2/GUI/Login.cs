using System.DirectoryServices;
using PH2.BLL;
using PH2.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PH2.GUI
{
    public partial class Login : Form
    {
        private LoginBLL loginBLL;
        public Login()
        {
            InitializeComponent();
            loginBLL = new LoginBLL();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text.Trim().ToUpper();
            string password = passwordBox.Text.Trim();

            //TEST with username and password defautl SV00000102
            username = password = "SV00000102";

            DbConnection conn = loginBLL.Connect(username, password);
            if (conn.role == null) { return; }

            if (conn.role == "RL_SINHVIEN")
            {
                this.Hide();
                SV_Home svHome = new SV_Home(conn.username);
                svHome.ShowDialog();
                this.Close();
            }

        }

    }
}
