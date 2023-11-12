using SectionReportApplication1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DataModel1 _DataModel1;

        public Form1(DataModel1 dataModel1)
        {
            _DataModel1 = dataModel1;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewer1.LoadDocument(new SectionReport1(_DataModel1));
        }
    }
}