using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using System;
using System.Data;

namespace Creating_Report_at_Runtime
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
            var data = new DataSet();
            data.ReadXmlSchema(Server.MapPath(@"Data\Demo.xsd"));
            data.ReadXml(Server.MapPath(@"Data\Demo.xml"));

            var report = new StiReport();
            report.RegData(data);

            // Fill dictionary
            report.Dictionary.Synchronize();

            var page = report.Pages[0];

            // Create HeaderBand
            var headerBand = new StiHeaderBand();
            headerBand.Height = 0.5;
            headerBand.Name = "HeaderBand";
            page.Components.Add(headerBand);

            // Create text on header
            var headerText = new StiText(new RectangleD(0, 0, 5, 0.5));
            headerText.Text = "CompanyName";
            headerText.HorAlignment = StiTextHorAlignment.Center;
            headerText.Name = "HeaderText";
            headerText.Brush = new StiSolidBrush(System.Drawing.Color.LightGreen);
            headerBand.Components.Add(headerText);

            // Create Databand
            var dataBand = new StiDataBand();
            dataBand.DataSourceName = "Customers";
            dataBand.Height = 0.5;
            dataBand.Name = "DataBand";
            page.Components.Add(dataBand);

            // Create text
            var dataText = new StiText(new RectangleD(0, 0, 5, 0.5));
            dataText.Text = "{Line}.{Customers.CompanyName}";
            dataText.Name = "DataText";
            dataBand.Components.Add(dataText);

            // Create FooterBand
            var footerBand = new StiFooterBand();
            footerBand.Height = 0.5;
            footerBand.Name = "FooterBand";
            page.Components.Add(footerBand);

            // Create text on footer
            var footerText = new StiText(new RectangleD(0, 0, 5, 0.5));
            footerText.Text = "Count - {Count()}";
            footerText.HorAlignment = StiTextHorAlignment.Right;
            footerText.Name = "FooterText";
            footerText.Brush = new StiSolidBrush(System.Drawing.Color.LightGreen);
            footerBand.Components.Add(footerText);

            StiWebViewer1.Report = report;
        }
    }
}