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
    public partial class Frm_TaiSan : DevExpress.XtraEditors.XtraForm
    {
        BUS_TaiSan busTS = new BUS_TaiSan();
        int index;

        public Frm_TaiSan()
        {
            InitializeComponent();
        }

        private void Frm_TaiSan_Load(object sender, EventArgs e)
        {
            gcData.DataSource = busTS.getTaiSan();

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_ThemTS frm = new Frm_ThemTS();
            frm.ShowDialog();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_CapNhatTS frm = new Frm_CapNhatTS();
            frm.mats = gvData.GetRowCellValue(index, "MaTS").ToString();
            frm.tents = gvData.GetRowCellValue(index, "TenTS").ToString();
            frm.dvt = gvData.GetRowCellValue(index, "DVT").ToString();
            frm.soluong = Convert.ToInt32(gvData.GetRowCellValue(index, "SoLuong").ToString());
            frm.dongia = Convert.ToInt32(gvData.GetRowCellValue(index, "DonGia").ToString());
            frm.ngaynhap = DateTime.Parse(gvData.GetRowCellValue(index, "NgayNhap").ToString());
            frm.maloai = gvData.GetRowCellValue(index, "MaLoai").ToString();
            frm.maxx = gvData.GetRowCellValue(index, "MaXuatXu").ToString();
            frm.manguon = gvData.GetRowCellValue(index, "MaNguon").ToString();
            frm.mabp = gvData.GetRowCellValue(index, "MaBP").ToString();
            frm.muckh = Convert.ToInt32(gvData.GetRowCellValue(index, "MucKH").ToString());
            frm.tinhtrang = gvData.GetRowCellValue(index, "TinhTrang").ToString();

            MessageBox.Show("Bạn muốn cập nhật tài sản có mã là: " + frm.mats);
            frm.ShowDialog();
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcData.DataSource = busTS.getTaiSan();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            string mats = gvData.GetRowCellValue(index, "MaTS").ToString();

            if (busTS.xoaTaiSan(mats))
            {
                MessageBox.Show("Xóa tài sản thành công!");
                gcData.DataSource = busTS.getTaiSan();
            }
            else
            {
                MessageBox.Show("Xóa tài sản không thành công!");
            }
        }

        private void gvData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void gcData_Click(object sender, EventArgs e)
        {

        }
    }
}