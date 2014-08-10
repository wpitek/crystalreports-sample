using SharedReports;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrystalSample.WinForms
{
    public partial class MainForm : Form
    {
        private readonly IReport _reportViewer;
        private readonly IReportGenerator _reportGenerator;

        public MainForm()
        {
            InitializeComponent();
            _reportViewer = new ReportViewer();
            _reportGenerator = new ReportGenerator();
        }

        private void HelloWorlButton_Click(object sender, EventArgs e)
        {
            _reportViewer.LoadReport(new HelloWorldReport());
        }

        private void HelloYou_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MyName.Text))
            {
                var parameters=new Dictionary<string,object>();
                parameters.Add("name", MyName.Text);
                var report = _reportGenerator.GenerateReport(new HelloYou(), parameters);
                _reportViewer.LoadReport(report);
            }
        }
    }
}
