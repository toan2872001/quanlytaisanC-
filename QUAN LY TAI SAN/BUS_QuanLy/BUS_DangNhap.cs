using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
     public class BUS_DangNhap
    {
        DAL_DangNhap dalDangNhap = new DAL_DangNhap();

        public bool login(string taikhoan, string matkhau)
        {
            return dalDangNhap.Login(taikhoan,matkhau);
        }

        public DataTable getNguoiDung()
        {
            return dalDangNhap.getNguoiDung();
        }

        public DataTable KTMatKhau(string dn)
        {
            return dalDangNhap.KTMatKhau(dn);
        }

        public DataTable getPhanQuyen(string pq)
        {
            return dalDangNhap.getPhanQuyen(pq);
        }

        public bool doimatkhau(DTO_DangNhap dn, string tk)
        {
            return dalDangNhap.DoiMatKhau(dn, tk);
        }

        public bool ThemNguoiDung(DTO_DangNhap nd)
        {
            return dalDangNhap.ThemNguoiDung(nd);
        }

        public bool SuaNguoiDung(DTO_DangNhap nd)
        {
            return dalDangNhap.SuaNguoiDung(nd);
        }

        public bool XoaNguoiDung(string taikhoan)
        {
            return dalDangNhap.XuaNguoiDung(taikhoan);
        }
    }
}
