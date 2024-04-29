using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class GVU_PhanCongDTO
    {
        private string _MAGV;
        private string _HOTEN;
        private string _MAHP;
        private string _TENHP;
        private string _MAHP2;
        private int _HK;
        private int _NAM;
        private string _MACT;
        public string MAGV { get => _MAGV;  set => _MAGV = value;}
        public string HOTEN { get => _HOTEN; set => _HOTEN = value; }
        public string MAHP { get => _MAHP; set => _MAHP = value;}
        public string TENHP { get => _TENHP; set => _TENHP = value; }

        public int HK { get => _HK; set => _HK = value;}
        public int NAM { get =>  _NAM; set => _NAM = value;}
        public string MACT { get => _MACT; set => _MACT = value;}
        public string MAHP2 { get => _MAHP2; set => _MAHP2 = value; }
        public GVU_PhanCongDTO()
        {
            this.MAGV = "";
            this.HOTEN = "";
            this.MAHP = "";
            this.TENHP = "";
            this.MAHP2 = "";
            this.HK = -1;
            this.NAM = -1;
            this.MACT = "";
        }
        public GVU_PhanCongDTO(string MAGV, string HOTEN, string MAHP, string TENHP, int HK, int NAM, string MACT, string MAHP2)
        {
            this.MAGV = MAGV;
            this.HOTEN = HOTEN;
            this.MAHP = MAHP;
            this.TENHP = TENHP;
            this.HK = HK;
            this.NAM = NAM;
            this.MACT = MACT;
            this.MAHP2 = MAHP2;
        }

        public GVU_PhanCongDTO(GVU_PhanCongDTO phanCongDTO) 
        {
            this.MAGV = phanCongDTO.MAGV;
            this.HOTEN = phanCongDTO.HOTEN;
            this.MAHP = phanCongDTO.MAHP;
            this.TENHP = phanCongDTO.TENHP;
            this.HK = phanCongDTO.HK;
            this.NAM = phanCongDTO.NAM;
            this.MACT = phanCongDTO.MACT;
            this.MAHP2 = phanCongDTO.MAHP2;
        }
    }
}
