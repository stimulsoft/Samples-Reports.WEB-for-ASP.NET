using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;

namespace Export_Report_from_Code
{
    public partial class Default : System.Web.UI.Page
    {
        protected void ButtonExport_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            DataSet data = new DataSet();
            report.Load(Server.MapPath(String.Format("Reports\\{0}.mrt", ListBoxReports.SelectedItem.Text)));
            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));
            report.RegData(data);

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