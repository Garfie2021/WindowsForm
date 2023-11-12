namespace SectionReportApplication1
{
    /// <summary>
    /// NewActiveReport1 の概要の説明です。
    /// </summary>
    partial class SectionReport1
    {
        private GrapeCity.ActiveReports.SectionReportModel.PageHeader pageHeader;
        private GrapeCity.ActiveReports.SectionReportModel.Detail detail;
        private GrapeCity.ActiveReports.SectionReportModel.PageFooter pageFooter;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReports デザイナーで生成されたコード
        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SectionReport1));
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.textReportNo = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.textDetail1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textDetail2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textDetail3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line13 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line14 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line15 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line16 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
            this.groupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
            this.textDescription = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textTitle = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.line4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line5 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line6 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line7 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.groupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
            this.groupHeader2 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
            this.label19 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line8 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line9 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line10 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line11 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line12 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.groupFooter2 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
            ((System.ComponentModel.ISupportInitialize)(this.textReportNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDetail1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDetail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDetail3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.textReportNo,
            this.textDate});
            this.pageHeader.Height = 0.4F;
            this.pageHeader.Name = "pageHeader";
            // 
            // textReportNo
            // 
            this.textReportNo.Height = 0.2F;
            this.textReportNo.Left = 0.049F;
            this.textReportNo.Name = "textReportNo";
            this.textReportNo.Text = "ReportNo";
            this.textReportNo.Top = 0.042F;
            this.textReportNo.Width = 2.708F;
            // 
            // textDate
            // 
            this.textDate.Height = 0.2F;
            this.textDate.Left = 3.677F;
            this.textDate.Name = "textDate";
            this.textDate.Style = "text-align: right";
            this.textDate.Text = "Date";
            this.textDate.Top = 0F;
            this.textDate.Width = 2.292F;
            // 
            // detail
            // 
            this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.textDetail1,
            this.textDetail2,
            this.textDetail3,
            this.line1,
            this.line3,
            this.line13,
            this.line14,
            this.line15,
            this.line16});
            this.detail.Height = 0.2F;
            this.detail.Name = "detail";
            // 
            // textDetail1
            // 
            this.textDetail1.CanGrow = false;
            this.textDetail1.DataField = "Test1";
            this.textDetail1.Height = 0.2F;
            this.textDetail1.Left = 0.04F;
            this.textDetail1.MultiLine = false;
            this.textDetail1.Name = "textDetail1";
            this.textDetail1.Style = "font-size: 9pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
            this.textDetail1.Text = "Detail1";
            this.textDetail1.Top = 0F;
            this.textDetail1.Width = 1.896F;
            // 
            // textDetail2
            // 
            this.textDetail2.CanGrow = false;
            this.textDetail2.DataField = "Test2";
            this.textDetail2.Height = 0.2F;
            this.textDetail2.Left = 2.03F;
            this.textDetail2.MultiLine = false;
            this.textDetail2.Name = "textDetail2";
            this.textDetail2.Style = "font-size: 9pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
            this.textDetail2.Text = "Detail2";
            this.textDetail2.Top = 0F;
            this.textDetail2.Width = 1.844F;
            // 
            // textDetail3
            // 
            this.textDetail3.CanGrow = false;
            this.textDetail3.DataField = "Test3";
            this.textDetail3.Height = 0.2F;
            this.textDetail3.Left = 4.03F;
            this.textDetail3.MultiLine = false;
            this.textDetail3.Name = "textDetail3";
            this.textDetail3.Style = "font-size: 9pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
            this.textDetail3.Text = "Detail3";
            this.textDetail3.Top = 0F;
            this.textDetail3.Width = 1.927F;
            // 
            // line1
            // 
            this.line1.Height = 0F;
            this.line1.Left = 0F;
            this.line1.LineWeight = 1F;
            this.line1.Name = "line1";
            this.line1.Top = 0.19F;
            this.line1.Width = 7.844999F;
            this.line1.X1 = 0F;
            this.line1.X2 = 7.844999F;
            this.line1.Y1 = 0.19F;
            this.line1.Y2 = 0.19F;
            // 
            // line3
            // 
            this.line3.Height = 0F;
            this.line3.Left = 0F;
            this.line3.LineWeight = 1F;
            this.line3.Name = "line3";
            this.line3.Top = 0F;
            this.line3.Width = 7.845F;
            this.line3.X1 = 0F;
            this.line3.X2 = 7.845F;
            this.line3.Y1 = 0F;
            this.line3.Y2 = 0F;
            // 
            // line13
            // 
            this.line13.Height = 0.2F;
            this.line13.Left = 0.013F;
            this.line13.LineWeight = 1F;
            this.line13.Name = "line13";
            this.line13.Top = 0F;
            this.line13.Width = 0F;
            this.line13.X1 = 0.013F;
            this.line13.X2 = 0.013F;
            this.line13.Y1 = 0F;
            this.line13.Y2 = 0.2F;
            // 
            // line14
            // 
            this.line14.Height = 0.2F;
            this.line14.Left = 1.974F;
            this.line14.LineWeight = 1F;
            this.line14.Name = "line14";
            this.line14.Top = 0F;
            this.line14.Width = 0F;
            this.line14.X1 = 1.974F;
            this.line14.X2 = 1.974F;
            this.line14.Y1 = 0F;
            this.line14.Y2 = 0.2F;
            // 
            // line15
            // 
            this.line15.Height = 0.2F;
            this.line15.Left = 3.931F;
            this.line15.LineWeight = 1F;
            this.line15.Name = "line15";
            this.line15.Top = 0F;
            this.line15.Width = 0F;
            this.line15.X1 = 3.931F;
            this.line15.X2 = 3.931F;
            this.line15.Y1 = 0F;
            this.line15.Y2 = 0.2F;
            // 
            // line16
            // 
            this.line16.Height = 0.2F;
            this.line16.Left = 6.016F;
            this.line16.LineWeight = 1F;
            this.line16.Name = "line16";
            this.line16.Top = 0F;
            this.line16.Width = 0F;
            this.line16.X1 = 6.016F;
            this.line16.X2 = 6.016F;
            this.line16.Y1 = 0F;
            this.line16.Y2 = 0.2F;
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.reportInfo1});
            this.pageFooter.Name = "pageFooter";
            // 
            // reportInfo1
            // 
            this.reportInfo1.FormatString = "{PageNumber} / {PageCount}";
            this.reportInfo1.Height = 0.2F;
            this.reportInfo1.Left = 0F;
            this.reportInfo1.Name = "reportInfo1";
            this.reportInfo1.Style = "color: Black; font-size: 9pt; text-align: center; vertical-align: middle; ddo-cha" +
    "r-set: 1";
            this.reportInfo1.Top = 0.025F;
            this.reportInfo1.Width = 6F;
            // 
            // groupHeader1
            // 
            this.groupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.textDescription,
            this.textTitle,
            this.line4,
            this.line5,
            this.line6,
            this.line7});
            this.groupHeader1.Height = 1.973F;
            this.groupHeader1.Name = "groupHeader1";
            // 
            // textDescription
            // 
            this.textDescription.Height = 1.169F;
            this.textDescription.Left = 0.062F;
            this.textDescription.Name = "textDescription";
            this.textDescription.Text = "Description";
            this.textDescription.Top = 0.6020001F;
            this.textDescription.Width = 5.593F;
            // 
            // textTitle
            // 
            this.textTitle.Height = 0.375F;
            this.textTitle.Left = 0F;
            this.textTitle.Name = "textTitle";
            this.textTitle.Style = "font-size: 30pt; text-align: center; ddo-char-set: 1";
            this.textTitle.Text = "Title";
            this.textTitle.Top = 0F;
            this.textTitle.Width = 6F;
            // 
            // line4
            // 
            this.line4.Height = 0F;
            this.line4.Left = 0.002F;
            this.line4.LineWeight = 1F;
            this.line4.Name = "line4";
            this.line4.Top = 0.5790001F;
            this.line4.Width = 5.698F;
            this.line4.X1 = 0.002F;
            this.line4.X2 = 5.7F;
            this.line4.Y1 = 0.5790001F;
            this.line4.Y2 = 0.5790001F;
            // 
            // line5
            // 
            this.line5.Height = 0F;
            this.line5.Left = 0.002F;
            this.line5.LineWeight = 1F;
            this.line5.Name = "line5";
            this.line5.Top = 1.798F;
            this.line5.Width = 5.698F;
            this.line5.X1 = 0.002F;
            this.line5.X2 = 5.7F;
            this.line5.Y1 = 1.798F;
            this.line5.Y2 = 1.798F;
            // 
            // line6
            // 
            this.line6.Height = 1.219F;
            this.line6.Left = 0.03F;
            this.line6.LineWeight = 1F;
            this.line6.Name = "line6";
            this.line6.Top = 0.579F;
            this.line6.Width = 0F;
            this.line6.X1 = 0.03F;
            this.line6.X2 = 0.03F;
            this.line6.Y1 = 0.579F;
            this.line6.Y2 = 1.798F;
            // 
            // line7
            // 
            this.line7.Height = 1.219F;
            this.line7.Left = 5.693F;
            this.line7.LineWeight = 1F;
            this.line7.Name = "line7";
            this.line7.Top = 0.579F;
            this.line7.Width = 0F;
            this.line7.X1 = 5.693F;
            this.line7.X2 = 5.693F;
            this.line7.Y1 = 0.579F;
            this.line7.Y2 = 1.798F;
            // 
            // groupFooter1
            // 
            this.groupFooter1.Name = "groupFooter1";
            // 
            // groupHeader2
            // 
            this.groupHeader2.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.label19,
            this.label1,
            this.label2,
            this.line2,
            this.line8,
            this.line9,
            this.line10,
            this.line11,
            this.line12});
            this.groupHeader2.Height = 0.2F;
            this.groupHeader2.Name = "groupHeader2";
            this.groupHeader2.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.All;
            // 
            // label19
            // 
            this.label19.Height = 0.2F;
            this.label19.HyperLink = null;
            this.label19.Left = 0F;
            this.label19.MultiLine = false;
            this.label19.Name = "label19";
            this.label19.Style = "background-color: Gainsboro; font-size: 9pt; text-align: center; vertical-align: " +
    "middle; ddo-char-set: 1";
            this.label19.Text = "Detail 1 Title";
            this.label19.Top = 0F;
            this.label19.Width = 2F;
            // 
            // label1
            // 
            this.label1.Height = 0.2F;
            this.label1.HyperLink = null;
            this.label1.Left = 2F;
            this.label1.MultiLine = false;
            this.label1.Name = "label1";
            this.label1.Style = "background-color: Gainsboro; font-size: 9pt; text-align: center; vertical-align: " +
    "middle; ddo-char-set: 1";
            this.label1.Text = "Detail 2 Title";
            this.label1.Top = 0F;
            this.label1.Width = 2F;
            // 
            // label2
            // 
            this.label2.Height = 0.2F;
            this.label2.HyperLink = null;
            this.label2.Left = 4F;
            this.label2.MultiLine = false;
            this.label2.Name = "label2";
            this.label2.Style = "background-color: Gainsboro; font-size: 9pt; text-align: center; vertical-align: " +
    "middle; ddo-char-set: 1";
            this.label2.Text = "Detail 3 Title";
            this.label2.Top = 0F;
            this.label2.Width = 2F;
            // 
            // line2
            // 
            this.line2.Height = 0F;
            this.line2.Left = 0F;
            this.line2.LineWeight = 1F;
            this.line2.Name = "line2";
            this.line2.Top = 0F;
            this.line2.Width = 7.845F;
            this.line2.X1 = 0F;
            this.line2.X2 = 7.845F;
            this.line2.Y1 = 0F;
            this.line2.Y2 = 0F;
            // 
            // line8
            // 
            this.line8.Height = 0F;
            this.line8.Left = 0F;
            this.line8.LineWeight = 1F;
            this.line8.Name = "line8";
            this.line8.Top = 0.19F;
            this.line8.Width = 7.845F;
            this.line8.X1 = 0F;
            this.line8.X2 = 7.845F;
            this.line8.Y1 = 0.19F;
            this.line8.Y2 = 0.19F;
            // 
            // line9
            // 
            this.line9.Height = 0.2F;
            this.line9.Left = 0.01F;
            this.line9.LineWeight = 1F;
            this.line9.Name = "line9";
            this.line9.Top = 0F;
            this.line9.Width = 0F;
            this.line9.X1 = 0.01F;
            this.line9.X2 = 0.01F;
            this.line9.Y1 = 0F;
            this.line9.Y2 = 0.2F;
            // 
            // line10
            // 
            this.line10.Height = 0.2F;
            this.line10.Left = 1.974F;
            this.line10.LineWeight = 1F;
            this.line10.Name = "line10";
            this.line10.Top = 0F;
            this.line10.Width = 0F;
            this.line10.X1 = 1.974F;
            this.line10.X2 = 1.974F;
            this.line10.Y1 = 0F;
            this.line10.Y2 = 0.2F;
            // 
            // line11
            // 
            this.line11.Height = 0.2F;
            this.line11.Left = 3.931F;
            this.line11.LineWeight = 1F;
            this.line11.Name = "line11";
            this.line11.Top = 0F;
            this.line11.Width = 0F;
            this.line11.X1 = 3.931F;
            this.line11.X2 = 3.931F;
            this.line11.Y1 = 0F;
            this.line11.Y2 = 0.2F;
            // 
            // line12
            // 
            this.line12.Height = 0.2F;
            this.line12.Left = 6.022F;
            this.line12.LineWeight = 1F;
            this.line12.Name = "line12";
            this.line12.Top = 0F;
            this.line12.Width = 0F;
            this.line12.X1 = 6.022F;
            this.line12.X2 = 6.022F;
            this.line12.Y1 = 0F;
            this.line12.Y2 = 0.2F;
            // 
            // groupFooter2
            // 
            this.groupFooter2.Name = "groupFooter2";
            // 
            // SectionReport1
            // 
            this.MasterReport = false;
            this.PageSettings.DefaultPaperSize = false;
            this.PageSettings.PaperHeight = 11.69291F;
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.PageSettings.PaperWidth = 8.267716F;
            this.PrintWidth = 6.031F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.groupHeader1);
            this.Sections.Add(this.groupHeader2);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupFooter2);
            this.Sections.Add(this.groupFooter1);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: \"MS UI Gothic\"; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; font-family: \"MS UI Gothic\"; ddo-char-set: 12" +
            "8", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; font-style: inherit; font-family: \"MS UI Goth" +
            "ic\"; ddo-char-set: 128", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 128", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.textReportNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDetail1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDetail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDetail3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private GrapeCity.ActiveReports.SectionReportModel.TextBox textReportNo;
        public GrapeCity.ActiveReports.SectionReportModel.TextBox textDetail1;
        public GrapeCity.ActiveReports.SectionReportModel.TextBox textDetail2;
        public GrapeCity.ActiveReports.SectionReportModel.TextBox textDetail3;
        private GrapeCity.ActiveReports.SectionReportModel.Line line1;
        private GrapeCity.ActiveReports.SectionReportModel.GroupHeader groupHeader1;
        private GrapeCity.ActiveReports.SectionReportModel.GroupFooter groupFooter1;
        private GrapeCity.ActiveReports.SectionReportModel.GroupHeader groupHeader2;
        private GrapeCity.ActiveReports.SectionReportModel.Label label1;
        private GrapeCity.ActiveReports.SectionReportModel.Label label2;
        private GrapeCity.ActiveReports.SectionReportModel.Line line2;
        private GrapeCity.ActiveReports.SectionReportModel.GroupFooter groupFooter2;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textDate;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textDescription;
        private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textTitle;
        private GrapeCity.ActiveReports.SectionReportModel.Line line4;
        private GrapeCity.ActiveReports.SectionReportModel.Line line5;
        private GrapeCity.ActiveReports.SectionReportModel.Line line6;
        private GrapeCity.ActiveReports.SectionReportModel.Line line7;
        private GrapeCity.ActiveReports.SectionReportModel.Line line3;
        private GrapeCity.ActiveReports.SectionReportModel.Label label19;
        private GrapeCity.ActiveReports.SectionReportModel.Line line8;
        private GrapeCity.ActiveReports.SectionReportModel.Line line9;
        private GrapeCity.ActiveReports.SectionReportModel.Line line13;
        private GrapeCity.ActiveReports.SectionReportModel.Line line14;
        private GrapeCity.ActiveReports.SectionReportModel.Line line15;
        private GrapeCity.ActiveReports.SectionReportModel.Line line16;
        private GrapeCity.ActiveReports.SectionReportModel.Line line10;
        private GrapeCity.ActiveReports.SectionReportModel.Line line11;
        private GrapeCity.ActiveReports.SectionReportModel.Line line12;
    }
}
