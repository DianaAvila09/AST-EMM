using CapaPresentacion.AppCode.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MegaDoc.BLL;
using System.Data;

namespace CapaPresentacion.auth
{
    public partial class userReg : System.Web.UI.Page
    {
        clsDocAst objDocAst = new clsDocAst();
        clsAccesosMegaDoc objAuth = new clsAccesosMegaDoc();
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


                cargaComboDpto();
                cargaComboRol();

                this.txtNombre.Focus();


            }

 

        }

        private void MisVariables()
        {
            this.txtNombre.Text         = "";
            this.txtEmail.Text          = "";
            this.txtPass.Text           = "";
            this.txtCia.Text            = "";
            this.chkActivo.Checked      = false;
            this.cmbDepto.Value         = null;
            this.cmbRol.Value           = null;
        }

        private void BuscarData()
        {
            DataTable dt = new DataTable();
            objAuth.user_id = _id;

            dt = objAuth.UsuariosQuery_ById().Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[0];

                this.txtNombre.Text         = dr["nombre"].ToString();
                this.txtEmail.Text          = dr["email"].ToString();
                this.txtPass.Text           = dr["password"].ToString();
                this.txtCia.Text            = dr["cia"].ToString();
                this.chkActivo.Checked      = Convert.ToBoolean(dr["esActivo"].ToString());
                this.cmbDepto.Value         = dr["dpto_id"].ToString();
                this.cmbRol.Value           = dr["rol_id"].ToString();
               
            }
        }

        private void cargaComboDpto()
        {
            cmbDepto.TextField = "dpto_nombre";
            cmbDepto.ValueField = "dpto_id";

            cmbDepto.DataSource = objDocAst.Deptos_Sel();
            cmbDepto.DataBind();
        }
        private void cargaComboRol()
        {
            cmbRol.TextField = "rol_nombre";
            cmbRol.ValueField = "rol_id";

            cmbRol.DataSource = objAuth.RolesQuery();
            cmbRol.DataBind();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("userQuery.aspx");
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
            this.lblErrEmail.Visible    = false;
            this.lblErrPass.Visible     = false;
            this.lblErrCia.Visible      = false;
            this.lblErrDepto.Visible    = false;
            this.lblErrRol.Visible      = false;

            if (txtNombre.Text == "")
            {
                lblErrName.Visible = true;
                lblErrName.Text = "El Nombre es requerido";
                return false;
            }
            if (txtEmail.Text == "")
            {
                lblErrEmail.Visible = true;
                lblErrEmail.Text = "El correo electronico es requerido";
                return false;
            }
            if (txtPass.Text == "")
            {
                lblErrPass.Visible = true;
                lblErrPass.Text = "El Password es requerido";
                return false;
            }
            if (txtCia.Text == "")
            {
                lblErrCia.Visible = true;
                lblErrCia.Text = "La Compañia es requerida";
                return false;
            }

            if (cmbDepto.Value == null)
            {
                lblErrDepto.Visible = true;
                lblErrDepto.Text = "El Departamento es requerido";
                return false;
            }

            if (cmbRol.Value == null)
            {
                lblErrRol.Visible = true;
                lblErrRol.Text = "El Rol del usaurio es requerido";
                return false;
            }


            return true;
           
        }

        protected void Actualizar()
        {
            int result;

            objAuth.user_id = _id;
            objAuth.nombre = txtNombre.Text;
            objAuth.email = txtEmail.Text;
            objAuth.password = txtPass.Text;
            objAuth.cia = txtCia.Text;
            objAuth.depto_id = int.Parse(cmbDepto.Value.ToString());
            objAuth.rol_id = int.Parse(cmbRol.Value.ToString());
            objAuth.esActivo = bool.Parse(chkActivo.Value.ToString());
            objAuth.mode = "upd";

            // lanzar el metodo insert
            result = objAuth.User_Actualiza();

        }
        protected void Insertar()
        {
            int result;
       
            objAuth.nombre = txtNombre.Text;
            objAuth.email = txtEmail.Text;
            objAuth.password = txtPass.Text;
            objAuth.cia = txtCia.Text;
            objAuth.depto_id = int.Parse(cmbDepto.Value.ToString());
            objAuth.rol_id = int.Parse(cmbRol.Value.ToString());
            objAuth.esActivo = bool.Parse(chkActivo.Value.ToString());
            objAuth.mode = "ins";

            // lanzar el metodo insert
            result = objAuth.User_Actualiza();
           

        }
    }
}