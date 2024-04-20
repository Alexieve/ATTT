using System;
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
    public partial class GIAOVU_SV_Them : Form
    {
        private SinhVienBLL svBLL = new SinhVienBLL();
        public GIAOVU_SV_Them()
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
            SinhVienDTO sv  = new SinhVienDTO();
            sv.MASV = textBox1.Text;
            sv.HOTEN = textBox2.Text;
            sv.PHAI = textBox3.Text;
            sv.NGSINH = textBox4.Text;
            sv.DCHI =  textBox5.Text;
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
            int tmp = svBLL.AddSinhVien(sv);
            if (tmp == 1)
            {
                MessageBox.Show("Thêm thành công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if(tmp == 0) MessageBox.Show("Vui lòng kiểm tra lại hoặc có lỗi xảy ra!");


        }
    }
}
