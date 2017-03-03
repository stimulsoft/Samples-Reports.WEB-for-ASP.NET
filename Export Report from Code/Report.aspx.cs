using Stimulsoft.Report;
using System;
using System.Data;

namespace Export_Report_from_Code
{
    public partial class Report : System.Web.UI.Page
    {
        static Report()
        {
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            DataSet data = new DataSet();
            report.Load(Server.MapPath(String.Format("Reports\\{0}.mrt", (string)Session["reportname"])));
            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            report.RegData(data);
            
            StiWebViewer1.Report = report;
        }
    }
}