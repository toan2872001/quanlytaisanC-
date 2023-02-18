using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class frm_ChaoMung : Form
    {
        public frm_ChaoMung()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhapMoi frm = new Frm_DangNhapMoi();
            frm.ShowDialog();
            this.Close();
        }

        private void frm_ChaoMung_Load(object sender, EventArgs e)
        {

        }
    }
}
