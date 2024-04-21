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
    internal class XemPhanCongBLL
    {
        private XemPhanCongDAL XemPhanCongDAL;
        public XemPhanCongBLL()
        {
            XemPhanCongDAL = new XemPhanCongDAL();
        }
        public List<PhanCongDTO> getPhanCong()
        {
            DataTable dt = XemPhanCongDAL.GetPhanCong();
            List<PhanCongDTO> danhSach = Utility.ToList<PhanCongDTO>(dt);
            return danhSach;
        }
        public List<PhanCongDTO> GetPC()
        {
            DataTable dt = XemPhanCongDAL.GetPC();
            List<PhanCongDTO> danhSach = Utility.ToList<PhanCongDTO>(dt);
            return danhSach;
        }
        public List<string> GetMAGV()
        {
            DataTable dt = XemPhanCongDAL.GetMAGV();
            List<string> danhSach = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add((string)row["MANV"]);
            }
            return danhSach;
        }
        public List<string> GetMAHP()
        {
            DataTable dt = XemPhanCongDAL.GetMAHP();
            List<string> danhSach = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add((string)row["MAHP"]);
            }
            return danhSach;
        }
        public void DeleteRow(string MAGV, string MAHP, int HK, int NAM, string MACT)
        {
            XemPhanCongDAL.DeleteRow(MAGV, MAHP, HK, NAM, MACT);
        }

        public void AddRow(string MAGV, string MAHP, int HK, int NAM, string MACT)
        {
            XemPhanCongDAL.AddRow(MAGV, MAHP, HK, NAM, MACT);
        }
    }
}
