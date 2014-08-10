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
                var report = _reportGenerator.GenerateReport(new HelloYou(), parameters,null);
                _reportViewer.LoadReport(report);
            }
        }

        private void PeopleButton_Click(object sender, RoutedEventArgs e)
        {
            var ds = new SampleDataSet();
            var t = ds.Tables["People"];
            ds.Tables["People"].Rows.Add("Jon", "Doe I");
            ds.Tables["People"].Rows.Add("Jon", "Doe II");
            ds.Tables["People"].Rows.Add("Jon", "Doe III");
            ds.Tables["People"].Rows.Add("Jon", "Doe IV");
            var report = _reportGenerator.GenerateReport(new PeopleReport(), mainDataSet: ds);
            _reportViewer.LoadReport(report);
        }

        private void TeamButton_Click(object sender, RoutedEventArgs e)
        {
            var teams = new List<Team>();
            var t1 = new Team { Name = "One team", StartDate = DateTime.Now };
            var t2 = new Team { Name = "Two team", StartDate = DateTime.Now };
            teams.Add(t1);
            teams.Add(t2);
            var report = _reportGenerator.GenerateReport(new TeamReport(), classList: teams);
            _reportViewer.LoadReport(report);
        }

        private void ComplexButton_Click(object sender, RoutedEventArgs e)
        {
            var teams = new List<Team>();
            var t1 = new Team { Name = "One team", StartDate = DateTime.Now };
            var t2 = new Team { Name = "Two team", StartDate = DateTime.Now };
            teams.Add(t1);
            teams.Add(t2);

            var ds = new SampleDataSet();
            var t = ds.Tables["People"];
            ds.Tables["People"].Rows.Add("Jon", "Doe I");
            ds.Tables["People"].Rows.Add("Jon", "Doe II");
            ds.Tables["People"].Rows.Add("Jon", "Doe III");
            ds.Tables["People"].Rows.Add("Jon", "Doe IV");

            var parameters = new Dictionary<string, object>();
            parameters.Add("value", 666);

            var report = _reportGenerator.GenerateReport(new MainReport(), parameters: parameters, mainDataSet: ds);
            report.Subreports["SubReportOne.rpt"].SetDataSource(teams);
            report.Subreports["SubReportTwo.rpt"].SetDataSource(ds);
            report.SetParameterValue("value", 666);
            _reportViewer.LoadReport(report);
        }
    }
}
