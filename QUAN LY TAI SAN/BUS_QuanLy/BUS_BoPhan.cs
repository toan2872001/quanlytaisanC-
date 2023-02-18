using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_BoPhan
    {
        DAL_BoPhan dalBP = new DAL_BoPhan();

        public DataTable getBoPhan()
        {
            return dalBP.getBoPhan();
        }

        public DataTable KTBoPhan(string mabp)
        {
            return dalBP.KTBoPhan(mabp);
        }

        public bool ThemBoPhan(DTO_BoPhan bp)
        {
            return dalBP.ThemBoPhan(bp);
        }

        public bool SuaBoPhan(DTO_BoPhan bp)
        {
            return dalBP.SuaBoPhan(bp);
        }

        public bool XoaBoPhan(string mabp)
        {
            return dalBP.XoaBoPhan(mabp);
        }
    }
}
