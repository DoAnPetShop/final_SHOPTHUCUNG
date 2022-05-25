using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLCTNHAPHANG
    {
        DALCTNHAPHANG dalnhaphang = new DALCTNHAPHANG();
        public BLLCTNHAPHANG()
        {

        }
        public List<View_CTNHAPHANG> loadCTnhaphang(int pMaNhap)
        {
            return dalnhaphang.loadCTnhaphang(pMaNhap);
        }
    }
}
