using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;

namespace Customizing_the_Viewer
{
    public partial class Default : System.Web.UI.Page
    {
        static Default()
        {
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StiWebViewer1_GetReport(object sender, StiReportDataEventArgs e)
        {
            var reportPath = Server.MapPath("Reports/TwoSimpleLists.mrt");
            var report = new StiReport();
            report.Load(reportPath);

            e.Report = report;
        }
    }
}