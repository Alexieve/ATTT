using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class HocPhanDTO
    {
        private string _MAHP;
        private string _TENHP;
        private int _SOTC;
        private int _STLT;
        private int _STTH;
        private int _SOSVTD;
        private string _MADV;

        public string MAHP { get => _MAHP; set => _MAHP = value; }
        public string TENHP { get => _TENHP; set => _TENHP = value; }
        public int SOTC { get => _SOTC; set => _SOTC = value; }
        public int STLT { get => _STLT; set => _STLT = value; }
        public int STTH { get => _STTH; set => _STTH = value; }
        public int SOSVTD { get => _SOSVTD; set => _SOSVTD = value; }
        public string MADV { get => _MADV; set => _MADV = value; }


        public HocPhanDTO()
        {
            this.MAHP = "";
            this.TENHP = "";
            this.SOTC = 0;
            this.STLT = 0;
            this.STTH = 0;
            this.SOSVTD = 0;
            this.MADV = "";
        }

        public HocPhanDTO(string MAHP, string TENHP, int SOTC, int STLT, int STTH, int SOSVTD, string MADV)
        {
            this.MAHP = MAHP;
            this.TENHP = TENHP;
            this.SOTC = SOTC;
            this.STLT = STLT;
            this.STTH = STTH;
            this.SOSVTD = SOSVTD;
            this.MADV = MADV;
        }

        public HocPhanDTO(HocPhanDTO hp)
        {
            this.MAHP = hp.MAHP;
            this.TENHP = hp.TENHP;
            this.SOTC = hp.SOTC;
            this.STLT = hp.STLT;
            this.STTH = hp.STTH;
            this.SOSVTD = hp.SOSVTD;
            this.MADV = hp.MADV;
        }
    }
}
