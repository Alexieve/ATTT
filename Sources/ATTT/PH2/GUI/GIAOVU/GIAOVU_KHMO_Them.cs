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
    public partial class GIAOVU_KHMO_Them : Form
    {
        private GVU_KHMOBLL svBLL = new GVU_KHMOBLL();
        public GIAOVU_KHMO_Them()
        {
            InitializeComponent();
            LoadNamHKCbb();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GVU_KHMODTO sv = new GVU_KHMODTO();
            //sv.MAHP = textBox1.Text;
            sv.MAHP = HKNamCbb.SelectedItem.ToString();
            //sv.HK = textBox2.Text;
            //sv.NAM = textBox3.Text;
            sv.MACT = comboBox1.SelectedItem.ToString();

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
            else
            {
                sv.HK = -1;
                sv.NAM = -1;
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
        private void LoadNamHKCbb()
        {
            //HKNamCbb.Items.Add("Tất cả học kỳ và năm học");
            List<string> hkNamList = svBLL.getAllHP();
            foreach (string hkNam in hkNamList)
            {
                HKNamCbb.Items.Add(hkNam);
            }
            HKNamCbb.SelectedIndex = 0;
            comboBox1.Items.Add("CLC");
            comboBox1.Items.Add("VP");
            comboBox1.Items.Add("CQ");
            comboBox1.Items.Add("CTTT");
            comboBox1.SelectedIndex = 0;
        }
    }
}
