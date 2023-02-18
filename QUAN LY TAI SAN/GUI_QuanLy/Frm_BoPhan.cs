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
    public partial class Frm_BoPhan : DevExpress.XtraEditors.XtraForm
    {
        BUS_BoPhan busBP = new BUS_BoPhan();
        int index;
        int i;
        public Frm_BoPhan()
        {
            InitializeComponent();
        }

        private void Frm_BoPhan_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            gcData.DataSource = busBP.getBoPhan();
        }

        private void gvData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            i = 0;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaBP.Enabled = false;
        }

        private void gcData_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaBP.Text = gvData.GetRowCellValue(index, "MaBP").ToString();
            txtTenBP.Text = gvData.GetRowCellValue(index, "TenBP").ToString();
            txtChucNang.Text = gvData.GetRowCellValue(index, "ChucNang").ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            i = 1;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtMaBP.Text = "";
            txtTenBP.Text = "";
            txtChucNang.Text = "";
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (i == 1)
            {
                DTO_BoPhan bp = new DTO_BoPhan(txtMaBP.Text, txtTenBP.Text, txtChucNang.Text);

                if (busBP.ThemBoPhan(bp))
                {
                    MessageBox.Show("Thêm bộ phận mới thành công!");
                    gcData.DataSource = busBP.getBoPhan();
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                    txtMaBP.Text = "";
                    txtTenBP.Text = "";
                    txtChucNang.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm bộ phận mới không thành công!");
                }
            }
            else
            {
                DTO_BoPhan bp = new DTO_BoPhan(txtMaBP.Text, txtTenBP.Text, txtChucNang.Text);

                if (busBP.SuaBoPhan(bp))
                {
                    MessageBox.Show("Cập nhật thông tin bộ phận thành công!");
                    gcData.DataSource = busBP.getBoPhan();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    txtMaBP.Enabled = true;
                    txtMaBP.Text = "";
                    txtTenBP.Text = "";
                    txtChucNang.Text = "";
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin bộ phận không thành công!");
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            string mabp = gvData.GetRowCellValue(index, "MaBP").ToString();

            if (busBP.XoaBoPhan(mabp))
            {
                MessageBox.Show("Xóa bộ phận thành công!");
                gcData.DataSource = busBP.getBoPhan();
            }
            else
            {
                MessageBox.Show("Xóa bộ phận không thành công!");
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}