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
    internal class KetQuaHPBLL
    {
        private KetQuaHPDAL ketQuaHPDAL;

        public KetQuaHPBLL()
        {
            ketQuaHPDAL = new KetQuaHPDAL();
        }

        public List<string> getAllNamHK()
        {
            DataTable dt = ketQuaHPDAL.getAllNamHK();
            List<string> listNamHK = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                listNamHK.Add(row["HK"] + " - " + row["NAM"]);
            }
            return listNamHK;
        }

        public List<KetQuaHPDTO> getAll()
        {
            DataTable dt = ketQuaHPDAL.getAll();
            List<KetQuaHPDTO> listKetQuaHp = dt.ToList<KetQuaHPDTO>();
            return listKetQuaHp;
        }

        public List<KetQuaHPDTO> getByNamHK(int nam, int hk)
        {
            DataTable dt = ketQuaHPDAL.getByNamHK(nam, hk);
            List<KetQuaHPDTO> listKetQuaHp = dt.ToList<KetQuaHPDTO>();
            return listKetQuaHp;
        }
    }
}
