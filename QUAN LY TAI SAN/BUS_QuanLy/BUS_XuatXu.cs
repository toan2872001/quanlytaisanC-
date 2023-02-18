using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_XuatXu
    {
        DAL_XuatXu dalXX = new DAL_XuatXu();

        public DataTable getXuatXu()
        {
            return dalXX.getXuatXu();
        }

        public DataTable KTXuatXu(string maxx)
        {
            return dalXX.KTXuatXu(maxx);
        }
        public bool themXuatXu(DTO_XuatXu xx)
        {
            return dalXX.themXuatXu(xx);
        }

        public bool suaXuatXu(DTO_XuatXu xx)
        {
            return dalXX.suaXuatXu(xx);
        }

        public bool xoaXuatXu(string maxx)
        {
            return dalXX.xoaXuatXu(maxx);
        }
    }
}
