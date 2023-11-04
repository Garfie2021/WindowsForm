namespace SectionReportApplication1
{
    /// <summary>
    /// NewActiveReport1 の概要の説明です。
    /// </summary>
    public partial class SectionReport1 : GrapeCity.ActiveReports.SectionReport
    {

        public SectionReport1(DataModel1 dataModel1)
        {
            //
            // デザイナー サポートに必要なメソッドです。このメソッドの内容を
            //
            InitializeComponent();

            textBox1.Text = dataModel1.Text1;

        }
    }
}
