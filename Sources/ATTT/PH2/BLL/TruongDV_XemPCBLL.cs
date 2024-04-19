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
    internal class TruongDV_XemPCBLL
    {
        private TruongDV_XemPCDAL XemPCDAL;
        public TruongDV_XemPCBLL()
        {
            XemPCDAL = new TruongDV_XemPCDAL();
        }
        public List<TruongDV_XemPCDTO> GetPC()
        {
            DataTable dt = XemPCDAL.GetPC();
            List<TruongDV_XemPCDTO> danhSach = Utility.ToList<TruongDV_XemPCDTO>(dt);
            return danhSach;
        }
        public List<NSComboBoxDTO> GetMAGV()
        {
            DataTable dt = XemPCDAL.GetMAGV();
            List<NSComboBoxDTO> danhSach = Utility.ToList<NSComboBoxDTO>(dt);
            return danhSach;
        }
        public List<HPComboBox> GetMAHP()
        {
            DataTable dt = XemPCDAL.GetMAHP();
            List<HPComboBox> danhSach = Utility.ToList<HPComboBox>(dt);
            return danhSach;
        }
        public void DeleteRow(string MAGV, string MAHP, int HK, int NAM, string MACT)
        {
            XemPCDAL.DeleteRow(MAGV, MAHP, HK, NAM, MACT);
        }
        
        public void AddRow(string MAGV, string MAHP, int HK, int NAM, string MACT)
        {
            XemPCDAL.AddRow(MAGV, MAHP, HK, NAM, MACT);
        }
    }
}
