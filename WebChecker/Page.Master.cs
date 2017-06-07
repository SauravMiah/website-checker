using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BEL;

namespace WebsiteCheckerV2
{
    public partial class Page : System.Web.UI.MasterPage
    {
        UserBEL bo = new UserBEL();
        UserBLL bl = new UserBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["uid"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                this.bo = bl.getProfile(Convert.ToInt64(Session["uid"]));
                Session["name"] = bo.username;
            }
        }
    }
}