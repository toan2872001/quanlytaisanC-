using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_BoPhan
    {
        private string MaBP;
        private string TenBP;
        private string ChucNang;

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

        public string Ten_BP
        {
            get
            {
                return TenBP;
            }

            set
            {
                TenBP = value;
            }
        }

        public string Chuc_Nang
        {
            get
            {
                return ChucNang;
            }

            set
            {
                ChucNang = value;
            }
        }

        public DTO_BoPhan()
        {

        }

        public DTO_BoPhan(string mabp, string tenbp, string chucnang)
        {
            this.Ma_BP = mabp;
            this.Ten_BP = tenbp;
            this.ChucNang = chucnang;

        }
    }
}
