using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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
                float.Parse(dr["DTBTL"].ToString()),
                dr["COSO"].ToString());
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
                
                
        public GVU_SinhVienDTO getProfile2(string masv)
        {
            DataTable dt = svDAL.getProfile2(masv);
            DataRow dr = dt.Rows[0];
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
            return svDTO;
        }
                
                
        public List<GVU_SinhVienDTO> getAll2()
        {
            DataTable dt = svDAL.getAll();
            List<GVU_SinhVienDTO> listSV = new List<GVU_SinhVienDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                float dtbtl;
                if (dr["DTBTL"] != DBNull.Value && !string.IsNullOrWhiteSpace(dr["DTBTL"].ToString()))
                {
                    dtbtl = float.Parse(dr["DTBTL"].ToString());
                }
                else
                {
                    // Assign a default value or handle the null value case as needed
                    dtbtl = 0; // Default value as example, you can change this to fit your logic
                }
                GVU_SinhVienDTO svDTO = new GVU_SinhVienDTO(
                dr["MASV"].ToString(),
                dr["HOTEN"].ToString(),
                dr["PHAI"].ToString(),
                DateTime.Parse(dr["NGSINH"].ToString()).ToString("dd/MM/yyyy"), dr["DCHI"].ToString(),
                dr["SDT"].ToString(),
                dr["MACT"].ToString(),
                dr["MANGANH"].ToString(),
                int.Parse(dr["SOTCTL"].ToString()),
                dtbtl, dr["COSO"].ToString());

                //SinhVienDTO sv = Utility.ToObject<SinhVienDTO>(dr);
                listSV.Add(svDTO);
            }
            return listSV;
        }
                
        public int AddSinhVien(GVU_SinhVienDTO a)
        {
            string pattern = @"^(0[1-9]|[1-2][0-9]|3[0-1])-(0[1-9]|1[0-2])-(19|20)\d{2}$";
            if (a.SDT.Length != 10 || a.SDT[0] != '0')
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
                return 2;
            }
            if (!Regex.IsMatch(a.NGSINH, pattern))
            {
                // Nếu chuỗi không đúng định dạng, thực hiện xử lý ở đây
                MessageBox.Show("Định dạng ngày tháng phải là DD-MM-YYYY");
                return 3; // Thoát khỏi phương thức hoặc sự kiện
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
            string pattern = @"^(0[1-9]|[1-2][0-9]|3[0-1])-(0[1-9]|1[0-2])-(19|20)\d{2}$";
            if (!Regex.IsMatch(a.NGSINH, pattern))
            {
                // Nếu chuỗi không đúng định dạng, thực hiện xử lý ở đây
                MessageBox.Show("Định dạng ngày tháng phải là DD-MM-YYYY");
                return 3; // Thoát khỏi phương thức hoặc sự kiện
            }
            return svDAL.UpdateSinhVien(a);
        }
                
        public List<GVU_SinhVienDTO> search(string keyword)
        {
            DataTable dt = svDAL.search(keyword.ToUpper());
            List<GVU_SinhVienDTO> listSV = new List<GVU_SinhVienDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                float dtbtl;
                if (dr["DTBTL"] != DBNull.Value && !string.IsNullOrWhiteSpace(dr["DTBTL"].ToString()))
                {
                    dtbtl = float.Parse(dr["DTBTL"].ToString());
                }
                else
                {
                    // Assign a default value or handle the null value case as needed
                    dtbtl = 0; // Default value as example, you can change this to fit your logic
                }
                GVU_SinhVienDTO svDTO = new GVU_SinhVienDTO(
                dr["MASV"].ToString(),
                dr["HOTEN"].ToString(),
                dr["PHAI"].ToString(),
                DateTime.Parse(dr["NGSINH"].ToString()).ToString("dd/MM/yyyy"), dr["DCHI"].ToString(),
                dr["SDT"].ToString(),
                dr["MACT"].ToString(),
                dr["MANGANH"].ToString(),
                int.Parse(dr["SOTCTL"].ToString()),
                dtbtl, dr["COSO"].ToString());

                //SinhVienDTO sv = Utility.ToObject<SinhVienDTO>(dr);
                listSV.Add(svDTO);
            }
            return listSV;
        }
        public List<string> getAllMaNganh()
        {
            DataTable dt = svDAL.getAllMaNganh();
            List<string> listNamHK = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                listNamHK.Add(row["MADV"].ToString());
            }
            return listNamHK;
        }
    }
}
