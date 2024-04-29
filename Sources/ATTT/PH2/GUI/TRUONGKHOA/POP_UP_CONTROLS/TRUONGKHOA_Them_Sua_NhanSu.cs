using PH2.BLL;
using PH2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PH2.GUI.TRUONGKHOA.POP_UP_CONTROLS
{
    public partial class TRUONGKHOA_Them_Sua_NhanSu : Form
    {
        string type;
        NhanSuBLL _NhanSuBLL;
        public TRUONGKHOA_Them_Sua_NhanSu(string type, NhanSuDTO _NhanSuDTO = null)
        {
            InitializeComponent();
            _NhanSuBLL = new NhanSuBLL();
            tbPHUCAP.KeyPress += CheckNumeric;
            tbSDT.KeyPress += CheckNumeric;
            this.type = type;
            if (type == "update")
                loadUpdate(_NhanSuDTO);
            cbboxVaiTro.SelectedIndexChanged += VaiTro_changed;
        }

        public void loadUpdate(NhanSuDTO _NhanSuDTO)
        {
            tbMANV.Text = _NhanSuDTO.MANV.Trim();
            tbMANV.ReadOnly = true;
            tbHOTEN.Text = _NhanSuDTO.HOTEN.Trim();
            string PHAI = _NhanSuDTO.PHAI.Trim();
            if (PHAI == "Nam")
                rbtnNAM.Select();
            else
                rbtnNU.Select();
            dtpkDOB.Value = DateTime.Parse(_NhanSuDTO.NGSINH.Trim());
            tbPHUCAP.Text = _NhanSuDTO.PHUCAP.Trim();
            tbSDT.Text = _NhanSuDTO.SDT.Trim();
            cbboxVaiTro.Text = _NhanSuDTO.VAITRO.Trim();
            cbboxMaDV.Text = _NhanSuDTO.MADV.Trim();
            cbboxCoSo.Text = _NhanSuDTO.COSO.Trim();
        }

        private void CheckNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void VaiTro_changed(object sender, EventArgs e)
        {
            cbboxMaDV.SelectedIndex = -1;
            if (cbboxVaiTro.Text == "Trưởng khoa")
            {
                cbboxMaDV.Items.Clear();
                cbboxMaDV.Items.Add("VPK");
            }
            else
            {
                cbboxMaDV.Items.Clear();
                cbboxMaDV.Items.Add("HTTT");
                cbboxMaDV.Items.Add("CNPM");               
                cbboxMaDV.Items.Add("KHMT");               
                cbboxMaDV.Items.Add("CNTT");               
                cbboxMaDV.Items.Add("TGMT");               
                cbboxMaDV.Items.Add("MMT");               
            }    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbMANV.Text == "" || tbHOTEN.Text == "" || tbPHUCAP.Text == "" || tbSDT.Text == "" || cbboxVaiTro.Text == "" || cbboxMaDV.Text == "" || cbboxCoSo.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            string MANV = tbMANV.Text.Trim();
            string HOTEN = tbHOTEN.Text.Trim();
            string PHAI = rbtnNAM.Checked ? "Nam" : "Nữ";
            DateTime NGSINH = dtpkDOB.Value;
            float PHUCAP = float.Parse(tbPHUCAP.Text.Trim());
            string SDT = tbSDT.Text.Trim();
            string VAITRO = cbboxVaiTro.Text.Trim();
            string MADV = cbboxMaDV.Text.Trim();
            string COSO = cbboxCoSo.Text.Trim();
            string status;
            if (type == "update")
                status = _NhanSuBLL.update(MANV, HOTEN, PHAI, NGSINH, PHUCAP, SDT, VAITRO, MADV, COSO);
            else
                status = _NhanSuBLL.insert(MANV, HOTEN, PHAI, NGSINH, PHUCAP, SDT, VAITRO, MADV, COSO);

            if (status == "")
                MessageBox.Show((type == "insert" ? "Thêm" : "Sửa") + " thành công");
            if (status.Contains("SDT"))
                MessageBox.Show("SĐT vượt quá giới hạn");
            if (status.Contains("VAITRO"))
                MessageBox.Show("Vai trò không hợp lệ");
            if (status.Contains("DONVI"))
                MessageBox.Show("Đơn vị không hợp lệ");
            if (status.Contains("COSO"))
                MessageBox.Show("Cơ sở không hợp lệ");
            if (status.Contains("unique"))
                MessageBox.Show("Nhân viên đã tồn tại");
            if (status.Contains("role"))
                MessageBox.Show("Mã nhân viên không hợp lệ");
        }
    }
}
