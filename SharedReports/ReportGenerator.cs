using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;

namespace SharedReports
{
    public class ReportGenerator : IReportGenerator
    {
        public ReportDocument GenerateReport(ReportDocument report, IDictionary<string, object> parameters = null)
        {
            if (report == null)
                throw new ArgumentException("Report cannot be null");
            AddParametersToReport(report, parameters);
            return report;
        }

        private static void AddParametersToReport(ReportDocument report, IDictionary<string, object> parameters)
        {
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    report.SetParameterValue(parameter.Key, parameter.Value);
                }
            }
        }
    }
}
