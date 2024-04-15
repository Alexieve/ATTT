using System.Data;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class SV_Profile : Form
    {
        private SinhVienBLL svBLL = new SinhVienBLL();
        public SV_Profile()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            //SinhVien sv = Entity.SinhVien.GetList()[0];
            SinhVienDTO svDTO = svBLL.getProfile();
            MASVBox.Text = svDTO.MASV;
            HoTenBox.Text = svDTO.HOTEN;
            PhaiBox.Text = svDTO.PHAI;
            NgaySinhBox.Text = svDTO.NGSINH;
            DiaChiBox.Text = svDTO.DCHI;
            SDTBox.Text = svDTO.SDT;
            MACTBox.Text = svDTO.MACT;
            MaNganhBox.Text = svDTO.MANGANH;
            SOTCTLBox.Text = svDTO.SOTCTL.ToString();
            DTBTLBox.Text = svDTO.DTBTL.ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (svBLL.updateSDTProfile(SDTBox.Text))
                MessageBox.Show("Cập nhật thành công");
        }

        // Turn KeyPress above into function
        private void SDTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
