using PH2.BLL;
using PH2.DTO;
using System.Data;
using System.Windows.Forms;

namespace PH2.GUI.GIANGVIEN
{
    public partial class GV_XemDangKy : Form
    {
        string prevValue;
        private XemDangKyBLL XemDangKyBLL;
        public GV_XemDangKy()
        {
            InitializeComponent();
            XemDangKyBLL = new XemDangKyBLL();
            Load();
        }
        private void Load()
        {
            dataGridView1.Columns.Clear();
            List<DangKyDTO> danhSachDK = XemDangKyBLL.GetDangKyGV();
            //foreach (var array in danhSachDK)
            //{
            //    dataGridView1.Rows.Add(array.MASV, array.MAGV, array.HOTEN, array.MAHP, array.TENHP, array.HK, array.NAM, array.MACT, array.DIEMTH, array.DIEMQT, array.DIEMCK, array.DIEMTK);
            //}
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachDK;
            setColumnName();
        }
        private void setColumnName()
        {
            dataGridView1.Columns[0].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns[1].HeaderText = "Mã Giáo Viên";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Tên Sinh Viên";
            dataGridView1.Columns[3].HeaderText = "Mã Học Phần";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Tên Học Phần";
            dataGridView1.Columns[5].HeaderText = "Học Kì";
            dataGridView1.Columns[6].HeaderText = "Năm";
            dataGridView1.Columns[7].HeaderText = "Mã Chương Trình";
            dataGridView1.Columns[8].HeaderText = "Điểm Thực Hành";
            dataGridView1.Columns[9].HeaderText = "Điểm Quá Trình";
            dataGridView1.Columns[10].HeaderText = "Điểm Cuối Kì";
            dataGridView1.Columns[11].HeaderText = "Điểm Tổng Kết";
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Điểm không hợp lệ!", "Thông báo");
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = prevValue;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string DIEM = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (!XemDangKyBLL.CheckConvert(DIEM))
            {
                MessageBox.Show("Điểm không hợp lệ!", "Thông báo");
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = prevValue;
                return;
            }
            string MASV = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string MAGV = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string HOTEN = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string MAHP = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string TENHP = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string tmp = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string DIEMTH = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            string DIEMQT = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            string DIEMCK = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            string DIEMTK = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            int HK = Int32.Parse(tmp);
            tmp = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            int NAM = Int32.Parse(tmp);
            string MACT = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            bool temp = float.TryParse(DIEMTH, out float d);
            temp = float.TryParse(DIEMQT, out float f);
            temp = float.TryParse(DIEMCK, out float g);
            temp = float.TryParse(DIEMTK, out float h);
            XemDangKyBLL.UpdateDiem(MASV, MAGV, MAHP, HK, NAM, MACT, d, f, g, h);
        }
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            prevValue = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
        }
    }
}
