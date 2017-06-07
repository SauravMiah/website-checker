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
    public partial class Login : System.Web.UI.Page
    {
        UserBEL bo = new UserBEL();
        UserBLL bl = new UserBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["uid"] != null)
            {
                Response.Redirect("logs");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bo.username = txtUser.Text;
            bo.password = txtPass.Text;

            if (String.IsNullOrWhiteSpace(txtUser.Text) || String.IsNullOrWhiteSpace(txtPass.Text))
            {
                logMsg.Visible = true;
                logMsg.InnerHtml = "Please enter username or password!";
            }
            else
            {
                int res = bl.doLogin(bo);
                if(res == 2)
                {
                    //correct login
                    Response.Redirect("logs");
                } 
                else if(res == 1)
                {
                    logMsg.Visible = true;
                    logMsg.InnerHtml = "Invalid login credentials";
                }
                else
                {
                    logMsg.Visible = true;
                    logMsg.InnerHtml = "Username not found!";
                }
            }
        }
    }
}