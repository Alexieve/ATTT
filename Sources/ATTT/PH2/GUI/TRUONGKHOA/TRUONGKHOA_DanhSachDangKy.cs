using PH2.BLL;
using PH2.DTO;
using PH2.GUI.GIANGVIEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH2.GUI.TRUONGKHOA
{
    public partial class TRUONGKHOA_DanhSachDangKy : Form
    {
        DangKyBLL _DangKyBLL;
        List<DangKyTKDTO> listDangKyDTO;
        public TRUONGKHOA_DanhSachDangKy()
        {
            InitializeComponent();
            _DangKyBLL = new DangKyBLL();
            load();
        }

        private void load()
        {
            listDangKyDTO = _DangKyBLL.getAll();
            dtgviewDangKy.DataSource = listDangKyDTO;
            dtgviewDangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewDangKy.ReadOnly = true;

            tbMASV.TextChanged += TextChanged;
            tbMAGV.TextChanged += TextChanged;
            tbMAHP.TextChanged += TextChanged;
            tbMACT.TextChanged += TextChanged;
            tbHK.TextChanged += TextChanged;
            tbNAM.TextChanged += TextChanged;
            tbDIEMTH.TextChanged += TextChanged;
            tbDIEMQT.TextChanged += TextChanged;
            tbDIEMCK.TextChanged += TextChanged;
            tbDIEMTK.TextChanged += TextChanged;

            tbHK.KeyPress += CheckNumeric;
            tbNAM.KeyPress += CheckNumeric;

            tbDIEMTH.KeyPress += CheckFloat;
            tbDIEMQT.KeyPress += CheckFloat;
            tbDIEMCK.KeyPress += CheckFloat;
            tbDIEMTK.KeyPress += CheckFloat;
        }

        private void CheckNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CheckFloat(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1 || (sender as TextBox).Text.Length == 0)
                    e.Handled = true;
            }
        }

        private void TextChanged(object sender, EventArgs e)
        {
            string MASV = tbMASV.Text.ToLower();
            string MAGV = tbMAGV.Text.ToLower();
            string MAHP = tbMAHP.Text.ToLower();
            string MACT = tbMACT.Text.ToLower();
            int HK = tbHK.Text != "" ? int.Parse(tbHK.Text) : -1;
            int NAM = tbNAM.Text != "" ? int.Parse(tbNAM.Text) : -1;
            float DIEMTH = tbDIEMTH.Text != "" ? float.Parse(tbDIEMTH.Text) : -1;
            float DIEMQT = tbDIEMQT.Text != "" ? float.Parse(tbDIEMQT.Text) : -1;
            float DIEMCK = tbDIEMCK.Text != "" ? float.Parse(tbDIEMCK.Text) : -1;
            float DIEMTK = tbDIEMTK.Text != "" ? float.Parse(tbDIEMTK.Text) : -1;

            List<DangKyTKDTO> filteredList = listDangKyDTO.Where(s =>
                s.MASV.ToLower().Contains(MASV) &&
                s.MAGV.ToLower().Contains(MAGV) &&
                s.MAHP.ToLower().Contains(MAHP) &&
                s.MACT.ToLower().Contains(MACT) &&
                (s.HK == HK || HK == -1) &&
                (s.NAM == NAM || NAM == -1) &&
                (s.DIEMTK == DIEMTK || DIEMTK == -1) &&
                (s.DIEMTH == DIEMTH || DIEMTH == -1) &&
                (s.DIEMQT == DIEMQT || DIEMQT == -1) &&
                (s.DIEMCK == DIEMCK || DIEMCK == -1)
                ).ToList();
            dtgviewDangKy.DataSource = null;
            dtgviewDangKy.DataSource = filteredList;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            GV_XemDangKy _GV_XemDangKy = new GV_XemDangKy();
            _GV_XemDangKy.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            _GV_XemDangKy.ShowDialog();
            load();
        }
    }
}
