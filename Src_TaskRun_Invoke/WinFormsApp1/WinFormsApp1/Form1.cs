namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "aaaaa";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                textBox1.Text = "bbbbb";
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var value = "ccccc";
                Invoke(() =>
                {
                    textBox1.Text = value;
                });
            });
        }
    }
}