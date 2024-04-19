using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class DangKyTKDTO
    {
        private string _MASV;
        private string _MAGV;
        private string _MAHP;
        private int _HK;
        private int _NAM;
        private string _MACT;
        private float _DIEMTH;
        private float _DIEMQT;
        private float _DIEMCK;
        private float _DIEMTK;

        public string MASV { get => _MASV; set => _MASV = value; }
        public string MAGV{get => _MAGV;set => _MAGV = value;}
        public string MAHP{get => _MAHP;set => _MAHP = value;}
        public int HK{get => _HK;set => _HK = value;}
        public int NAM{get => _NAM;set => _NAM = value;}
        public string MACT{get => _MACT;set => _MACT = value;}
        public float DIEMTH{get => _DIEMTH;set => _DIEMTH = value;}
        public float DIEMQT{get => _DIEMQT;set => _DIEMQT = value;}
        public float DIEMCK{get => _DIEMCK;set => _DIEMCK = value;}
        public float DIEMTK{get => _DIEMTK;set => _DIEMTK = value;}


        public DangKyTKDTO()
        {
            _MASV = "";
            _MAGV = "";
            _MAHP = "";
            _HK = -1;
            _NAM = -1;
            _MACT = "";
            _DIEMTH = -1;
            _DIEMQT = -1;
            _DIEMCK = -1;
            _DIEMTK = -1;
        }

        public DangKyTKDTO(DangKyDTO _DangKyDTO)
        {
            _MASV = _DangKyDTO.MASV;
            _MAGV = _DangKyDTO.MAGV;
            _MAHP = _DangKyDTO.MAHP;
            _HK = _DangKyDTO.HK;
            _NAM = _DangKyDTO.NAM;
            _MACT = _DangKyDTO.MACT;
            _DIEMTH = _DangKyDTO.DIEMTH;
            _DIEMQT = _DangKyDTO.DIEMQT;
            _DIEMCK = _DangKyDTO.DIEMCK;
            _DIEMTK = _DangKyDTO.DIEMTK;
        }

        public DangKyTKDTO(string MASV, string MAGV, string MAHP, int HK, int NAM, string MACT, float DIEMTH, float DIEMQT, float DIEMCK, float DIEMTK)
        {
            _MASV = MASV;
            _MAGV = MAGV;
            _MAHP = MAHP;
            _HK = HK;
            _NAM = NAM;
            _MACT = MACT;
            _DIEMTH = DIEMTH;
            _DIEMQT = DIEMQT;
            _DIEMCK = DIEMCK;
            _DIEMTK = DIEMTK;
        }
    }
}
