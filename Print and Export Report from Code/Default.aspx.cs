using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;

namespace Print_and_Export_Report_from_Code
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private StiReport GetReport()
        {
            string reportPath = Server.MapPath("Reports/SimpleList.mrt");
            StiReport report = new StiReport();
            report.Load(reportPath);

            string dataPath = Server.MapPath("Data/Demo.xml");
            DataSet data = new DataSet();
            data.ReadXml(dataPath);
            report.RegData(data);

            return report;
        }

        protected void ButtonPrint_Click(object sender, EventArgs e)
        {
            StiReport report = this.GetReport();

            StiReportResponse.PrintAsHtml(report);
        }

        protected void ButtonExport_Click(object sender, EventArgs e)
        {
            StiReport report = this.GetReport();

            StiReportResponse.ResponseAsPdf(report);
        }
    }
}