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
    public partial class Frm_TimKiemTS : DevExpress.XtraEditors.XtraForm
    {
        BUS_TaiSan busTS = new BUS_TaiSan();
        public Frm_TimKiemTS()
        {
            InitializeComponent();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Frm_TimKiemTS_Load(object sender, EventArgs e)
        {
            gcData.DataSource = busTS.getTaiSan();
        }

        private void txtTuKhoa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Mã tài sản")
                gcData.DataSource = busTS.TimMa(txtTuKhoa.Text);

            if (cboTimKiem.Text == "Tên tài sản")
                gcData.DataSource = busTS.TimTen(txtTuKhoa.Text);

            if (cboTimKiem.Text == "Đơn giá")
                gcData.DataSource = busTS.TimDonGia(Convert.ToInt32(txtTuKhoa.Text));

            if (cboTimKiem.Text == "Mã loại")
                gcData.DataSource = busTS.TimMaLoai(txtTuKhoa.Text);

            if (cboTimKiem.Text == "Mã xuất xứ")
                gcData.DataSource = busTS.TimMaXuatXu(txtTuKhoa.Text);

            if (cboTimKiem.Text == "Mã nguồn")
                gcData.DataSource = busTS.TimMaNguon(txtTuKhoa.Text);

            if (cboTimKiem.Text == "Mã bộ phận")
                gcData.DataSource = busTS.TimMaBP(txtTuKhoa.Text);

            if (cboTimKiem.Text == "Tình trạng")
                gcData.DataSource = busTS.TimTinhTrang(txtTuKhoa.Text);
        }
    }
}