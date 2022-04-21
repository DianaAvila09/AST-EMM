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
    public partial class deptosReg : System.Web.UI.Page
    {
     
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
            this.chkActivo.Checked      = false;
   ;
        }

        private void BuscarData()
        {
            DataTable dt = new DataTable();
            objDoctos.dpto_id = _id;

            dt = objDoctos.DeptosQuery_ById().Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[0];

                this.txtNombre.Text         = dr["dpto_nombre"].ToString();
                this.chkActivo.Checked      = Convert.ToBoolean(dr["esActivo"].ToString());
               
               
            }
        }

       

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("deptosQuery.aspx");
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
            

            if (txtNombre.Text == "")
            {
                lblErrName.Visible = true;
                lblErrName.Text = "El departamento es requerido";
                return false;
            }
                    


            return true;
           
        }

        protected void Actualizar()
        {
            int result;

            objDoctos.dpto_id = _id;
            objDoctos.dpto_nombre = txtNombre.Text;
            objDoctos.esActivo = bool.Parse(chkActivo.Value.ToString());
            objDoctos.mode = "upd";

            // lanzar el metodo insert
            result = objDoctos.Deptos_Actualiza();

        }
        protected void Insertar()
        {
            int result;

            objDoctos.dpto_nombre = txtNombre.Text;
            objDoctos.esActivo = bool.Parse(chkActivo.Value.ToString());
            objDoctos.mode = "ins";

            // lanzar el metodo insert
            result = objDoctos.Deptos_Actualiza();
           

        }
    }
}