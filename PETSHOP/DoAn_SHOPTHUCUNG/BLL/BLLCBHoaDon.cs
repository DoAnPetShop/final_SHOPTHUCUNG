using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLCBHoaDon
    {
        DALCBHoaDon dalcbhoadon = new DALCBHoaDon();
        public BLLCBHoaDon()
        {

        }
        public List<HOADON> loadCBHoaDon()
        {
            return dalcbhoadon.loadCBHoaDon();
        }
    }
}
