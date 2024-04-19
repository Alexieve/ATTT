using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class NSComboBoxDTO
    {
        private string _MANV;
        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }
        public NSComboBoxDTO()
        {
            MANV = "";
        }
    }
}
