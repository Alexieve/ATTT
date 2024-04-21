using System.Data;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class GIAOVU_HP : Form
    {
        private HocPhanBLL hpBLL;
        private GIAOVU_HP_Them GIAOVU_HP_Them;
        private GIAOVU_HP_CapNhat GIAOVU_HP_CapNhat;
        public GIAOVU_HP()
        {
            InitializeComponent();
            hpBLL = new HocPhanBLL();
            LoadData();
        }
        private string maSinhVienToShow = ""; // Biến để lưu trữ mã sinh viên cần hiển thị




        private void LoadData()
        {
            List<HocPhanDTO> listSV = hpBLL.getAll();
            HocPhanTable.DataSource = listSV;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HocPhanTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();

        }
        private void LoadData(string keyword)
        {
            List<HocPhanDTO> listSV = hpBLL.search(keyword);
            HocPhanTable.DataSource = listSV;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HocPhanTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
            maSinhVienToShow = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (GIAOVU_HP_Them == null || GIAOVU_HP_Them.IsDisposed)
            {
                GIAOVU_HP_Them = new GIAOVU_HP_Them();
                GIAOVU_HP_Them.StartPosition = FormStartPosition.CenterParent;
            }

            GIAOVU_HP_Them.ShowDialog();
        }
        private void setColumnName()
        {
            HocPhanTable.Columns[0].HeaderText = "Mã Học Phần";
            HocPhanTable.Columns[1].HeaderText = "Tên Học Phần";
            HocPhanTable.Columns[2].HeaderText = "Số Tín Chỉ";
            HocPhanTable.Columns[3].HeaderText = "Số Tiết Lý Thuyết";
            HocPhanTable.Columns[4].HeaderText = "Số Tiết Thực Hành";
            HocPhanTable.Columns[5].HeaderText = "Số Sinh Viên Tối Đa";
            HocPhanTable.Columns[6].HeaderText = "Mã Đơn Vị";
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
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVienToShow))
            {
                // Hiển thị mã sinh viên trong một cửa sổ tin nhắn
                if (GIAOVU_HP_CapNhat == null || GIAOVU_HP_CapNhat.IsDisposed || maSinhVienToShow != "")
                {

                    GIAOVU_HP_CapNhat = new GIAOVU_HP_CapNhat();
                    GIAOVU_HP_CapNhat.StartPosition = FormStartPosition.CenterParent;
                    //GIAOVU_SV_CapNhat.SetMyString(maSinhVienToShow);
                    GIAOVU_HP_CapNhat.Loadd(maSinhVienToShow);
                }
                //MessageBox.Show(GIAOVU_SV_CapNhat.MyString);
                GIAOVU_HP_CapNhat.ShowDialog();
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
                MessageBox.Show("Vui lòng chọn một dòng trước khi cập nhật.");
            }
        }
    }
}
