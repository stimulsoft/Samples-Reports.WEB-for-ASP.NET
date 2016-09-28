using System;

namespace Localizing_the_Designer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void ButtonShowDesigner_Click(object sender, EventArgs e)
        {
            Session["lang"] = DropDownListLang.SelectedValue;
            Response.Redirect("Designer.aspx");
        }
    }
}