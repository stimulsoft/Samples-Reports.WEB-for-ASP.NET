using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Web;
using System.Web.UI;

namespace Web_Demo
{
    public partial class Designer : Page
    {
        private static string appDirectory = HttpContext.Current.Server.MapPath(string.Empty);

        static Designer()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the report name fror URL query
            string keyValue = Page.Request.QueryString.Get("reportname");
            if (keyValue == null) keyValue = "SimpleList";

            var report = new StiReport();
            report.Load(string.Format("{0}\\Reports\\{1}.mrt", appDirectory, keyValue));
            StiWebDesigner1.Report = report;
        }

        protected void StiWebDesigner1_SaveReport(object sender, StiSaveReportEventArgs e)
        {
            var report = e.Report;

            // string packedReport = report.SavePackedReportToString();
            // ...
            // The save report code here
            // ...
        }

        protected void StiWebDesigner1_Exit(object sender, StiReportDataEventArgs e)
        {
            string keyValue = Page.Request.QueryString.Get("reportname");
            if (keyValue == null) keyValue = "SimpleList";

            this.Response.Redirect("Viewer.aspx?reportname=" + keyValue, true);
        }
    }
}