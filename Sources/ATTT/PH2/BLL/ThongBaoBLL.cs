using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PH2.DAL;

namespace PH2.BLL
{
    internal class ThongBaoBLL
    {
        ThongBaoDAL thongBaoDAL;

        public ThongBaoBLL()
        {
            thongBaoDAL = new ThongBaoDAL();
        }

        public DataTable getAll()
        {
            return thongBaoDAL.getAll();
        }
    }
}
