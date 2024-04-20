using System.Data;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class GIAOVU_DV : Form
    {
        private DonViBLL dvBLL;
        private GIAOVU_DV_Them GIAOVU_DV_Them;
        private GIAOVU_DV_CapNhat GIAOVU_DV_CapNhat;
        public GIAOVU_DV()
        {
            InitializeComponent();
            dvBLL = new DonViBLL();
            LoadData();
        }
        private string maDonViToShow = ""; // Biến để lưu trữ mã sinh viên cần hiển thị
        private void LoadData()
        {
            List<DonViDTO> listDV = dvBLL.getALL();
            HocPhanTable.DataSource = listDV;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in HocPhanTable.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //HocPhanTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();

        }
        private void LoadData(string keyword)
        {
            List<DonViDTO> listDV = dvBLL.search(keyword);
            HocPhanTable.DataSource = listDV;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in HocPhanTable.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //HocPhanTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
            maDonViToShow = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (GIAOVU_DV_Them == null || GIAOVU_DV_Them.IsDisposed)
            {
                GIAOVU_DV_Them = new GIAOVU_DV_Them();
                GIAOVU_DV_Them.StartPosition = FormStartPosition.CenterParent;
            }

            GIAOVU_DV_Them.ShowDialog();
        }
        private void setColumnName()
        {
            HocPhanTable.Columns[0].HeaderText = "Mã Đơn Vị";
            HocPhanTable.Columns[1].HeaderText = "Tên Đơn Vị";
            HocPhanTable.Columns[2].HeaderText = "Trưởng Đơn Vị";

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
                // Lấy mã sinh viên từ dòng được chọn và lưu vào biến maDonViToShow
                maDonViToShow = HocPhanTable.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maDonViToShow))
            {
                // Hiển thị mã sinh viên trong một cửa sổ tin nhắn
                if (GIAOVU_DV_CapNhat == null || GIAOVU_DV_CapNhat.IsDisposed || maDonViToShow != "")
                {

                    GIAOVU_DV_CapNhat = new GIAOVU_DV_CapNhat();
                    GIAOVU_DV_CapNhat.StartPosition = FormStartPosition.CenterParent;
                    //GIAOVU_SV_CapNhat.SetMyString(maDonViToShow);
                    GIAOVU_DV_CapNhat.Loadd(maDonViToShow);
                }
                //MessageBox.Show(GIAOVU_SV_CapNhat.MyString);
                GIAOVU_DV_CapNhat.ShowDialog();
                //if (HocPhanTable.SelectedRows.Count == 1)
                //{
                //    HocPhanTable.SelectedRows[0].Selected = false;
                //}
                HocPhanTable.ClearSelection();
                maDonViToShow = "";
                //GIAOVU_SV_CapNhat.SetMyString(maDonViToShow);
            }
            else
            {
                // Hiển thị thông báo cho người dùng rằng họ cần chọn một dòng trước khi nhấp nút
                MessageBox.Show("Vui lòng chọn một dòng trước khi cập nhật.");
            }
        }
    }
}
