using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;

namespace Print_Report_from_Code
{
    public partial class Default : System.Web.UI.Page
    {
        static Default()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private StiReport GetReport()
        {
            var report = new StiReport();
            report.Load(Server.MapPath("Reports/SimpleList.mrt"));
            return report;
        }

        protected void ButtonPrintPdf_Click(object sender, EventArgs e)
        {
            var report = this.GetReport();
            StiReportResponse.PrintAsPdf(report);
        }

        protected void ButtonPrintHtml_Click(object sender, EventArgs e)
        {
            var report = this.GetReport();
            StiReportResponse.PrintAsHtml(report);
        }
    }
}