using CapaPresentacion.AppCode.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MegaDoc.BLL;
using System.Data;

namespace CapaPresentacion.catalogos
{
    public partial class vigilantesReg : System.Web.UI.Page
    {
        clsDocAst objDocAst = new clsDocAst();
        clsCatalogos objDoctos = new clsCatalogos();
        Int32 _id;
        bool _botonNuevo;
        string _roleNombre;
        Int16 _usrIdLogin;

        protected void Page_Load(object sender, EventArgs e)
        {

            _id = Convert.ToInt32(Request.QueryString["id"]);
            if (_id != 0)
            { hfIsNew["hidden_value"] = false; }
            else
            { hfIsNew["hidden_value"] = true; }
            _botonNuevo = Convert.ToBoolean(hfIsNew["hidden_value"]);

            if (!Page.IsPostBack)
            {

                if ((Session["useremail"] == null) || (Session["useremail"].ToString() == ""))
                {
                    Response.Redirect("../login.aspx");
                }



                if (_botonNuevo)
                {
                    this.MisVariables();

                }
                else
                {
                    //_usrIdLogin = Convert.ToInt16(Session["userid"].ToString());
                    //_roleNombre = Session["rol_nombre"].ToString();

                    BuscarData();
                   
                }

               
                this.txtNombre.Focus();


            }

 

        }

        private void MisVariables()
        {
            this.txtNombre.Text         = "";
            this.txtEmail.Text = "";
            this.chkActivo.Checked      = false;
   ;
        }

        private void BuscarData()
        {
            DataTable dt = new DataTable();
            objDoctos.vigilancia_id = _id;

            dt = objDoctos.VigilantesQuery_ById().Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[0];

                this.txtNombre.Text         = dr["nombre"].ToString();
                this.txtEmail.Text          = dr["email"].ToString();
                this.chkActivo.Checked      = Convert.ToBoolean(dr["esActivo"].ToString());
               
               
            }
        }

       

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("vigilantesQuery.aspx");
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            if (_botonNuevo)
            {
                if (validaCampos())
                {
                    Insertar();
                }
                else
                {
                    return;
                }

            }
            else
            {
                if (validaCampos())
                {
                    Actualizar();
                }
                else
                {
                    return;
                }
               
            }

            btnCancelar_Click(null, null);
        }

        protected bool validaCampos()
        {
            this.lblErrName.Visible     = false;
            this.lblErrEmail.Visible        = false;


            if (txtNombre.Text == "")
            {
                lblErrName.Visible = true;
                lblErrName.Text = "El nombre es requerido";
                return false;
            }
            if (txtEmail.Text == "")
            {
                lblErrEmail.Visible = true;
                lblErrEmail.Text = "El correo es requerido";
                return false;
            }



            return true;
           
        }

        protected void Actualizar()
        {
            int result;

            objDoctos.vigilancia_id = _id;
            objDoctos.nombre = txtNombre.Text;
            objDoctos.email = txtEmail.Text;
            objDoctos.esActivo = bool.Parse(chkActivo.Value.ToString());
            objDoctos.mode = "upd";

            // lanzar el metodo insert
            result = objDoctos.Vigilantes_Actualiza();

        }
        protected void Insertar()
        {
            int result;

            objDoctos.nombre = txtNombre.Text;
            objDoctos.email = txtEmail.Text;
            objDoctos.esActivo = bool.Parse(chkActivo.Value.ToString());
            objDoctos.mode = "ins";

            // lanzar el metodo insert
            result = objDoctos.Vigilantes_Actualiza();
           

        }
    }
}