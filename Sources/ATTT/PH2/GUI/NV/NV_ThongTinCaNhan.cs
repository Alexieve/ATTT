using PH2.BLL;
using PH2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PH2.GUI.NV
{
    public partial class NV_ThongTinCaNhan : Form
    {
        NhanSuBLL nhanSuBLL;
        string old_SDT = null;
        public NV_ThongTinCaNhan()
        {
            InitializeComponent();
            nhanSuBLL = new NhanSuBLL();
            Load();
        }

        private void Load()
        {
            DataTable dt = nhanSuBLL.getProfile();
            DataRow dr = dt.Rows[0];
            
            tbMANV.Text = dr["MANV"].ToString().Trim();
            tbHOTEN.Text = dr["HOTEN"].ToString().Trim();
            string PHAI = dr["PHAI"].ToString().Trim();
            if (PHAI == "Nam")
                rbtnNAM.Checked = true;
            else
                rbtnNU.Checked = true;
            string NGSINH = dr["NGSINH"].ToString().Trim();
            dtpkDOB.Value = DateTime.Parse(NGSINH);
            tbPHUCAP.Text = dr["PHUCAP"].ToString().Trim();
            tbSDT.Text = dr["SDT"].ToString().Trim();
            old_SDT = dr["SDT"].ToString().Trim();
            tbVAITRO.Text = dr["VAITRO"].ToString().Trim();
            tbMADONVI.Text = dr["MADV"].ToString().Trim();
            tbCOSO.Text = dr["COSO"].ToString().Trim();


            tbMANV.ReadOnly = true;
            tbHOTEN.ReadOnly = true;
            dtpkDOB.Enabled = false;
            tbPHUCAP.ReadOnly = true;
            tbVAITRO.ReadOnly = true;
            tbMADONVI.ReadOnly = true;
            tbCOSO.ReadOnly = true; 
            tbSDT.KeyPress += CheckNumeric;

        }

        private void prevent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void CheckNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string SDT = tbSDT.Text;
            if (nhanSuBLL.updateSDTProfile(SDT))
            {
                MessageBox.Show("Cập nhật số điện thoại thành công");
                old_SDT = SDT;
            }
            else
            {
                MessageBox.Show("Cập nhật số điện thoại không thành công, vui lòng nhập ít hơn hoặc bằng 10 số.");
                tbSDT.Text = old_SDT;
            }
        }
    }
}
