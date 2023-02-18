using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_NguonQuy
    {
        DAL_NguonQuy dalNQ = new DAL_NguonQuy();

        public DataTable getNguonQuy()
        {
            return dalNQ.getNguonQuy();
        }

        public DataTable KTNguonQuy(string manguon)
        {
            return dalNQ.KTNguonQuy(manguon);
        }
                
        public bool ThemNguonQuy(DTO_NguonQuy nq)
        {
            return dalNQ.ThemNguonQuy(nq);
        }

        public bool SuaNguonQuy(DTO_NguonQuy nq)
        {
            return dalNQ.SuaNguonQuy(nq);
        }

        public bool XoaNguonQuy(string manguon)
        {
            return dalNQ.XoaNguonQuy(manguon);
        }
    }
}
