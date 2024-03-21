namespace ATTT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Get username and password
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();

            if (username == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo");
            }
            else if (password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
            }

            // get connection from connection.cs
            Connection.Connect(username, password);
            if (Connection.role == "DBA")
            {
                // announce login success
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                // change to HomeForm
                HomeForm homeForm = new HomeForm();
                homeForm.ShowDialog();


                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo");
            }

        }
    }
}
