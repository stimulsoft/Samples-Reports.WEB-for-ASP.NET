using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.IO;
using System.Web.UI;

namespace Configuring_Report_caching
{
    public class StiFileCacheHelper : StiCacheHelper
    {
        public override StiReport GetReport(string guid)
        {
            var path = HttpContext.Server.MapPath(Path.Combine("CacheFiles", guid));
            if (File.Exists(path))
            {
                var report = new StiReport();
                var packedReport = File.ReadAllText(path);
                if (guid.EndsWith(GUID_ReportTemplate)) report.LoadPackedReportFromString(packedReport);
                else report.LoadPackedDocumentFromString(packedReport);

                return report;
            }
            return null;
        }

        public override void SaveReport(StiReport report, string guid)
        {
            var packedReport = guid.EndsWith(GUID_ReportTemplate) ? report.SavePackedReportToString() : report.SavePackedDocumentToString();
            var path = HttpContext.Server.MapPath(Path.Combine("CacheFiles", guid));
            File.WriteAllText(path, packedReport);
        }

        public override void RemoveReport(string guid)
        {
            var path = HttpContext.Server.MapPath(Path.Combine("CacheFiles", guid));
            if (File.Exists(path))
                File.Delete(path);
        }
    }

    public partial class FileCache : Page
    {
        static FileCache()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public FileCache()
        {
            StiWebViewer.CacheHelper = new StiFileCacheHelper();
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