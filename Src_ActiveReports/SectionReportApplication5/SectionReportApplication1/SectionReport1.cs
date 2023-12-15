using System.Windows.Forms;

namespace SectionReportApplication1
{
    /// <summary>
    /// NewActiveReport1 の概要の説明です。
    /// </summary>
    public partial class SectionReport1 : GrapeCity.ActiveReports.SectionReport
    {

        public SectionReport1(ReportDataModel reportDataModel)
        {
            //
            // デザイナー サポートに必要なメソッドです。このメソッドの内容を
            //
            InitializeComponent();

            textReportNo.Text = reportDataModel.ReportNo;
            textDate.Text = reportDataModel.Date;
            textTitle.Text = reportDataModel.Title;
            textDescription.Text = reportDataModel.Description;

            DataSource = new BindingSource(reportDataModel.ReportDetailList, null);
        }
    }
}
