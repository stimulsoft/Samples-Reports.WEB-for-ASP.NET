using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web.UI;

namespace Connecting_to_Data_from_Code
{
    public partial class Viewer : Page
    {
        static Viewer()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StiWebViewer1_GetReport(object sender, StiReportDataEventArgs e)
        {
            // Loading the report template
            var reportPath = Server.MapPath("Reports/SimpleList.mrt");
            var report = new StiReport();
            report.Load(reportPath);

            // Deleting connections in the report template
            report.Dictionary.Databases.Clear();

            // Loading data from the XML file
            var dataPath = Server.MapPath("Data/Demo.xml");
            var data = new DataSet();
            data.ReadXml(dataPath);

            // Registering data in the report
            report.RegData(data);

            // Syncing the data structure, if required
            //report.Dictionary.Synchronize();

            e.Report = report;
        }
    }
}