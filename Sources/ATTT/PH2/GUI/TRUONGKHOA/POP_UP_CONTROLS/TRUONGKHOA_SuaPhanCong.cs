using PH2.BLL;
using PH2.DAL;
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

namespace PH2.GUI.TRUONGKHOA.POP_UP_CONTROLS
{
    public partial class TRUONGKHOA_SuaPhanCong : Form
    {
        private GiangVienBLL _GiangVienBLL;
        private PhanCongBLL _PhanCongBLL;
        List<GiangVienDTO> listGiangVienDTO;
        string cMAGV, cMAHP, cMACT;
        int cHOCKY, cNAM;
        public TRUONGKHOA_SuaPhanCong(string MAGV, int HOCKY, int NAM, string MAHP, string MACT)
        {
            InitializeComponent();
            _GiangVienBLL = new GiangVienBLL();
            _PhanCongBLL = new PhanCongBLL();
            cMAGV = MAGV;
            cHOCKY = HOCKY;
            cNAM = NAM;
            cMAHP = MAHP;
            cMACT = MACT;
            Load();
        }

        private void Load()
        {
            listGiangVienDTO = _GiangVienBLL.getAll();
            dtgviewGiangVien.DataSource = listGiangVienDTO.Where(s => s.MAGV != cMAGV).ToList();
            dtgviewGiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewGiangVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgviewGiangVien.MultiSelect = false;
            dtgviewGiangVien.ReadOnly = true;

            tbMAGV.TextChanged += GiangVien_TextChanged;
            tbHOTEN.TextChanged += GiangVien_TextChanged;
            tbSDT.TextChanged += GiangVien_TextChanged;
            tbCOSO.TextChanged += GiangVien_TextChanged;
            tbMADV.TextChanged += GiangVien_TextChanged;

            tbHK.Text = cHOCKY.ToString();
            tbNAM.Text = cNAM.ToString();
            tbMAHP.Text = cMAHP;
            tbMACT.Text = cMACT;

            List<GiangVienDTO> currentGV = listGiangVienDTO.Where(s => s.MAGV == cMAGV).ToList();
            tbMAGVht.Text = currentGV[0].MAGV;
            tbHOTENht.Text = currentGV[0].HOTEN;
            tbMADVht.Text = currentGV[0].MADV;
            tbCOSOht.Text = currentGV[0].COSO;
        }

        private void CheckNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void GiangVien_TextChanged(object sender, EventArgs e)
        {
            string MAGV = tbMAGV.Text.ToLower();
            string HOTEN = tbHOTEN.Text.ToLower();
            string COSO = tbCOSO.Text.ToLower();
            string MADV = tbMADV.Text.ToLower();
            string SDT = tbSDT.Text.ToLower();

            List<GiangVienDTO> filteredList = listGiangVienDTO.Where(s =>
                s.MAGV.ToLower().Contains(MAGV) &&
                s.HOTEN.ToLower().Contains(HOTEN) &&
                s.COSO.ToLower().Contains(COSO) &&
                s.MADV.ToLower().Contains(MADV)
                ).ToList();
            dtgviewGiangVien.DataSource = null;
            dtgviewGiangVien.DataSource = filteredList;
        }

        private void btnChinhSua_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow rowGiangVien = dtgviewGiangVien.SelectedRows[0];
            var _GiangVienDTO = (GiangVienDTO)rowGiangVien.DataBoundItem;
            bool check = _PhanCongBLL.checkDK(cMAGV, cMAHP, cHOCKY, cNAM, cMACT);
            if (!check)
            {
                YesNoDialog yesNoDialog = new YesNoDialog();
                DialogResult result = yesNoDialog.ShowDialog();
                if (result == DialogResult.No)
                    return;
            }
            
            string status = _PhanCongBLL.doiMAGV(cMAGV, cMAHP, cHOCKY, cNAM, cMACT, _GiangVienDTO.MAGV);
            if (status == "")
            {
                MessageBox.Show("Sửa thành công");
                cMAGV = _GiangVienDTO.MAGV;
                Load();
            }
            else if (status.Contains("-20001"))
                MessageBox.Show("Giáo viên đã được phân công cho kế hoạch mở này");
            else if (status.Contains("-20002"))
                MessageBox.Show("Phân công chứa học phần không thuộc quản lý của Văn Phòng Khoa");
        }
    }
}
