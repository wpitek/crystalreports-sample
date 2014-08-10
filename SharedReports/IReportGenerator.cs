using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;

namespace SharedReports
{
    public interface IReportGenerator
    {
        ReportDocument GenerateReport(ReportDocument report, IDictionary<string, object> parameters = null);
    }
}
