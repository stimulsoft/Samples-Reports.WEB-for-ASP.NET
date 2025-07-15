using System;
using System.Web.UI;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Web;

namespace Changing_Database_Type
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
            var showReportWithChangedDatabase =
                Request.QueryString["changeDatabase"]?.Equals("True") ?? false;

            e.Report = showReportWithChangedDatabase
                ? GetReportWithChangedDatabase()
                : GetReportWithOriginalDatabase();
        }

        private StiReport GetReportWithOriginalDatabase()
        {
            // Loading the report template
            var reportPath = Server.MapPath("Reports/Report.mrt");
            var report = new StiReport();
            report.Load(reportPath);

            // Showing the report unchanged.
            // It has JSON database as its source of data.
            return report;
        }

        private StiReport GetReportWithChangedDatabase()
        {
            // Loading the report template
            var reportPath = Server.MapPath("Reports/Report.mrt");
            var report = new StiReport();
            report.Load(reportPath);

            // Retrieving the only database from the template, the JSON one.
            var originalJsonDatabase = (StiJsonDatabase)report.Dictionary.Databases[0];

            // Changing its type to MySql.
            var newMySqlDatabase = (StiMySqlDatabase)report.Dictionary.ChangeDatabaseType(originalJsonDatabase, typeof(StiMySqlDatabase));

            // Providing connection information.
            // New database should contain data with the same structure as the original database,
            // i.e. tables with the same names and columns with the same names and data types.
            newMySqlDatabase.ConnectionString = "Server=myServerAddress; Database=myDataBase; UserId=myUsername; Pwd=myPassword;";

            // Showing the same template with another database as its source of data.
            return report;
        }
    }
}