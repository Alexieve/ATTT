using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class GVU_SinhVienDTO
    {
        private string _MASV;
        private string _HOTEN;
        private string _PHAI;
        private string _NGSINH;
        private string _DCHI;
        private string _SDT;
        private string _MACT;
        private string _MANGANH;
        private int _SOTCTL;
        private float _DTBTL;
        private string _COSO;

        public string MASV { get => _MASV; set => _MASV = value; }
        public string HOTEN { get => _HOTEN; set => _HOTEN = value; }
        public string PHAI { get => _PHAI; set => _PHAI = value; }
        public string NGSINH { get => _NGSINH; set => _NGSINH = value; }
        public string DCHI { get => _DCHI; set => _DCHI = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string MACT { get => _MACT; set => _MACT = value; }
        public string MANGANH { get => _MANGANH; set => _MANGANH = value; }
        public int SOTCTL { get => _SOTCTL; set => _SOTCTL = value; }
        public float DTBTL { get => _DTBTL; set => _DTBTL = value; }
        public string COSO { get => _COSO; set => _COSO = value; }

        public GVU_SinhVienDTO()
        {
            this.MASV = "";
            this.HOTEN = "";
            this.PHAI = "";
            this.NGSINH = "";
            this.DCHI = "";
            this.SDT = "";
            this.MACT = "";
            this.MANGANH = "";
            this.SOTCTL = 0;
            this.DTBTL = 0;
            this.COSO = "";
        }

        public GVU_SinhVienDTO(string MASV, string HOTEN, string PHAI, string NGSINH, string DCHI, string SDT, string MACT,
            string MANGANH, int SOTCTL, float DTBTL, string COSO)
        {
            this.MASV = MASV;
            this.HOTEN = HOTEN;
            this.PHAI = PHAI;
            this.NGSINH = NGSINH;
            this.DCHI = DCHI;
            this.SDT = SDT;
            this.MACT = MACT;
            this.MANGANH = MANGANH;
            this.SOTCTL = SOTCTL;
            this.DTBTL = DTBTL;
            this.COSO = COSO;
        }

        public GVU_SinhVienDTO(GVU_SinhVienDTO sv)
        {
            this.MASV = sv.MASV;
            this.HOTEN = sv.HOTEN;
            this.PHAI = sv.PHAI;
            this.NGSINH = sv.NGSINH;
            this.DCHI = sv.DCHI;
            this.SDT = sv.SDT;
            this.MACT = sv.MACT;
            this.MANGANH = sv.MANGANH;
            this.SOTCTL = sv.SOTCTL;
            this.DTBTL = sv.DTBTL;
            this.COSO = sv.COSO;
        }

    }
}
