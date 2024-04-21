using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class PhanCongDTO
    {
        private string _MAGV;
        private string _HOTEN;
        private string _TENHP;
        private string _MAHP;
        private int _HK;
        private int _NAM;
        private string _MACT;

        public string MAGV
        {
            get { return _MAGV; }
            set { _MAGV = value; }
        }

        public string MAHP
        {
            get { return _MAHP; }
            set { _MAHP = value; }
        }
        public string HOTEN
        {
            get { return _HOTEN; }
            set { _HOTEN = value; }
        }
        public string TENHP
        {
            get { return _TENHP; }
            set { _TENHP = value; }
        }
        public int HK
        {
            get { return _HK; }
            set { _HK = value; }
        }
        public int NAM
        {
            get { return _NAM; }
            set { _NAM = value; }
        }
        public string MACT
        {
            get { return _MACT; }
            set { _MACT = value; }
        }
        public PhanCongDTO()
        {
            this.MAGV = "";
            this.HOTEN = "";
            this.TENHP = "";
            this.MAHP = "";
            this.HK = 0;
            this.NAM = 0;
            this.MACT = "";
        }
        public PhanCongDTO(string MAGV, string HOTEN, string TENHP, string MAHP, int HK, int NAM, string MACT)
        {
            this.MAGV = MAGV;
            this.HOTEN = HOTEN;
            this.MAHP = MAHP;
            this.TENHP = TENHP;
            this.HK = HK;
            this.NAM = NAM;
            this.MACT = MACT;
        }
    }
}
