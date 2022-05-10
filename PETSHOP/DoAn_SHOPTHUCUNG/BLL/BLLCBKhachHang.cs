using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLCBKhachHang
    {
        DALCBKhachHang dalcbkhachhang = new DALCBKhachHang();
        public BLLCBKhachHang()
        {

        }
        public List<KHACHHANG> loadCBKhachHang()
        {
            return dalcbkhachhang.loadCBKhachHang();
        }
    }
}
