using System.Drawing.Printing;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class SV_DangKyHP : Form
    {
        private DangKyHPBLL dangKyHPBLL;
        public SV_DangKyHP()
        {
            InitializeComponent();
            dangKyHPBLL = new DangKyHPBLL();
            if (!dangKyHPBLL.checkTimeDangKyHP())
            {
                MessageBox.Show("Chưa đến thời gian đăng ký học phần");
            }
            else Load();
        }

        private void Load()
        {
            HPDaDKTable.Columns.Clear();
            List<DangKyHPDTO> listHPDaDK = dangKyHPBLL.getDaDK();
            HPDaDKTable.DataSource = listHPDaDK;
            HPDaDKTable.Columns[2].Visible = false;
            HPDaDKTable.Columns[6].Visible = false;
            HPDaDKTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HPDaDKTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            HPChuaDKTable.Columns.Clear();
            List<DangKyHPDTO> listHPChuaDK = dangKyHPBLL.getChuaDK();
            HPChuaDKTable.DataSource = listHPChuaDK;
            HPChuaDKTable.Columns[2].Visible = false;
            HPChuaDKTable.Columns[6].Visible = false;
            HPChuaDKTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HPChuaDKTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            setColumnName();
        }


        private void setColumnName()
        {
            HPDaDKTable.Columns[0].HeaderText = "Mã HP";
            HPDaDKTable.Columns[1].HeaderText = "Tên HP";
            HPDaDKTable.Columns[3].HeaderText = "Tên GV";
            HPDaDKTable.Columns[4].HeaderText = "Số TC";
            HPDaDKTable.Columns[5].HeaderText = "Số SV";
            //HPDaDKTable.Columns[6].HeaderText = "Đã ĐK";

            HPChuaDKTable.Columns[0].HeaderText = "Mã HP";
            HPChuaDKTable.Columns[1].HeaderText = "Tên HP";
            HPChuaDKTable.Columns[3].HeaderText = "Tên GV";
            HPChuaDKTable.Columns[4].HeaderText = "Số TC";
            HPChuaDKTable.Columns[5].HeaderText = "Số SV";
            //HPChuaDKTable.Columns[6].HeaderText = "Đã ĐK";
        }

        private void HuyBtn_Click(object sender, EventArgs e)
        {
            if (HPDaDKTable.SelectedCells.Count == 0) return;
            int rowIndex = HPDaDKTable.SelectedCells[0].RowIndex;
            if (rowIndex < 0) return;
            string MAGV = HPDaDKTable.Rows[rowIndex].Cells[2].Value.ToString();
            string MAHP = HPDaDKTable.Rows[rowIndex].Cells[0].Value.ToString();
            dangKyHPBLL.HuyHP(MAGV, MAHP);
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
            dangKyHPBLL.DangKyHP(MAGV, MAHP);
            Load();
            MessageBox.Show("Đăng ký học phần thành công");
        }
    }
}
