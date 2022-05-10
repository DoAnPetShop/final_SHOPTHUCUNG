using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALDemSoLuongSP
    {
         QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
         public DALDemSoLuongSP()
        {

        }
        public int loadSLSanPham(DateTime ngay)
        {

            List<View_SoLuongSP> lsv = qlthucung.View_SoLuongSPs.Where(t => t.NGAYHD == ngay).ToList<View_SoLuongSP>();
    
          
            return lsv.Count;
        }
        public int loadSLSanPhamTheoThang(DateTime thang)
        {

            List<View_SoLuongSP> lsv = qlthucung.View_SoLuongSPs.Where(t => t.NGAYHD.Value.Month == thang.Month).ToList<View_SoLuongSP>();


            return lsv.Count;
        }
    }
}
