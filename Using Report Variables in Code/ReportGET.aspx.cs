using Stimulsoft.Report;
using System;
using System.Data;

namespace Using_Report_Variables_in_Code
{
    public partial class ReportGET : System.Web.UI.Page
    {
        static ReportGET()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Load(Server.MapPath(@"Reports\Variables.mrt"));

            StiWebViewer1.Report = report;
        }
    }
}