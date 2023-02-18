using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_NguonQuy
    {
        private string MaNguon;
        private string TenNguon;
       

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

        public string Ten_Nguon
        {
            get
            {
                return TenNguon;
            }

            set
            {
                TenNguon = value;
            }
        }

        public DTO_NguonQuy()
        {

        }

        public DTO_NguonQuy(string manguon, string tennguon)
        {
            this.Ma_Nguon = manguon;
            this.Ten_Nguon = tennguon;
        }
    }
}
