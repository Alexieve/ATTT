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
                
        public List<DonViDTO> search(string keyword)
        {
            DataTable dt = _DonViDAL.search(keyword.ToUpper());
            List<DonViDTO> listDonViDTO = Utility.ToList<DonViDTO>(dt);
            return listDonViDTO;
        }
        public int AddDonVi(DonViDTO a)
        {
            if (a.MADV.Length > 10 )
            {
                MessageBox.Show("Mã quá dài", "Thông báo");
                return 2;
            }
            if (a.TRUONGDV.Length > 10)
            {
                MessageBox.Show("Mã trưởng đơn vị quá dài", "Thông báo");
                return 3;
            }

            return _DonViDAL.AddDonVi(a);
        }
        public DonViDTO getProfile2(string madv)
        {
            DataTable dt = _DonViDAL.getProfile2(madv);
            DataRow dr = dt.Rows[0];
            DonViDTO svDTO = new DonViDTO(
                dr["MADV"].ToString(),
                dr["TENDV"].ToString(),
                dr["TRUONGDV"].ToString());
            return svDTO;
        }
        public int UpdateDonVi(DonViDTO a)
        {
            if (a.MADV.Length > 10)
            {
                MessageBox.Show("Mã quá dài", "Thông báo");
                return 2;
            }
            if (a.TRUONGDV.Length > 10)
            {
                MessageBox.Show("Mã trưởng đơn vị quá dài", "Thông báo");
                return 3;
            }

            return _DonViDAL.UpdateDonVi(a);
        }
    }
}
