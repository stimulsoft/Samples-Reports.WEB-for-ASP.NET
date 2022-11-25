using Stimulsoft.Report;
using System;
using System.Data;

namespace Using_Report_Variables_in_Code
{
    public partial class ReportPOST : System.Web.UI.Page
    {
        static ReportPOST()
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

            report["Name"] = Request.Form["name"] ?? string.Empty;
            report["Surname"] = Request.Form["surname"] ?? string.Empty;
            report["Email"] = Request.Form["email"] ?? string.Empty;
            report["Address"] = Request.Form["address"] ?? string.Empty;
            report["Sex"] = Request.Form["sex"] != null && Convert.ToBoolean(Request.Form["sex"]);

            StiWebViewer1.Report = report;
        }
    }
}