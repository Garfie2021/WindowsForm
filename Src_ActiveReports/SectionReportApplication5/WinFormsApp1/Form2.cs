using GrapeCity.ActiveReports.Export.Pdf.Section;
using SectionReportApplication1;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textReportNo.Text = "R-00001";
            textDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            textTitle.Text = "Report Title ABC";
            textDescription.Text = @"Report Description ABCDEFG
12345678890";

            textDetail1.Text = "Detail1 ABC ";
            textDetail2.Text = "Detail1 ABC ";
            textDetail3.Text = "Detail1 ABC ";
            textNumberOfLines.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reportDataModel = new ReportDataModel
            {
                ReportNo = textReportNo.Text,
                Date = textDate.Text,
                Title = textTitle.Text,
                Description = textDescription.Text,
            };

            var max = int.Parse(textNumberOfLines.Text);
            for (var cnt = 0; cnt < max; cnt++)
            {
                reportDataModel.ReportDetailList.Add(new ReportDataModelDetail1
                {
                    Test1 = textDetail1.Text + $" cnt={cnt}",
                    Test2 = textDetail2.Text + $" cnt={cnt}",
                    Test3 = textDetail3.Text + $" cnt={cnt}",
                });
            }

            var form1 = new Form1(reportDataModel);
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reportDataModel = new ReportDataModel
            {
                ReportNo = textReportNo.Text,
                Date = textDate.Text,
                Title = textTitle.Text,
                Description = textDescription.Text,
            };

            var max = int.Parse(textNumberOfLines.Text);
            for (var cnt = 0; cnt < max; cnt++)
            {
                reportDataModel.ReportDetailList.Add(new ReportDataModelDetail1
                {
                    Test1 = textDetail1.Text + $" cnt={cnt}",
                    Test2 = textDetail2.Text + $" cnt={cnt}",
                    Test3 = textDetail3.Text + $" cnt={cnt}",
                });
            }

            var sectionReportFrontCover = new SectionReportFrontCover();
            sectionReportFrontCover.Run();

            var sectionReport1 = new SectionReport1(reportDataModel);
            sectionReport1.Run();

            var sectionReportBackCover = new SectionReportBackCover(reportDataModel);
            sectionReportBackCover.Run();

            sectionReportFrontCover.Document.Pages.AddRange((GrapeCity.ActiveReports.Document.Section.PagesCollection)sectionReport1.Document.Pages.Clone());
            sectionReportFrontCover.Document.Pages.AddRange((GrapeCity.ActiveReports.Document.Section.PagesCollection)sectionReportBackCover.Document.Pages.Clone());

            using (var export = new PdfExport())
            {
                export.Export(sectionReportFrontCover.Document, @"C:\temp\sample4.pdf");
            }

            MessageBox.Show("PDFファイルを作成しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
