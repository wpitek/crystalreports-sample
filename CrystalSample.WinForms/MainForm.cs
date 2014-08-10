using SharedReports;
using System;
using System.Windows.Forms;

namespace CrystalSample.WinForms
{
    public partial class MainForm : Form
    {
        private IReport _reportViever;
        public MainForm()
        {
            InitializeComponent();
            _reportViever = new ReportViewer();
        }

        private void HelloWorlButton_Click(object sender, EventArgs e)
        {
            _reportViever.LoadReport(new HelloWorldReport());
        }
    }
}
