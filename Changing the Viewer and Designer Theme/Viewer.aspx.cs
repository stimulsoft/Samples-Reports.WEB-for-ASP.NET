using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;

namespace Changing_the_Viewer_and_Designer_Theme
{
    public partial class Viewer : System.Web.UI.Page
    {
        static Viewer()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["theme"] != null)
                StiWebViewer1.Theme = (StiViewerTheme)Enum.Parse(typeof(StiViewerTheme), Session["theme"] as string);
        }

        protected void StiWebViewer1_GetReport(object sender, StiReportDataEventArgs e)
        {
            if (e.Report == null)
            {
                var report = new StiReport();
                report.Load(Server.MapPath(@"Reports\Invoice.mrt"));

                e.Report = report;
            }
        }
    }
}