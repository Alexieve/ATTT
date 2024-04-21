﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;
namespace PH2.GUI
{
    public partial class GIAOVU_DV_Them : Form
    {
        private DonViBLL dvBLL = new DonViBLL();
        public GIAOVU_DV_Them()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DonViDTO sv = new DonViDTO();
            sv.MADV = textBox1.Text;
            sv.TENDV = textBox2.Text;
            sv.TRUONGDV = textBox3.Text;

            int tmp = dvBLL.AddDonVi(sv);
            if (tmp == 1)
            {
                MessageBox.Show("Thêm thành công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (tmp == 0) MessageBox.Show("Vui lòng kiểm tra lại hoặc có lỗi xảy ra!");
        }
    }
}
