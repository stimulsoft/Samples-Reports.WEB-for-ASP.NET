using System;
using System.Web.UI;

namespace Changing_Database_Type
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButtonJsonDatabase_Click(object sender, EventArgs e)
        {
            Response.Redirect("Viewer.aspx?changeDatabase=False");
        }

        protected void LinkButtonMySqlDatabase_Click(object sender, EventArgs e)
        {
            Response.Redirect("Viewer.aspx?changeDatabase=True");
        }
    }
}