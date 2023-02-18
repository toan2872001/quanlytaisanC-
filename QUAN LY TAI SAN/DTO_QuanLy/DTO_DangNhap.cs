using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_DangNhap
    {
        private string TaiKhoan;
        private string MatKhau;
        private string PhanQuyen;
        private string HoTen;
        private DateTime NgaySinh;
        private string ChucVu;
        private string DienThoai;

        public string Tai_Khoan
        {
            get
            {
                return TaiKhoan;
            }

            set
            {
                TaiKhoan = value;
            }
        }

        public string Mat_Khau
        {
            get
            {
                return MatKhau;
            }

            set
            {
                MatKhau = value;
            }
        }

        public string Phan_Quyen
        {
            get
            {
                return PhanQuyen;
            }

            set
            {
                PhanQuyen = value;
            }
        }
        public string Chuc_Vu
        {
            get
            {
                return ChucVu;
            }

            set
            {
                ChucVu = value;
            }
        }

        public string Dien_Thoai
        {
            get
            {
                return DienThoai;
            }

            set
            {
                DienThoai = value;
            }
        }
        public string Ho_Ten
        {
            get
            {
                return HoTen;
            }

            set
            {
                HoTen = value;
            }
        }
        public DateTime Ngay_Sinh
        {
            get
            {
                return NgaySinh;
            }

            set
            {
                NgaySinh = value;
            }
        }

        public DTO_DangNhap()
        {

        }

        public DTO_DangNhap(string mk)
        {
            this.Mat_Khau = mk;
        }

        public DTO_DangNhap(string taikhoan, string matkhau)
        {
            this.Tai_Khoan = taikhoan;
            this.Mat_Khau = matkhau;
           // this.Phan_Quyen = phanquyen;
           
        }
        public DTO_DangNhap(string taikhoan, string matkhau, string phanquyen, string hoten, DateTime ngaysinh, string chucvu, string dienthoai)
        {
            this.Tai_Khoan = taikhoan;
            this.Mat_Khau = matkhau;
            this.Phan_Quyen = phanquyen;
            this.Ho_Ten = hoten;
            this.Ngay_Sinh = ngaysinh;
            this.Chuc_Vu = chucvu;
            this.Dien_Thoai = dienthoai;

        }
    }
}
