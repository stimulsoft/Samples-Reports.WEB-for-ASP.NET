using Stimulsoft.Report;
using System;
using System.Data;
using System.Globalization;

namespace Globalizing_Reports
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
            // Apply Localization to WebViewer
            var locFile = DropDownList1.SelectedValue.Substring(0, 2);
            StiWebViewer1.Localization = $"\\Localization\\{locFile}.xml";

            // Get Report
            var report = new StiReport();
            report.Load(Server.MapPath("\\Reports\\SimpleList.mrt"));
            report.GlobalizationManager = new GlobalizationManager(new CultureInfo(DropDownList1.SelectedValue));

            // Get Report Data
            var data = new DataSet();
            data.ReadXml(Server.MapPath("\\Data\\Demo.xml"));
            report.RegData(data);

            // Assign Report
            StiWebViewer1.Report = report;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}