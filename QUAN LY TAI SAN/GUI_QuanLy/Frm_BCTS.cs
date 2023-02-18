using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class Frm_BCTS : DevExpress.XtraEditors.XtraForm
    {
        BUS_TaiSan busTS = new BUS_TaiSan();
        public Frm_BCTS()
        {
            InitializeComponent();
        }

        private void Frm_BCTS_Load(object sender, EventArgs e)
        {
            gcData.DataSource = busTS.getTaiSan();
        }

        private void btnBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvData.BestFitColumns();
            Frm_BaoCaoTS report = new Frm_BaoCaoTS();
            report.GridControl = gcData;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
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