using System;
using System.Web.UI;

namespace Connect_to_Data_from_the_Code
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