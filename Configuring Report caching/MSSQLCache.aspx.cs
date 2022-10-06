using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.IO;
using System.Web.UI;
using System.Data.SqlClient;

namespace Configuring_Report_caching
{
    public class StiMSSQLCacheHelper : StiCacheHelper
    {
        // Please use your own database connection
        private string connectionString = @"Data Source=192.168.31.32;Initial Catalog=SampleDB;Integrated Security=False;User ID=******;Password=******;";

        public override StiReport GetReport(string guid)
        {
            var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                var query = $"SELECT Guid, Value FROM ReportCache WHERE Guid='{guid}'";
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    var packedReport = reader.GetString(1);
                    reader.Close();

                    var report = new StiReport();
                    if (guid.EndsWith(GUID_ReportTemplate)) report.LoadPackedReportFromString(packedReport);
                    else report.LoadPackedDocumentFromString(packedReport);

                    return report;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return null;
        }

        public override void SaveReport(StiReport report, string guid)
        {
            var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                var query = $"DELETE FROM ReportCache WHERE Guid='{guid}'";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                var packedReport = guid.EndsWith(GUID_ReportTemplate) ? report.SavePackedReportToString() : report.SavePackedDocumentToString();
                query = $"INSERT INTO ReportCache (Guid, Value) VALUES ('{guid}', '{packedReport}')";
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public override void RemoveReport(string guid)
        {
            var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                var query = $"DELETE FROM ReportCache WHERE Guid='{guid}'";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public partial class MSSQLCache : Page
    {
        static MSSQLCache()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public MSSQLCache()
        {
            StiWebViewer.CacheHelper = new StiMSSQLCacheHelper();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StiWebViewer1_GetReport(object sender, StiReportDataEventArgs e)
        {
            var report = new StiReport();
            report.Load(Server.MapPath("Reports/SimpleList.mrt"));

            e.Report = report;
        }
    }
}