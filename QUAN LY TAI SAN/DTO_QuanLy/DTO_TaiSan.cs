using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_TaiSan
    {
        private string MaTS;
        private string TenTS;
        private string DVT;
        private int SoLuong;
        private int DonGia;
        private DateTime NgayNhap;
        private string MaLoai;
        private string MaXuatXu;
        private string MaNguon;
        private string MaBP;
        private int MucKH;
        private string TinhTrang;

        /* ======== GETTER/SETTER ======== */
        public string Ma_TS
        {
            get
            {
                return MaTS;
            }

            set
            {
                MaTS = value;
            }
        }

        public string Ten_TS
        {
            get
            {
                return TenTS;
            }

            set
            {
                TenTS = value;
            }
        }
        public string D_VT
        {
            get
            {
                return DVT;
            }

            set
            {
                DVT = value;
            }
        }

        public int So_Luong
        {
            get
            {
                return SoLuong;
            }

            set
            {
                SoLuong = value;
            }
        }

        public int Don_Gia
        {
            get
            {
                return DonGia;
            }

            set
            {
                DonGia = value;
            }
        }

        public DateTime Ngay_Nhap
        {
            get
            {
                return NgayNhap;
            }

            set
            {
                NgayNhap = value;
            }
        }

        public string Ma_Loai
        {
            get
            {
                return MaLoai;
            }

            set
            {
                MaLoai = value;
            }
        }

        public string Ma_Xuat_Xu
        {
            get
            {
                return MaXuatXu;
            }

            set
            {
                MaXuatXu = value;
            }
        }

        public string Ma_Nguon
        {
            get
            {
                return MaNguon;
            }

            set
            {
                MaNguon = value;
            }
        }

        public string Ma_BP
        {
            get
            {
                return MaBP;
            }

            set
            {
                MaBP = value;
            }
        }

        public int Muc_KH
        {
            get
            {
                return MucKH;
            }

            set
            {
                MucKH = value;
            }
        }

        public string Tinh_Trang
        {
            get
            {
                return TinhTrang;
            }

            set
            {
                TinhTrang = value;
            }
        }

        public DTO_TaiSan()
        {

        }

        public DTO_TaiSan(string mats, string tents, string dvt, int soluong, int dongia, DateTime ngaynhap, string maloai, string maxuatxu, string manguon, string mabp, int muckh, string tinhtrang)
        {
            this.Ma_TS = mats;
            this.Ten_TS = tents;
            this.D_VT = dvt;
            this.So_Luong = soluong;
            this.Don_Gia = dongia;
            this.Ngay_Nhap = ngaynhap;
            this.Ma_Loai = maloai;
            this.Ma_Xuat_Xu = maxuatxu;
            this.Ma_Nguon = manguon;
            this.Ma_BP = mabp;
            this.MucKH = muckh;
            this.Tinh_Trang = tinhtrang;
        }
    }
}
