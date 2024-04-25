using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class GVU_KHMODTO
    {
        private int _HK;
        private int _NAM;
        private string _MAHP;
        private string _TENHP;
        private string _MACT;


        public int HK { get => _HK; set => _HK = value; }
        public int NAM { get => _NAM; set => _NAM = value; }
        public string MAHP { get => _MAHP; set => _MAHP = value; }
        public string TENHP { get => _TENHP; set => _TENHP = value; }
        public string MACT { get => _MACT; set => _MACT = value; }

        public GVU_KHMODTO()
        {
            this.HK = -1;
            this.NAM = -1;
            this.MAHP = "";
            this.TENHP = "";
            this.MACT = "";
        }

        public GVU_KHMODTO(string MAHP, string TENHP, int HK, int NAM,  string MACT)
        {
            this.HK = HK;
            this.NAM = NAM;
            this.MAHP = MAHP;
            this.TENHP = TENHP;
            this.MACT = MACT;
        }

        public GVU_KHMODTO(GVU_KHMODTO khmo)
        {
            this.HK = khmo.HK;
            this.NAM = khmo.NAM;
            this.MAHP = khmo.MAHP;
            this.TENHP = khmo.TENHP;
            this.MACT = khmo.MACT;

        }
    }
}
