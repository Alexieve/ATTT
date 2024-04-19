using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PH2.DAL;

namespace PH2.BLL
{
    internal class ChuongTrinhBLL
    {
        private ChuongTrinhDAL _ChuongTrinhDAL;
        public ChuongTrinhBLL()
        {
            _ChuongTrinhDAL = new ChuongTrinhDAL();
        }

        public DataTable getALL()
        {
            DataTable dt = _ChuongTrinhDAL.getALL();
            return dt;
        }

        public DataTable getALL_MADV() 
        {
            DataTable dt = _ChuongTrinhDAL.getALL_MADV();
            return dt;
        }
    }
}
