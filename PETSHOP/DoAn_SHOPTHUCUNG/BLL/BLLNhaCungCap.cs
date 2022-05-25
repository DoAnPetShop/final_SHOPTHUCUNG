using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    
    public class BLLNhaCungCap
    {
        DALNhaCungCap dalnhacc = new DALNhaCungCap();
        public BLLNhaCungCap()
        {

        }

        public List<NHACUNGCAP> loadNhacc()
        {
            return dalnhacc.loadNhaCC();
        }
    }
}
