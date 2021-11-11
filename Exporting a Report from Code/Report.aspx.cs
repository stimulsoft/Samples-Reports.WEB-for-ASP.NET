using Stimulsoft.Report;
using System;
using System.Data;

namespace Exporting_a_Report_from_Code
{
    public partial class Report : System.Web.UI.Page
    {
        static Report()
        {
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Load(Server.MapPath($"Reports\\{Session["reportname"]}.mrt"));
            
            StiWebViewer1.Report = report;
        }
    }
}