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
    internal class KHMOBLL
    {
        private KHMODAL khmoDAL;
        public KHMOBLL()
        {
            khmoDAL = new KHMODAL();
        }

        public List<KHMODTO> getAll()
        {
            DataTable dt = khmoDAL.getAll();
            List<KHMODTO> listKHMO = dt.ToList<KHMODTO>();
            return listKHMO;
        }

        public List<KHMODTO> getByNamHK(int Nam, int Hk)
        {
            DataTable dt = khmoDAL.getByNamHK(Nam, Hk);
            List<KHMODTO> listKHMO = dt.ToList<KHMODTO>();
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

        public List<KHMODTO_TRUONGKHOA> getAll_TRUONGKHOA()
        {
            DataTable dt = khmoDAL.getAll_TRUONGKHOA();
            List<KHMODTO_TRUONGKHOA> listKHMO = dt.ToList<KHMODTO_TRUONGKHOA>();
            return listKHMO;
        }
    }
}
