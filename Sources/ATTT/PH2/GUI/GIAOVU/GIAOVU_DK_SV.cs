using System.Drawing.Printing;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class GIAOVU_DK_SV : Form
    {
        private DangKyHPBLL dangKyHPBLL =  new DangKyHPBLL();
        public string MyString = "";

        public void SetMyString(string value)
        {
            MyString = value;
        }
        public GIAOVU_DK_SV()
        {
            InitializeComponent();
            
            //if (!dangKyHPBLL.checkTimeDangKyHP())
            //{
            //    MessageBox.Show("Chưa đến thời gian đăng ký học phần");
            //    MyString = "";
            //}
            ////else Load();
        }
        public void Check()
        {
            if (!dangKyHPBLL.checkTimeDangKyHP())
            {
                MessageBox.Show("Chưa đến thời gian đăng ký học phần");
            }
            else Load();
        }
        public void Load()
        {
            HPDaDKTable.Columns.Clear();
            List<DangKyHPDTO> listHPDaDK = dangKyHPBLL.getDaDK2(MyString);
            HPDaDKTable.DataSource = listHPDaDK;
            //HPDaDKTable.Columns[2].Visible = false;
            HPDaDKTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HPDaDKTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            HPChuaDKTable.Columns.Clear();
            List<DangKyHPDTO> listHPChuaDK = dangKyHPBLL.getChuaDK(MyString);
            HPChuaDKTable.DataSource = listHPChuaDK;
            //HPChuaDKTable.Columns[2].Visible = false;
            HPChuaDKTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HPChuaDKTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            setColumnName();
        }


        private void setColumnName()
        {
            HPDaDKTable.Columns[0].HeaderText = "Mã HP";
            HPDaDKTable.Columns[1].HeaderText = "Tên HP";
            HPDaDKTable.Columns[2].HeaderText = "Mã GV";
            HPDaDKTable.Columns[3].HeaderText = "Học Kì - Năm";
            HPDaDKTable.Columns[4].HeaderText = "Số TC";
            HPDaDKTable.Columns[5].HeaderText = "Số SV";
            HPDaDKTable.Columns[6].HeaderText = "Đã ĐK";

            HPChuaDKTable.Columns[0].HeaderText = "Mã HP";
            HPChuaDKTable.Columns[1].HeaderText = "Tên HP";
            HPChuaDKTable.Columns[2].HeaderText = "Mã GV";
            HPChuaDKTable.Columns[3].HeaderText = "Học Kì - Năm";
            HPChuaDKTable.Columns[4].HeaderText = "Số TC";
            HPChuaDKTable.Columns[5].HeaderText = "Số SV";
            HPChuaDKTable.Columns[6].HeaderText = "Đã ĐK";
        }

        private void HuyBtn_Click(object sender, EventArgs e)
        {
            if (HPDaDKTable.SelectedCells.Count == 0) return;
            int rowIndex = HPDaDKTable.SelectedCells[0].RowIndex;
            if (rowIndex < 0) return;
            string MAGV = HPDaDKTable.Rows[rowIndex].Cells[2].Value.ToString();
            string MAHP = HPDaDKTable.Rows[rowIndex].Cells[0].Value.ToString();
            dangKyHPBLL.HuyHP(MAGV, MAHP, MyString);
            Load();
            MessageBox.Show("Hủy học phần thành công");
        }

        private void DKBtn_Click(object sender, EventArgs e)
        {
            if (HPChuaDKTable.SelectedCells.Count == 0) return;
            int rowIndex = HPChuaDKTable.SelectedCells[0].RowIndex;
            if (rowIndex < 0) return;
            string MAGV = HPChuaDKTable.Rows[rowIndex].Cells[2].Value.ToString();
            string MAHP = HPChuaDKTable.Rows[rowIndex].Cells[0].Value.ToString();
            dangKyHPBLL.DangKyHP(MAGV, MAHP, MyString);
            Load();
            MessageBox.Show("Đăng ký học phần thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
