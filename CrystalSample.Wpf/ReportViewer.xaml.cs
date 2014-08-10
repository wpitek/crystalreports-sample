using CrystalDecisions.CrystalReports.Engine;
using SharedReports;
using System;
using System.Windows;

namespace CrystalSample.Wpf
{
    /// <summary>
    /// Interaction logic for ReportViewer.xaml
    /// </summary>
    public partial class ReportViewer : Window,IReport
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        public void LoadReport(ReportDocument report)
        {
            viewer.ViewerCore.ReportSource = report;
            ShowDialog();
        }
    }
}
