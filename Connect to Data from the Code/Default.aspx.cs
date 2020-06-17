using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Connect_to_Data_from_the_Code
{
    public partial class _Default : Page
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