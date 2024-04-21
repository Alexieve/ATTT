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
    public partial class NV_DanhSachKHMO : Form
    {
        KHMOBLL _KHMOBLL;
        List<KHMODTO> listKHMODTO;
        public NV_DanhSachKHMO()
        {
            InitializeComponent();
            _KHMOBLL = new KHMOBLL();
            load();
        }

        private void load()
        {
            listKHMODTO = _KHMOBLL.getAll();
            dtgviewKHMO.DataSource = listKHMODTO;
            dtgviewKHMO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewKHMO.ReadOnly = true;
            tbMAHP.TextChanged += TextChanged;
            tbTENHP.TextChanged += TextChanged;
            tbMADV.TextChanged += TextChanged;
            tbHK.TextChanged += TextChanged;
            tbSOTC.TextChanged += TextChanged;
            tbNAM.TextChanged += TextChanged;
            tbHK.KeyPress += CheckNumeric;
            tbSOTC.KeyPress += CheckNumeric;
            tbNAM.KeyPress += CheckNumeric;
        }

        private void CheckNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextChanged(object sender, EventArgs e)
        {
            string MAHP = tbMAHP.Text.ToLower();
            string TENHP = tbTENHP.Text.ToLower();
            string MADV = tbMADV.Text.ToLower();
            int HK = tbHK.Text != "" ? int.Parse(tbHK.Text) : -1;
            int SOTC = tbSOTC.Text != "" ? int.Parse(tbSOTC.Text) : -1;
            int NAM = tbNAM.Text != "" ? int.Parse(tbNAM.Text) : -1;
            List<KHMODTO> filteredList = listKHMODTO.Where(s =>
                s.MAHP.ToLower().Contains(MAHP) &&
                s.TENHP.ToLower().Contains(TENHP) &&
                s.MADV.ToLower().Contains(MADV) &&
                (s.HK == HK || HK == -1) &&
                (s.SOTC == SOTC || SOTC == -1) &&
                (s.NAM == NAM || NAM == -1) 
                ).ToList();
            dtgviewKHMO.DataSource = null;
            dtgviewKHMO.DataSource = filteredList;
        }
    }
}
