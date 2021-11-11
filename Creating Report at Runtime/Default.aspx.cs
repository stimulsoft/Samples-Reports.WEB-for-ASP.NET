using System;

namespace Creating_Report_at_Runtime
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