using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_TaiSan
    {
        DAL_TaiSan dalTS = new DAL_TaiSan();

        public DataTable getTaiSan()
        {
            return dalTS.getTaiSan();
        }
        public DataTable KTTaiSan(string mats)
        {
            return dalTS.KTTaiSan(mats);
        }

        public DataTable KTLoaiTaiSan(string maloai)
        {
            return dalTS.KTLoaiTaiSan(maloai);
        }

        public DataTable KTNguonQuy(string manguon)
        {
            return dalTS.KTNguonQuy(manguon);
        }

        public DataTable KTBoPhan(string mabp)
        {
            return dalTS.KTBoPhan(mabp);
        }
        public bool themTaiSan(DTO_TaiSan ts)
        {
            return dalTS.themTaiSan(ts);
        }

        public bool suaTaiSan(DTO_TaiSan ts)
        {
            return dalTS.suaTaiSan(ts);
        }

        public bool xoaTaiSan(string mats)
        {
            return dalTS.xoaTaiSan(mats);
        }

        public DataTable TimTen(string tents)
        {
            return dalTS.TimTen(tents);
        }

        public DataTable TimMa(string mats)
        {
            return dalTS.TimMa(mats);
        }

        public DataTable TimDonGia(float dongia)
        {
            return dalTS.TimDonGia(dongia);
        }

        public DataTable TimNgayNhap(DateTime ngaynhap)
        {
            return dalTS.TimNgayNhap(ngaynhap);
        }

        public DataTable TimMaLoai(string maloai)
        {
            return dalTS.TimMaLoai(maloai);
        }

        public DataTable TimMaXuatXu(string maxx)
        {
            return dalTS.TimMaXuatXu(maxx);
        }

        public DataTable TimMaNguon(string manguon)
        {
            return dalTS.TimMaNguon(manguon);
        }

        public DataTable TimMaBP(string mabp)
        {
            return dalTS.TimMaBP(mabp);
        }

        public DataTable TimTinhTrang(string tinhtrang)
        {
            return dalTS.TimTinhTrang(tinhtrang);
        }
    }
}
