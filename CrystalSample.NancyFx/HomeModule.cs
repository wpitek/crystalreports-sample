using CrystalDecisions.CrystalReports.Engine;
using CrystalSample.NancyFx.DataModel;
using Nancy;
using Nancy.ModelBinding;
using SharedReports;
using System.Collections.Generic;

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
    }
}