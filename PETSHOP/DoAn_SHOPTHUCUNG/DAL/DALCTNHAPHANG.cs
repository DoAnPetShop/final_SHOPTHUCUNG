using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCTNHAPHANG
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        public DALCTNHAPHANG()
        {

        }
        public List<View_CTNHAPHANG> loadCTnhaphang(int pMaNhap)
        {
            List<CTNHAPHANG> lst = qlthucung.CTNHAPHANGs.Where(t => t.MANHAP == pMaNhap).ToList<CTNHAPHANG>();
            var kq = lst.ConvertAll(l => new View_CTNHAPHANG()
            {

                MANHAP = l.MANHAP,
                MASP = l.MASP,
                SOLUONG = l.SOLUONG,
                DONGIA = l.DONGIA,
                TONGTIEN = l.DONGIA * l.SOLUONG


            });
            return kq.ToList<View_CTNHAPHANG>();
        }
    }
}
