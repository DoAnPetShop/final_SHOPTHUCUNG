using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALNhaCungCap
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        public DALNhaCungCap()
        {

        }
        public List<NHACUNGCAP> loadNhaCC()
        {
            return qlthucung.NHACUNGCAPs.Select(t => t).ToList<NHACUNGCAP>();
        }


    }
}
