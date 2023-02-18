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
    public partial class Frm_DangNhapMoi : DevExpress.XtraEditors.XtraForm
    {
        BUS_DangNhap busDN = new BUS_DangNhap();
        public Frm_DangNhapMoi()
        {
            InitializeComponent();
        }

        private void Frm_DangNhapMoi_Load(object sender, EventArgs e)
        {
         
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string num = " ";
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            DataTable pq = busDN.getPhanQuyen(taikhoan);
            if (pq != null)
            {
                foreach (DataRow dr in pq.Rows)
                {
                    num = dr["PhanQuyen"].ToString();
                }
            }
                if (busDN.login(taikhoan, matkhau))
                {
                if (num == "admin")
                {
                    MessageBox.Show("Đăng nhập thành công! Phân quyền là: " + num.ToString());
                    this.Hide();
                    Frm_MainAdmin frm = new Frm_MainAdmin();
                   
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công! Phân quyền là: " + num.ToString());
                    this.Hide();
                    //frm_Chinh frm = new frm_Chinh();
                    Frm_MainAdmin frm = new Frm_MainAdmin();
                    frm.btnNguoiDung.Enabled = false;
                    frm.ShowDialog();
                    this.Close();
                }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                }
            }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }