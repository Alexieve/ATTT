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
    internal class DangKyBLL
    {
        private DangKyDAL _DangKyDAL;

        public DangKyBLL()
        {
            _DangKyDAL = new DangKyDAL();
        }

        public List<DangKyTKDTO> getAll()
        {
            DataTable dt = _DangKyDAL.getAll();
            List<DangKyTKDTO> list = Utility.ToList<DangKyTKDTO>(dt);
            return list;
        }
    }
}
