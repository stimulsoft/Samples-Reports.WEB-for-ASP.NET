using Stimulsoft.Report;
using System;
using System.Data;

namespace Using_Variables_in_the_Report
{
    public partial class Report : System.Web.UI.Page
    {
        static Report()
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
            report.Compile();

            report["Name"] = Request.QueryString["name"] ?? string.Empty;
            report["Surname"] = Request.QueryString["surname"] ?? string.Empty;
            report["Email"] = Request.QueryString["email"] ?? string.Empty;
            report["Address"] = Request.QueryString["address"] ?? string.Empty;
            report["Sex"] = Request.QueryString["sex"] != null && Convert.ToBoolean(Request.QueryString["sex"]);

            StiWebViewer1.Report = report;
        }
    }
}