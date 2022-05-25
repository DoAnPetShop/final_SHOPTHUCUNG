using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLNhapHang
    {
        DALNhapHang dalnhap = new DALNhapHang();
        public BLLNhapHang()
        {

        }

        public List<NHAPHANG> loadNhapHang()
        {
            return dalnhap.loadNhapHang();
        }
    }
}
