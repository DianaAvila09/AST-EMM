using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;
using MegaDoc.BLL;

namespace CapaPresentacion
{
    public partial class login : System.Web.UI.Page
    {
        clsAccesosMegaDoc objAcceso = new clsAccesosMegaDoc();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblMsgErr.Visible = false;
            this.txtEmail.Text = "shamelius77@gmail.com";
            this.txtPass.Text = "123456";

            this.lblAnio.Text = DateTime.Now.Year.ToString();
       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //Usuario objUsuario = UsaurioBL.getInstance().AccesoSistema();

            //if (objUsuario.nombre != null)
            //{
            //    Response.Write("<script> alert('lo encontro')</script>");
            //}
            //else
            //{
            //    Response.Write("<script> alert('no data')</script>");
            //}

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //objAcceso.email = txtEmail.Text;
            //objAcceso.password = txtPass.Text;
            objAcceso.AccesoLogin(txtEmail.Text, txtPass.Text);

            if (objAcceso.nombre != null)
            {
                Session["useremail"] = txtEmail.Text;
                Session["username"] = objAcceso.nombre;
                Session["userid"] = objAcceso.user_id;

                Response.Redirect("mainMenu.aspx");
            }
            else
            {
                this.lblMsgErr.Visible = true;

            }

           
        }
    }
}