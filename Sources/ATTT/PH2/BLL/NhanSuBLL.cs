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
    internal class NhanSuBLL
    {
        private NhanSuDAL nhanSuDAL;

        public NhanSuBLL()
        {
            nhanSuDAL = new NhanSuDAL();
        }

        public DataTable getProfile()
        {
            DataTable dt = nhanSuDAL.getProfile();
            return dt;
        }
        public bool updateSDTProfile(string SDT)
        {
            return nhanSuDAL.updateSDTProfile(SDT);
        }

        public List<NhanSuDTO> getAll()
        {
            DataTable dt = nhanSuDAL.getAll();
            List<NhanSuDTO> list = Utility.ToList<NhanSuDTO>(dt);
            return list;
        }

        public bool delete(string MANV)
        {
            return nhanSuDAL.delete(MANV);
        }

        public string insert(string MANV, string HOTEN, string PHAI, DateTime NGSINH, float PHUCAP, string SDT, string VAITRO, string MADV, string COSO)
        {
            return nhanSuDAL.insert(MANV, HOTEN, PHAI, NGSINH, PHUCAP, SDT, VAITRO, MADV, COSO);
        }

        public string update(string MANV, string HOTEN, string PHAI, DateTime NGSINH, float PHUCAP, string SDT, string VAITRO, string MADV, string COSO)
        {
            return nhanSuDAL.update(MANV, HOTEN, PHAI, NGSINH, PHUCAP, SDT, VAITRO, MADV, COSO);
        }
    }
}
