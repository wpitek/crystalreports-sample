﻿using SharedReports;
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
    }
}
