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
    public partial class Frm_XuatXu : DevExpress.XtraEditors.XtraForm
    {
        BUS_XuatXu busXX = new BUS_XuatXu();
        int index;
        int i;
        public Frm_XuatXu()
        {
            InitializeComponent();
        }

        private void Frm_XuatXu_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            gcData.DataSource = busXX.getXuatXu();
        }

        private void gvData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gcData_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaXX.Text = gvData.GetRowCellValue(index, "MaXuatXu").ToString();
            txtNoiXX.Text = gvData.GetRowCellValue(index, "NoiXuatXu").ToString();           
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            i = 1;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtMaXX.Text = "";
            txtNoiXX.Text = "";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            i = 0;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaXX.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (i == 1)
            {
                DTO_XuatXu xx = new DTO_XuatXu(txtMaXX.Text, txtNoiXX.Text);

                if (busXX.themXuatXu(xx))
                {
                    MessageBox.Show("Thêm xuất xứ mới thành công!");
                    gcData.DataSource = busXX.getXuatXu();
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                    txtMaXX.Text = "";
                    txtNoiXX.Text = "";                  
                }
                else
                {
                    MessageBox.Show("Thêm xuất xứ mới không thành công!");
                }
            }
            else
            {
                DTO_XuatXu xx = new DTO_XuatXu(txtMaXX.Text, txtNoiXX.Text);

                if (busXX.suaXuatXu(xx))
                {
                    MessageBox.Show("Cập nhật thông tin xuất xứ thành công!");
                    gcData.DataSource = busXX.getXuatXu();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    txtMaXX.Enabled = true;
                    txtMaXX.Text = "";
                    txtNoiXX.Text = "";          
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin xuất xứ không thành công!");
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            string maxx = gvData.GetRowCellValue(index, "MaXuatXu").ToString();

            if (busXX.xoaXuatXu(maxx))
            {
                MessageBox.Show("Xóa xuất xứ thành công!");
                gcData.DataSource = busXX.getXuatXu();
            }
            else
            {
                MessageBox.Show("Xóa xuất xứ không thành công!");
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}