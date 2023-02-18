using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_LoaiTaiSan
    {
        DAL_LoaiTaiSan dalLTS = new DAL_LoaiTaiSan();

        public DataTable getLoaiTaiSan()
        {
            return dalLTS.getLoaiTaiSan();
        }

        public DataTable getKhauHao()
        {
            return dalLTS.getKhauHao();
        }

        public DataTable KTLoaiTaiSan(string maloai)
        {
            return dalLTS.KTLoaiTaiSan(maloai);
        }
        public bool ThemLoaiTaiSan(DTO_LoaiTaiSan lts)
        {
            return dalLTS.ThemLoaiTaiSan(lts);
        }

        public bool SuaLoaiTaiSan(DTO_LoaiTaiSan lts)
        {
            return dalLTS.SuaLoaiTaiSan(lts);
        }

        public bool XoaLoaiTaiSan(string maloai)
        {
            return dalLTS.XoaLoaiTaiSan(maloai);
        }
    }
}
