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
    internal class TaiLieuBLL
    {
        private TaiLieuDAL khmoDAL;
        public TaiLieuBLL()
        {
            khmoDAL = new TaiLieuDAL();
        }
        public List<TaiLieuDTO> getAll()
        {
            DataTable dt = khmoDAL.getAll();
            List<TaiLieuDTO> listKHMO = dt.ToList<TaiLieuDTO>();
            return listKHMO;
        }
    }
}
