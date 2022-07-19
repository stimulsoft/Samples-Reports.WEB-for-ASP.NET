using Stimulsoft.Base;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Linq;

namespace Using_a_Custom_Data_Adapter
{
    public partial class Default : System.Web.UI.Page
    {
        static Default()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            //Clearing standard data adapters, if necessary
            StiOptions.Services.Databases.Clear();

            //Adding a Custom PostgreSQL data adapter
            StiOptions.Services.Databases.Add(new CustomPostgreSQLDatabase());
            StiOptions.Services.DataAdapters.Add(new CustomPostgreSQLAdapterService());
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StiWebDesigner1_GetReport(object sender, StiReportDataEventArgs e)
        {
            var report = new StiReport();

            //Adding a reference to this project using a custom adapter class
            var assemblies = report.ReferencedAssemblies.ToList();
            assemblies.Add("Using_a_Custom_Data_Adapter.dll");
            report.ReferencedAssemblies = assemblies.ToArray();

            //Adding a connection to the report from code
            var database = new CustomPostgreSQLDatabase("CustomData1", "Server=127.0.0.1; Port=5432; Database=myDataBase; User Id=myUsername; Password=myPassword;");
            report.Dictionary.Databases.Add(database);

            e.Report = report;
        }

        protected void StiWebDesigner1_SaveReport(object sender, StiSaveReportEventArgs e)
        {
            var report = e.Report;
            report.Save(Server.MapPath(@"Reports\" + report.ReportName + ".mrt"));
        }
    }
}