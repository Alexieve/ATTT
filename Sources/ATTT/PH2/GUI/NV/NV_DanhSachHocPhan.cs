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

namespace PH2.GUI.NV
{
    public partial class NV_DanhSachHocPhan : Form
    {
        HocPhanBLL _HocPhanBLL;
        List<HocPhanDTO> listHocPhanDTO;
        public NV_DanhSachHocPhan()
        {
            InitializeComponent();
            _HocPhanBLL = new HocPhanBLL();
            load();
        }

        private void load()
        {
            listHocPhanDTO = _HocPhanBLL.getAll();
            dtgviewHocPhan.DataSource = listHocPhanDTO;
            dtgviewHocPhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewHocPhan.ReadOnly = true;
            tbMaHP.TextChanged += TextChanged;
            tbTenHP.TextChanged += TextChanged;
            tbSTC.TextChanged += TextChanged;
            tbSTLT.TextChanged += TextChanged;
            tbSTTH.TextChanged += TextChanged;
            tbSSVTD.TextChanged += TextChanged;
            tbSTC.KeyPress += CheckNumeric;
            tbSTLT.KeyPress += CheckNumeric;
            tbSTTH.KeyPress += CheckNumeric;
            tbSSVTD.KeyPress += CheckNumeric;
            tbMaDV.TextChanged += TextChanged;
            setColumnName();
        }

        private void setColumnName()
        {
            dtgviewHocPhan.Columns[0].HeaderText = "Mã Học Phần";
            dtgviewHocPhan.Columns[1].HeaderText = "Tên Học Phần";
            dtgviewHocPhan.Columns[2].HeaderText = "Số Tín Chỉ";
            dtgviewHocPhan.Columns[3].HeaderText = "Số Tiết Lý Thuyết";
            dtgviewHocPhan.Columns[4].HeaderText = "Số Tiết Thực Hành";
            dtgviewHocPhan.Columns[5].HeaderText = "Số Sinh Viên Tối Đa";
            dtgviewHocPhan.Columns[5].HeaderText = "Mã Đơn Vị";
        }
        private void CheckNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextChanged(object sender, EventArgs e)
        {
            string MaHP = tbMaHP.Text.ToLower();
            string TenHP = tbTenHP.Text.ToLower();
            int SoTC = tbSTC.Text != "" ? int.Parse(tbSTC.Text) : -1;
            int STLT = tbSTLT.Text != "" ? int.Parse(tbSTLT.Text) : -1;
            int STTH = tbSTTH.Text != "" ? int.Parse(tbSTTH.Text) : -1;
            int SSVTD = tbSSVTD.Text != "" ? int.Parse(tbSSVTD.Text) : -1;
            string MaDV = tbMaDV.Text.ToLower();
            List<HocPhanDTO> filteredList = listHocPhanDTO.Where(s =>
                s.MAHP.ToLower().Contains(MaHP) &&
                s.TENHP.ToLower().Contains(TenHP) &&
                (s.SOTC == SoTC || SoTC == -1) &&
                (s.STLT == STLT || STLT == -1) &&
                (s.STTH == STTH || STTH == -1) &&
                (s.SOSVTD == SSVTD || SSVTD == -1) &&
                s.MADV.ToLower().Contains(MaDV)
                ).ToList();
            dtgviewHocPhan.DataSource = null;
            dtgviewHocPhan.DataSource = filteredList;
        }
    }
}
