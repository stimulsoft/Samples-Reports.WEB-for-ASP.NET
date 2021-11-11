using System;
using System.Web.UI;

namespace Connecting_to_Data_from_Code
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButtonViewer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Viewer.aspx");
        }

        protected void LinkButtonDesigner_Click(object sender, EventArgs e)
        {
            Response.Redirect("Designer.aspx");
        }
    }
}