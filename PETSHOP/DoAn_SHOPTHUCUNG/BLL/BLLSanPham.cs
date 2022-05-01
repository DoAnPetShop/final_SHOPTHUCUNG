using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLSanPham
    {
        DALSanPham dalsanpham = new DALSanPham();
        public BLLSanPham()
        {

        }
        public List<View_SanPham> loadSanPham()
        {
            return dalsanpham.loadSanPham();
        }
    }
}
