using System.Data;
using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class GIAOVU_KHMO : Form
    {
        private GIAOVU_KHMO_Them GIAOVU_KHMO_Them;
        private GIAOVU_KHMO_CapNhat GIAOVU_KHMO_CapNhat;
        //private GIAOVU_SV_CapNhat GIAOVU_SV_CapNhat;
        private GVU_KHMOBLL khmoBLL;
        public GIAOVU_KHMO()
        {
            InitializeComponent();
            khmoBLL = new GVU_KHMOBLL();
            LoadNamHKCbb();
        }
        private string maSinhVienToShow = ""; // Biến để lưu trữ mã sinh viên cần hiển thị
        private string maSinhVienToShow2 = "";
        private string maSinhVienToShow3 = "";
        private string maSinhVienToShow4 = "";
        private void LoadNamHKCbb()
        {
            HKNamCbb.Items.Add("Tất cả học kỳ và năm học");
            List<string> hkNamList = khmoBLL.getAllNamHK();
            foreach (string hkNam in hkNamList)
            {
                HKNamCbb.Items.Add(hkNam);
            }
            HKNamCbb.SelectedIndex = 0;
        }
        private void Load()
        {
            List<GVU_KHMODTO> listKHMO = khmoBLL.getAll();
            KHMOTable.DataSource = listKHMO;
            KHMOTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in KHMOTable.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //KHMOTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
        }
        private void Load(int HK, int NAM)
        {
            List<GVU_KHMODTO> listKHMO = khmoBLL.getByNamHK(NAM, HK);
            KHMOTable.DataSource = listKHMO;
            KHMOTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in KHMOTable.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //KHMOTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
        }
        private void KHMOTable_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có ít nhất một dòng được chọn
            if (KHMOTable.SelectedRows.Count == 1)
            {
                // Lấy mã sinh viên từ dòng được chọn và lưu vào biến maSinhVienToShow
                maSinhVienToShow = KHMOTable.SelectedRows[0].Cells[2].Value.ToString();
                maSinhVienToShow2 = KHMOTable.SelectedRows[0].Cells[0].Value.ToString();
                maSinhVienToShow3 = KHMOTable.SelectedRows[0].Cells[1].Value.ToString();
                maSinhVienToShow4 = KHMOTable.SelectedRows[0].Cells[3].Value.ToString();
            }
        }





        private void setColumnName()
        {
            KHMOTable.Columns[0].HeaderText = "Học Kỳ";
            KHMOTable.Columns[1].HeaderText = "Năm";
            KHMOTable.Columns[2].HeaderText = "Mã Học Phần";
            KHMOTable.Columns[3].HeaderText = "Mã Chương Trình";

        }
        private void Cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedHkNam = HKNamCbb.SelectedIndex;
            if (selectedHkNam == 0)
            {
                Load();
            }
            else
            {
                string[] hkNam = HKNamCbb.SelectedItem.ToString().Split(" - ");
                Load(int.Parse(hkNam[0]), int.Parse(hkNam[1]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GIAOVU_KHMO_Them == null || GIAOVU_KHMO_Them.IsDisposed)
            {
                GIAOVU_KHMO_Them = new GIAOVU_KHMO_Them();
                GIAOVU_KHMO_Them.StartPosition = FormStartPosition.CenterParent;
            }

            GIAOVU_KHMO_Them.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVienToShow))
            {
                // Hiển thị mã sinh viên trong một cửa sổ tin nhắn
                if (GIAOVU_KHMO_CapNhat == null || GIAOVU_KHMO_CapNhat.IsDisposed || maSinhVienToShow != "")
                {

                    GIAOVU_KHMO_CapNhat = new GIAOVU_KHMO_CapNhat();
                    GIAOVU_KHMO_CapNhat.StartPosition = FormStartPosition.CenterParent;
                    //GIAOVU_SV_CapNhat.SetMyString(maSinhVienToShow);
                    GIAOVU_KHMO_CapNhat.Loadd(maSinhVienToShow, maSinhVienToShow2, maSinhVienToShow3, maSinhVienToShow4);
                }
                //MessageBox.Show(GIAOVU_SV_CapNhat.MyString);
                GIAOVU_KHMO_CapNhat.ShowDialog();
                //if (HocPhanTable.SelectedRows.Count == 1)
                //{
                //    HocPhanTable.SelectedRows[0].Selected = false;
                //}
                KHMOTable.ClearSelection();
                maSinhVienToShow = "";
                maSinhVienToShow2 = "";
                maSinhVienToShow3 = "";
                maSinhVienToShow4 = "";
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
