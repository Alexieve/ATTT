using PH2.BLL;
using PH2.DAL;
using PH2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH2.GUI.TRUONGDV
{
    public partial class TruongDV_XemPC : Form
    {
        private XemPhanCongBLL XemPCBLL;
        private string Old_MAGV_Value;
        public TruongDV_XemPC()
        {
            InitializeComponent();
            ComboHK.Items.Add(1);
            ComboHK.Items.Add(2);
            ComboHK.Items.Add(3);
            ComboMACT.Items.Add("CLC");
            ComboMACT.Items.Add("VP");
            ComboMACT.Items.Add("CQ");
            ComboMACT.Items.Add("CTTT");
            ComboNam.Items.Add(DateTime.Now.Year);
            XemPCBLL = new XemPhanCongBLL();
            List<string> listGV = XemPCBLL.GetMAGV();
            List<string> listHP = XemPCBLL.GetMAHP();
            ComboMAGV.DataSource = listGV;
            MAGV.DataSource = listGV;
            ComboMAGV.DisplayMember = "MANV";
            ComboMAHP.DataSource = listHP;
            ComboMAHP.DisplayMember = "MAHP";
            Load();
        }
        private void Load()
        {

            dataGridView1.Columns.Clear();
            List<PhanCongDTO> danhSachPC = XemPCBLL.GetPC();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachPC;
            setColumnName();
        }
        private void setColumnName()
        {
            dataGridView1.Columns[0].HeaderText = "Mã Giáo Viên";
            //dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Mã Học Phần";
            //dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Tên Giáo Viên";
            dataGridView1.Columns[3].HeaderText = "Tên Học Phần";

            dataGridView1.Columns[4].HeaderText = "Học Kì";
            dataGridView1.Columns[5].HeaderText = "Năm";
            dataGridView1.Columns[6].HeaderText = "Mã Chương Trình";
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) return;
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            if (rowIndex < 0) return;
            string MAGV = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string MAHP = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            string tmp = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            int HK = Int32.Parse(tmp);
            tmp = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            int NAM = Int32.Parse(tmp);
            string MACT = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Dữ liệu của lớp giảng dạy có thể bị mất!", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    XemPCBLL.DeleteRow(MAGV, MAHP, HK, NAM, MACT);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khóa ngoại!");
                    return;
                }
                Load();
                MessageBox.Show("Xóa phân công thành công!");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ComboMAGV.SelectedItem == null || ComboMAHP.SelectedItem == null || ComboHK.SelectedItem == null || ComboNam.SelectedItem == null || ComboMACT.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }
            string MAGV = ComboMAGV.SelectedItem.ToString();
            string MAHP = ComboMAHP.SelectedItem.ToString();
            string tmp = ComboHK.SelectedItem.ToString();
            int HK = Int32.Parse(tmp);
            tmp = ComboNam.SelectedItem.ToString();
            int NAM = Int32.Parse(tmp);
            string MACT = ComboMACT.SelectedItem.ToString();
            try
            {
                XemPCBLL.AddRow(MAGV, MAHP, HK, NAM, MACT);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("policy"))
                {
                    MessageBox.Show("Vi phạm chính sách VPD!");
                }
                else if (ex.Message.Contains("unique constraint"))
                {
                    MessageBox.Show("Kế hoạch đã được đăng ký!");
                }
                else
                {
                    MessageBox.Show("Kế hoạch mở không có học phần này!");
                }
                return;
            }
            MessageBox.Show("Thêm vào thành công!");
            Load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            MAHPBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            HKBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            NAMBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            MACTBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Old_MAGV_Value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string MaGV = MAGV.SelectedItem.ToString();
            string MaHP = MAHPBox.Text;
            int HK = 0;
            int NAM = 0;
            try
            {
                HK = int.Parse(HKBox.Text);
                NAM = int.Parse(NAMBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật!", "Thông báo");
                return;
            }
            string MACT = MACTBox.Text;
            DialogResult dialogResult = MessageBox.Show("Dữ liệu của lớp giảng dạy có thể bị mất!", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    XemPCBLL.UpdateRow(MaGV, MaHP, HK, NAM, MACT, Old_MAGV_Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Cập nhật thành công!");
                Load();
            }

        }
    }
}
