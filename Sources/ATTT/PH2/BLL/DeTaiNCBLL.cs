using PH2.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.BLL
{
    internal class DeTaiNCBLL
    {
        DeTaiNCDAL DeTaiNCDAL;

        public DeTaiNCBLL()
        {
            DeTaiNCDAL = new DeTaiNCDAL();
        }

        public DataTable getAll()
        {
            return DeTaiNCDAL.getAll();
        }
    }
}
