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
    public partial class Frm_CapNhatTS : Form
    {
        BUS_TaiSan busTS = new BUS_TaiSan();
        BUS_XuatXu busXX = new BUS_XuatXu();
        BUS_LoaiTaiSan busLTS = new BUS_LoaiTaiSan();
        BUS_NguonQuy busNQ = new BUS_NguonQuy();
        BUS_BoPhan busBP = new BUS_BoPhan();
        public Frm_CapNhatTS()
        {
            InitializeComponent();
        }

        public string mats;
        public string tents;
        public string dvt;
        public int soluong;
        public int dongia;
        public DateTime ngaynhap;
        public string maloai;
        public string maxx;
        public string manguon;
        public string mabp;
        public int muckh;
        public string tinhtrang;

        private void Frm_CapNhatTS_Load(object sender, EventArgs e)
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

            txtMaTS.Text = mats;
            txtMaTS.Enabled = false;
            txtTenTS.Text = tents;
            cboDVT.Text = dvt;
            txtSoLuong.Text = soluong.ToString();
            txtDonGia.Text = dongia.ToString();
            dtpNgayNhap.Text = ngaynhap.ToString();
            cboMaLoai.Text = maloai;
            cboMaXX.Text = maxx;
            cboMaNguon.Text = manguon;
            cboMaBP.Text = mabp;
            cboKhauHao.Text = muckh.ToString();
            txtTinhTrang.Text = tinhtrang;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_TaiSan ts = new DTO_TaiSan(txtMaTS.Text, txtTenTS.Text, cboDVT.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text), DateTime.Parse(dtpNgayNhap.Text), cboMaLoai.Text, cboMaXX.Text, cboMaNguon.Text, cboMaBP.Text, Convert.ToInt32(cboKhauHao.Text), txtTinhTrang.Text);

            if (busTS.suaTaiSan(ts))
            {
                MessageBox.Show("Cập nhật thông tin tài sản thành công!");
                this.Close();

                Frm_TaiSan frm = new Frm_TaiSan();
                frm.gcData.DataSource = busTS.getTaiSan();

            }
            else
            {
                MessageBox.Show("Cập nhật thông tin tài sản không thành công!");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
