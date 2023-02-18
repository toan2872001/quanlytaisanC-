using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace GUI_QuanLy
{
    public partial class Frm_MainAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_MainAdmin()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DoiMatKhau forms = new Frm_DoiMatKhau();
            forms.ShowDialog();
        }

        private void Frm_MainAdmin_Load(object sender, EventArgs e)
        {

        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_DoiMatKhau));
            if (frm == null)
            {
                Frm_DoiMatKhau forms = new Frm_DoiMatKhau();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();

            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Hide();
               
                frm_ChaoMung frm = new frm_ChaoMung();
                frm.ShowDialog();
                 
             this.Close();
               

        }

        private void btnQuanLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_TaiSan));
            if (frm == null)
            {
                Frm_TaiSan forms = new Frm_TaiSan();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();

            }
        }



        private void btnThongKeTS_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnNhapXutaTS_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnNhapTS_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_NhapTS));
            if (frm == null)
            {
                Frm_NhapTS forms = new Frm_NhapTS();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();

            }
        }

        




        private void btnNguonQuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_NguonQuy));
            if (frm == null)
            {
                Frm_NguonQuy forms = new Frm_NguonQuy();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnLoaiTS_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_LoaiTaiSan));
            if (frm == null)
            {
                Frm_LoaiTaiSan forms = new Frm_LoaiTaiSan();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnXuatXu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_XuatXu));
            if (frm == null)
            {
                Frm_XuatXu forms = new Frm_XuatXu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_BoPhan));
            if (frm == null)
            {
                Frm_BoPhan forms = new Frm_BoPhan();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }







        private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_NguoiDung));
            if (frm == null)
            {
                Frm_NguoiDung forms = new Frm_NguoiDung();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnTimKiemTS_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_TimKiemTS));
            if (frm == null)
            {
                Frm_TimKiemTS forms = new Frm_TimKiemTS();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnThanhLyTS_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_ThanhLyTS));
            if (frm == null)
            {
                Frm_ThanhLyTS forms = new Frm_ThanhLyTS();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

  

        

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_lienhe frm = new Frm_lienhe();
           
            frm.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnBaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_BCTS));
            if (frm == null)
            {
                Frm_BCTS forms = new Frm_BCTS();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();

            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}