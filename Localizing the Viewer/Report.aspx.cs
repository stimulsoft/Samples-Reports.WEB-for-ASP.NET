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
            StiReport report = new StiReport();
            report.Load(Server.MapPath(@"Reports\Invoice.mrt"));
            report.Compile();

            DataSet data = new DataSet();
            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            report.RegData(data);

            StiWebViewer1.Localization = string.Format("Localization/{0}.xml", (string)Session["lang"]);
            StiWebViewer1.Report = report;
        }
    }
}