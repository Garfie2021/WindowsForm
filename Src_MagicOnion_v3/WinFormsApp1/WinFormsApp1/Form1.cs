using ClassLibrary1.Interface;
using ClassLibrary1.Model;
using Grpc.Net.Client;
using MagicOnion.Client;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Connect to the server using gRPC channel.
            var channel = GrpcChannel.ForAddress("https://localhost:7061");

            // Create a proxy to call the server transparently.
            var client = MagicOnionClient.Create<IMyFirstService>(channel);

            // Call the server-side method using the proxy.
            var result = (await client.SumAsync(123, 456));
            textBox1.Text = result.ToString();

            var modelClassA1 = new ModelClassA()
            {
                IntA = 1,
                StringA = "aa"
                ,ColorA = Color.FromArgb(10, 20, 30)
            };
            var modelClassA2 = new ModelClassA()
            {
                IntA = 2,
                StringA = "bb"
                ,ColorA = Color.FromArgb(10, 20, 30)
            };
            var resultModelClassA = (await client.Sum2Async(modelClassA1, modelClassA2));
            textBox1.Text = resultModelClassA.IntA.ToString() + " " + resultModelClassA.StringA;
        }
    }
}