using Stimulsoft.Base;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Drawing;

namespace Adding_a_Font_to_the_Resource
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StiWebDesigner1_GetReport(object sender, StiReportDataEventArgs e)
        {
            var report = new StiReport();

            //Loading and adding a font to resources
            var fileContent = System.IO.File.ReadAllBytes(Server.MapPath("Fonts/Roboto-Black.ttf"));
            var resource = new StiResource("Roboto-Black", "Roboto-Black", false, StiResourceType.FontTtf, fileContent, false);
            report.Dictionary.Resources.Add(resource);

            //Adding a font from resources to the font collection
            StiFontCollection.AddResourceFont(resource.Name, resource.Content, "ttf", resource.Alias);

            //Creating a text component
            var dataText = new StiText();
            dataText.ClientRectangle = new RectangleD(1, 1, 3, 2);
            dataText.Text = "Sample Text";
            dataText.Font = StiFontCollection.CreateFont("Roboto-Black", 12, FontStyle.Regular);
            dataText.Border.Side = StiBorderSides.All;

            report.Pages[0].Components.Add(dataText);

            e.Report = report;
        }

        protected void StiWebDesigner1_SaveReport(object sender, StiSaveReportEventArgs e)
        {
            var report = e.Report;
            report.Save(Server.MapPath(@"Reports\" + report.ReportName + ".mrt"));
        }
    }
}