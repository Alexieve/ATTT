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
    internal class SinhVienBLL
    {
        private SinhVienDAL svDAL;
        public SinhVienBLL()
        {
            svDAL = new SinhVienDAL();
        }

        public SinhVienDTO getProfile()
        {
            DataTable dt = svDAL.getProfile();
            DataRow dr = dt.Rows[0];
            SinhVienDTO svDTO = new SinhVienDTO(
                dr["MASV"].ToString(), 
                dr["HOTEN"].ToString(), 
                dr["PHAI"].ToString(),
                DateTime.Parse(dr["NGSINH"].ToString()).ToString("dd/MM/yyyy"), dr["DCHI"].ToString(), 
                dr["SDT"].ToString(),
                dr["MACT"].ToString(),
                dr["MANGANH"].ToString(), 
                int.Parse(dr["SOTCTL"].ToString()), 
                float.Parse(dr["DTBTL"].ToString()));
            return svDTO;
        }

        public bool updateSDTProfile(string SDT)
        {
            if (SDT.Length != 10 || SDT[0] != '0')
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
                return false;
            }
            return svDAL.updateSDTProfile(SDT);
        }

        public List<SinhVienDTO> getAll()
        {
            DataTable dt = svDAL.getAll();
            List<SinhVienDTO> list = Utility.ToList<SinhVienDTO>(dt);
            return list;
        }
                
        public SinhVienDTO getProfile2(string masv)
        {
            DataTable dt = svDAL.getProfile2(masv);
            DataRow dr = dt.Rows[0];
            SinhVienDTO svDTO = new SinhVienDTO(
                dr["MASV"].ToString(),
                dr["HOTEN"].ToString(),
                dr["PHAI"].ToString(),
                DateTime.Parse(dr["NGSINH"].ToString()).ToString("dd/MM/yyyy"), dr["DCHI"].ToString(),
                dr["SDT"].ToString(),
                dr["MACT"].ToString(),
                dr["MANGANH"].ToString(),
                int.Parse(dr["SOTCTL"].ToString()),
                float.Parse(dr["DTBTL"].ToString()));
            return svDTO;
        }
                
                
        public List<GVU_SinhVienDTO> getAll2()
        {
            DataTable dt = svDAL.getAll();
            List<GVU_SinhVienDTO> list = Utility.ToList<GVU_SinhVienDTO>(dt);
            return list;
        }
                
        public int AddSinhVien(GVU_SinhVienDTO a)
        {
            if (a.SDT.Length != 10 || a.SDT[0] != '0')
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
                return 2;
            }
            if (a.SOTCTL == -1 || a.DTBTL == -1)
            {
                MessageBox.Show("Giá trị điểm hoặc tín chỉ không hợp lệ", "Thông báo");
                return 3;
            }

            return svDAL.AddSinhVien(a);
        }
        public int UpdateSinhVien(GVU_SinhVienDTO a)
        {
            if (a.SDT.Length != 10 || a.SDT[0] != '0')
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
                return 2;
            }
            if (a.SOTCTL == -1 || a.DTBTL == -1)
            {
                MessageBox.Show("Giá trị điểm hoặc tín chỉ không hợp lệ", "Thông báo");
                return 3;
            }

            return svDAL.UpdateSinhVien(a);
        }
                
        public List<GVU_SinhVienDTO> search(string keyword)
        {
            DataTable dt = svDAL.search(keyword.ToUpper());
            List<GVU_SinhVienDTO> listSV = new List<GVU_SinhVienDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                GVU_SinhVienDTO svDTO = new GVU_SinhVienDTO(
                dr["MASV"].ToString(),
                dr["HOTEN"].ToString(),
                dr["PHAI"].ToString(),
                DateTime.Parse(dr["NGSINH"].ToString()).ToString("dd/MM/yyyy"), dr["DCHI"].ToString(),
                dr["SDT"].ToString(),
                dr["MACT"].ToString(),
                dr["MANGANH"].ToString(),
                int.Parse(dr["SOTCTL"].ToString()),
                float.Parse(dr["DTBTL"].ToString()), dr["COSO"].ToString());

                //SinhVienDTO sv = Utility.ToObject<SinhVienDTO>(dr);
                listSV.Add(svDTO);
            }
            return listSV;
        }
    }
}
