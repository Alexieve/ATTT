using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class TaiLieuDTO
    {
        private string _MATL;
        private string _TENTL;
        public string MATL { get => _MATL; set => _MATL = value; }
        public string TENTL { get => _TENTL; set => _TENTL = value; }
        public TaiLieuDTO()
        {
            this.MATL = "";
            this.TENTL = "";
           
        }
        public TaiLieuDTO(string MATL, string TENTL)
        {
            this.TENTL = TENTL;
            this.MATL = MATL;
        }

        public TaiLieuDTO(TaiLieuDTO hp)
        {
            this.TENTL = hp.TENTL;
            this.MATL = hp.MATL;
        }
    }

}
