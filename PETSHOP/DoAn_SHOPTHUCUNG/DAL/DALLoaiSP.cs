using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALLoaiSP
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        public DALLoaiSP()
        {

        }
        public List<LOAISP> loadLoaiSP()
        {
            return qlthucung.LOAISPs.Select(t => t).ToList<LOAISP>();
        }
    }
}
