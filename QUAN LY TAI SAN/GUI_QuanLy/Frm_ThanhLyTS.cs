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
    public partial class Frm_ThanhLyTS : DevExpress.XtraEditors.XtraForm
    {
        BUS_TaiSan busTS = new BUS_TaiSan();
        BUS_ThanhLyTS busTL = new BUS_ThanhLyTS();
        int index;
        public Frm_ThanhLyTS()
        {
            InitializeComponent();
        }

        private void Frm_ThanhLyTS_Load(object sender, EventArgs e)
        {
            gcTaiSan.DataSource = busTS.getTaiSan();
            gcThanhLyTS.DataSource = busTL.getThanhLyTS();
            //txtMaTS.Enabled = false;
            //txtTenTS.Enabled = false;
            //txtDVT1.Enabled = false;
            //txtMaLoai.Enabled = false;


        }              

        private void gcTaiSan_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaTS.Text = gvTaiSan.GetRowCellValue(index, "MaTS").ToString();
            txtTenTS.Text = gvTaiSan.GetRowCellValue(index, "TenTS").ToString();
            txtDVT1.Text = gvTaiSan.GetRowCellValue(index, "DVT").ToString();
            txtSoLuong1.Text = gvTaiSan.GetRowCellValue(index, "SoLuong").ToString();
            txtDonGia1.Text = gvTaiSan.GetRowCellValue(index, "DonGia").ToString();
            txtNgayNhap1.Text = gvTaiSan.GetRowCellValue(index, "NgayNhap").ToString();
            txtMaLoai.Text = gvTaiSan.GetRowCellValue(index, "MaLoai").ToString();
            txtMaXX1.Text = gvTaiSan.GetRowCellValue(index, "MaXuatXu").ToString();
            txtMaNguon1.Text = gvTaiSan.GetRowCellValue(index, "MaNguon").ToString();
            txtMaBP1.Text = gvTaiSan.GetRowCellValue(index, "MaBP").ToString();
            txtMucKH.Text = gvTaiSan.GetRowCellValue(index, "MucKH").ToString();
            txtTinhTrang1.Text = gvTaiSan.GetRowCellValue(index, "TinhTrang").ToString();
        }

        private void btnThanhLy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string mts = gvTaiSan.GetRowCellValue(index, "MaTS").ToString();

            DTO_ThanhLyTS tl = new DTO_ThanhLyTS(txtMaTS.Text, txtTenTS.Text, txtDVT1.Text, Convert.ToInt32(txtSoLuong1.Text), txtMaLoai.Text, txtMaXX1.Text, txtMaNguon1.Text, txtMaBP1.Text, Convert.ToInt32(txtMucKH.Text), txtTinhTrang1.Text);

            if (busTL.ThemThanhLyTS(tl))
            {
                MessageBox.Show("Thêm tài sản " + mts + " vào danh sách thanh lý thành công!");
                busTL.CapNhatTinhTrang(mts);
                gcThanhLyTS.DataSource = busTL.getThanhLyTS();

                busTS.xoaTaiSan(mts);
                gcTaiSan.DataSource = busTS.getTaiSan();
            }
            else
            {
                MessageBox.Show("Thêm tài sản vào danh sách thanh lý không thành công!");
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gvTaiSan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            string mats = gvTaiSan.GetRowCellValue(index, "MaTS").ToString();

            if (busTS.xoaTaiSan(mats))
            {
                MessageBox.Show("Xóa tài sản thành công!");
                gcTaiSan.DataSource = busTS.getTaiSan();
            }
            else
            {
                MessageBox.Show("Xóa tài sản không thành công!");
            }
        }
    }
}