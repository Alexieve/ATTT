using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class GIAOVU_KHMO_Them : Form
    {
        private GVU_KHMOBLL svBLL = new GVU_KHMOBLL();
        public GIAOVU_KHMO_Them()
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
            GVU_KHMODTO sv = new GVU_KHMODTO();
            sv.MAHP = textBox1.Text;
            //sv.HK = textBox2.Text;
            //sv.NAM = textBox3.Text;
            sv.MACT = textBox4.Text;

            //sv.SOTCTL = int.Parse(textBox9.Text); 
            //sv.DTBTL = float.Parse(textBox10.Text);
            int sotctl;
            int dtbtl;
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                sv.HK = -1;
                sv.NAM = -1;
            }
            else if (int.TryParse(textBox2.Text, out sotctl) && int.TryParse(textBox3.Text, out dtbtl))
            {
                sv.HK = sotctl;
                sv.NAM = dtbtl;
            }
            int tmp = svBLL.AddKHMO(sv);
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
