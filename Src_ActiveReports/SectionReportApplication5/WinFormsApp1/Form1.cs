using SectionReportApplication1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ReportDataModel _ReportDataModel;

        public Form1(ReportDataModel reportDataModel)
        {
            _ReportDataModel = reportDataModel;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sectionReportFrontCover = new SectionReportFrontCover();
            sectionReportFrontCover.Run();

            var sectionReport1 = new SectionReport1(_ReportDataModel);
            sectionReport1.Run();

            var sectionReportBackCover = new SectionReportBackCover(_ReportDataModel);
            sectionReportBackCover.Run();

            sectionReportFrontCover.Document.Pages.AddRange((GrapeCity.ActiveReports.Document.Section.PagesCollection)sectionReport1.Document.Pages.Clone());
            sectionReportFrontCover.Document.Pages.AddRange((GrapeCity.ActiveReports.Document.Section.PagesCollection)sectionReportBackCover.Document.Pages.Clone());

            viewer1.LoadDocument(sectionReportFrontCover.Document);
        }
    }
}