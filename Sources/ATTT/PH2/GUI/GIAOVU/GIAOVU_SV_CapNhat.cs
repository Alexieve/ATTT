﻿using PH2.BLL;
using PH2.DTO;
using PH2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH2.GUI
{
    
    public partial class GIAOVU_SV_CapNhat : Form
    {
        //public string MyString = "";

        //public void SetMyString(string value)
        //{
        //    MyString = value;
        //}
        private SinhVienBLL svBLL = new SinhVienBLL();
        public GIAOVU_SV_CapNhat()
        {
            InitializeComponent();
            //if (MyString != null)
            //    Loadd();
            //Loadd();
        }
        public void Loadd(string MyString)
        {
            SinhVienDTO svDTO = svBLL.getProfile2(MyString);
            //SinhVienDTO svDTO = svBLL.getProfile2("a");

            textBox1.Text = svDTO.MASV;
            textBox2.Text = svDTO.HOTEN;
            textBox3.Text = svDTO.PHAI;
            textBox4.Text = svDTO.NGSINH;
            textBox5.Text = svDTO.DCHI;
            textBox6.Text = svDTO.SDT;
            textBox7.Text = svDTO.MACT;
            textBox8.Text = svDTO.MANGANH;
            textBox9.Text = svDTO.SOTCTL.ToString();
            textBox10.Text = svDTO.DTBTL.ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.MASV = textBox1.Text;
            sv.HOTEN = textBox2.Text;
            sv.PHAI = textBox3.Text;
            sv.NGSINH = textBox4.Text;
            sv.DCHI = textBox5.Text;
            sv.SDT = textBox6.Text;
            sv.MACT = textBox7.Text;
            sv.MANGANH = textBox8.Text;
            //sv.SOTCTL = int.Parse(textBox9.Text); 
            //sv.DTBTL = float.Parse(textBox10.Text);
            int sotctl;
            float dtbtl;
            if (string.IsNullOrWhiteSpace(textBox9.Text) || string.IsNullOrWhiteSpace(textBox10.Text))
            {
                sv.SOTCTL = -1;
                sv.DTBTL = -1;
            }
            else if (int.TryParse(textBox9.Text, out sotctl) && float.TryParse(textBox10.Text, out dtbtl))
            {
                sv.SOTCTL = sotctl;
                sv.DTBTL = dtbtl;
            }
            int tmp = svBLL.UpdateSinhVien(sv);
            if (tmp == 1)
            {
                MessageBox.Show("Cập nhật thành công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (tmp == 0) MessageBox.Show("Vui lòng kiểm tra lại hoặc có lỗi xảy ra!");


        }
    }
}
