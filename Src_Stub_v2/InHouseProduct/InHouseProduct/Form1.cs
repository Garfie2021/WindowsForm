using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdPartyProducts;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIsStarted_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Execute IsStarted... ");
            var result = ThirdPartyProductOps.IsStarted.ToString();
            Debug.WriteLine("Result: " + result);
        }

        private void btnStartup_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Execute Started... ");
            var result = ThirdPartyProductOps.Startup().ToString();
            Debug.WriteLine("Result: " + result);
        }

        private void btnTransaction1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Execute Transaction1... ");
            var result = ThirdPartyProductOps.Transaction1().ToString();
            Debug.WriteLine("Result: " + result);
        }

        private void btnTransaction2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Execute Transaction2... ");
            var result = ThirdPartyProductOps.Transaction2().ToString();
            Debug.WriteLine("Result: " + result);
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Execute Shutdown... ");
            var result = ThirdPartyProductOps.Shutdown().ToString();
            Debug.WriteLine("Result: " + result);
        }

        private void btnAllExecute_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Execute IsStarted... ");
            var result = ThirdPartyProductOps.IsStarted.ToString();
            Debug.WriteLine("Result: " + result);

            Debug.WriteLine("Execute Started... ");
            result = ThirdPartyProductOps.Startup().ToString();
            Debug.WriteLine("Result: " + result);

            Debug.WriteLine("Execute Transaction1... ");
            result = ThirdPartyProductOps.Transaction1().ToString();
            Debug.WriteLine("Result: " + result);

            Debug.WriteLine("Execute Transaction2... ");
            result = ThirdPartyProductOps.Transaction2().ToString();
            Debug.WriteLine("Result: " + result);

            Debug.WriteLine("Execute Shutdown... ");
            result = ThirdPartyProductOps.Shutdown().ToString();
            Debug.WriteLine("Result: " + result);
        }

    }
}
