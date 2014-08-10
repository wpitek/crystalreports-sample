using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Nancy;
using System;
using System.IO;
using System.Web;

namespace CrystalSample.NancyFx
{
    public class ReportResponse : Response
    {
        public ReportResponse(ReportDocument report)
        {
            Contents = GetPdfContents(report);
            ContentType = "application/pdf";
            StatusCode = HttpStatusCode.OK;
        }

        private Action<Stream> GetPdfContents(ReportDocument report)
        {
            return stream =>
            {
                report.ExportToHttpResponse(ExportFormatType.PortableDocFormat, HttpContext.Current.Response, false, string.Format("{0}.pdf",report.Name));
            };
        }
    }
}