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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PH2.GUI
{
    public partial class GIAOVU_HP_CapNhat : Form
    {
        private HocPhanBLL hpBLL = new HocPhanBLL();
        public GIAOVU_HP_CapNhat()
        {
            InitializeComponent();
            LoadNamHKCbb();
        }
        private void LoadNamHKCbb()
        {
            //HKNamCbb.Items.Add("Tất cả học kỳ và năm học");
            List<string> hkNamList = hpBLL.getAllMaNganh();
            foreach (string hkNam in hkNamList)
            {
                HKNamCbb.Items.Add(hkNam);
            }
            HKNamCbb.SelectedIndex = 0;
        }
        public void Loadd(string MyString)
        {
            HocPhanDTO svDTO = hpBLL.getProfile2(MyString);
            //SinhVienDTO svDTO = svBLL.getProfile2("a");

            textBox1.Text = svDTO.MAHP;
            textBox2.Text = svDTO.TENHP;
            textBox3.Text = svDTO.SOTC.ToString();
            textBox4.Text = svDTO.STLT.ToString();
            textBox5.Text = svDTO.STTH.ToString();
            textBox6.Text = svDTO.SOSVTD.ToString();
            textBox7.Text = svDTO.MADV;

        }
        private void button3_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocPhanDTO sv = new HocPhanDTO();
            sv.MAHP = textBox1.Text;
            sv.TENHP = textBox2.Text;
            //sv.SOTC = textBox3.Text;
            //sv.STLT = textBox4.Text;
            //sv.STTH = textBox5.Text;
            //sv.SOSVTD = textBox6.Text;
            sv.MADV = HKNamCbb.SelectedItem.ToString();
            int tmp1 = -1, tmp2 = -1, tmp3 = -1, tmp4 = -1;
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text)
                || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                sv.SOTC = -1;
                sv.STLT = -1;
                sv.STTH = -1;
                sv.SOSVTD = -1;
            }
            else if (int.TryParse(textBox3.Text, out tmp1) && int.TryParse(textBox4.Text, out tmp2)
                && int.TryParse(textBox5.Text, out tmp3) && int.TryParse(textBox6.Text, out tmp4))
            {
                sv.SOTC = tmp1;
                sv.STLT = tmp2;
                sv.STTH = tmp3;
                sv.SOSVTD = tmp4;
            }
            else
            {
                sv.SOTC = -1;
                sv.STLT = -1;
                sv.STTH = -1;
                sv.SOSVTD = -1;
            }
            int tmp = hpBLL.UpdateHocPhan(sv);
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
