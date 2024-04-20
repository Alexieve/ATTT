using System.Data;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;
namespace PH2.GUI
{
    public partial class GIAOVU_DK : Form
    {
        private GIAOVU_DK_SV GIAOVU_DK_SV;
        //private GIAOVU_SV_CapNhat GIAOVU_SV_CapNhat;
        private GVU_DANGKYBLL svBLL;
        //private DangKyHPBLL dangKyHPBLL;
        public GIAOVU_DK()
        {
            InitializeComponent();
            svBLL = new GVU_DANGKYBLL();
            LoadData();
        }
        private void LoadData()
        {
            List<GVU_DangKyDTO> listSV = svBLL.getAll();
            HocPhanTable.DataSource = listSV;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in HocPhanTable.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //HocPhanTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();

        }
        private string maSinhVienToShow = "";
        private void LoadData(string keyword)
        {
            List<GVU_DangKyDTO> listSV = svBLL.search(keyword);
            HocPhanTable.DataSource = listSV;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in HocPhanTable.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //HocPhanTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
            maSinhVienToShow = "";
        }
        private void setColumnName()
        {
            HocPhanTable.Columns[0].HeaderText = "Mã Sinh Viên";
            HocPhanTable.Columns[1].HeaderText = "Mã Giáo Viên";
            HocPhanTable.Columns[2].HeaderText = "Mã Học Phần";
            HocPhanTable.Columns[3].HeaderText = "Học Kì";
            HocPhanTable.Columns[4].HeaderText = "Năm";
            HocPhanTable.Columns[5].HeaderText = "Mã CT";
            HocPhanTable.Columns[6].HeaderText = "Điểm TH";
            HocPhanTable.Columns[7].HeaderText = "Điểm QT";
            HocPhanTable.Columns[8].HeaderText = "Điểm CK";
            HocPhanTable.Columns[9].HeaderText = "Điểm TK";
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadData(searchBox.Text);
        }
        private void HocPhanTable_SelectionChanged(object sender, EventArgs e)
        {
            //Kiểm tra nếu có ít nhất một dòng được chọn
            if (HocPhanTable.SelectedRows.Count == 1)
            {
                // Lấy mã sinh viên từ dòng được chọn và lưu vào biến maSinhVienToShow
                maSinhVienToShow = HocPhanTable.SelectedRows[0].Cells[0].Value.ToString();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(maSinhVienToShow))
                {
                    // Hiển thị mã sinh viên trong một cửa sổ tin nhắn
                    if (GIAOVU_DK_SV == null || GIAOVU_DK_SV.IsDisposed || maSinhVienToShow != "")
                    {
                        GIAOVU_DK_SV = new GIAOVU_DK_SV();
                        GIAOVU_DK_SV.StartPosition = FormStartPosition.CenterParent;
                        GIAOVU_DK_SV.SetMyString(maSinhVienToShow);
                        GIAOVU_DK_SV.Check();
                    }
                    //MessageBox.Show(GIAOVU_DK_SV.MyString);
                    GIAOVU_DK_SV.ShowDialog();
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
                    MessageBox.Show("Vui lòng chọn một dòng sinh viên trước khi thêm/xóa.");
                }
            
        }
    }
}
