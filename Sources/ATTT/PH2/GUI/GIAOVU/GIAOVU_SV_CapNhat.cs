using PH2.BLL;
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
            LoadNamHKCbb();
        }
        private void LoadNamHKCbb()
        {
            //HKNamCbb.Items.Add("Tất cả học kỳ và năm học");
            List<string> hkNamList = svBLL.getAllMaNganh();
            foreach (string hkNam in hkNamList)
            {
                HKNamCbb.Items.Add(hkNam);
            }
            HKNamCbb.SelectedIndex = 0;
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Add("CLC");
            comboBox2.Items.Add("VP");
            comboBox2.Items.Add("CQ");
            comboBox2.Items.Add("CTTT");
            comboBox2.SelectedIndex = 0;
            comboBox3.Items.Add("CS1");
            comboBox3.Items.Add("CS2");
            comboBox3.SelectedIndex = 0;
        }
        public void Loadd(string MyString)
        {
            GVU_SinhVienDTO svDTO = svBLL.getProfile2(MyString);
            //SinhVienDTO svDTO = svBLL.getProfile2("a");

            textBox1.Text = svDTO.MASV;
            textBox2.Text = svDTO.HOTEN;
            textBox3.Text = svDTO.PHAI;
            textBox4.Text = svDTO.NGSINH;
            textBox5.Text = svDTO.DCHI;
            textBox6.Text = svDTO.SDT;
            textBox7.Text = svDTO.MACT;
            textBox8.Text = svDTO.MANGANH;
            textBox9.Text = svDTO.COSO;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GVU_SinhVienDTO sv = new GVU_SinhVienDTO();
            sv.MASV = textBox1.Text;
            sv.HOTEN = textBox2.Text;
            sv.PHAI = comboBox1.SelectedItem.ToString();
            sv.NGSINH = textBox4.Text;
            sv.DCHI = textBox5.Text;
            sv.SDT = textBox6.Text;
            sv.MACT = comboBox2.SelectedItem.ToString();
            sv.MANGANH = HKNamCbb.SelectedItem.ToString();
            //sv.SOTCTL = int.Parse(textBox9.Text); 
            //sv.DTBTL = float.Parse(textBox10.Text);
            sv.COSO = comboBox3.SelectedItem.ToString();
            
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
