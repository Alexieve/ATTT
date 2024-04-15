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
    internal class HocPhanBLL
    {
        private HocPhanDAL hpDAL;

        public HocPhanBLL()
        {
            hpDAL = new HocPhanDAL();
        }

        public List<HocPhanDTO> getAll()
        {
            
            DataTable dt = hpDAL.getAll();
            List<HocPhanDTO> listHP = new List<HocPhanDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                HocPhanDTO hp = Utility.ToObject<HocPhanDTO>(dr);
                listHP.Add(hp);
            }
            return listHP;

        }

        public List<HocPhanDTO> search(string keyword)
        {
            DataTable dt = hpDAL.search(keyword.ToUpper());
            List<HocPhanDTO> listHP = new List<HocPhanDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                HocPhanDTO hp = Utility.ToObject<HocPhanDTO>(dr);
                listHP.Add(hp);
            }
            return listHP;
        }
    }
}
