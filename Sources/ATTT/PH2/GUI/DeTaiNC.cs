using PH2.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH2.GUI
{
    public partial class DeTaiNC : Form
    {
        DeTaiNCBLL DeTaiNCBLL;
        public DeTaiNC()
        {
            InitializeComponent();
            DeTaiNCBLL = new DeTaiNCBLL();
            Load();
        }

        private void Load()
        {
            DeTaiNCTB.DataSource = DeTaiNCBLL.getAll();
            DeTaiNCTB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeTaiNCTB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            setColumnName();
        }

        private void setColumnName()
        {
            DeTaiNCTB.Columns[0].HeaderText = "Tiêu đề";
            DeTaiNCTB.Columns[1].HeaderText = "Nội dung";
        }


    }
}
