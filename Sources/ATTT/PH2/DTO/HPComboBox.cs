using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.DTO
{
    internal class HPComboBox
    {
        private string _MAHP;
        public string MAHP
        {
            get { return _MAHP; }
            set { _MAHP = value; }
        }
        public HPComboBox()
        {
            MAHP = "";
        }
    }
}
