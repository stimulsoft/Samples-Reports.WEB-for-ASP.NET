using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web.UI;

namespace Using_the_Designer
{
    public partial class Default : System.Web.UI.Page
    {
        static Default()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Load(Server.MapPath(@"Reports\Invoice.mrt"));
            StiWebDesigner1.Report = report;
        }
        
        protected void StiWebDesigner1_CreateReport(object sender, StiReportDataEventArgs e)
        {
            var data = new DataSet();
            data.ReadXmlSchema(Server.MapPath(@"Data\Demo.xsd"));
            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            e.Report.RegData(data);
            e.Report.Dictionary.Synchronize();
        }

        protected void StiWebDesigner1_PreviewReport(object sender, StiReportDataEventArgs e)
        {
            /*var data = new DataSet();
            data.ReadXmlSchema(Server.MapPath(@"Data\Demo.xsd"));
            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            e.Report.RegData(data);*/
        }

        protected void StiWebDesigner1_SaveReport(object sender, StiSaveReportEventArgs e)
        {
            var report = e.Report;
            report.Save(Server.MapPath(@"Reports\" + report.ReportName + ".mrt"));
        }
    }
}