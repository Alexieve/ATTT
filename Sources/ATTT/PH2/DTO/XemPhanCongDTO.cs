using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class XemPhanCongDTO
    {
        private string _TENHP;
        private string _HK;
        private string _NAM;
        private string _MACT;
        public string TENHP
        {
            get { return _TENHP; }
            set { _TENHP = value; }
        }
        public string HK
        {
            get { return _HK; }
            set { _HK = value; }
        }
        public string NAM
        {
            get { return _NAM; }
            set { _NAM = value; }
        }
        public string MACT
        {
            get { return _MACT; }
            set { _MACT = value; }
        }
        public XemPhanCongDTO()
        {
            this.TENHP = "";
            this.HK = "";
            this.NAM = "";
            this.MACT = "";
        }
        public XemPhanCongDTO(string TENHP, string HK, string NAM, string MACT)
        {
            this.TENHP = TENHP;
            this.HK = HK;
            this.NAM = NAM;
            this.MACT = MACT;
        }
    }
}
