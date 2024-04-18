using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class TruongDV_XemPCDTO
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
        public TruongDV_XemPCDTO()
        {
            MAGV = "";
            HOTEN = "";
            TENHP = "";
            MAHP = "";
            HK = 0;
            NAM = 0;
            MACT = "";
        }

    }
}
