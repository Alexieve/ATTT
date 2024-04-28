using PH2.BLL;
using PH2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH2.GUI.GIANGVIEN
{
    public partial class XemNhanSu : Form
    {
        private NhanSuBLL NhanSu;
        public XemNhanSu()
        {
            InitializeComponent();
            NhanSu = new NhanSuBLL();
            Load();
        }
        private void Load()
        {

            dataGridView1.Columns.Clear();
            List<NhanSuDTO> danhSachNS = NhanSu.getNhanSuOLS();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachNS;
            setColumnName();
        }
        private void setColumnName()
        {
            dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
            //dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Họ Tên";
            //dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Phái";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";

            dataGridView1.Columns[4].HeaderText = "Phụ Cấp";
            dataGridView1.Columns[5].HeaderText = "SDT";
            dataGridView1.Columns[6].HeaderText = "Vai Trò";
            dataGridView1.Columns[7].HeaderText = "Mã Đơn Vị";
            dataGridView1.Columns[8].HeaderText = "Cơ Sở";

            for (int i = 0; i < 9; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
        }
    }
}
