﻿using PH2.BLL;
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
using static System.Net.Mime.MediaTypeNames;

namespace PH2.GUI.TRUONGKHOA
{
    public partial class TRUONGKHOA_BangPhanCong : Form
    {
        private PhanCongBLL _PhanCongBLL;
        List<PhanCongTKDTO> _PhanCongDTOList;
        public TRUONGKHOA_BangPhanCong()
        {
            InitializeComponent();
            _PhanCongBLL = new PhanCongBLL();
            Load();
        }

        public void Load()
        {
            _PhanCongDTOList = _PhanCongBLL.getAll();
            dtgvPhanCong.DataSource = _PhanCongDTOList;
            dtgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPhanCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvPhanCong.MultiSelect = false;
            dtgvPhanCong.ReadOnly = true;
            dtgvPhanCong.AllowUserToDeleteRows = true;
            tbHK.TextChanged += TextChanged;
            tbMACT.TextChanged += TextChanged;
            tbMAGV.TextChanged += TextChanged;
            tbMAHP.TextChanged += TextChanged;
            tbNAM.TextChanged += TextChanged;
            tbMADV.TextChanged += TextChanged;
            tbHK.KeyPress += CheckNumeric;
            tbNAM.KeyPress += CheckNumeric;
            setColumnName();
        }

        private void setColumnName()
        {
            dtgvPhanCong.Columns[0].HeaderText = "Mã Giáo Viên";
            dtgvPhanCong.Columns[1].HeaderText = "Mã Học Phần";
            dtgvPhanCong.Columns[2].HeaderText = "Học Kỳ";
            dtgvPhanCong.Columns[3].HeaderText = "Năm";
            dtgvPhanCong.Columns[4].HeaderText = "Mã Chương Trình";
            dtgvPhanCong.Columns[5].HeaderText = "Mã Đơn Vị";
        }

        private void CheckNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextChanged(object sender, EventArgs e)
        {
            string MACT = tbMACT.Text.ToLower();
            string MAGV = tbMAGV.Text.ToLower();
            string MAHP = tbMAHP.Text.ToLower();
            string MADV = tbMADV.Text.ToLower();
            int HK = tbHK.Text != "" ? int.Parse(tbHK.Text) : -1;
            int NAM = tbNAM.Text != "" ? int.Parse(tbNAM.Text) : -1;
            List<PhanCongTKDTO> filteredList = _PhanCongDTOList.Where(s =>
                s.MACT.ToLower().Contains(MACT) &&
                s.MAGV.ToLower().Contains(MAGV) &&
                s.MAHP.ToLower().Contains(MAHP) &&
                s.MADV.ToLower().Contains(MADV) &&
                (s.HK == HK || HK == -1) &&
                (s.NAM == NAM || NAM == -1)
                ).ToList();
            dtgvPhanCong.DataSource = null;
            dtgvPhanCong.DataSource = filteredList;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dtgvPhanCong.SelectedRows[0];
            var phanCongDTO = (PhanCongTKDTO)row.DataBoundItem;

            bool check = _PhanCongBLL.checkDK(phanCongDTO.MAGV, phanCongDTO.MAHP, phanCongDTO.HK, phanCongDTO.NAM, phanCongDTO.MACT);
            if (!check)
            {
                YesNoDialog yesNoDialog = new YesNoDialog();
                DialogResult result = yesNoDialog.ShowDialog();
                if (result == DialogResult.No)
                    return;
            }

            int deleteCount = _PhanCongBLL.delete(phanCongDTO.MAGV, phanCongDTO.MAHP, phanCongDTO.HK, phanCongDTO.NAM, phanCongDTO.MACT);
            if (deleteCount == 1)
            {
                MessageBox.Show("Xóa thành công");
                _PhanCongDTOList.Remove(phanCongDTO);
                TextChanged(null, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Phân công chứa học phần không thuộc quản lý của Văn Phòng Khoa");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TRUONGKHOA_ThemPhanCong _ThemPhanCong = new TRUONGKHOA_ThemPhanCong();
            _ThemPhanCong.StartPosition = FormStartPosition.CenterScreen;
            _ThemPhanCong.Text = "Thêm Phân Công";
            _ThemPhanCong.ShowDialog();
            Load();
            TextChanged(null, EventArgs.Empty);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvPhanCong.SelectedRows[0];
            var phanCongDTO = (PhanCongTKDTO)row.DataBoundItem;
            TRUONGKHOA_SuaPhanCong _SuaPhanCong = new TRUONGKHOA_SuaPhanCong(phanCongDTO.MAGV, phanCongDTO.HK, phanCongDTO.NAM, phanCongDTO.MAHP, phanCongDTO.MACT);
            _SuaPhanCong.StartPosition = FormStartPosition.CenterScreen;
            _SuaPhanCong.Text = "Sửa Phân Công";
            _SuaPhanCong.ShowDialog();
            Load();
            TextChanged(null, EventArgs.Empty);
        }
    }
}
