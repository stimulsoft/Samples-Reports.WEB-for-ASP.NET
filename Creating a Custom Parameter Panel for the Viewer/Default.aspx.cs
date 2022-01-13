using Stimulsoft.Report;
using System;

namespace Creating_a_Custom_Parameter_Panel_for_the_Viewer
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
            var report = new StiReport();
            report.Load(Server.MapPath(@"Reports\VariablesSimpleList.mrt"));

            StiWebViewer1.Report = report;
        }
    }
}