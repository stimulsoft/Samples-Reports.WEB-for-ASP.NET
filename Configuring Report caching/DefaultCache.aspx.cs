using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.IO;
using System.Web.UI;

namespace Configuring_Report_caching
{
    public class StiDefaultCacheHelper : StiCacheHelper
    {
        public override StiReport GetReport(string guid)
        {
            return base.GetReport(guid);
        }

        public override void SaveReport(StiReport report, string guid)
        {
            base.SaveReport(report, guid);
        }

        public override void RemoveReport(string guid)
        {
            base.RemoveReport(guid);
        }
    }

    public partial class DefaultCache : Page
    {
        static DefaultCache()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public DefaultCache()
        {
            StiWebViewer.CacheHelper = new StiDefaultCacheHelper();
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