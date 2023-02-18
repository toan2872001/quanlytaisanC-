using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;

namespace GUI_QuanLy
{
    public partial class Frm_BaoCaoTS : DevExpress.XtraReports.UI.XtraReport
    {
        public Frm_BaoCaoTS()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblThoiGian = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.pccReport = new DevExpress.XtraReports.UI.PrintableComponentContainer();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.lblThoiGian,
            this.xrLabel2});
            this.topMarginBand1.HeightF = 101F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(42.25F, 9.999996F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(243.4028F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "TRƯỜNG ĐẠI HỌC Thành Đông";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.LocationFloat = new DevExpress.Utils.PointFloat(486.5417F, 9.999996F);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblThoiGian.SizeF = new System.Drawing.SizeF(225.8195F, 23F);
            this.lblThoiGian.Text =string.Format("Hải Dương, ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(113.0834F, 43.41666F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(539.5833F, 34.45834F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "BÁO CÁO TÌNH HÌNH TẢI SẢN ĐƠN VỊ";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pccReport});
            this.detailBand1.HeightF = 195.4861F;
            this.detailBand1.Name = "detailBand1";
            // 
            // pccReport
            // 
            this.pccReport.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.999996F);
            this.pccReport.Name = "pccReport";
            this.pccReport.SizeF = new System.Drawing.SizeF(747.0001F, 159.375F);
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 100F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // Frm_BaoCaoTS
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1});
            this.Margins = new System.Drawing.Printing.Margins(15, 41, 101, 100);
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private TopMarginBand topMarginBand1;
        private XRLabel xrLabel1;
        private XRLabel lblThoiGian;
        private XRLabel xrLabel2;
        private DetailBand detailBand1;
        private PrintableComponentContainer pccReport;
        private BottomMarginBand bottomMarginBand1;
        private GridControl control;
        public GridControl GridControl
        {
            get
            {
                return control;
            }
            set
            {
                control = value;
                pccReport.PrintableComponent = control;
            }
        }

        
    }
}
