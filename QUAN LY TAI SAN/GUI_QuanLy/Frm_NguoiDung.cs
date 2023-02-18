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
    public partial class Frm_NguoiDung : DevExpress.XtraEditors.XtraForm
    {
        BUS_DangNhap busDN = new BUS_DangNhap();
        int index;
        int i;
        public Frm_NguoiDung()
        {
            InitializeComponent();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Frm_NguoiDung_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMatKhau.Enabled = false;
            txtTaiKhoan.Enabled = false;
            gcData.DataSource = busDN.getNguoiDung();
        }

        private void gvData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gcData_MouseClick(object sender, MouseEventArgs e)
        {
            txtTaiKhoan.Text = gvData.GetRowCellValue(index, "TaiKhoan").ToString();
            txtMatKhau.Text = gvData.GetRowCellValue(index, "MatKhau").ToString();
            txtPhanQuyen.Text = gvData.GetRowCellValue(index, "PhanQuyen").ToString();
            txtHoTen.Text = gvData.GetRowCellValue(index, "HoTen").ToString();
            dtpNgaySinh.Text = gvData.GetRowCellValue(index, "NgaySinh").ToString();
            txtChucVu.Text = gvData.GetRowCellValue(index, "ChucVu").ToString();
            txtDienThoai.Text = gvData.GetRowCellValue(index, "DienThoai").ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            i = 1;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtPhanQuyen.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            txtChucVu.Text = "";
            txtDienThoai.Text = "";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            i = 0;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTaiKhoan.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (i == 1)
            {
                DTO_DangNhap nd = new DTO_DangNhap(txtTaiKhoan.Text, txtMatKhau.Text, txtPhanQuyen.Text, txtHoTen.Text, DateTime.Parse(dtpNgaySinh.Text), txtChucVu.Text, txtDienThoai.Text);

                if (busDN.ThemNguoiDung(nd))
                {
                    MessageBox.Show("Thêm người dùng mới thành công!");
                    gcData.DataSource = busDN.getNguoiDung();
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtPhanQuyen.Text = "";
                    txtHoTen.Text = "";
                    dtpNgaySinh.Text = "";
                    txtChucVu.Text = "";
                    txtDienThoai.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm người dùng mới không thành công!");
                }
            }
            else
            {
                DTO_DangNhap nd = new DTO_DangNhap(txtTaiKhoan.Text, txtMatKhau.Text, txtPhanQuyen.Text, txtHoTen.Text, DateTime.Parse(dtpNgaySinh.Text), txtChucVu.Text, txtDienThoai.Text);

                if (busDN.SuaNguoiDung(nd))
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thành công!");
                    gcData.DataSource = busDN.getNguoiDung();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    txtTaiKhoan.Enabled = true;
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtPhanQuyen.Text = "";
                    txtHoTen.Text = "";
                    dtpNgaySinh.Text = "";
                    txtChucVu.Text = "";
                    txtDienThoai.Text = "";
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin người dùng không thành công!");
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            string taikhoan = gvData.GetRowCellValue(index, "TaiKhoan").ToString();

            if (busDN.XoaNguoiDung(taikhoan))
            {
                MessageBox.Show("Xóa người dùng thành công!");
                gcData.DataSource = busDN.getNguoiDung();
            }
            else
            {
                MessageBox.Show("Xóa người dùng không thành công!");
            }
        }
    }
}