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

namespace PH2.GUI.TRUONGKHOA.POP_UP_CONTROLS
{
    public partial class TRUONGKHOA_ThemPhanCong : Form
    {
        private PhanCongBLL _PhanCongBLL;
        private GiangVienBLL _GiangVienBLL;
        private KHMOBLL _KHMOBLL;
        List<GiangVienDTO> listGiangVienDTO;
        List<KHMODTO_TRUONGKHOA> listKHMODTO_TRUONGKHOA;
        public TRUONGKHOA_ThemPhanCong()
        {
            InitializeComponent();
            _GiangVienBLL = new GiangVienBLL();
            _KHMOBLL = new KHMOBLL();
            _PhanCongBLL = new PhanCongBLL();
            Load();
        }

        private void Load()
        {
            listGiangVienDTO = _GiangVienBLL.getAll();
            dtgviewGiangVien.DataSource = listGiangVienDTO;
            dtgviewGiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewGiangVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgviewGiangVien.MultiSelect = false;
            dtgviewGiangVien.ReadOnly = true;

            tbMAGV.KeyPress += GiangVien_TextChanged;
            tbHOTEN.KeyPress += GiangVien_TextChanged;
            tbSDT.KeyPress += GiangVien_TextChanged;
            tbCOSO.KeyPress += GiangVien_TextChanged;
            tbMADV.KeyPress += GiangVien_TextChanged;

            listKHMODTO_TRUONGKHOA = _KHMOBLL.getAll_TRUONGKHOA();
            dtgviewKHMO.DataSource = listKHMODTO_TRUONGKHOA;
            dtgviewKHMO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewKHMO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgviewKHMO.MultiSelect = false;
            dtgviewKHMO.ReadOnly = true;

            tbMAHP.TextChanged += KHMO_TextChanged;
            tbTENHP.TextChanged += KHMO_TextChanged;
            tbMADV.TextChanged += KHMO_TextChanged;
            tbHK.TextChanged += KHMO_TextChanged;
            tbMACT.TextChanged += KHMO_TextChanged;
            tbNAM.TextChanged += KHMO_TextChanged;
            tbHK.KeyPress += CheckNumeric;
            tbNAM.KeyPress += CheckNumeric;
        }

        private void CheckNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void KHMO_TextChanged(object sender, EventArgs e)
        {
            string MAHP = tbMAHP.Text.ToLower();
            string TENHP = tbTENHP.Text.ToLower();
            string MADV = tbMADV.Text.ToLower();
            string MACT = tbMACT.Text.ToLower();
            int HK = tbHK.Text != "" ? int.Parse(tbHK.Text) : -1;
            int NAM = tbNAM.Text != "" ? int.Parse(tbNAM.Text) : -1;
            List<KHMODTO_TRUONGKHOA> filteredList = listKHMODTO_TRUONGKHOA.Where(s =>
                s.MAHP.ToLower().Contains(MAHP) &&
                s.TENHP.ToLower().Contains(TENHP) &&
                s.MADV.ToLower().Contains(MADV) &&
                s.MACT.ToLower().Contains(MACT) &&
                (s.HK == HK || HK == -1) &&
                (s.NAM == NAM || NAM == -1)
                ).ToList();
            dtgviewKHMO.DataSource = null;
            dtgviewKHMO.DataSource = filteredList;
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
            dtgviewKHMO.DataSource = null;
            dtgviewKHMO.DataSource = filteredList;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowKHMO = dtgviewKHMO.SelectedRows[0];
            DataGridViewRow rowGiangVien = dtgviewGiangVien.SelectedRows[0];
            var _KHMODTO_TRUONGKHOA = (KHMODTO_TRUONGKHOA)rowKHMO.DataBoundItem;
            var _GiangVienDTO = (GiangVienDTO)rowGiangVien.DataBoundItem;
            string status = _PhanCongBLL.them(_GiangVienDTO.MAGV, _KHMODTO_TRUONGKHOA.MAHP, _KHMODTO_TRUONGKHOA.HK, _KHMODTO_TRUONGKHOA.NAM, _KHMODTO_TRUONGKHOA.MACT);
            if (status == "")
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                if(status.Contains("policy"))
                    MessageBox.Show("Phân công chứa học phần không thuộc quản lý của Văn Phòng Khoa");
                if(status.Contains("unique"))
                    MessageBox.Show("Phân công đã tồn tại");
            }
        }
    }
}
