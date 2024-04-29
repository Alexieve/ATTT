using PH2.DAL;

namespace PH2.GUI
{
    public partial class SV_Home : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public SV_Home(string username)
        {
            InitializeComponent();
            nameLabel.Text = username;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            openChildForm(new SV_Profile());
        }
        private void HOCPHANPanel_Click(object? sender, EventArgs e)
        {
            openChildForm(new SV_DSHocPhan());
            ActiveButton(sender);
        }

        private void KHMOPanel_Click(object? sender, EventArgs e)
        {
            openChildForm(new SV_KHMO());
            ActiveButton(sender);
        }

        private void DKHPPanel_Click(object? sender, EventArgs e)
        {
            openChildForm(new SV_DangKyHP());
            ActiveButton(sender);

        }

        private void KQHPPanel_Click(object? sender, EventArgs e)
        {
            openChildForm(new SV_KetQuaHP());
            ActiveButton(sender);

        }


        private void DeTaiNCBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new DeTaiNC());
            ActiveButton(sender);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DbConnection conn = new DbConnection();
            conn.Disconnect();
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void NotifyBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongBao());
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.childFormPanel.Controls.Add(childForm);
            this.childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (currentButton != (Button)senderBtn)
                {
                    DisableButton();
                    currentButton = (Button)senderBtn;
                    currentButton.BackColor = Color.FromArgb(128, 128, 128);
                }
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

    }
}
