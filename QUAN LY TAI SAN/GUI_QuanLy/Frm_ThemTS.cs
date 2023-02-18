using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class Frm_ThemTS : Form
    {
        BUS_TaiSan busTS = new BUS_TaiSan();
        BUS_XuatXu busXX = new BUS_XuatXu();
        BUS_LoaiTaiSan busLTS = new BUS_LoaiTaiSan();
        BUS_NguonQuy busNQ = new BUS_NguonQuy();
        BUS_BoPhan busBP = new BUS_BoPhan();

        public Frm_ThemTS()
        {
            InitializeComponent();
        }

        private void Frm_ThemTS_Load(object sender, EventArgs e)
        {
            cboMaXX.DataSource = busXX.getXuatXu();
            cboMaXX.DisplayMember = "MaXuatXu";
            cboMaXX.ValueMember = "MaXuatXu";

            cboMaNguon.DataSource = busNQ.getNguonQuy();
            cboMaNguon.DisplayMember = "MaNguon";
            cboMaNguon.ValueMember = "MaNguon";

            cboMaBP.DataSource = busBP.getBoPhan();
            cboMaBP.DisplayMember = "MaBP";
            cboMaBP.ValueMember = "MaBP";

            cboMaLoai.DataSource = busLTS.getLoaiTaiSan();
            cboMaLoai.DisplayMember = "MaLoai";
            cboMaLoai.ValueMember = "MaLoai";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DTO_TaiSan ts = new DTO_TaiSan(txtMaTS.Text, txtTenTS.Text, cboDVT.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text), DateTime.Parse(dtpNgayNhap.Text), cboMaLoai.Text, cboMaXX.Text, cboMaNguon.Text, cboMaBP.Text, Convert.ToInt32(cboKhauHao.Text), txtTinhTrang.Text);

            if (busTS.themTaiSan(ts))
            {
                MessageBox.Show("Thêm tài sản mới thành công!");
                this.Hide();
                Frm_TaiSan frm = new Frm_TaiSan();
                frm.gcData.DataSource = busTS.getTaiSan();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm tài sản mới không thành công!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
