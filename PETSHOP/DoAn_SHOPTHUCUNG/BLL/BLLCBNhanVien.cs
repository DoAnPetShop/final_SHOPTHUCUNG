using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLCBNhanVien
    {
        DALCBNhanVien dalcbnhanvien = new DALCBNhanVien();
        public BLLCBNhanVien()
        {

        }
        public List<NHANVIEN> loadCBNhanVien()
        {
            return dalcbnhanvien.loadCBNhanVien();
        }
    }
}
