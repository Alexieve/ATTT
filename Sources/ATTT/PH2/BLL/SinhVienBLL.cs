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
    }
}
