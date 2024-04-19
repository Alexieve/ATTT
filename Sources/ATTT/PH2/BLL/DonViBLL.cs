using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PH2.DAL;
using PH2.DTO;

namespace PH2.BLL
{
    internal class DonViBLL
    {
        private DonViDAL _DonViDAL;
        public DonViBLL()
        {
            _DonViDAL = new DonViDAL();
        }

        public List<DonViDTO> getALL()
        {
            DataTable dt = _DonViDAL.getALL();
            List<DonViDTO> listDonViDTO = Utility.ToList<DonViDTO>(dt);
            return listDonViDTO;
        }
    }
}
