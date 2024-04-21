using PH2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    public class NhanSuDTO
    {
        private string _MANV;
        private string _HOTEN;
        private string _PHAI;
        private string _NGSINH;
        private string _PHUCAP;
        private string _SDT;
        private string _VAITRO;
        private string _MADV;
        private string _COSO;

        public string MANV { get => _MANV; set => _MANV = value; }
        public string HOTEN { get => _HOTEN; set => _HOTEN = value; }
        public string PHAI { get => _PHAI; set => _PHAI = value; }
        public string NGSINH { get => _NGSINH; set => _NGSINH = value; }
        public string PHUCAP { get => _PHUCAP; set => _PHUCAP = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string VAITRO { get => _VAITRO; set => _VAITRO = value; }
        public string MADV { get => _MADV; set => _MADV = value; }
        public string COSO { get => _COSO; set => _COSO = value; }

        public NhanSuDTO()
        {
            _MANV = "";
            _HOTEN = "";
            _PHAI = "";
            _NGSINH = "";
            _PHUCAP = "";
            _SDT = "";
            _VAITRO = "";
            _MADV = "";
            _COSO = "";
        }
        public NhanSuDTO(string MANV, string HOTEN, string PHAI, string NGSINH, string PHUCAP, string SDT, string VAITRO, string MADV, string COSO)
        {
            _MANV = MANV;
            _HOTEN = HOTEN;
            _PHAI = PHAI;
            _NGSINH = NGSINH;
            _PHUCAP = PHUCAP;
            _SDT = SDT;
            _VAITRO = VAITRO;
            _MADV = MADV;
            _COSO = COSO;
        }

        public NhanSuDTO(NhanSuDTO nhanSuDTO)
        {
            _MANV = nhanSuDTO.MANV;
            _HOTEN = nhanSuDTO.HOTEN;
            _PHAI = nhanSuDTO.PHAI;
            _NGSINH = nhanSuDTO.NGSINH;
            _PHUCAP = nhanSuDTO.PHUCAP;
            _SDT = nhanSuDTO.SDT;
            _VAITRO = nhanSuDTO.VAITRO;
            _MADV = nhanSuDTO.MADV;
            _COSO = nhanSuDTO.COSO;
        }
    }
}
