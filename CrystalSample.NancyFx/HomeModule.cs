using CrystalDecisions.CrystalReports.Engine;
using CrystalSample.NancyFx.DataModel;
using Nancy;
using Nancy.ModelBinding;
using SharedReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace CrystalSample.NancyFx
{
    public class HomeModule : NancyModule
    {

        public HomeModule()
        {
            Get["/"] = _ => View["Index"];
            Get["HelloWorld"] = _ => new ReportResponse(new HelloWorldReport());
            Post["HelloYou"] = _ =>
                {
                    var model = this.Bind<Model>();
                    return new ReportResponse(HelloYouReport(model.Name));
                };
            Get["People"] = _ => new ReportResponse(GivePeopleReport());
            Get["Teams"] = _ => new ReportResponse(GiveTeamsReport());
            Post["Complex"] = _ => new ReportResponse(Complex());
        }

        private ReportDocument GiveTeamsReport()
        {
            var generator = new ReportGenerator();
            var teams = new List<Team>();
            var t1 = new Team { Name = "One team", StartDate = DateTime.Now };
            var t2 = new Team { Name = "Two team", StartDate = DateTime.Now };
            teams.Add(t1);
            teams.Add(t2);
            var report = generator.GenerateReport(new TeamReport(), classList: teams);
            return report;
        }

        private ReportDocument HelloYouReport(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var generator = new ReportGenerator();
                var parameters = new Dictionary<string, object>();
                parameters.Add("name", name);
                var report = generator.GenerateReport(new HelloYou(), parameters);
                return report;
            }
            else
                return new ReportDocument();
        }

        private ReportDocument GivePeopleReport()
        {
            var generator = new ReportGenerator();
            var ds = new SampleDataSet();
            var t = ds.Tables["People"];
            ds.Tables["People"].Rows.Add("Jon", "Doe I");
            ds.Tables["People"].Rows.Add("Jon", "Doe II");
            ds.Tables["People"].Rows.Add("Jon", "Doe III");
            ds.Tables["People"].Rows.Add("Jon", "Doe IV");
            var report = generator.GenerateReport(new PeopleReport(), mainDataSet: ds);
            return report;
        }

        private ReportDocument Complex()
        {
            var generator = new ReportGenerator();
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

            var report = generator.GenerateReport(new MainReport(), parameters: parameters, mainDataSet: ds);
            report.Subreports["SubReportOne.rpt"].SetDataSource(teams);
            report.Subreports["SubReportTwo.rpt"].SetDataSource(ds);
            report.SetParameterValue("value", 666);
            return report;
        }

    }
}