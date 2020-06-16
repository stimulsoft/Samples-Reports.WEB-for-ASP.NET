using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;

namespace Export_Report_from_Code
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

        protected void ButtonExport_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Load(Server.MapPath($"Reports\\{ListBoxReports.SelectedItem.Text}.mrt"));

            switch (ListBoxFormats.SelectedIndex)
            {
                case 0:
                    StiReportResponse.ResponseAsPdf(report);
                    break;

                case 1:
                    StiReportResponse.ResponseAsHtml(report);
                    break;

                case 2:
                    StiReportResponse.ResponseAsXls(report);
                    break;

                case 3:
                    StiReportResponse.ResponseAsText(report);
                    break;

                case 4:
                    StiReportResponse.ResponseAsRtf(report);
                    break;
            }
        }

        protected void ButtonPreview_Click(object sender, EventArgs e)
        {
            Session["reportname"] = ListBoxReports.SelectedItem.Text;
            Response.Redirect("Report.aspx");
        }
    }
}