using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class DangKyHPDTO
    {
        private string _MAHP;
        private string _TENHP;
        private string _MAGV;
        private string _TENGV;
        private int _SOTC;
        private int _SOSVTD;
        private int _SOSVDK;

        public string MAHP { get => _MAHP; set => _MAHP = value; }
        public string TENHP { get => _TENHP; set => _TENHP = value; }
        public string MAGV { get => _MAGV; set => _MAGV = value; }
        public string TENGV { get => _TENGV; set => _TENGV = value; }
        public int SOTC {get => _SOTC; set => _SOTC = value; }
        public int SOSVTD { get => _SOSVTD; set => _SOSVTD = value; }
        public int SOSVDK { get => _SOSVDK; set => _SOSVDK = value; }

        public DangKyHPDTO()
        {
            this.MAHP = "";
            this.TENHP = "";
            this.MAGV = "";
            this.TENGV = "";
            this.SOTC = -1;
            this.SOSVTD = -1;
            this.SOSVDK = -1;
        }

        public DangKyHPDTO(string MAHP, string TENHP, string magv, string tengv, int SOTC, int SOSVTD, int SOSVDK)
        {
            this.MAHP = MAHP;
            this.TENHP = TENHP;
            this.MAGV = magv;
            this.TENGV = tengv;
            this.SOTC = SOTC;
            this.SOSVTD = SOSVTD;
            this.SOSVDK = SOSVDK;
        }

        public DangKyHPDTO(DangKyHPDTO hp)
        {
            this.MAHP = hp.MAHP;
            this.TENHP = hp.TENHP;
            this.MAGV = hp.MAGV;
            this.TENGV = hp.TENGV;
            this.SOTC = hp.SOTC;
            this.SOSVTD = hp.SOSVTD;
            this.SOSVDK = hp.SOSVDK;
        }
    }
}
