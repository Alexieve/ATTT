using PH2.BLL;
using PH2.DTO;
using PH2.GUI.TRUONGKHOA.POP_UP_CONTROLS;
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

namespace PH2.GUI.TRUONGKHOA
{
    public partial class TRUONGKHOA_DanhSachNhanSu : Form
    {
        NhanSuBLL _NhanSuBLL;
        List<NhanSuDTO> listNhanSuDTO;
        public TRUONGKHOA_DanhSachNhanSu()
        {
            InitializeComponent();
            _NhanSuBLL = new NhanSuBLL();
            Load();
        }

        private void Load()
        {
            listNhanSuDTO = _NhanSuBLL.getAll();
            dtgvNhanSu.DataSource = listNhanSuDTO;
            dtgvNhanSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNhanSu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvNhanSu.MultiSelect = false;
            dtgvNhanSu.ReadOnly = true;
            dtgvNhanSu.AllowUserToDeleteRows = true;

            tbMANV.TextChanged += TextChanged;
            tbHOTEN.TextChanged += TextChanged;
            tbMADV.TextChanged += TextChanged;
            tbVAITRO.TextChanged += TextChanged;
            tbPHUCAP.TextChanged += TextChanged;
            tbMACS.TextChanged += TextChanged;
            tbSDT.TextChanged += TextChanged;
            cbboxPHAI.TextChanged += TextChanged;
            dtpkDOBFrom.TextChanged += TextChanged;
            dtpkDOBTo.TextChanged += TextChanged;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            string MANV = tbMANV.Text.ToLower();
            string HOTEN = tbHOTEN.Text.ToLower();
            string MADV = tbMADV.Text.ToLower();
            string VAITRO = tbVAITRO.Text.ToLower();
            string PHUCAP = tbPHUCAP.Text.ToLower();
            string MACS = tbMACS.Text.ToLower();
            string SDT = tbSDT.Text.ToLower();
            string PHAI = cbboxPHAI.Text.ToLower();
            DateTime fromDate = dtpkDOBFrom.Value;
            DateTime toDate = dtpkDOBTo.Value;
            List<NhanSuDTO> filteredList = listNhanSuDTO.Where(s =>
                s.MANV.ToLower().Contains(MANV) &&
                s.HOTEN.ToLower().Contains(HOTEN) &&
                s.MADV.ToLower().Contains(MADV) &&
                s.VAITRO.ToLower().Contains(VAITRO) &&
                s.PHUCAP.ToLower().Contains(PHUCAP) &&
                s.COSO.ToLower().Contains(MACS) &&
                s.SDT.ToLower().Contains(SDT) &&
                s.PHAI.ToLower().Contains(PHAI) &&
                (DateTime.Parse(s.NGSINH) >= fromDate && DateTime.Parse(s.NGSINH) <= toDate)
                ).ToList();
            dtgvNhanSu.DataSource = null;
            dtgvNhanSu.DataSource = filteredList;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TRUONGKHOA_Them_Sua_NhanSu _ThemNhanSu = new TRUONGKHOA_Them_Sua_NhanSu("insert");
            _ThemNhanSu.StartPosition = FormStartPosition.CenterScreen;
            _ThemNhanSu.ShowDialog();
            Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvNhanSu.SelectedRows[0];
            var nhanSuDTO = (NhanSuDTO)row.DataBoundItem;
            bool status = _NhanSuBLL.delete(nhanSuDTO.MANV);
            if (status)
            {
                MessageBox.Show("Xóa thành công");
                listNhanSuDTO.Remove(nhanSuDTO);
                TextChanged(null, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvNhanSu.SelectedRows[0];
            var nhanSuDTO = (NhanSuDTO)row.DataBoundItem;
            TRUONGKHOA_Them_Sua_NhanSu _SuaNhanSu = new TRUONGKHOA_Them_Sua_NhanSu("update", nhanSuDTO);
            _SuaNhanSu.StartPosition = FormStartPosition.CenterScreen;
            _SuaNhanSu.ShowDialog();
            Load();
        }
    }
}
