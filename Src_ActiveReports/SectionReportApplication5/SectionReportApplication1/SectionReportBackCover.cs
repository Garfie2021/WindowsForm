namespace SectionReportApplication1
{
    /// <summary>
    /// SectionReport3 の概要の説明です。
    /// </summary>
    public partial class SectionReportBackCover : GrapeCity.ActiveReports.SectionReport
    {

        public SectionReportBackCover(ReportDataModel reportDataModel)
        {
            //
            // デザイナー サポートに必要なメソッドです。
            //
            InitializeComponent();

            textSummary.Text = "Count : " + reportDataModel.ReportDetailList.Count.ToString();
        }
    }
}
