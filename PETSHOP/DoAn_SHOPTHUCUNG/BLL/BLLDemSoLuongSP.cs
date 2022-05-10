using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLDemSoLuongSP
    {
        DALDemSoLuongSP daldemsoluonsp = new DALDemSoLuongSP();
         public BLLDemSoLuongSP()
        {

        }
        public int loadsoluongSP(DateTime ngay)
        {
            return daldemsoluonsp.loadSLSanPham(ngay);
        }
        public int loadsoluongSPTheoThang(DateTime thang)
        {
            return daldemsoluonsp.loadSLSanPhamTheoThang(thang);
        }
    }
}
