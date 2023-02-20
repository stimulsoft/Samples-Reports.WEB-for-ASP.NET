using System;

namespace Changing_the_Viewer_and_Designer_Theme_and_viewer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void ButtonShowDesigner_Click(object sender, EventArgs e)
        {
            Session["theme"] = DropDownListDesignerThemes.SelectedValue;
            Response.Redirect("Designer.aspx");
        }

        protected void ButtonShowViewer_Click(object sender, EventArgs e)
        {
            Session["theme"] = DropDownListViewerThemes.SelectedValue;
            Response.Redirect("Viewer.aspx");
        }
    }
}