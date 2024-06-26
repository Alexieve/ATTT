using System.Data;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{

    public partial class GIAOVU_SV : Form
    {   
        private GIAOVU_SV_Them GIAOVU_SV_Them;
        private GIAOVU_SV_CapNhat GIAOVU_SV_CapNhat;
        private SinhVienBLL svBLL;

        public GIAOVU_SV()
        {
            InitializeComponent();
            svBLL = new SinhVienBLL();
            LoadData();
        }
        private string maSinhVienToShow = ""; // Biến để lưu trữ mã sinh viên cần hiển thị

        


        private void LoadData()
        {
            List<GVU_SinhVienDTO> listSV = svBLL.getAll2();
            HocPhanTable.DataSource = listSV;
            SetColumnWidths(HocPhanTable);
            //HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            setColumnName();

        }
        private void SetColumnWidths(DataGridView dataGridView)
        {
            // Thiết lập kích thước cho mỗi cột
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {

                if (i == 4) // Cột 2, 3, 4
                {
                    dataGridView.Columns[i].Width = dataGridView.Columns[i].Width * 4; // Độ rộng gấp đôi
                }
                if (i == 1 ) // Cột 2, 3, 4
                    {
                        dataGridView.Columns[i].Width = (dataGridView.Columns[i].Width * 3)/2; // Độ rộng gấp đôi
                    }

                    else
                    {
                        dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        int colWidth = dataGridView.Columns[i].Width;
                        dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dataGridView.Columns[i].Width = colWidth;
                    }
                
            }
        }
        private void LoadData(string keyword)
        {
            List<GVU_SinhVienDTO> listSV = svBLL.search(keyword);
            HocPhanTable.DataSource = listSV;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //HocPhanTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
            maSinhVienToShow = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (GIAOVU_SV_Them == null || GIAOVU_SV_Them.IsDisposed)
            {
                GIAOVU_SV_Them = new GIAOVU_SV_Them();
                GIAOVU_SV_Them.StartPosition = FormStartPosition.CenterParent;
            }

            GIAOVU_SV_Them.ShowDialog();
        }
        private void setColumnName()
        {
            HocPhanTable.Columns[0].HeaderText = "Mã Sinh Viên";
            HocPhanTable.Columns[1].HeaderText = "Họ Tên";
            HocPhanTable.Columns[2].HeaderText = "Phái";
            HocPhanTable.Columns[3].HeaderText = "Ngày Sinh";
            HocPhanTable.Columns[4].HeaderText = "Địa Chỉ";
            HocPhanTable.Columns[5].HeaderText = "SĐT";
            HocPhanTable.Columns[6].HeaderText = "Mã CT";
            HocPhanTable.Columns[7].HeaderText = "Mã Ngành";
            HocPhanTable.Columns[8].HeaderText = "TC Tích Lũy";
            HocPhanTable.Columns[9].HeaderText = "Điểm TB";
            HocPhanTable.Columns[10].HeaderText = "Cơ Sở";
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
                if (GIAOVU_SV_CapNhat == null || GIAOVU_SV_CapNhat.IsDisposed || maSinhVienToShow != "")
                {
                    
                    GIAOVU_SV_CapNhat = new GIAOVU_SV_CapNhat();
                    GIAOVU_SV_CapNhat.StartPosition = FormStartPosition.CenterParent;
                    //GIAOVU_SV_CapNhat.SetMyString(maSinhVienToShow);
                    GIAOVU_SV_CapNhat.Loadd(maSinhVienToShow);
                }
                //MessageBox.Show(GIAOVU_SV_CapNhat.MyString);
                GIAOVU_SV_CapNhat.ShowDialog();
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
