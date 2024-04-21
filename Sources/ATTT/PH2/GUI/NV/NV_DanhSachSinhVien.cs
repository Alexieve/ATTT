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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace PH2.GUI.NV
{
    public partial class NV_DanhSachSinhVien : Form
    {
        SinhVienBLL _SinhVienBLL;
        List<SinhVienDTO> listSinhVienDTO;
        public NV_DanhSachSinhVien()
        {
            InitializeComponent();
            _SinhVienBLL = new SinhVienBLL();
            load();
        }

        private void load()
        {
            listSinhVienDTO = _SinhVienBLL.getAll();
            dtgviewSinhVien.DataSource = listSinhVienDTO;
            dtgviewSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewSinhVien.ReadOnly = true;
            var distinctMANGANH = listSinhVienDTO.Select(dto => dto.MANGANH).Distinct();
            var distinctMACT = listSinhVienDTO.Select(dto => dto.MACT).Distinct();
            foreach (var MANGANH in distinctMANGANH)
            {
                cbboxCN.Items.Add(MANGANH);
            }
            foreach (var MACT in distinctMACT)
            {
                cbboxCT.Items.Add(MACT);
            }
            tbHoTen.TextChanged += TextChanged;
            tbMaSV.TextChanged += TextChanged;
            tbDT.TextChanged += TextChanged;
            tbDiaChi.TextChanged += TextChanged;
            cbboxPhai.TextChanged += TextChanged;
            cbboxCN.TextChanged += TextChanged;
            cbboxCT.TextChanged += TextChanged;
            dtpkDOBFrom.TextChanged += TextChanged;
            dtpkDOBTo.TextChanged += TextChanged;

            setColumnName();
        }

        private void setColumnName()
        {
            dtgviewSinhVien.Columns[0].HeaderText = "Mã Sinh Viên";
            dtgviewSinhVien.Columns[1].HeaderText = "Họ Tên";
            dtgviewSinhVien.Columns[2].HeaderText = "Phái";
            dtgviewSinhVien.Columns[3].HeaderText = "Ngày Sinh";
            dtgviewSinhVien.Columns[4].HeaderText = "Địa Chỉ";
            dtgviewSinhVien.Columns[5].HeaderText = "SĐT";
            dtgviewSinhVien.Columns[6].HeaderText = "Mã Chương Trình";
            dtgviewSinhVien.Columns[7].HeaderText = "Mã Ngành";
            dtgviewSinhVien.Columns[8].HeaderText = "Số Tín Chỉ Tích Lũy";
            dtgviewSinhVien.Columns[9].HeaderText = "Điểm Trung Bình Tích Lũy";
        }

        private void TextChanged(object sender, EventArgs e)
        {
            string Hoten = tbHoTen.Text.ToLower();
            string MaSV = tbMaSV.Text.ToLower();
            string DT = tbDT.Text.ToLower();
            string DiaChi = tbDiaChi.Text.ToLower();
            string Phai = cbboxPhai.Text.ToLower();
            string CN = cbboxCN.Text.ToLower();
            string CT = cbboxCT.Text.ToLower();
            DateTime fromDate = dtpkDOBFrom.Value;
            DateTime toDate = dtpkDOBTo.Value;
            List<SinhVienDTO> filteredList = listSinhVienDTO.Where(s =>
                s.HOTEN.ToLower().Contains(Hoten) &&
                s.MASV.ToLower().Contains(MaSV) &&
                s.SDT.ToLower().Contains(DT) &&
                s.DCHI.ToLower().Contains(DiaChi) &&
                s.MANGANH.ToLower().Contains(CN) &&
                s.PHAI.ToLower().Contains(Phai) &&
                s.MACT.ToLower().Contains(CT) &&
                (DateTime.Parse(s.NGSINH) >= fromDate && DateTime.Parse(s.NGSINH) <= toDate)
                ).ToList();
            dtgviewSinhVien.DataSource = null;
            dtgviewSinhVien.DataSource = filteredList;
        }
    }
}
