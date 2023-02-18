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
    public partial class Frm_NguonQuy : DevExpress.XtraEditors.XtraForm
    {
        BUS_NguonQuy busNQ = new BUS_NguonQuy();
        int index;
        int i;
        public Frm_NguonQuy()
        {
            InitializeComponent();
        }

        private void gvData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gcData_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaNguon.Text = gvData.GetRowCellValue(index, "MaNguon").ToString();
            txtTenNguon.Text = gvData.GetRowCellValue(index, "TenNguon").ToString();
        }

        private void Frm_NguonQuy_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            gcData.DataSource = busNQ.getNguonQuy();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            i = 1;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtMaNguon.Text = "";
            txtTenNguon.Text = "";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            i = 0;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaNguon.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (i == 1)
            {
                DTO_NguonQuy nq = new DTO_NguonQuy(txtMaNguon.Text, txtTenNguon.Text);

                if (busNQ.ThemNguonQuy(nq))
                {
                    MessageBox.Show("Thêm nguồn quỹ mới thành công!");
                    gcData.DataSource = busNQ.getNguonQuy();
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                    txtMaNguon.Text = "";
                    txtTenNguon.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm nguồn quỹ mới không thành công!");
                }
            }
            else
            {
                DTO_NguonQuy nq = new DTO_NguonQuy(txtMaNguon.Text, txtTenNguon.Text);

                if (busNQ.SuaNguonQuy(nq))
                {
                    MessageBox.Show("Cập nhật thông tin nguồn quỹ thành công!");
                    gcData.DataSource = busNQ.getNguonQuy();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    txtMaNguon.Enabled = true;
                    txtMaNguon.Text = "";
                    txtTenNguon.Text = "";
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nguồn quỹ không thành công!");
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            string manguon = gvData.GetRowCellValue(index, "MaNguon").ToString();

            if (busNQ.XoaNguonQuy(manguon))
            {
                MessageBox.Show("Xóa nguồn quỹ thành công!");
                gcData.DataSource = busNQ.getNguonQuy();
            }
            else
            {
                MessageBox.Show("Xóa nguồn quỹ không thành công!");
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}