using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALCBHoaDon
    {
          QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
          public DALCBHoaDon()
        {

        }
        public List<HOADON> loadCBHoaDon()
        {
            return qlthucung.HOADONs.Select(t => t).ToList<HOADON>();
        }
    }
}
