using PH2.DAL;
using PH2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.BLL
{
    internal class PhanCongBLL
    {
        private PhanCongDAL _PhanCongDAL;

        public PhanCongBLL()
        {
            _PhanCongDAL = new PhanCongDAL();
        }

        public List<PhanCongTKDTO> getAll()
        {
            DataTable dt = _PhanCongDAL.getAll();
            List<PhanCongTKDTO> list = Utility.ToList<PhanCongTKDTO>(dt);
            return list;
        }

        public int delete(string MAGV, string MAHP, int HK, int NAM, string MACT) 
        {
            return _PhanCongDAL.delete(MAGV,  MAHP,  HK,  NAM,  MACT);
        }

        public string them(string MAGV, string MAHP, int HK, int NAM, string MACT)
        {
            return _PhanCongDAL.them(MAGV, MAHP, HK, NAM, MACT);
        }
    }
}
