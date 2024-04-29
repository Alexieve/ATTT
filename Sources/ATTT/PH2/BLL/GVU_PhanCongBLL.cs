using Microsoft.VisualBasic.Devices;
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
    internal class GVU_PhanCongBLL
    {
        private GVU_PhanCongDAL _PhanCongDAL;

        public GVU_PhanCongBLL()
        {
            _PhanCongDAL = new GVU_PhanCongDAL();
        }

        public List<GVU_PhanCongDTO> getAll()
        {
            DataTable dt = _PhanCongDAL.getAll();
            //List<GVU_PhanCongDTO> list = Utility.ToList<GVU_PhanCongDTO>(dt);
            //return list;
            List<GVU_PhanCongDTO> listSV = new List<GVU_PhanCongDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                string maHP2Value = dr["MAHP2"].ToString();
                if (maHP2Value != "Không")
                {
                    maHP2Value = "Có";
                }
                GVU_PhanCongDTO svDTO = new GVU_PhanCongDTO(
                dr["MAGV"].ToString(),
                dr["HOTEN"].ToString(),
                dr["MAHP"].ToString(),
                dr["TENHP"].ToString(),
                int.Parse(dr["HK"].ToString()),
                int.Parse(dr["NAM"].ToString()),
                dr["MACT"].ToString(),
                maHP2Value);
                listSV.Add(svDTO);
            }
            return listSV;
        }

        public List<GVU_PhanCongDTO> search(string keyword)
        {
            DataTable dt = _PhanCongDAL.search(keyword.ToUpper());
            List<GVU_PhanCongDTO> listSV = new List<GVU_PhanCongDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                string maHP2Value = dr["MAHP2"].ToString();
                if (maHP2Value != "Không")
                {
                    maHP2Value = "Có";
                }
                GVU_PhanCongDTO svDTO = new GVU_PhanCongDTO(
                dr["MAGV"].ToString(),
                 dr["HOTEN"].ToString(),
                dr["MAHP"].ToString(),
                dr["TENHP"].ToString(),
                int.Parse(dr["HK"].ToString()),
                int.Parse(dr["NAM"].ToString()),
                dr["MACT"].ToString(),
                maHP2Value);
                listSV.Add(svDTO);
            }
            return listSV;
        }
        public int UpdatePhanCong(GVU_PhanCongDTO a, GVU_PhanCongDTO a2)
        {
            if (a.MAHP.Length > 10 || a.MACT.Length > 5 || a.MAGV.Length > 10)
            {
                MessageBox.Show("Mã không hợp lệ", "Thông báo");
                return 2;
            }
            //if (a.HK < 0 || a.NAM < 0)
            //{
            //    MessageBox.Show("Số không hợp lệ", "Thông báo");
            //    return 3;
            //}

            return _PhanCongDAL.UpdatePhanCong(a, a2);
        }
        public List<string> getAllMAGV()
        {
            DataTable dt = _PhanCongDAL.getAllMAGV();
            List<string> listNamHK = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                listNamHK.Add(row["MAGV"].ToString());
            }
            return listNamHK;
        }
    }
}
