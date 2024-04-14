using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class KetQuaHPDTO
    {
        private string _HK_NAM;
        private string _MAHP;
        private string _TENHP;
        private int _SOTC;
        private float _DIEMTH;
        private float _DIEMQT;
        private float _DIEMCK;
        private float _DIEMTK;

        public string HK_NAM { get => _HK_NAM; set => _HK_NAM = value; }
        public string MAHP { get => _MAHP; set => _MAHP = value; }
        public string TENHP { get => _TENHP; set => _TENHP = value; }
        public int SOTC { get => _SOTC; set => _SOTC = value; }
        public float DIEMTH { get => _DIEMTH; set => _DIEMTH = value; }
        public float DIEMQT { get => _DIEMQT; set => _DIEMQT = value; }
        public float DIEMCK { get => _DIEMCK; set => _DIEMCK = value; }
        public float DIEMTK { get => _DIEMTK; set => _DIEMTK = value; }

        public KetQuaHPDTO()
        {
            HK_NAM = "";
            MAHP = "";
            TENHP = "";
            SOTC = -1;
            DIEMTH = -1;
            DIEMQT = -1;
            DIEMCK = -1;
            DIEMTK = -1;
        }

        public KetQuaHPDTO(string HK_NAM, string MAHP, string TENHP, int SOTC, float DIEMTH, float DIEMQT,
            float DIEMCK, float DIEMTK)
        {
            this.HK_NAM = HK_NAM;
            this.MAHP = MAHP;
            this.TENHP = TENHP;
            this.SOTC = SOTC;
            this.DIEMTH = DIEMTH;
            this.DIEMQT = DIEMQT;
            this.DIEMCK = DIEMCK;
            this.DIEMTK = DIEMTK;
        }

        public KetQuaHPDTO(KetQuaHPDTO kq)
        {
            HK_NAM = kq.HK_NAM;
            MAHP = kq.MAHP;
            TENHP = kq.TENHP;
            SOTC = kq.SOTC;
            DIEMTH = kq.DIEMTH;
            DIEMQT = kq.DIEMQT;
            DIEMCK = kq.DIEMCK;
            DIEMTK = kq.DIEMTK;
        }
    }
}
