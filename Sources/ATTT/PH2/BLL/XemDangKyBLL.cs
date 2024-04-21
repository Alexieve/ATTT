using PH2.DAL;
using PH2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.BLL
{
    internal class XemDangKyBLL
    {
        private DangKyDAL XemDangKyDAL;
        public XemDangKyBLL()
        {
            XemDangKyDAL = new DangKyDAL();
        }
        public List<DangKyDTO> GetDangKyGV()
        {
            DataTable dt = XemDangKyDAL.GetDangKyGV();
            List<DangKyDTO> danhSach = Utility.ToList<DangKyDTO>(dt);
            return danhSach;
        }
        public bool CheckConvert(string DIEMTH, string DIEMQT, string DIEMCK, string DIEMTK)
        {
            if (!float.TryParse(DIEMTH, out float d) || d > 10 || d < 0 || !float.TryParse(DIEMQT, out float e) || e < 0 || e > 10 || !float.TryParse(DIEMCK, out float f) || f < 0 || f > 10 || !float.TryParse(DIEMTK, out float g) || f < 0 || f > 10)
            {
                return false;
            }
            return true;
        }
        public bool CheckConvert(string DIEM)
        {
            if (!float.TryParse(DIEM, out float d) || d > 10 || d < 0)
            {
                return false;
            }
            return true;
        }
        public int UpdateDiem(string MASV, string MAGV, string MAHP, int HK, int NAM, string MACT, float DIEMTH, float DIEMQT, float DIEMCK, float DIEMTK)
        {
            return XemDangKyDAL.UpdateDiem(MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK);
        }
    }
}
