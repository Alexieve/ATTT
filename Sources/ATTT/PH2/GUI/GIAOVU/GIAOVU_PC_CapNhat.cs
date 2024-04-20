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
using PH2.DTO;
using PH2.DAL;

namespace PH2.GUI
{ 
    public partial class GIAOVU_PC_CapNhat : Form
    {
        private GVU_PhanCongBLL svBLL = new GVU_PhanCongBLL();
        public GIAOVU_PC_CapNhat()
        {
            InitializeComponent();
        }
    public void Loadd(string MyString, string MyString2, string MyString3, string MyString4, string MyString5)
    {
        textBox1.Text = MyString;
        textBox2.Text = MyString2;
        textBox3.Text = MyString3;
        textBox4.Text = MyString4;
        textBox5.Text = MyString5;


        textBox6.Text = MyString;
        textBox7.Text = MyString2;
        textBox8.Text = MyString3;
            textBox9.Text = MyString4;
            textBox10.Text = MyString5;

        }
    private void button3_Click(object sender, EventArgs e)
    {

        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        GVU_PhanCongDTO sv = new GVU_PhanCongDTO();
        sv.MAGV = textBox1.Text;
        sv.MAHP = textBox2.Text;
        //sv.HK = textBox2.Text;
        //sv.NAM = textBox3.Text;
        sv.MACT = textBox5.Text;

        //sv.SOTCTL = int.Parse(textBox9.Text); 
        //sv.DTBTL = float.Parse(textBox10.Text);
        int sotctl;
        int dtbtl;
        if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
        {
            sv.HK = -1;
            sv.NAM = -1;
        }
        else if (int.TryParse(textBox3.Text, out sotctl) && int.TryParse(textBox4.Text, out dtbtl))
        {
            sv.HK = sotctl;
            sv.NAM = dtbtl;
        }
        GVU_PhanCongDTO sv2 = new GVU_PhanCongDTO();
        sv2.MAGV = textBox6.Text;
        sv2.MAHP = textBox7.Text;
        //sv2.HK = int.Parse(textBox6.Text);
        //sv2.NAM = int.Parse(textBox7.Text);
        sv2.MACT = textBox10.Text;
        int sotctl2;
        int dtbtl2;
        if (string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text))
        {
            sv2.HK = -1;
            sv2.NAM = -1;
        }
        else if (int.TryParse(textBox8.Text, out sotctl) && int.TryParse(textBox9.Text, out dtbtl))
        {
            sv2.HK = sotctl;
            sv2.NAM = dtbtl;
        }
        int tmp = svBLL.UpdatePhanCong(sv, sv2);
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
