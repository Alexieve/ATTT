using PH2.BLL;
using PH2.DAL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class SV_KetQuaHP : Form
    {
        private KetQuaHPBLL ketQuaHPBLL;
        public SV_KetQuaHP()
        {
            InitializeComponent();
            ketQuaHPBLL = new KetQuaHPBLL();
            LoadNamHKCbb();
        }

        private void LoadData()
        {
            List<KetQuaHPDTO> listKQ = ketQuaHPBLL.getAll();
            DangKyTable.DataSource = listKQ;
            DangKyTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DangKyTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
            DTBValueLabel.Text = CalculateGPA(listKQ).ToString("0.00");
        }

        private void LoadData(int HK, int NAM)
        {
            List<KetQuaHPDTO> listKQ = ketQuaHPBLL.getByNamHK(NAM, HK);
            DangKyTable.DataSource = listKQ;
            DangKyTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DangKyTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
            DTBValueLabel.Text = CalculateGPA(listKQ).ToString("0.00");
        }

        private float CalculateGPA(List<KetQuaHPDTO> listKQ)
        {
            float sum = 0;
            int count = 0;
            foreach (KetQuaHPDTO kq in listKQ)
            {
                if (kq.DIEMTK != null && kq.DIEMTK != -1)
                {
                    sum += kq.DIEMTK;
                    count++;
                }
            }
            return sum / count;
        }

        private void setColumnName()
        {
            DangKyTable.Columns[0].HeaderText = "Học Kỳ";
            DangKyTable.Columns[1].HeaderText = "Mã Học Phần";
            DangKyTable.Columns[2].HeaderText = "Tên Học Phần";
            DangKyTable.Columns[3].HeaderText = "Số Tín Chỉ";
            DangKyTable.Columns[4].HeaderText = "Điểm Thực Hành";
            DangKyTable.Columns[5].HeaderText = "Điểm Quá Trình";
            DangKyTable.Columns[6].HeaderText = "Điểm Cuối Kỳ";
            DangKyTable.Columns[7].HeaderText = "Điểm Tổng Kết";
        }

        private void LoadNamHKCbb()
        {
            HKNamCbb.Items.Add("Tất cả học kỳ và năm học");
            List<string> listNamHK = ketQuaHPBLL.getAllNamHK();
            foreach (string namHK in listNamHK)
            {
                HKNamCbb.Items.Add(namHK);
            }
            HKNamCbb.SelectedIndex = 0;
        }

        private void HKNamCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HKNamCbb.SelectedIndex == 0)
            {
                LoadData();
            }
            else
            {
                string[] hkNam = HKNamCbb.SelectedItem.ToString().Split('-');
                LoadData(int.Parse(hkNam[0]), int.Parse(hkNam[1]));
            }
        }
    }
}
