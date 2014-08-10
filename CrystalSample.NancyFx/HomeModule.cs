using Nancy;
using SharedReports;

namespace CrystalSample.NancyFx
{
    public class HomeModule:NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["Index"];
            Get["HelloWorld"] = _ =>new ReportResponse(new HelloWorldReport());
        }
    }
}