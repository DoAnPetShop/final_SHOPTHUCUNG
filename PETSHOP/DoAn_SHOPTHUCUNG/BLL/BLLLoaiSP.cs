using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLLoaiSP
    {
        DALLoaiSP dalnhacc = new DALLoaiSP();
        public BLLLoaiSP()
        {

        }

        public List<LOAISP> loadLoaiSP()
        {
            return dalnhacc.loadLoaiSP();
        }
    }
}
