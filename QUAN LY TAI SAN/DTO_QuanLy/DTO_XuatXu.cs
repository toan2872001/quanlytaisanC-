using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_XuatXu
    {
        private string MaXuatXu;
        private string NoiXuatXu;


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

        public string Noi_Xuat_Xu
        {
            get
            {
                return NoiXuatXu;
            }

            set
            {
                NoiXuatXu = value;
            }
        }

        public DTO_XuatXu()
        {

        }

        public DTO_XuatXu(string manxuatxu, string noixuatxu)
        {
            this.Ma_Xuat_Xu = manxuatxu;
            this.Noi_Xuat_Xu = noixuatxu;
        }
    }
}
