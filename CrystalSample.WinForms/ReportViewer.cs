using CrystalDecisions.CrystalReports.Engine;
using SharedReports;
using System;
using System.Windows.Forms;

namespace CrystalSample.WinForms
{
    public partial class ReportViewer : Form, IReport
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        //private void ReportViewer_Load(object sender, EventArgs e)
        //{
        //    this.
        //}

        public void LoadReport(ReportDocument report)
        {
            viewer.ReportSource = report;
            ShowDialog();
        }
    }
}
