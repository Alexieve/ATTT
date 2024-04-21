using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class DangKyDTO
    {
        private string _MASV;
        private string _MAGV;
        private string _HOTEN;
        private string _MAHP;
        private string _TENHP;
        private int _HK;
        private int _NAM;
        private string _MACT;
        private float _DIEMTH;
        private float _DIEMQT;
        private float _DIEMCK;
        private float _DIEMTK;
        public string MASV
        {
            get { return _MASV; }
            set { _MASV = value; }
        }
        public string MAGV
        {
            get { return _MAGV; }
            set { _MAGV = value; }
        }
        public string HOTEN
        {
            get { return _HOTEN; }
            set { _HOTEN = value; }
        }
        public string MAHP
        {
            get { return _MAHP; }
            set { _MAHP = value; }
        }
        public string TENHP
        {
            get { return _TENHP; }
            set { _TENHP = value; }
        }
        public int HK
        {
            get { return _HK;  }
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
        public float DIEMTH
        {
            get { return _DIEMTH; }
            set { _DIEMTH = value; }
        }
        public float DIEMQT
        {
            get { return _DIEMQT; }
            set { _DIEMQT = value; }
        }
        public float DIEMCK
        {
            get { return _DIEMCK; }
            set { _DIEMCK = value; }
        }
        public float DIEMTK
        {
            get { return _DIEMTK; }
            set { _DIEMTK = value; }
        }
        public DangKyDTO()
        {
            this.MASV = "";
            this.MAGV = "";
            this.HOTEN = "";
            this.MAHP = "";
            this.TENHP = "";
            this.HK = 0;
            this.NAM = 0;
            this.MACT = "";
            this.DIEMTH = 0;
            this.DIEMQT = 0;
            this.DIEMCK = 0;
            this.DIEMTK = 0;
        }
        public DangKyDTO(string MASV, string MAGV, string HOTEN, string MAHP, string TENHP, int HK, int NAM, string MACT, float DIEMTH, float DIEMQT, float DIEMCK, float DIEMTK)
        {
            this.MASV = MASV;
            this.MAGV = MAGV;
            this.HOTEN = HOTEN;
            this.MAHP = MAHP;
            this.TENHP = TENHP;
            this.HK = HK;
            this.NAM = NAM;
            this.MACT = MACT;
            this.DIEMTH = DIEMTH;
            this.DIEMQT = DIEMQT;
            this.DIEMCK = DIEMCK;
            this.DIEMTK = DIEMTK;
        }
    }
}
