using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web;

namespace Using_the_DesignerFx
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string appDirectory = HttpContext.Current.Server.MapPath(string.Empty);

            // Load report
            StiReport report = new StiReport();
            report.Load(appDirectory + "\\Reports\\SimpleList.mrt");

            // Assign data
            StiXmlDatabase database = new StiXmlDatabase("Demo", appDirectory + "\\Data\\Demo.xsd", appDirectory + "\\Data\\Demo.xml");
            report.Dictionary.Databases.Add(database);
            report.Dictionary.Synchronize();

            // Design report
            StiWebDesigner1.Design(report);
        }
    }
}