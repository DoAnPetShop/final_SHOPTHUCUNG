using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALCBNhanVien
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        public DALCBNhanVien()
        {

        }
        public List<NHANVIEN> loadCBNhanVien()
        {
            return qlthucung.NHANVIENs.Select(t => t).ToList<NHANVIEN>();
        }
      
    }
}
