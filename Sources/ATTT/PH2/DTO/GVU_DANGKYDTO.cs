using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class GVU_DangKyDTO
    {
        private string _MAHP;
        private string _MAGV;
        private int _HK;
        private int _NAM;
        private string _MACT;
        private string _MASV;
        private float _DIEMTH;
        private float _DIEMQT;
        private float _DIEMCK;
        private float _DIEMTK;
        public string MASV { get => _MASV; set => _MASV = value; }
        public string MAGV { get => _MAGV; set => _MAGV = value; }
        public string MAHP { get => _MAHP; set => _MAHP = value; }
        public int HK { get => _HK; set => _HK = value; }
        public int NAM { get => _NAM; set => _NAM = value; }

        public string MACT { get => _MACT; set => _MACT = value; }
        public float DIEMTH { get => _DIEMTH; set => _DIEMTH = value; }
        public float DIEMQT { get => _DIEMQT; set => _DIEMQT = value; }
        public float DIEMCK { get => _DIEMCK; set => _DIEMCK = value; }
        public float DIEMTK { get => _DIEMTK; set => _DIEMTK = value; }
        
        
        public GVU_DangKyDTO()
        {
            this.MAHP = "";
            this.MASV = "";
            this.MAGV = "";
            this.MACT = "";
            this.DIEMTH = 0;
            this.DIEMCK = 0;
            this.DIEMTK = 0;
            this.DIEMQT = 0;
            this.HK = -1;
            this.NAM = -1;
        }

        public GVU_DangKyDTO(string MASV, string MAGV, string MAHP, int HK, int NAM, string MACT, float DIEMTH, float DIEMCK, float DIEMTK, float DIEMQT)
        {
            this.MAHP = MAHP;
            this.MASV = MASV;
            this.MAGV = MAGV;
            this.MACT = MACT;
            this.DIEMTH = DIEMTH;
            this.DIEMCK = DIEMCK;
            this.DIEMTK = DIEMTK;
            this.DIEMQT = DIEMQT;
            this.HK = HK;
            this.NAM = NAM;
        }

        public GVU_DangKyDTO(GVU_DangKyDTO hp)
        {
            this.MAHP = hp.MAHP;
            this.MASV = hp.MASV;
            this.MAGV = hp.MAGV;
            this.MACT = hp.MACT;
            this.DIEMTH = hp.DIEMTH;
            this.DIEMCK = hp.DIEMCK;
            this.DIEMTK = hp.DIEMTK;
            this.DIEMQT = hp.DIEMQT;
            this.HK = hp.HK;
            this.NAM = hp.NAM;
        }
    }
}
