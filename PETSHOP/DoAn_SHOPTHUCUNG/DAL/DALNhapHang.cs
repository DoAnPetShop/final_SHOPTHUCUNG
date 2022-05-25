using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{

    public class DALNhapHang
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        public DALNhapHang()
        {

        }

        public List<NHAPHANG> loadNhapHang()
        {
            return qlthucung.NHAPHANGs.Select(t => t).ToList<NHAPHANG>();
        }
    }
}
