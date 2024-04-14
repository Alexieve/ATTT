using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class KHMODTO
    {
        private int _HK;
        private int _NAM;
        private string _MADV;
        private string _TENHP;
        private string _MAHP;
        private int _SOTC;

        public int HK { get => _HK; set => _HK = value; }
        public int NAM { get => _NAM; set => _NAM = value; }
        public string MADV { get => _MADV; set => _MADV = value; }
        public string TENHP { get => _TENHP; set => _TENHP = value; }
        public string MAHP { get => _MAHP; set => _MAHP = value; }
        public int SOTC { get => _SOTC; set => _SOTC = value; }

        public KHMODTO()
        {
            this.HK = -1;
            this.NAM = -1;
            this.MADV = "";
            this.TENHP = "";
            this.MAHP = "";
            this.SOTC = -1;
        }

        public KHMODTO(int HK, int NAM, string MADV, string TENHP, string MAHP, int SOTC)
        {
            this.HK = HK;
            this.NAM = NAM;
            this.MADV = MADV;
            this.TENHP = TENHP;
            this.MAHP = MAHP;
            this.SOTC = SOTC;
        }

        public KHMODTO(KHMODTO khmo)
        {
            this.HK = khmo.HK;
            this.NAM = khmo.NAM;
            this.MADV = khmo.MADV;
            this.TENHP = khmo.TENHP;
            this.MAHP = khmo.MAHP;
            this.SOTC = khmo.SOTC;
        }
    }
}
