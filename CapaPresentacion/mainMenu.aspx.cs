using MegaDoc.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class mainMenu : System.Web.UI.Page
    {
        clsAccesosMegaDoc objAuth = new clsAccesosMegaDoc();
        string _rolUsuer;
        int _userId;

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
                    _userId = Convert.ToInt16(Session["userid"].ToString());
                    ASPxLabel2.Text =  Session["username"].ToString();
                    ASPxLabel3.Text = System.DateTime.Now.ToLongDateString();

                    lblAnio.Text = DateTime.Now.Year.ToString();

                    AsignaOpcionesMenu();

                   
                }

            }
        }

        private void AsignaOpcionesMenu()
        {
            DataTable dt = new DataTable();

           
            objAuth.user_id = _userId;
            dt = objAuth.UsuariosQuery_ById().Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                  _rolUsuer = dr["rol_nombre"].ToString();
                }
            }

            //Elimina la opcion usuarios si es diferente a admin_rol
            if (_rolUsuer != "admin_rol")
            {
                ASPxNavBar1.Groups[1].Visible = false;
                //ASPxNavBar1.Groups[1].Items[0].Visible = false;
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