using System;

namespace Localizing_WebViewer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void ButtonShowReport_Click(object sender, EventArgs e)
        {
            Session["lang"] = DropDownListLang.SelectedValue;
            Response.Redirect("Report.aspx");
        }
    }
}