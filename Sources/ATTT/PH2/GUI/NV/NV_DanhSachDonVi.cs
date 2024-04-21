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
    public partial class NV_DanhSachDonVi : Form
    {
        DonViBLL _DonViBLL;
        List<DonViDTO> listDonViDTO;
        public NV_DanhSachDonVi()
        {
            InitializeComponent();
            _DonViBLL = new DonViBLL();
            load();
        }

        private void load()
        {
            listDonViDTO = _DonViBLL.getALL();
            dtgviewDonVi.DataSource = listDonViDTO;
            dtgviewDonVi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewDonVi.ReadOnly = true;
            tbMaDV.TextChanged += TextChanged;
            tbTen.TextChanged += TextChanged;
            tbTruongDV.TextChanged += TextChanged;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            string Ten = tbTen.Text.ToLower();
            string MaDV = tbMaDV.Text.ToLower();
            string TruongDV = tbTruongDV.Text.ToLower();
            List<DonViDTO> filteredList = listDonViDTO.Where(s =>
                s.MADV.ToLower().Contains(MaDV) &&
                s.TENDV.ToLower().Contains(Ten) &&
                s.TRUONGDV.ToLower().Contains(TruongDV)
                ).ToList();
            dtgviewDonVi.DataSource = null;
            dtgviewDonVi.DataSource = filteredList;
        }
    }
}
