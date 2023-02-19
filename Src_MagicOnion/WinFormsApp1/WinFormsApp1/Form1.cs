using Grpc.Net.Client;
using MagicOnion.Client;
using WebApplication1.Shared;

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
            var channel = GrpcChannel.ForAddress("https://localhost:7120");

            // Create a proxy to call the server transparently.
            var client = MagicOnionClient.Create<IMyFirstService>(channel);

            // Call the server-side method using the proxy.
            var result = (await client.SumAsync(123, 456));
            textBox1.Text = result.ToString();
        }

    }
}