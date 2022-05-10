using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALCBKhachHang
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        public DALCBKhachHang()
        {

        }
        public List<KHACHHANG> loadCBKhachHang()
        {
            return qlthucung.KHACHHANGs.Select(t => t).ToList<KHACHHANG>();
        }
    }
}
