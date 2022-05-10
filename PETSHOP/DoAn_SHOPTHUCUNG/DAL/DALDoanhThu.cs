using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALDoanhThu
    {
          QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
          public DALDoanhThu()
        {

        }
          public List<View_DoanhThu> loadDoanhThu(DateTime ngay)
        {

            List<View_DoanhThu> lsv = qlthucung.View_DoanhThus.Where(t => t.NGAYHD == ngay).ToList<View_DoanhThu>();
            
          
            return lsv;
        }
          public List<View_DoanhThu> loadDoanhThuTheoThang(DateTime ngay)
          {

              List<View_DoanhThu> lsv = qlthucung.View_DoanhThus.Where(t => t.NGAYHD.Value.Month == ngay.Month).ToList<View_DoanhThu>();


              return lsv;
          }
    }
}
