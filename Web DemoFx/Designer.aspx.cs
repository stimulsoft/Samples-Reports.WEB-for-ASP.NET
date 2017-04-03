using Stimulsoft.Report;
using Stimulsoft.Report.MobileDesign;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_DemoFx
{
    public partial class Designer : System.Web.UI.Page
    {
        private static string AppDirectory = HttpContext.Current.Server.MapPath(string.Empty);

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
                // Get the report name fror URL query
                string keyValue = Page.Request.QueryString.Get("reportname");
                if (keyValue == null) keyValue = "SimpleList";

                var report = new StiReport();
                report.Load(string.Format("{0}\\ReportTemplates\\{1}.mrt", AppDirectory, keyValue));
                StiMobileDesigner1.Report = report;
            }
        }

        protected void StiMobileDesigner1_PreviewReport(object sender, StiMobileDesigner.StiPreviewReportEventArgs e)
        {
            var data = new DataSet();
            data.ReadXmlSchema(AppDirectory + "\\Data\\Demo.xsd");
            data.ReadXml(AppDirectory + "\\Data\\Demo.xml");

            e.Report.RegData(data);
        }

        protected void StiMobileDesigner1_SaveReport(object sender, StiMobileDesigner.StiSaveReportEventArgs e)
        {
            StiReport report = e.Report;

            // string packedReport = report.SavePackedReportToString();
            // ...
            // The save report code here
            // ...
        }

        protected void StiMobileDesigner1_Exit(object sender, StiMobileDesigner.StiExitEventArgs e)
        {
            string keyValue = Page.Request.QueryString.Get("reportname");
            if (keyValue == null) keyValue = "SimpleList";

            this.Response.Redirect("Default.aspx?reportname=" + keyValue, true);
        }
    }
}