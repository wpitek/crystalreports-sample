using SharedReports;
using System;
using System.Windows;


namespace CrystalSample.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IReport _reportViewer;
        public MainWindow()
        {
            InitializeComponent();
            _reportViewer = new ReportViewer();
        }

        private void HelloWorldButton_Click(object sender, RoutedEventArgs e)
        {
            _reportViewer.LoadReport(new HelloWorldReport());
        }
    }
}
