using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class mainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if ((Session["useremail"] == null) || (Session["useremail"].ToString() == ""))
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    ASPxLabel2.Text =  Session["username"].ToString();
                    ASPxLabel3.Text = System.DateTime.Now.ToLongDateString();

                    lblAnio.Text = DateTime.Now.Year.ToString();
                }

            }
        }

        protected void btnLogout_click(object sender, EventArgs e)
        {
            Session.Remove("useremail");
            Session.Remove("username");
            Session.Remove("userid");
            Session.Remove("rol_nombre");


            Response.Redirect("login.aspx");
        }
    }
}