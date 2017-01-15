using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx", true);
        }

        protected void btnBrowse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Browse.aspx", true);
        }
    }
}