namespace SectionReportApplication1
{
    /// <summary>
    /// SectionReport3 の概要の説明です。
    /// </summary>
    partial class SectionReportBackCover
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

        #region ActiveReport Designer generated code
        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SectionReportBackCover));
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.textTitle = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textSummary = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.line4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line5 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line6 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line7 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Name = "pageHeader";
            // 
            // detail
            // 
            this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.textTitle,
            this.textSummary,
            this.line4,
            this.line5,
            this.line6,
            this.line7});
            this.detail.Height = 4.78125F;
            this.detail.Name = "detail";
            // 
            // textTitle
            // 
            this.textTitle.Height = 1.01F;
            this.textTitle.Left = 0F;
            this.textTitle.Name = "textTitle";
            this.textTitle.Style = "font-size: 30pt; text-align: center; ddo-char-set: 1";
            this.textTitle.Text = "Back cover\r\nSummary";
            this.textTitle.Top = 0.495F;
            this.textTitle.Width = 6F;
            // 
            // textSummary
            // 
            this.textSummary.Height = 1.169F;
            this.textSummary.Left = 0.211F;
            this.textSummary.Name = "textSummary";
            this.textSummary.ShrinkToFit = true;
            this.textSummary.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; ddo-char-set: 1; ddo-shrink-to-fit: true" +
    "";
            this.textSummary.Text = "Summary";
            this.textSummary.Top = 1.804125F;
            this.textSummary.Width = 5.593F;
            // 
            // line4
            // 
            this.line4.Height = 0F;
            this.line4.Left = 0.151F;
            this.line4.LineWeight = 1F;
            this.line4.Name = "line4";
            this.line4.Top = 1.781125F;
            this.line4.Width = 5.698F;
            this.line4.X1 = 0.151F;
            this.line4.X2 = 5.849F;
            this.line4.Y1 = 1.781125F;
            this.line4.Y2 = 1.781125F;
            // 
            // line5
            // 
            this.line5.Height = 0F;
            this.line5.Left = 0.151F;
            this.line5.LineWeight = 1F;
            this.line5.Name = "line5";
            this.line5.Top = 3.000125F;
            this.line5.Width = 5.698F;
            this.line5.X1 = 0.151F;
            this.line5.X2 = 5.849F;
            this.line5.Y1 = 3.000125F;
            this.line5.Y2 = 3.000125F;
            // 
            // line6
            // 
            this.line6.Height = 1.219F;
            this.line6.Left = 0.179F;
            this.line6.LineWeight = 1F;
            this.line6.Name = "line6";
            this.line6.Top = 1.781125F;
            this.line6.Width = 0F;
            this.line6.X1 = 0.179F;
            this.line6.X2 = 0.179F;
            this.line6.Y1 = 1.781125F;
            this.line6.Y2 = 3.000125F;
            // 
            // line7
            // 
            this.line7.Height = 1.219F;
            this.line7.Left = 5.842F;
            this.line7.LineWeight = 1F;
            this.line7.Name = "line7";
            this.line7.Top = 1.781125F;
            this.line7.Width = 0F;
            this.line7.X1 = 5.842F;
            this.line7.X2 = 5.842F;
            this.line7.Y1 = 1.781125F;
            this.line7.Y2 = 3.000125F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0.2395834F;
            this.pageFooter.Name = "pageFooter";
            // 
            // SectionReportBackCover
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: \"MS UI Gothic\"; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; font-family: \"MS UI Gothic\"; ddo-char-set: 12" +
            "8", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; font-style: inherit; font-family: \"MS UI Goth" +
            "ic\"; ddo-char-set: 128", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 128", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.textTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private GrapeCity.ActiveReports.SectionReportModel.TextBox textTitle;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textSummary;
        private GrapeCity.ActiveReports.SectionReportModel.Line line4;
        private GrapeCity.ActiveReports.SectionReportModel.Line line5;
        private GrapeCity.ActiveReports.SectionReportModel.Line line6;
        private GrapeCity.ActiveReports.SectionReportModel.Line line7;
    }
}
