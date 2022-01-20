using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web;

namespace Web_Demo
{
    public partial class Default : System.Web.UI.Page
    {
        private string appDirectory = HttpContext.Current.Server.MapPath(string.Empty);

        protected void StiWebViewer1_GetReport(object sender, StiReportDataEventArgs e)
        {
            var report = new StiReport();
            var reportName = "SimpleList";

            if (!string.IsNullOrEmpty(Page.Request.QueryString.Get("reportname")))
            {
                reportName = Page.Request.QueryString.Get("reportname");
            }

            report.Load(string.Format("{0}\\Reports\\{1}.mrt", appDirectory, reportName));

            e.Report = report;
        }

        protected void StiWebViewer1_DesignReport(object sender, EventArgs e)
        {
            var keyValue = Page.Request.QueryString.Get("reportname") ?? "SimpleList";
            Response.Redirect("Designer.aspx?reportname=" + keyValue, true);
        }
    }
}