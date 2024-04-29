using System.Data;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class TaiLieu : Form
    {
        private TaiLieuBLL svBLL;
        public TaiLieu()
        {
            InitializeComponent();
            svBLL = new TaiLieuBLL();
            LoadData();
        }
        private void LoadData()
        {
            List<TaiLieuDTO> listSV = svBLL.getAll();
            HocPhanTable.DataSource = listSV;
            HocPhanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HocPhanTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //HocPhanTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
        }
        private void setColumnName()
        {
            HocPhanTable.Columns[0].HeaderText = "Mã Tài Liệu";
            HocPhanTable.Columns[1].HeaderText = "Tên Tài Liệu";
        }
    }
}
