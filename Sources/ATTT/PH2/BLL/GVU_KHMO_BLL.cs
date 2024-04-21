using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PH2.DAL;
using PH2.DTO;

namespace PH2.BLL
{
    internal class GVU_KHMOBLL
    {
        private GVU_KHMODAL khmoDAL;
        public GVU_KHMOBLL()
        {
            khmoDAL = new GVU_KHMODAL();
        }

        public List<GVU_KHMODTO> getAll()
        {
            DataTable dt = khmoDAL.getAll();
            List<GVU_KHMODTO> listKHMO = dt.ToList<GVU_KHMODTO>();
            return listKHMO;
        }

        public List<GVU_KHMODTO> getByNamHK(int Nam, int Hk)
        {
            DataTable dt = khmoDAL.getByNamHK(Nam, Hk);
            List<GVU_KHMODTO> listKHMO = dt.ToList<GVU_KHMODTO>();
            return listKHMO;
        }

        public List<string> getAllNamHK()
        {
            DataTable dt = khmoDAL.getAllNamHK();
            List<string> listNamHK = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                listNamHK.Add(row["HK"] + " - " + row["NAM"]);
            }
            return listNamHK;
        }
        public int AddKHMO(GVU_KHMODTO a)
        {
            if (a.MAHP.Length > 10 || a.MACT.Length > 5)
            {
                MessageBox.Show("Mã không hợp lệ", "Thông báo");
                return 2;
            }
            if (a.HK < 0 || a.NAM < 0)
            {
                MessageBox.Show("Số không hợp lệ", "Thông báo");
                return 3;
            }

            return khmoDAL.AddKHMO(a);
        }
        public int UpdateKHMO(GVU_KHMODTO a, GVU_KHMODTO a2)
        {
            if (a.MAHP.Length > 10 || a.MACT.Length > 5)
            {
                MessageBox.Show("Mã không hợp lệ", "Thông báo");
                return 2;
            }
            if (a.HK < 0 || a.NAM < 0)
            {
                MessageBox.Show("Số không hợp lệ", "Thông báo");
                return 3;
            }

            return khmoDAL.UpdateKHMO(a,a2);
        }
    }
}
