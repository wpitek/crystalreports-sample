using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;

namespace SharedReports
{
    public interface IReportGenerator
    {
        ReportDocument GenerateReport(ReportDocument report, IDictionary<string, object> parameters = null, DataSet mainDataSet=null);
    }
}
