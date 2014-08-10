using Nancy;

namespace CrystalSample.NancyFx
{
    public class HomeModule:NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["Index"];
        }
    }
}