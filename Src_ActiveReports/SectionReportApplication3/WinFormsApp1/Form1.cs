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
            viewer1.LoadDocument(new SectionReport1(_ReportDataModel));
        }
    }
}