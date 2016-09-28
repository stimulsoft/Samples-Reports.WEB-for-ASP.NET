using Stimulsoft.Report;
using System;
using System.Web.UI;

namespace Using_Variables_in_the_Report
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page != null && !Page.IsPostBack)
            {
                StiReport report = new StiReport();
                report.Load(Server.MapPath(@"Reports\Variables.mrt"));
                StiMobileDesigner1.Report = report;
            }
        }
    }
}