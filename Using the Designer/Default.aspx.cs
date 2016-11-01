using Stimulsoft.Report;
using Stimulsoft.Report.MobileDesign;
using System;
using System.Data;
using System.Web.UI;

namespace Using_the_Designer
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page != null && !Page.IsPostBack)
            {
                StiReport report = new StiReport();
                report.Load(Server.MapPath(@"Reports\Invoice.mrt"));
                StiMobileDesigner1.Report = report;
            }
        }
        
        protected void StiMobileDesigner1_CreateReport(object sender, StiMobileDesigner.StiCreateReportEventArgs e)
        {
            DataSet data = new DataSet();
            data.ReadXmlSchema(Server.MapPath(@"Data\Demo.xsd"));
            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            e.Report.RegData(data);
            e.Report.Dictionary.Synchronize();
        }

        protected void StiMobileDesigner1_PreviewReport(object sender, StiMobileDesigner.StiPreviewReportEventArgs e)
        {
            DataSet data = new DataSet();
            data.ReadXmlSchema(Server.MapPath(@"Data\Demo.xsd"));
            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            e.Report.RegData(data);
        }

        protected void StiMobileDesigner1_SaveReport(object sender, StiMobileDesigner.StiSaveReportEventArgs e)
        {
            StiReport report = e.Report;
            report.Save(Server.MapPath(@"Reports\" + report.ReportName + ".mrt"));
        }
    }
}