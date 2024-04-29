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
               
        public int AddHocPhan(HocPhanDTO a)
       {
           if (a.SOTC < 0 || a.STLT < 0 || a.STTH < 0 || a.SOSVTD < 0)
           {
               MessageBox.Show("Số không hợp lệ", "Thông báo");
               return 2;
           }
           if (a.MAHP.Length > 10 || a.MADV.Length > 10)
           {
               MessageBox.Show("Chuỗi quá dài", "Thông báo");
               return 3;
           }

           return hpDAL.AddHocPhan(a);
       }
       public HocPhanDTO getProfile2(string masv)
       {
           DataTable dt = hpDAL.getProfile2(masv);
           DataRow dr = dt.Rows[0];
           HocPhanDTO svDTO = new HocPhanDTO(
               dr["MAHP"].ToString(),
               dr["TENHP"].ToString(),
               int.Parse(dr["SOTC"].ToString()),
               int.Parse(dr["STLT"].ToString()),
               int.Parse(dr["STTH"].ToString()),
               int.Parse(dr["SOSVTD"].ToString()),
               dr["MADV"].ToString());
           return svDTO;

       }
       public int UpdateHocPhan(HocPhanDTO a)
       {
           if (a.SOTC < 0 || a.STLT < 0 || a.STTH < 0 || a.SOSVTD < 0)
           {
               MessageBox.Show("Số không hợp lệ", "Thông báo");
               return 2;
           }
           if (a.MAHP.Length > 10 || a.MADV.Length > 10)
           {
               MessageBox.Show("Chuỗi quá dài", "Thông báo");
               return 3;
           }

           return hpDAL.UpdateHocPhan(a);
       }
        public List<string> getAllMaNganh()
        {
            DataTable dt = hpDAL.getAllMaNganh();
            List<string> listNamHK = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                listNamHK.Add(row["MADV"].ToString());
            }
            return listNamHK;
        }
    }
}
