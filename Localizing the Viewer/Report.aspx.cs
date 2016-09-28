using Stimulsoft.Report;
using System;
using System.Data;

namespace Localizing_the_Viewer
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StiReport report = new StiReport();

            DataSet data = new DataSet();

            report.Load(Server.MapPath(@"Reports\Invoice.mrt"));
            report.Compile();

            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            report.RegData(data);

            StiWebViewer1.Localization = String.Format("Localization/{0}.xml", (string)Session["lang"]);
            StiWebViewer1.Report = report;
        }
    }
}