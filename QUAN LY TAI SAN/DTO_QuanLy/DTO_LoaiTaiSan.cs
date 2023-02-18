using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_LoaiTaiSan
    {
        private string MaLoai;
        private string TenLoai;
        private int KhauHao;

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

        public string Ten_Loai
        {
            get
            {
                return TenLoai;
            }

            set
            {
                TenLoai = value;
            }
        }

        public int Khau_Hao
        {
            get
            {
                return KhauHao;
            }

            set
            {
                KhauHao = value;
            }
        }

        public DTO_LoaiTaiSan()
        {

        }

        public DTO_LoaiTaiSan(string maloai, string tenloai, int khauhao)
        {
            this.Ma_Loai = maloai;
            this.Ten_Loai = tenloai;
            this.KhauHao = khauhao;

        }
    }
}
