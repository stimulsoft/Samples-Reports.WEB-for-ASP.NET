using Stimulsoft.Report;
using System;
using System.Data;

namespace Using_Variables_in_the_Report
{
    public partial class Report : System.Web.UI.Page
    {
        static Report()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            DataSet data = new DataSet();

            report.Load(Server.MapPath(@"Reports\Variables.mrt"));
            report.Compile();

            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            if (Request.QueryString["name"] != null) report["Name"] = Request.QueryString["name"];
            else report["Name"] = "";

            if (Request.QueryString["surname"] != null) report["Surname"] = Request.QueryString["surname"];
            else report["Surname"] = "";

            if (Request.QueryString["email"] != null) report["Email"] = Request.QueryString["email"];
            else report["Email"] = "";

            if (Request.QueryString["address"] != null) report["Address"] = Request.QueryString["address"];
            else report["Address"] = "";

            if (Request.QueryString["sex"] != null)
            {
                bool isMale = true;
                Boolean.TryParse(Request.QueryString["sex"], out isMale);
                report["Sex"] = isMale;
            }
            else
            {
                report["Sex"] = false;
            }

            report.RegData(data);

            StiWebViewer1.Report = report;
        }
    }
}