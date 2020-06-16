using Stimulsoft.Report;
using System;
using System.Data;

namespace Localizing_the_Viewer
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
            report.Load(Server.MapPath("Reports\\Invoice.mrt"));

            StiWebViewer1.Localization = $"Localization/{Session["lang"]}.xml";
            StiWebViewer1.Report = report;
        }
    }
}