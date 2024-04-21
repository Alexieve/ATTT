using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class KHMODTO_TRUONGKHOA
    {
        private int _HK;
        private int _NAM;
        private string _MADV;
        private string _TENHP;  
        private string _MAHP;
        private string _MACT;

        public int HK { get => _HK; set => _HK = value; }
        public int NAM { get => _NAM; set => _NAM = value; }
        public string MADV { get => _MADV; set => _MADV = value; }
        public string TENHP { get => _TENHP; set => _TENHP = value; }
        public string MAHP { get => _MAHP; set => _MAHP = value; }
        public string MACT { get => _MACT; set => _MACT = value; }

        public KHMODTO_TRUONGKHOA()
        {
            this.HK = -1;
            this.NAM = -1;
            this.MADV = "";
            this.TENHP = "";
            this.MAHP = "";
            this.MACT = "";
        }

        public KHMODTO_TRUONGKHOA(int HK, int NAM, string MADV, string TENHP, string MAHP, string MACT)
        {
            this.HK = HK;
            this.NAM = NAM;
            this.MADV = MADV;
            this.TENHP = TENHP;
            this.MAHP = MAHP;
            this.MACT = MACT;
        }

        public KHMODTO_TRUONGKHOA(KHMODTO_TRUONGKHOA khmo)
        {
            this.HK = khmo.HK;
            this.NAM = khmo.NAM;
            this.MADV = khmo.MADV;
            this.TENHP = khmo.TENHP;
            this.MAHP = khmo.MAHP;
            this.MACT = khmo.MACT;
        }
    }
}
