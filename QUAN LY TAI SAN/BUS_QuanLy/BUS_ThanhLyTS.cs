using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_ThanhLyTS
    {
        DAL_ThanhLyTS dalTLTS = new DAL_ThanhLyTS();
        public DataTable getThanhLyTS()
        {
            return dalTLTS.getThanhLyTS();
        }

        public DataTable KTThanhLyTS(string mats)
        {
            return dalTLTS.KTThanhLyTS(mats);
        }

        public bool ThemThanhLyTS(DTO_ThanhLyTS ts)
        {
            return dalTLTS.themThanhLyTS(ts);
        }

        public bool SuaThanhLyTS(DTO_ThanhLyTS ts)
        {
            return dalTLTS.suaThanhLyTS(ts);
        }

        public bool XoaThanhLyTS(string mats)
        {
            return dalTLTS.xoaThanhLyTS(mats);
        }

        public bool CapNhatTinhTrang(string mats)
        {
            return dalTLTS.CapNhatTinhTrang(mats);
        }
    }
}
