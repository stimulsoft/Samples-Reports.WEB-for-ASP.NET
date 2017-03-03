using Stimulsoft.Report;
using System;
using System.Data;
using System.Globalization;

namespace Globalized_Reports
{
    public partial class Default : System.Web.UI.Page
    {
        static Default()
        {
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page != null)
            {
                // Apply Localization to WebViewer
                StiWebViewer1.Localization = "\\Localizations\\en.xml";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string appPath = Server.MapPath(string.Empty);
            string cultureName = DropDownList1.SelectedValue;

            // Get Report Data
            DataSet data = new DataSet();
            data.ReadXml(appPath + "\\Data\\Demo.xml");

            // Get Report
            StiReport report = new StiReport();
            report.GlobalizationManager = new GlobalizationManager(new CultureInfo(cultureName));
            report.RegData(data);
            report.Load(appPath + "\\Reports\\SimpleList.mrt");

            // Show Report
            StiWebViewer1.Report = report;
        }
    }
}