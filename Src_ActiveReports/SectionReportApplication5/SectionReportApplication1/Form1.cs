﻿using System;
using System.Windows.Forms;

namespace SectionReportApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var reportDataModel = new ReportDataModel
            {
                Title = "test"
            };

            viewer1.LoadDocument(new SectionReport1(reportDataModel));
        }
    }
}
