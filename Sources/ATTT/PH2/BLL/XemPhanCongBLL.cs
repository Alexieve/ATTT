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
    internal class XemPhanCongBLL
    {
        private XemPhanCongDAL XemPhanCongDAL;
        public XemPhanCongBLL()
        {
            XemPhanCongDAL = new XemPhanCongDAL();
        }
        public List<XemPhanCongDTO> getPhanCong()
        {
            DataTable dt = XemPhanCongDAL.GetPhanCong();
            List<XemPhanCongDTO> danhSach = Utility.ToList<XemPhanCongDTO>(dt);
            return danhSach;
        }
    }
}
