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
    internal class GVU_DANGKYBLL
    {
        private GVU_DANGKYDAL dangKyHPDAL;

        public GVU_DANGKYBLL()
        {
            dangKyHPDAL = new GVU_DANGKYDAL();
        }
        public List<GVU_DangKyDTO> getAll()
        {

            DataTable dt = dangKyHPDAL.getAll();
            List<GVU_DangKyDTO> list = Utility.ToList<GVU_DangKyDTO>(dt);

            return list;
        }
        public List<GVU_DangKyDTO> search(string keyword)
        {
            DataTable dt = dangKyHPDAL.search(keyword.ToUpper());
            List<GVU_DangKyDTO> list = Utility.ToList<GVU_DangKyDTO>(dt);
            return list;
        }
        //public bool checkTimeDangKyHP()
        //{
        //    int month = DateTime.Now.Month;
        //    if (month != 1 && month != 4 && month != 9) return false;

        //    int day = DateTime.Now.Day;
        //    if (day > 15) return false;

        //    return true;
        //}

        //public List<DangKyHPDTO> getChuaDK()
        //{
        //    DataTable dt = dangKyHPDAL.getChuaDK();
        //    List<DangKyHPDTO> listHPChuaDK = Utility.ToList<DangKyHPDTO>(dt);
        //    return listHPChuaDK;
        //}

        //public List<DangKyHPDTO> getDaDK()
        //{
        //    DataTable dt = dangKyHPDAL.getDaDK();
        //    List<DangKyHPDTO> listHPDaDK = Utility.ToList<DangKyHPDTO>(dt);
        //    return listHPDaDK;
        //}

        //public void HuyHP(string MAGV, string MAHP)
        //{
        //    dangKyHPDAL.HuyHP(MAGV, MAHP);
        //}

        //public void DangKyHP(string MAGV, string MAHP)
        //{
        //    dangKyHPDAL.DangKyHP(MAGV, MAHP);
        //}
    }
}
