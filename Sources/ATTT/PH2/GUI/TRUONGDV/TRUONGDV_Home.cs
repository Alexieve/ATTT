using PH2.DAL;
using PH2.GUI.GIANGVIEN;
using PH2.GUI.NV;
using PH2.GUI.TRUONGDV;
namespace PH2.GUI
{
    public partial class TRUONGDV_Home : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public TRUONGDV_Home(string username)
        {
            InitializeComponent();
            nameLabel.Text = username;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            openChildForm(new NV_ThongTinCaNhan());
        }
        private void DSSinhVienBtn_Click(object? sender, EventArgs e)
        {
            openChildForm(new NV_DanhSachSinhVien());
            ActiveButton(sender);
        }

        private void DSDonViBtn_Click(object? sender, EventArgs e)
        {
            openChildForm(new NV_DanhSachDonVi());
            ActiveButton(sender);
        }

        private void DSHocPhanBtn_Click(object? sender, EventArgs e)
        {
            openChildForm(new NV_DanhSachHocPhan());
            ActiveButton(sender);
        }

        private void KHMOBtn_Click(object? sender, EventArgs e)
        {
            openChildForm(new NV_DanhSachKHMO());
            ActiveButton(sender);
        }
        private void PhanCongBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new TruongDV_XemPC());
            ActiveButton(sender);
        }

        private void DangKyBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new GV_XemDangKy());
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
