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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PH2.GUI
{
    public partial class GIAOVU_DV_CapNhat : Form
    {
        private DonViBLL dvBLL = new DonViBLL();
        public GIAOVU_DV_CapNhat()
        {
            InitializeComponent();
            LoadNamHKCbb();
        }
        private void LoadNamHKCbb()
        {
            //HKNamCbb.Items.Add("Tất cả học kỳ và năm học");
            List<string> hkNamList = dvBLL.getAllMaHoTenGV();
            foreach (string hkNam in hkNamList)
            {
                HKNamCbb.Items.Add(hkNam);
            }
            HKNamCbb.SelectedIndex = 0;
        }
        public void Loadd(string MyString)
        {
            DonViDTO svDTO = dvBLL.getProfile2(MyString);
            //SinhVienDTO svDTO = svBLL.getProfile2("a");

            textBox1.Text = svDTO.MADV;
            textBox2.Text = svDTO.TENDV;
            textBox3.Text = svDTO.TRUONGDV;
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
            string[] hkNam = HKNamCbb.SelectedItem.ToString().Split(" - ");
            sv.TRUONGDV = hkNam[0];
            //sv.TRUONGDV = textBox3.Text;
            
            int tmp = dvBLL.UpdateDonVi(sv);
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
