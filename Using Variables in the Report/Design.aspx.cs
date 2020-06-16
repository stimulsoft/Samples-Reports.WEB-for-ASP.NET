using Stimulsoft.Report;
using System;
using System.Web.UI;

namespace Using_Variables_in_the_Report
{
    public partial class Design : System.Web.UI.Page
    {
        static Design()
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
            StiWebDesigner1.Report = report;
        }
    }
}