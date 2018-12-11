using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace habBlog
{
    public partial class Panel : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count>0)
            {

            }
            else
            {
                Response.Redirect("giris.aspx",true);
            }
        }
    }
}