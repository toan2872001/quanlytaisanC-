using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class Frm_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        BUS_DangNhap busDN = new BUS_DangNhap();
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string mkc = txtMKC.Text;
            string mkm = txtMKM.Text;
            string nhaplai = txtNhapLai.Text;
            int i = busDN.KTMatKhau(mkc).Rows.Count;
            DTO_DangNhap d = new DTO_DangNhap(txtTaiKhoan.Text, mkm);
            if (txtMKC.Text != "" && txtMKM.Text != "" && txtNhapLai.Text != "")
            {
                if (i <= 0)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng. Nhập lại!");
                }
                else if (string.Compare(mkm, nhaplai) == 1)
                {
                    MessageBox.Show("Xác nhận mật khẩu mới chưa đúng. Nhập lại!");
                }
                else
                {
                    if (busDN.doimatkhau(d, txtTaiKhoan.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}