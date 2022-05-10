using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALHoaDon
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        public DALHoaDon()
        {

        }
        public List<View_CTHOADON> loadCTHoaDon(int pMaHD)
        {
        
            List<CTHOADON> lsv = qlthucung.CTHOADONs.Where(t => t.MAHD == pMaHD).ToList<CTHOADON>();
            var kq = lsv.ConvertAll(l => new View_CTHOADON()
            {

                MAHD = l.MAHD,
                MASP = l.MASP,
                SOLUONG = l.SOLUONG,
                DONGIA = l.DONGIA,
                TONGTIEN = l.SOLUONG * l.DONGIA
              

            });
            return kq.ToList<View_CTHOADON>();
            
        }
    }
}
