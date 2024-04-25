using System.Data;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class GIAOVU_PC : Form
    {
        //private GIAOVU_SV_Them GIAOVU_SV_Them;
        private GIAOVU_PC_CapNhat GIAOVU_PC_CapNhat;
        private GVU_PhanCongBLL svBLL;
        public GIAOVU_PC()
        {
            InitializeComponent();
            svBLL = new GVU_PhanCongBLL();
            LoadData();
        }
        private string maSinhVienToShow = "";
        private string maSinhVienToShow2 = "";
        private string maSinhVienToShow3 = "";
        private string maSinhVienToShow4 = "";
        private string maSinhVienToShow5 = "";
        private string maSinhVienToShow6 = "";
        private void LoadData()
        {
            List<GVU_PhanCongDTO> listSV = svBLL.getAll();
            HocPhanTable.DataSource = listSV;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //foreach (DataGridViewColumn column in HocPhanTable.Columns)
            //{
            //    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}
            HocPhanTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();

        }
        private void LoadData(string keyword)
        {
            List<GVU_PhanCongDTO> listSV = svBLL.search(keyword);
            HocPhanTable.DataSource = listSV;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //foreach (DataGridViewColumn column in HocPhanTable.Columns)
            //{
            //    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}
            HocPhanTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
            maSinhVienToShow = "";
        }
        
        private void setColumnName()
        {
            HocPhanTable.Columns[0].HeaderText = "Mã Giáo Viên";
            HocPhanTable.Columns[1].HeaderText = "Mã Học Phần";
            HocPhanTable.Columns[2].HeaderText = "Tên Học Phần";
            HocPhanTable.Columns[3].HeaderText = "Học Kì";
            HocPhanTable.Columns[4].HeaderText = "Năm";
            HocPhanTable.Columns[5].HeaderText = "Mã Chương Trình";
            HocPhanTable.Columns[6].HeaderText = "Có Thể Cập Nhật";
            //HocPhanTable.Columns[5].Visible = false;
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadData(searchBox.Text);
        }
        private void HocPhanTable_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có ít nhất một dòng được chọn
            if (HocPhanTable.SelectedRows.Count == 1)
            {
                // Lấy mã sinh viên từ dòng được chọn và lưu vào biến maSinhVienToShow
                maSinhVienToShow = HocPhanTable.SelectedRows[0].Cells[0].Value.ToString();
                maSinhVienToShow2 = HocPhanTable.SelectedRows[0].Cells[1].Value.ToString();
                maSinhVienToShow3 = HocPhanTable.SelectedRows[0].Cells[3].Value.ToString();
                maSinhVienToShow4 = HocPhanTable.SelectedRows[0].Cells[4].Value.ToString();
                maSinhVienToShow5 = HocPhanTable.SelectedRows[0].Cells[5].Value.ToString();
                maSinhVienToShow6 = HocPhanTable.SelectedRows[0].Cells[6].Value.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVienToShow) && maSinhVienToShow6 == "Có")
            {
                // Hiển thị mã sinh viên trong một cửa sổ tin nhắn
                if (GIAOVU_PC_CapNhat == null || GIAOVU_PC_CapNhat.IsDisposed || maSinhVienToShow != "")
                {

                    GIAOVU_PC_CapNhat = new GIAOVU_PC_CapNhat();
                    GIAOVU_PC_CapNhat.StartPosition = FormStartPosition.CenterParent;
                    //GIAOVU_SV_CapNhat.SetMyString(maSinhVienToShow);
                    GIAOVU_PC_CapNhat.Loadd(maSinhVienToShow, maSinhVienToShow2, maSinhVienToShow3, maSinhVienToShow4, maSinhVienToShow5);
                }
                //MessageBox.Show(GIAOVU_SV_CapNhat.MyString);
                GIAOVU_PC_CapNhat.ShowDialog();
                //if (HocPhanTable.SelectedRows.Count == 1)
                //{
                //    HocPhanTable.SelectedRows[0].Selected = false;
                //}
                HocPhanTable.ClearSelection();
                maSinhVienToShow = "";
                //GIAOVU_SV_CapNhat.SetMyString(maSinhVienToShow);
            }
            else
            {
                // Hiển thị thông báo cho người dùng rằng họ cần chọn một dòng trước khi nhấp nút
                MessageBox.Show("Vui lòng chọn một dòng trước hoặc dòng hợp lệ.");
            }
        }
    }
}
