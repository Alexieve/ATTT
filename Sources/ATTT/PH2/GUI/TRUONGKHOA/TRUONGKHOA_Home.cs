using PH2.DAL;
using PH2.GUI.GIANGVIEN;
using PH2.GUI.NV;
using PH2.GUI.TRUONGKHOA;

namespace PH2.GUI
{
    public partial class TRUONGKHOA_Home : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public TRUONGKHOA_Home(string username)
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
            ActiveButton(sender);
            openChildForm(new NV_DanhSachSinhVien());
        }

        private void DSDonViBtn_Click(object? sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new NV_DanhSachDonVi());
        }

        private void DSHocPhanBtn_Click(object? sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new NV_DanhSachHocPhan());
        }

        private void KHMOBtn_Click(object? sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new NV_DanhSachKHMO());
        }
        private void PhanCongBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new TRUONGKHOA_BangPhanCong());
        }
        private void NhanSuBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new TRUONGKHOA_DanhSachNhanSu());
        }

        private void DangKyBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new GV_XemDangKy());
        }
        private void TaiLieuBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new TaiLieu());
        }
        private void NhanSuOLS_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new XemNhanSu());
        }

        private void DeTaiNCBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new DeTaiNC());
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
