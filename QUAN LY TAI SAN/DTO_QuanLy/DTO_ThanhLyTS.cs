using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_ThanhLyTS
    {
        private string MaTS;
        private string TenTS;
        private string DVT;
        private int SoLuong;
        private string MaLoai;
        private string MaXuatXu;
        private string MaNguon;
        private string MaBP;
        public int MucKH;
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

        public DTO_ThanhLyTS()
        {

        }

        public DTO_ThanhLyTS(string mats, string tents, string dvt, int soluong, string maloai, string maxuatxu, string manguon, string mabp, int muckh, string tinhtrang)
        {
            this.Ma_TS = mats;
            this.Ten_TS = tents;
            this.D_VT = dvt;
            this.So_Luong = soluong;
            this.Ma_Loai = maloai;
            this.Ma_Xuat_Xu = maxuatxu;
            this.Ma_Nguon = manguon;
            this.Ma_BP = mabp;
            this.Muc_KH = muckh;
            this.Tinh_Trang = tinhtrang;
        }
    }
}
