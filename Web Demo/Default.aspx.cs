using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web;

namespace Web_Demo
{
    public partial class Default : System.Web.UI.Page
    {
        private static string AppDirectory = HttpContext.Current.Server.MapPath(string.Empty);

        static Default()
        {
            // How to Activate
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

                // Load the rendered report document prom packed MDZ file, or report template from MRT file
                if (keyValue != null && keyValue.Length > 0)
                {
                    var report = new StiReport();
                    switch (keyValue)
                    {
                        // Interactive Reports
                        case "DrillDownSorting":

                        // Parameters
                        case "ParametersDetailedCategories":
                        case "ParametersDetailedOrders":
                        case "ParametersHighlightCondition":
                        case "ParametersSelectingCountry":
                        case "ParametersInvoice":

                        // {Today} function is used
                        case "MultiColumnListContainers":
                            report.Load(string.Format("{0}\\ReportTemplates\\{1}.mrt", AppDirectory, keyValue));
                            break;

                        default: report.LoadPackedDocument(string.Format("{0}\\ReportSnapshots\\{1}.mdz", AppDirectory, keyValue)); break;
                    }
                    
                    StiWebViewer1.Report = report;
                }
            }
        }

        protected void StiWebViewer1_GetReportData(object sender, StiReportDataEventArgs e)
        {
            var data = new DataSet();
            data.ReadXmlSchema(AppDirectory + "\\Data\\Demo.xsd");
            data.ReadXml(AppDirectory + "\\Data\\Demo.xml");

            e.Report.RegData(data);
        }

        protected void StiWebViewer1_ReportDesign(object sender, EventArgs e)
        {
            string keyValue = Page.Request.QueryString.Get("reportname");
            if (keyValue == null) keyValue = "SimpleList";

            this.Response.Redirect("Designer.aspx?reportname=" + keyValue, true);
        }
    }
}