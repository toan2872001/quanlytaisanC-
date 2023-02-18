using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.IO;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class Frm_NhapTS : DevExpress.XtraEditors.XtraForm
    {
        BUS_TaiSan busTS = new BUS_TaiSan();
        int index;
        public Frm_NhapTS()
        {
            InitializeComponent();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DTO_TaiSan ts = new DTO_TaiSan(txtMaTS.Text, txtTenTS.Text, txtDVT.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text), DateTime.Parse(txtNgayNhap.Text), txtMaLoai.Text, txtMaXX.Text, txtMaNguon.Text, txtMaBP.Text, Convert.ToInt32(txtMucKH.Text), txtTinhTrang.Text);

            if (busTS.themTaiSan(ts))
            {
                MessageBox.Show("Thêm tài sản mới thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tài sản mới không thành công!");
            }
        }

        private void gvData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gcData_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaTS.Text = gvData.GetRowCellValue(index, "MaTS").ToString();
            txtTenTS.Text = gvData.GetRowCellValue(index, "TenTS").ToString();
            txtDVT.Text = gvData.GetRowCellValue(index, "DVT").ToString();
            txtSoLuong.Text = gvData.GetRowCellValue(index, "SoLuong").ToString();
            txtDonGia.Text = gvData.GetRowCellValue(index, "DonGia").ToString();
            txtNgayNhap.Text = gvData.GetRowCellValue(index, "NgayNhap").ToString();
            txtMaLoai.Text = gvData.GetRowCellValue(index, "MaLoai").ToString();
            txtMaXX.Text = gvData.GetRowCellValue(index, "MaXuatXu").ToString();
            txtMaNguon.Text = gvData.GetRowCellValue(index, "MaNguon").ToString();
            txtMaBP.Text = gvData.GetRowCellValue(index, "MaBP").ToString();
            txtMucKH.Text = gvData.GetRowCellValue(index, "MucKH").ToString();
            txtTinhTrang.Text = gvData.GetRowCellValue(index, "TinhTrang").ToString();
        }

        private void btnNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= '" + txtFileName.Text + "'" +
                   @"; Extended Properties=""Excel 8.0; HDR=Yes; IMEX=1; ImportMixedTypes=Text; TypeGuessRows=1""";

                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [SHEET1$]", cnn);
                OleDbDataAdapter adt = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adt.Fill(ds);
                gcData.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! Không đọc được tệp Excel" + ex.Message);
            }
        }

        private void btnDuongDan_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // Lấy đường dẫn file import vừa chọn
            txtFileName.Text = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : "";
        }
    }
}