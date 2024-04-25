using PH2.BLL;
using PH2.DAL;
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
    public partial class XemPhanCong : Form
    {
        private XemPhanCongBLL XemPhanCongBLL;
        public XemPhanCong()
        {
            InitializeComponent();
            XemPhanCongBLL = new XemPhanCongBLL();
            //DanhSachPC.Rows.Add("ok","ok","ok","ok");
            Load();
        }
        private void Load()
        {
            //DanhSachPC.Columns.Clear();
            List<PhanCongDTO> danhSachPC = XemPhanCongBLL.getPhanCong();
            foreach (var array in danhSachPC)
            {
                DanhSachPC.Rows.Add(array.MAHP ,array.TENHP, array.NAM, array.HK, array.MACT);
            }
        }

    }
}
