using SectionReportApplication1;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dataModel1 = new DataModel1
            {
                Text1 = textBox1.Text
            };

            var form1 = new Form1(dataModel1);
            form1.ShowDialog();
        }
    }
}
