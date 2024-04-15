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
            //username = password = "SV00000102";

            DbConnection conn = loginBLL.Connect(username, password);
            if (conn == null || conn.role == null) { return; }

            this.Hide();
            Form homeForm = null;
            switch (conn.role)
            {
                case "RL_SINHVIEN":
                    homeForm = new SV_Home(conn.username);
                    break;
                case "RL_NVCOBAN":
                    homeForm = new NV_Home(conn.username);
                    break;
                case "RL_GIANGVIEN":
                    homeForm = new GIANGVIEN_Home(conn.username);
                    break;
                case "RL_GIAOVU":
                    homeForm = new GIAOVU_Home(conn.username);
                    break;
                case "RL_TRUONGDV":
                    homeForm = new TRUONGDV_Home(conn.username);
                    break;
                case "RL_TRUONGKHOA":
                    homeForm = new TRUONGKHOA_Home(conn.username);
                    break;
            }

            homeForm.ShowDialog();
            this.Close();

        }

    }
}
