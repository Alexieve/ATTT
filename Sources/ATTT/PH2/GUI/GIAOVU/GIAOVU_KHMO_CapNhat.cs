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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PH2.GUI
{
    public partial class GIAOVU_KHMO_CapNhat : Form
    {
        private GVU_KHMOBLL svBLL = new GVU_KHMOBLL();
        public GIAOVU_KHMO_CapNhat()
        {
            InitializeComponent();
        }
        public void Loadd(string MyString, string MyString2, string MyString3, string MyString4)
        {
            textBox1.Text = MyString;
            textBox2.Text = MyString2;
            textBox3.Text = MyString3;
            textBox4.Text = MyString4;

            textBox5.Text = MyString;
            textBox6.Text = MyString2;
            textBox7.Text = MyString3;
            textBox8.Text = MyString4;

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
            //sv.HOTEN = textBox2.Text;
            //sv.PHAI = textBox3.Text;
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
            GVU_KHMODTO sv2 = new GVU_KHMODTO();
            sv2.MAHP = textBox5.Text;
            sv2.MACT = textBox8.Text;
            //sv2.HK = int.Parse(textBox6.Text);
            //sv2.NAM = int.Parse(textBox7.Text);
            int sotctl2;
            int dtbtl2;
            if (string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
            {
                sv2.HK = -1;
                sv2.NAM = -1;
            }
            else if (int.TryParse(textBox6.Text, out sotctl) && int.TryParse(textBox7.Text, out dtbtl))
            {
                sv2.HK = sotctl;
                sv2.NAM = dtbtl;
            }
            int tmp = svBLL.UpdateKHMO(sv,sv2);
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
