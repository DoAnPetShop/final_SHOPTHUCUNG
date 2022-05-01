using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLHoaDon
    {
        DALHoaDon dalhoadon = new DALHoaDon();
        public BLLHoaDon()
        {

        }
        public List<View_CTHOADON> loadCTHoaDon(int pMAHD)
        {
            return dalhoadon.loadCTHoaDon(pMAHD);
        }
    }
}
