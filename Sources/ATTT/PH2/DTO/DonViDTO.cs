using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class DonViDTO
    {
        private string _MADV;
        private string _TENDV;
        private string _TRUONGDV;

        public string MADV { get => _MADV; set => _MADV = value; }
        public string TENDV { get => _TENDV; set => _TENDV = value; }
        public string TRUONGDV { get => _TRUONGDV; set => _TRUONGDV = value; }

        public DonViDTO()
        {
            this.MADV = "";
            this.TENDV = "";
            this.TRUONGDV = "";
        }

        public DonViDTO(string MADV, string TENDV, string TRGDV)
        {
            this.MADV = MADV;
            this.TENDV = TENDV;
            this.TRUONGDV = TRGDV;
        }

        public DonViDTO(DonViDTO dv)
        {
            this.MADV = dv.MADV;
            this.TENDV = dv.TENDV;
            this.TRUONGDV = dv.TRUONGDV;
        }
    }
}
