using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;

namespace SharedReports
{
    public class ReportGenerator : IReportGenerator
    {
        public ReportDocument GenerateReport(ReportDocument report, IDictionary<string, object> parameters = null, DataSet mainDataSets=null)
        {
            if (report == null)
                throw new ArgumentException("Report cannot be null");
            AddParametersToReport(report, parameters);
            AddDataSet(report, mainDataSets);
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

        private static void AddDataSet(ReportDocument report, DataSet dataSet)
        {
            if (dataSet != null)
            {
                report.SetDataSource(dataSet);
            }
        }
    }
}
