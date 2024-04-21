using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class PhanCongTKDTO
    {
        private string _MAGV;
        private string _MAHP;
        private int _HK;
        private int _NAM;
        private string _MACT;
        private string _MADV;

        public string MAGV { get => _MAGV;  set => _MAGV = value;}
        public string MAHP { get => _MAHP; set => _MAHP = value;}
        public int HK { get => _HK; set => _HK = value;}
        public int NAM { get =>  _NAM; set => _NAM = value;}
        public string MACT { get => _MACT; set => _MACT = value;}
        public string MADV { get => _MADV; set => _MADV = value;}

        public PhanCongTKDTO()
        {
            this.MAGV = null;
            this.MAHP = null;
            this.HK = 0;
            this.NAM = 0;
            this.MACT = null;
            this.MADV = null;
        }
        public PhanCongTKDTO(string MAGV, string MAHP, int HK, int NAM, string MACT, string MADV)
        {
            this.MAGV = MAGV;
            this.MAHP = MAHP;
            this.HK = HK;
            this.NAM = NAM;
            this.MACT = MACT;
            this.MADV = MADV;
        }

        public PhanCongTKDTO(PhanCongTKDTO phanCongDTO) 
        {
            this.MAGV = phanCongDTO.MAGV;
            this.MAHP = phanCongDTO.MAHP;
            this.HK = phanCongDTO.HK;
            this.NAM = phanCongDTO.NAM;
            this.MACT = phanCongDTO.MACT;
            this.MADV = phanCongDTO.MADV;
        }
    }
}
