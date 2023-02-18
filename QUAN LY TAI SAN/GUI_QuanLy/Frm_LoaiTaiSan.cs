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
    public partial class Frm_LoaiTaiSan : DevExpress.XtraEditors.XtraForm
    {
        BUS_LoaiTaiSan busLTS = new BUS_LoaiTaiSan();
        int index;
        int i;
        public Frm_LoaiTaiSan()
        {
            InitializeComponent();
        }

        private void Frm_LoaiTaiSan_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            gcData.DataSource = busLTS.getLoaiTaiSan();
        }

        private void gvData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gcData_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaLoai.Text = gvData.GetRowCellValue(index, "MaLoai").ToString();
            txtTenLoai.Text = gvData.GetRowCellValue(index, "TenLoai").ToString();
            txtKhauHao.Text = gvData.GetRowCellValue(index, "KhauHao").ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            i = 1;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtKhauHao.Text = "";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            i = 0;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaLoai.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (i == 1)
            {
                DTO_LoaiTaiSan lts = new DTO_LoaiTaiSan(txtMaLoai.Text, txtTenLoai.Text, Convert.ToInt32(txtKhauHao.Text));

                if (busLTS.ThemLoaiTaiSan(lts))
                {
                    MessageBox.Show("Thêm loại mới thành công!");
                    gcData.DataSource = busLTS.getLoaiTaiSan();
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                    txtMaLoai.Text = "";
                    txtTenLoai.Text = "";
                    txtKhauHao.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm loại mới không thành công!");
                }
            }
            else
            {
                DTO_LoaiTaiSan lts = new DTO_LoaiTaiSan(txtMaLoai.Text, txtTenLoai.Text, Convert.ToInt32(txtKhauHao.Text));

                if (busLTS.SuaLoaiTaiSan(lts))
                {
                    MessageBox.Show("Cập nhật thông tin loại tài sản thành công!");
                    gcData.DataSource = busLTS.getLoaiTaiSan();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    txtMaLoai.Enabled = true;
                    txtMaLoai.Text = "";
                    txtTenLoai.Text = "";
                    txtKhauHao.Text = "";
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin loại tài sản không thành công!");
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            string maloai = gvData.GetRowCellValue(index, "MaLoai").ToString();

            if (busLTS.XoaLoaiTaiSan(maloai))
            {
                MessageBox.Show("Xóa loại tài sản thành công!");
                gcData.DataSource = busLTS.getLoaiTaiSan();
            }
            else
            {
                MessageBox.Show("Xóa loại tài sản không thành công!");
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}