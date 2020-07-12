using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace artefact.master_pages
{
    public partial class level1_main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] != null)
            {
                Button_Register.Visible = false;
                Button_SignIn.Visible = false;
                Button_Logout.Visible = true;
            }
            else
            {
                Button_Register.Visible = true;
                Button_SignIn.Visible = true;
                Button_Logout.Visible = false;
            }
        }

        protected void Button_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("../account/Register.aspx");
        }

        protected void Button_SignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../account/Login.aspx");
        }

        protected void Button_MyAccount_Click(object sender, EventArgs e)
        {
            /*Response.Redirect("../Default.aspx");*/
        }

        protected void Button_Logout_Click(object sender, EventArgs e)
        {
            Session["loggedIn"] = null;
            Response.Redirect("../Default.aspx");
        }
    }
}