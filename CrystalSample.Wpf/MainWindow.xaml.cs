using SharedReports;
using System;
using System.Collections.Generic;
using System.Windows;


namespace CrystalSample.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IReport _reportViewer;
        private readonly IReportGenerator _reportGenerator;

        public MainWindow()
        {
            InitializeComponent();
            _reportViewer = new ReportViewer();
            _reportGenerator = new ReportGenerator();
        }

        private void HelloWorldButton_Click(object sender, RoutedEventArgs e)
        {
            _reportViewer.LoadReport(new HelloWorldReport());
        }

        private void HelloYoudButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(MyName.Text))
            {
                var parameters = new Dictionary<string, object>();
                parameters.Add("name", MyName.Text);
                var report = _reportGenerator.GenerateReport(new HelloYou(), parameters);
                _reportViewer.LoadReport(report);
            }
        }
    }
}
