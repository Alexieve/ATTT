using PH2.DAL;
using PH2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH2.BLL
{
    internal class GiangVienBLL
    {
        private GiangVienDAL _GiangVienDAL;

        public GiangVienBLL() 
        {
            _GiangVienDAL = new GiangVienDAL();
        }

        public List<GiangVienDTO> getAll()
        {
            DataTable dt = _GiangVienDAL.getAll();
            List<GiangVienDTO> list = dt.ToList<GiangVienDTO>();
            return list;
        }
    }
}
