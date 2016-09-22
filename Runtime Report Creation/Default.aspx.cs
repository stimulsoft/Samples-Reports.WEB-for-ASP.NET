using System;

namespace Runtime_Report_Creation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonShowReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Report.aspx");
        }
    }
}