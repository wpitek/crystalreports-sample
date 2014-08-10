using CrystalDecisions.CrystalReports.Engine;

namespace SharedReports
{
    public interface IReport
    {
        void LoadReport(ReportDocument report);
    }
}
