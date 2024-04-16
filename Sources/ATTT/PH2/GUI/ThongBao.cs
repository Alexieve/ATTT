using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PH2.BLL;

namespace PH2.GUI
{
    public partial class ThongBao : Form
    {
        ThongBaoBLL thongBaoBLL;
        public ThongBao()
        {
            InitializeComponent();
            thongBaoBLL = new ThongBaoBLL();
            Load();
        }

        private void Load()
        {
            ThongBaoTB.DataSource = thongBaoBLL.getAll();
            ThongBaoTB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ThongBaoTB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
        }

        private void setColumnName()
        {
            ThongBaoTB.Columns[0].HeaderText = "Ngày tạo";
            ThongBaoTB.Columns[1].HeaderText = "Nội dung";
        }
    }
}
