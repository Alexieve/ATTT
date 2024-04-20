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
    internal class DangKyHPBLL
    {
        private DangKyHPDAL dangKyHPDAL;

        public DangKyHPBLL()
        {
            dangKyHPDAL = new DangKyHPDAL();
        }

        public bool checkTimeDangKyHP()
        {
            int month = DateTime.Now.Month;
            if (month != 1 && month != 4 && month != 9) return false;

            int day = DateTime.Now.Day;
            if (day > 15) return false;

            return true;
        }

        public List<DangKyHPDTO> getChuaDK()
        {
            DataTable dt = dangKyHPDAL.getChuaDK();
            List<DangKyHPDTO> listHPChuaDK =  Utility.ToList<DangKyHPDTO>(dt);
            return listHPChuaDK;
        }

        public List<DangKyHPDTO> getDaDK()
        {
            DataTable dt = dangKyHPDAL.getDaDK();
            List<DangKyHPDTO> listHPDaDK = Utility.ToList<DangKyHPDTO>(dt);
            return listHPDaDK;
        }

        public void HuyHP(string MAGV, string MAHP)
        {
            dangKyHPDAL.HuyHP(MAGV, MAHP);
        }

        public void DangKyHP(string MAGV, string MAHP)
        {
            dangKyHPDAL.DangKyHP(MAGV, MAHP);
        }
                
        public List<DangKyHPDTO> getChuaDK(string a)
        {
            DataTable dt = dangKyHPDAL.getChuaDK(a);
            List<DangKyHPDTO> listHPChuaDK = Utility.ToList<DangKyHPDTO>(dt);
            return listHPChuaDK;
        }
                
        public List<DangKyHPDTO> getDaDK2(string a)
        {
            DataTable dt = dangKyHPDAL.getDaDK2(a);
            List<DangKyHPDTO> listHPDaDK = Utility.ToList<DangKyHPDTO>(dt);
            return listHPDaDK;
        }
                
        public void HuyHP(string MAGV, string MAHP, string a)
        {
            dangKyHPDAL.HuyHP(MAGV, MAHP, a);
        }
                
        public void DangKyHP(string MAGV, string MAHP, string a)
        {
            dangKyHPDAL.DangKyHP(MAGV, MAHP, a);
        }
    }
}
