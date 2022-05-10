using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLDoanhThu
    {
           DALDoanhThu daldoanhthu = new DALDoanhThu();
           public BLLDoanhThu()
        {

        }
           public List<View_DoanhThu> loadDoanThu(DateTime ngay)
        {
            return daldoanhthu.loadDoanhThu(ngay);
        }
           public List<View_DoanhThu> loadDoanThuTheoThang(DateTime thang)
           {
               return daldoanhthu.loadDoanhThuTheoThang(thang);
           }
    }
}
