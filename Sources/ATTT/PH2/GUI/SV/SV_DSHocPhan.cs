using System.Data;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class SV_DSHocPhan : Form
    {
        private HocPhanBLL hpBLL;
        public SV_DSHocPhan()
        {
            InitializeComponent();
            hpBLL = new HocPhanBLL();
            LoadData();
        }

        private void LoadData()
        {
            List<HocPhanDTO> listHP = hpBLL.getAll();
            HocPhanTable.DataSource = listHP;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HocPhanTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();

        }

        private void LoadData(string keyword)
        {
            List<HocPhanDTO> listHP = hpBLL.search(keyword);
            HocPhanTable.DataSource = listHP;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HocPhanTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
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
    }
}
