using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class GiangVienDTO
    {
        private string _MAGV;
        private string _HOTEN;
        private string _SDT;
        private string _MADV;
        private string _COSO;

        public string MAGV { get => _MAGV; set => _MAGV = value;}
        public string HOTEN { get => _HOTEN; set => _HOTEN = value;}
        public string SDT { get => _SDT; set => _SDT = value;}
        public string MADV { get => _MADV; set => _MADV = value;}
        public string COSO { get => _COSO; set => _COSO = value;}

        public GiangVienDTO()
        {
            _MAGV = "";
            _HOTEN = "";
            _SDT = "";
            _MADV = "";
            _COSO = "";
        }

        public GiangVienDTO(string MAGV, string HOTEN, string SDT, string MADV, string COSO)
        {
            _MAGV = MAGV;
            _HOTEN = HOTEN;
            _SDT = SDT;
            _MADV = MADV;
            _COSO = COSO;
        }

        public GiangVienDTO(GiangVienDTO _GiangVienDTO)
        {
            _MAGV = _GiangVienDTO.MAGV;
            _HOTEN = _GiangVienDTO.HOTEN;
            _SDT = _GiangVienDTO.SDT;
            _MADV = _GiangVienDTO.MADV;
            _COSO = _GiangVienDTO.COSO;
        }
    }
}
