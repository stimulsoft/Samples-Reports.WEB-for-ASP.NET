using Stimulsoft.Report;
using System;
using System.Data;
using System.Web.UI;

namespace Localizing_the_Designer
{
    public partial class Designer : System.Web.UI.Page
    {
        static Designer()
        {
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page != null && !Page.IsPostBack)
            {
                StiReport report = new StiReport();
                StiMobileDesigner1.GlobalizationFile = String.Format("Localization/{0}.xml", (string)Session["lang"]);
                report.Load(Server.MapPath(@"Reports\Invoice.mrt"));
                StiMobileDesigner1.Report = report;
            }
        }
        
        protected void StiMobileDesigner1_CreateReport(object sender, Stimulsoft.Report.MobileDesign.StiMobileDesigner.StiCreateReportEventArgs e)
        {
            DataSet data = new DataSet();
            data.ReadXmlSchema(Server.MapPath(@"Data\Demo.xsd"));
            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            e.Report.RegData(data);
            e.Report.Dictionary.Synchronize();
        }

        protected void StiMobileDesigner1_PreviewReport(object sender, Stimulsoft.Report.MobileDesign.StiMobileDesigner.StiPreviewReportEventArgs e)
        {
            DataSet data = new DataSet();
            data.ReadXmlSchema(Server.MapPath(@"Data\Demo.xsd"));
            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            e.Report.RegData(data);
        }
    }
}