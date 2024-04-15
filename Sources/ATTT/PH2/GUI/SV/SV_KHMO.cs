using PH2.BLL;
using PH2.DTO;

namespace PH2.GUI
{
    public partial class SV_KHMO : Form
    {
        private KHMOBLL khmoBLL;
        public SV_KHMO()
        {
            InitializeComponent();
            khmoBLL = new KHMOBLL();
            LoadNamHKCbb();
        }

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
            List<KHMODTO> listKHMO = khmoBLL.getAll();
            KHMOTable.DataSource = listKHMO;
            KHMOTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            KHMOTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
        }

        private void Load(int HK, int NAM)
        {
            List<KHMODTO> listKHMO = khmoBLL.getByNamHK(NAM, HK);
            KHMOTable.DataSource = listKHMO;
            KHMOTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            KHMOTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
        }

        private void setColumnName()
        {
            KHMOTable.Columns[0].HeaderText = "Học Kỳ";
            KHMOTable.Columns[1].HeaderText = "Năm Học";
            KHMOTable.Columns[2].HeaderText = "Mã Đơn Vị";
            KHMOTable.Columns[3].HeaderText = "Tên Học Phần";
            KHMOTable.Columns[4].HeaderText = "Mã Học Phần";
            KHMOTable.Columns[5].HeaderText = "Số Tín Chỉ";
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

    }
}
