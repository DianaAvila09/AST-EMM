using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaPresentacion.AppCode.BLL;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace CapaPresentacion.main
{
    public partial class capAst : System.Web.UI.Page
    {
        bool _botonNuevo  ;
        bool _GrabacionFinal;
        Int32 _astid;
        string _roleNombre;
        Int16 _usrIdLogin;
        clsDocAst objDocAst = new clsDocAst();
        clsAstGpoAprobacion objAstGpoAprobacion = new clsAstGpoAprobacion();
        clsAstPersonalInvo objPersonalInvolucrado = new clsAstPersonalInvo();
        clsAstPracticasProh objPracticasProhibidas = new clsAstPracticasProh();
        clsAstSecuenciaTrab objSecuenciaTrabajo = new clsAstSecuenciaTrab();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               

                if ((Session["useremail"] == null) || (Session["useremail"].ToString() == ""))
                {
                    Response.Redirect("../login.aspx");
                }


                _astid = Convert.ToInt32(Request.QueryString["astid"]);
                

                this.lblMotivoRechazo.Visible = false;
                this.txtMotivorechazo.Visible = false;


                if (_astid != 0)
                {

                    hfIsNew["hidden_value"] = false;
                }
                else
                {
                    hfIsNew["hidden_value"] = true;
                }

                _botonNuevo = Convert.ToBoolean(hfIsNew["hidden_value"]);

                txtElabora.Text = Session["username"].ToString();

                // 
                this.Panel1.Visible = false;
                this.Panel2.Visible = false;
                this.Panel3.Visible = false;
                this.Panel4.Visible = false;
                this.Panel5.Visible = false;
                this.Panel6.Visible = false;

                // Practicas Prohibidas
                this.Panel7.Visible = false;
                this.Panel8.Visible = false;
                this.Panel9.Visible = false;
                this.Panel10.Visible = false;
                this.Panel11.Visible = false;
                this.Panel12.Visible = false;
                this.Panel13.Visible = false;

                // personal involucrado
                this.Panel14.Visible = false;
                this.Panel15.Visible = false;
                this.Panel16.Visible = false;


                if (_botonNuevo)
                {

                    this.MisVariables();

                    
                }
                else
                {
                    _usrIdLogin = Convert.ToInt16(Session["userid"].ToString());
                    _roleNombre = Session["rol_nombre"].ToString();

                    BucarAST_Formato();
                    BuscarAST_SecuenciaTrabajo();
                    BuscarAST_PracticasProhibidas();
                    BuscarAST_PersonalInvolucrado();
                    BuscarAST_GpoAprobacion();
                }


            }
            else
            {
                _astid = Convert.ToInt32(Request.QueryString["astid"]);


                if (_astid != 0)
                {

                    hfIsNew["hidden_value"] = false;
                }
                else
                {
                    hfIsNew["hidden_value"] = true;
                }

                _botonNuevo = Convert.ToBoolean(hfIsNew["hidden_value"]);
            }


           

                this.DeptoCombo();

                this.txtArea.Focus();

              



        }

        protected void BucarAST_Formato()
        {
            
            DataTable dt = new DataTable();
            objDocAst.ast_id = _astid;

            dt  = objDocAst.DocAstFormato_Sel().Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[0];
                txtArea.Text = dr["area"].ToString();
                cmbDepto.Value = dr["dpto_id"].ToString();
                cmbFecha.Value = Convert.ToDateTime(dr["fecha_creacion"].ToString());
                txtHoraIni.Text = dr["hora_inicio"].ToString();
                txtHoraFin.Text = dr["hora_fin"].ToString();
                txtDescTrabajo.Text = dr["desc_trabajo_realizar"].ToString();
                txtPuestoInvolucrado.Text = dr["puestos_involucrados"].ToString();
                txtEPP.Text = dr["epp_utilizar"].ToString();
                txtMotivorechazo.Text = dr["motivo_rechazo"].ToString();      
                txtContactoPlanta.Text = dr["email_contactoPlanta"].ToString();
                txtPlanRespuesta.Text = dr["plan_respuesta"].ToString();
                txtElabora.Text = dr["elaboro"].ToString();
                //_role = dr["rol_nombre"].ToString();

                this.lblEstatus2.Text = dr["estatus"].ToString();

                switch (this.lblEstatus2.Text)
                {
                    case "Capturado":
                        this.lblEstatus2.CssClass = "text-primary";
                        break;
                    case "En Proceso":
                        this.lblEstatus2.CssClass = "text-primary";
                        break;
                    case "Autorizado":
                        this.lblEstatus2.CssClass = "text-success";
                        break;
                    case "Rechazado":
                        this.lblEstatus2.CssClass = "text-danger";
                        break;
                    default:
                        this.lblEstatus2.CssClass = "text-primary";
                        break;
                }


                if (dr["estatus"].ToString() == "Rechazado" || dr["estatus"].ToString() == "Autorizado")
                {
                    this.btnGrabaFinal.Enabled = false;
                    this.btnGrabar.Enabled = false;
                    this.btnEliminar.Enabled = false;

                    this.txtAutorizaContacto.Text = txtContactoPlanta.Text;

                }
                else
                {
                    // validar si es usuario que se firma es el mismo que es dueño del AST

                    if (  _usrIdLogin != Convert.ToInt16(dr["user_id"].ToString()) && (_roleNombre != "admin_rol" )   )
                    {
                        this.btnGrabaFinal.Enabled = false;
                        this.btnGrabar.Enabled = false;
                        this.btnEliminar.Enabled = false;
                    }
                }

               if ( txtMotivorechazo.Text != "")
                {
                    this.lblMotivoRechazo.Visible = true;
                    this.txtMotivorechazo.Visible = true;
                }

               


            }



        }

        protected void BuscarAST_GpoAprobacion()
        {
            DataTable dt = new DataTable();
            objAstGpoAprobacion.ast_id = _astid;

            dt = objAstGpoAprobacion.DocAstGpoAprobacion_Sel().Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[0];
                txtAutorizaPlanta.Text = dr["nombre"].ToString();
            }


        }
        protected void BuscarAST_PersonalInvolucrado()
        {

            DataTable dt = new DataTable();
            objPersonalInvolucrado.ast_id = _astid;

            int i = 0;

            dt = objPersonalInvolucrado.DocAstPersonalInvo_Sel().Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[i];

                do
                {
                    switch (i)
                    {
                        case 0:
                            txtNombre1.Text = dr["nombre"].ToString();
                            break;
                        case 1:
                            txtNombre2.Text = dr["nombre"].ToString();
                            break;
                        case 2:
                            txtNombre3.Text = dr["nombre"].ToString();
                            break;
                        case 3:
                            txtNombre4.Text = dr["nombre"].ToString();
                            if (txtNombre4.Text != "")
                            {
                                this.Panel14.Visible = true;
                            }
                            break;
                        case 4:
                            txtNombre5.Text = dr["nombre"].ToString();
                            if (txtNombre5.Text != "")
                            {
                                this.Panel14.Visible = true;
                            }
                            break;
                        case 5:
                            txtNombre6.Text = dr["nombre"].ToString();
                            if (txtNombre6.Text != "")
                            {
                                this.Panel14.Visible = true;
                            }
                            break;
                        case 6:
                            txtNombre7.Text = dr["nombre"].ToString();
                            if (txtNombre7.Text != "")
                            {
                                this.Panel15.Visible = true;
                            }
                            break;
                        case 7:
                            txtNombre8.Text = dr["nombre"].ToString();
                            if (txtNombre8.Text != "")
                            {
                                this.Panel15.Visible = true;
                            }
                            break;
                        case 8:
                            txtNombre9.Text = dr["nombre"].ToString();
                            if (txtNombre9.Text != "")
                            {
                                this.Panel15.Visible = true;
                            }
                            break;
                        case 9:
                            txtNombre10.Text = dr["nombre"].ToString();
                            if (txtNombre10.Text != "")
                            {
                                this.Panel16.Visible = true;
                            }
                            break;
                        case 10:
                            txtNombre11.Text = dr["nombre"].ToString();
                            if (txtNombre11.Text != "")
                            {
                                this.Panel16.Visible = true;
                            }
                            break;
                        case 11:
                            txtNombre12.Text = dr["nombre"].ToString();
                            if (txtNombre12.Text != "")
                            {
                                this.Panel16.Visible = true;
                            }
                            break;
                       
                    }

                    i = i + 1;
                    if (i < dt.Rows.Count)
                    {
                        dr = dt.Rows[i];
                    }

                }
                while (i <= (dt.Rows.Count - 1));


                //while ( i < ( dt.Rows.Count ) )
                //{

                //}


            }

        }
        protected void BuscarAST_PracticasProhibidas()
        {
            DataTable dt = new DataTable();
            objPracticasProhibidas.ast_id = _astid;
            int i = 0; 

            dt = objPracticasProhibidas.DocAstPracticasProh_Sel().Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[i];

                do
                {
                    switch (i)
                    {
                        case 0:
                            txtPracticaDesc1.Text = dr["desc_practica"].ToString();
                            break;
                        case 1:
                            txtPracticaDesc2.Text = dr["desc_practica"].ToString();
                            if (txtPracticaDesc2.Text != "")
                            {
                                this.Panel7.Visible = true;
                            }
                            break;
                        case 2:
                            txtPracticaDesc3.Text = dr["desc_practica"].ToString();
                            if (txtPracticaDesc3.Text != "")
                            {
                                this.Panel8.Visible = true;
                            }
                            break;
                        case 3:
                            txtPracticaDesc4.Text = dr["desc_practica"].ToString();
                            if (txtPracticaDesc4.Text != "")
                            {
                                this.Panel9.Visible = true;
                            }
                            break;
                        case 4:
                            txtPracticaDesc5.Text = dr["desc_practica"].ToString();
                            if (txtPracticaDesc5.Text != "")
                            {
                                this.Panel10.Visible = true;
                            }
                            break;
                        case 5:
                            txtPracticaDesc6.Text = dr["desc_practica"].ToString();
                            if (txtPracticaDesc6.Text != "")
                            {
                                this.Panel11.Visible = true;
                            }
                            break;
                        case 6:
                            txtPracticaDesc7.Text = dr["desc_practica"].ToString();
                            if (txtPracticaDesc7.Text != "")
                            {
                                this.Panel12.Visible = true;
                            }
                            break;
                        case 7:
                            txtPracticaDesc8.Text = dr["desc_practica"].ToString();
                            if (txtPracticaDesc8.Text != "")
                            {
                                this.Panel13.Visible = true;
                            }
                            break;
                    }

                    i = i + 1;
                    if(i < dt.Rows.Count)
                    {
                        dr = dt.Rows[i];
                    }

                }
                while (i <= (dt.Rows.Count - 1));


                //while ( i < ( dt.Rows.Count ) )
                //{
 
                //}
                

            }
        }
        protected void BuscarAST_SecuenciaTrabajo()
        {
            DataTable dt = new DataTable();
            objSecuenciaTrabajo.ast_id = _astid;
            int i = 0;

            dt = objSecuenciaTrabajo.DocAstSecuenciaTrab_Sel().Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[i];

                do
                {
                    switch (i)
                    {
                        case 0:
                            txtSecNum1.Text = dr["paso_num"].ToString();
                            ASPxMemo1.Text = dr["desc_secuencia"].ToString();
                            ASPxMemo2.Text = dr["identifica_riesgos"].ToString();
                            ASPxMemo3.Text = dr["procedmiento_realizar"].ToString();
                            break;
                        case 1:
                            txtSecNum2.Text = dr["paso_num"].ToString();
                            ASPxMemo4.Text = dr["desc_secuencia"].ToString();
                            ASPxMemo5.Text = dr["identifica_riesgos"].ToString();
                            ASPxMemo6.Text = dr["procedmiento_realizar"].ToString();
                            if (ASPxMemo4.Text != "" | ASPxMemo5.Text != "" | ASPxMemo6.Text != "")
                            {
                                this.Panel1.Visible = true;
                            }
                            break;
                        case 2:
                            txtSecNum3.Text = dr["paso_num"].ToString();
                            ASPxMemo7.Text = dr["desc_secuencia"].ToString();
                            ASPxMemo8.Text = dr["identifica_riesgos"].ToString();
                            ASPxMemo9.Text = dr["procedmiento_realizar"].ToString();
                            if (ASPxMemo7.Text != "" | ASPxMemo8.Text != "" | ASPxMemo9.Text != "")
                            {
                                this.Panel2.Visible = true;
                            }
                            break;
                        case 3:
                            txtSecNum4.Text = dr["paso_num"].ToString();
                            ASPxMemo10.Text = dr["desc_secuencia"].ToString();
                            ASPxMemo11.Text = dr["identifica_riesgos"].ToString();
                            ASPxMemo12.Text = dr["procedmiento_realizar"].ToString();
                            if (ASPxMemo10.Text != "" | ASPxMemo11.Text != "" | ASPxMemo12.Text != "")
                            {
                                this.Panel3.Visible = true;
                            }
                            break;
                        case 4:
                            txtSecNum5.Text = dr["paso_num"].ToString();
                            ASPxMemo13.Text = dr["desc_secuencia"].ToString();
                            ASPxMemo14.Text = dr["identifica_riesgos"].ToString();
                            ASPxMemo15.Text = dr["procedmiento_realizar"].ToString();
                            if (ASPxMemo13.Text != "" | ASPxMemo14.Text != "" | ASPxMemo15.Text != "")
                            {
                                this.Panel4.Visible = true;
                            }
                            break;
                        case 5:
                            txtSecNum6.Text = dr["paso_num"].ToString();
                            ASPxMemo16.Text = dr["desc_secuencia"].ToString();
                            ASPxMemo17.Text = dr["identifica_riesgos"].ToString();
                            ASPxMemo18.Text = dr["procedmiento_realizar"].ToString();
                            if (ASPxMemo16.Text != "" | ASPxMemo17.Text != "" | ASPxMemo18.Text != "")
                            {
                                this.Panel5.Visible = true;
                            }
                            break;
                        case 6:
                            txtSecNum7.Text = dr["paso_num"].ToString();
                            ASPxMemo19.Text = dr["desc_secuencia"].ToString();
                            ASPxMemo20.Text = dr["identifica_riesgos"].ToString();
                            ASPxMemo21.Text = dr["procedmiento_realizar"].ToString();
                            if (ASPxMemo19.Text != "" | ASPxMemo20.Text != "" | ASPxMemo21.Text != "")
                            {
                                this.Panel6.Visible = true;
                            }
                            break;
                        
                    }

                    i = i + 1;
                    if (i < dt.Rows.Count)
                    {
                        dr = dt.Rows[i];
                    }

                }
                while (i <= (dt.Rows.Count - 1));


                //while ( i < ( dt.Rows.Count ) )
                //{

                //}


            }
        }

        protected void DeptoCombo()
        {

            cmbDepto.TextField = "dpto_nombre";
            cmbDepto.ValueField = "dpto_id";

            cmbDepto.DataSource = objDocAst.Deptos_Sel();
            cmbDepto.DataBind();     
        }
        protected void MisVariables()
        {

            this.txtArea.Text           = "";
            //this.txtDepto.Text          = "";
            this.cmbFecha.Value         = DateTime.Now;
            this.txtHoraIni.Text        = "";
            this.txtHoraFin.Text        = "";
            this.txtContactoPlanta.Text = "";

            this.txtDescTrabajo.Text    = "";
            this.txtPuestoInvolucrado.Text = "";
            //this.txtElabora.Text = "";
            this.txtEPP.Text = "";
            this.txtAutorizaContacto.Text = "";
            this.txtAutorizaPlanta.Text = "";

            // Secuencias de trabajo
            this.txtSecNum1.Text = "1";
            this.ASPxMemo1.Text = "";
            this.ASPxMemo2.Text = "";
            this.ASPxMemo3.Text = "";

            this.txtSecNum2.Text = "2";
            this.ASPxMemo4.Text = "";
            this.ASPxMemo5.Text = "";
            this.ASPxMemo6.Text = "";

            this.txtSecNum3.Text = "3";
            this.ASPxMemo7.Text = "";
            this.ASPxMemo8.Text = "";
            this.ASPxMemo9.Text = "";

            this.txtSecNum4.Text = "4";
            this.ASPxMemo10.Text = "";
            this.ASPxMemo11.Text = "";
            this.ASPxMemo12.Text = "";

            this.txtSecNum5.Text = "5";
            this.ASPxMemo13.Text = "";
            this.ASPxMemo14.Text = "";
            this.ASPxMemo15.Text = "";

            this.txtSecNum6.Text = "6";
            this.ASPxMemo16.Text = "";
            this.ASPxMemo17.Text = "";
            this.ASPxMemo18.Text = "";

            this.txtSecNum7.Text = "7";
            this.ASPxMemo19.Text = "";
            this.ASPxMemo20.Text = "";
            this.ASPxMemo21.Text = "";

            // Practicas peligrosas

            this.txtPracticaDesc1.Text = "";
            this.txtPracticaDesc2.Text = "";
            this.txtPracticaDesc3.Text = "";
            this.txtPracticaDesc4.Text = "";
            this.txtPracticaDesc5.Text = "";
            this.txtPracticaDesc6.Text = "";
            this.txtPracticaDesc7.Text = "";
            this.txtPracticaDesc8.Text = "";

            // Firmas involucradas
            this.txtNombre1.Text = "";
            this.txtNombre2.Text = "";
            this.txtNombre3.Text = "";
            this.txtNombre4.Text = "";
            this.txtNombre5.Text = "";
            this.txtNombre6.Text = "";
            this.txtNombre7.Text = "";
            this.txtNombre8.Text = "";
            this.txtNombre9.Text = "";
            this.txtNombre10.Text = "";
            this.txtNombre11.Text = "";
            this.txtNombre12.Text = "";

            //
            this.txtPlanRespuesta.Text = "";

        }


        protected void btnGrabaFinal_Click(object sender, EventArgs e)
        {

            _GrabacionFinal = true;

            if (_botonNuevo)
            {
                if (validaCampos())
                {
                    InsertarDocto();
                }
                else
                {
                    return;
                }

            }
            else
            {
                ActualizarDocto();

            }

            // lanza el email de notificaciones
               

            objDocAst.ast_id = _astid;
            objDocAst.EnviaMail_Proc();

            Procesa_SendMail();
            ActStatus();



            btnCancelar_Click(null, null);


        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            _GrabacionFinal = false;

            if (_botonNuevo)
            {
               if(validaCampos())
                {
                    InsertarDocto();
                }
                else
                {
                    return;
                }

            }
            else
            {
                ActualizarDocto();

            }

                btnCancelar_Click(null, null);
        }

        protected bool validaCampos()
        {
            this.lblErrContactoPlanta.Visible = false;
            this.lblError.Visible = false;


            if (cmbDepto.Value == null)
            {
                lblError.Visible = true;
                lblError.Text = "El Departamento es requerido";
                return false;
            }
            else
            {

                if (this.txtContactoPlanta.Text == "")
                {
                    this.lblErrContactoPlanta.Visible = true;
                    this.lblErrContactoPlanta.Text = "el email del contacto es requerido";
                    return false;
                }
                               
                return true;

            }
        }


        protected void InsertarDocto()
        {
            int result;
            DateTime fecha = DateTime.Now;
            Int64 valor = fecha.Ticks;

            objDocAst.area = txtArea.Text;
            objDocAst.dpto_id = int.Parse(cmbDepto.Value.ToString());
            objDocAst.fecha_creacion = Convert.ToDateTime(this.cmbFecha.Text.ToString());
            objDocAst.hora_inicio = this.txtHoraIni.Text;
            objDocAst.hora_fin = this.txtHoraFin.Text;
            objDocAst.email_contactoPlanta = this.txtContactoPlanta.Text;
            objDocAst.nombre_docto = "AST_" + valor + ".doc";
            objDocAst.desc_trabajo_realizar = this.txtDescTrabajo.Text;
            objDocAst.puestos_involucrados = this.txtPuestoInvolucrado.Text;
            objDocAst.epp_utilizar = this.txtEPP.Text;
            objDocAst.tipo_id = 1;
            objDocAst.motivo_rechazo = null;

            objDocAst.user_id = Convert.ToInt32(Session["userid"]);

            if (_GrabacionFinal)
            {
                objDocAst.estatus = "En Proceso";
            }
            else
            {
                objDocAst.estatus = "Capturado";

            }

            objDocAst.plan_respuesta = this.txtPlanRespuesta.Text;

            // lanzar el metodo insert
             result = objDocAst.Doctos_insert();

           
            // obtener el ast_id del ASTFormat
            DataTable dt = new DataTable();
            Int32 Id_ast = 0;
            
            dt = objDocAst.GetASTid_Sel().Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[0];
                Id_ast = Convert.ToInt32(dr["ast_id"].ToString());
            }

            _astid = Id_ast;

            // Campos secuencia de trabajo

            if (this.txtSecNum1.Text != "" && this.ASPxMemo1.Text  != "" && Id_ast != 0) 
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum1.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo1.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo2.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo3.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();

            }

            if (this.txtSecNum2.Text != "" && this.ASPxMemo4.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum2.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo4.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo5.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo6.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            if (this.txtSecNum3.Text != "" && this.ASPxMemo7.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum3.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo7.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo8.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo9.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            if (this.txtSecNum4.Text != "" && this.ASPxMemo10.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum4.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo10.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo11.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo12.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            if (this.txtSecNum5.Text != "" && this.ASPxMemo13.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum5.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo13.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo14.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo15.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            if (this.txtSecNum6.Text != "" && this.ASPxMemo16.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum6.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo16.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo17.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo18.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            if (this.txtSecNum7.Text != "" && this.ASPxMemo19.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum7.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo19.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo20.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo21.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            // Practicas peligrosas
            // hacer cilco de insert

            if (this.txtPracticaDesc1.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 1;
                objPracticasProhibidas.desc_practica = txtPracticaDesc1.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc2.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 2;
                objPracticasProhibidas.desc_practica = txtPracticaDesc2.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc3.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 3;
                objPracticasProhibidas.desc_practica = txtPracticaDesc3.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();

            }
            if (this.txtPracticaDesc4.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 4;
                objPracticasProhibidas.desc_practica = txtPracticaDesc4.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc5.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 5;
                objPracticasProhibidas.desc_practica = txtPracticaDesc5.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc6.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 6;
                objPracticasProhibidas.desc_practica = txtPracticaDesc6.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc7.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 7;
                objPracticasProhibidas.desc_practica = txtPracticaDesc7.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc8.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 8;
                objPracticasProhibidas.desc_practica = txtPracticaDesc8.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();

            }

            //  // Personal involucrado

            //  // hacer cilco de insert hasta el ultimo/

            if (this.txtNombre1.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre1.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre2.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre2.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre3.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre3.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre4.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre4.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre5.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre5.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre6.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre6.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre7.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre7.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre8.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre8.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }
            if (this.txtNombre9.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre9.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre10.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre10.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre11.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre11.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre12.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre12.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

        }

        protected void ActualizarDocto()
        {
            int result;

            objDocAst.ast_id = _astid;
            int Id_ast = _astid;

            objDocAst.area = txtArea.Text;
            objDocAst.dpto_id = int.Parse(cmbDepto.Value.ToString());
            //objDocAst.fecha_creacion = Convert.ToDateTime(this.cmbFecha.Text.ToString());
            objDocAst.hora_inicio = this.txtHoraIni.Text;
            objDocAst.hora_fin = this.txtHoraFin.Text;
            objDocAst.email_contactoPlanta = this.txtContactoPlanta.Text;
            //objDocAst.nombre_docto = "AST_" + valor + ".doc";
            objDocAst.desc_trabajo_realizar = this.txtDescTrabajo.Text;
            objDocAst.puestos_involucrados = this.txtPuestoInvolucrado.Text;
            objDocAst.epp_utilizar = this.txtEPP.Text;
            objDocAst.tipo_id = 1;
            objDocAst.motivo_rechazo = null;

            if (_GrabacionFinal)
            {
                objDocAst.estatus = "En Proceso";
            }
           


            objDocAst.user_id = Convert.ToInt32(Session["userid"]);
            //objDocAst.estatus = "Capturado";
            objDocAst.plan_respuesta = this.txtPlanRespuesta.Text;

            objDocAst.DocAstFormato_Upd();

            objDocAst.DocDetalleAst_Del();


            // Campos secuencia de trabajo

            if (this.txtSecNum1.Text != "" && this.ASPxMemo1.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum1.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo1.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo2.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo3.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();

            }

            if (this.txtSecNum2.Text != "" && this.ASPxMemo4.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum2.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo4.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo5.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo6.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            if (this.txtSecNum3.Text != "" && this.ASPxMemo7.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum3.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo7.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo8.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo9.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            if (this.txtSecNum4.Text != "" && this.ASPxMemo10.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum4.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo10.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo11.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo12.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            if (this.txtSecNum5.Text != "" && this.ASPxMemo13.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum5.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo13.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo14.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo15.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            if (this.txtSecNum6.Text != "" && this.ASPxMemo16.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum6.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo16.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo17.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo18.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            if (this.txtSecNum7.Text != "" && this.ASPxMemo19.Text != "" && Id_ast != 0)
            {
                objSecuenciaTrabajo.paso_num = Convert.ToInt32(this.txtSecNum7.Text);
                objSecuenciaTrabajo.desc_secuencia = this.ASPxMemo19.Text;
                objSecuenciaTrabajo.identifica_riesgos = this.ASPxMemo20.Text;
                objSecuenciaTrabajo.procedmiento_realizar = this.ASPxMemo21.Text;
                objSecuenciaTrabajo.ast_id = Id_ast;

                result = objSecuenciaTrabajo.DocAstSecuenciaTrab_insert();
            }

            // Practicas peligrosas
            // hacer cilco de insert

            if (this.txtPracticaDesc1.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 1;
                objPracticasProhibidas.desc_practica = txtPracticaDesc1.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc2.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 2;
                objPracticasProhibidas.desc_practica = txtPracticaDesc2.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc3.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 3;
                objPracticasProhibidas.desc_practica = txtPracticaDesc3.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();

            }
            if (this.txtPracticaDesc4.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 4;
                objPracticasProhibidas.desc_practica = txtPracticaDesc4.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc5.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 5;
                objPracticasProhibidas.desc_practica = txtPracticaDesc5.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc6.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 6;
                objPracticasProhibidas.desc_practica = txtPracticaDesc6.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc7.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 7;
                objPracticasProhibidas.desc_practica = txtPracticaDesc7.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();
            }

            if (this.txtPracticaDesc8.Text != "" && Id_ast != 0)
            {
                objPracticasProhibidas.practica_num = 8;
                objPracticasProhibidas.desc_practica = txtPracticaDesc8.Text;
                objPracticasProhibidas.ast_id = Id_ast;

                result = objPracticasProhibidas.DocAstPracticasProh_insert();

            }

            //  // Personal involucrado

            //  // hacer cilco de insert hasta el ultimo/

            if (this.txtNombre1.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre1.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre2.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre2.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre3.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre3.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre4.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre4.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre5.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre5.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre6.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre6.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre7.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre7.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre8.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre8.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }
            if (this.txtNombre9.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre9.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre10.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre10.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre11.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre11.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }

            if (this.txtNombre12.Text != "" && Id_ast != 0)
            {
                objPersonalInvolucrado.nombre = txtNombre12.Text;
                objPersonalInvolucrado.ast_id = Id_ast;
                result = objPersonalInvolucrado.DocAstPersonalInvo_insert();
            }



           

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("gestionAst.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            objDocAst.ast_id = _astid;

            objDocAst.DocAstFormato_Del();

            btnCancelar_Click(null, null);

        }

        #region (Botenes +- Practicas prohibidas)
        protected void btnPP0_Click(object sender, EventArgs e)
        {
            // aggregar
            this.Panel7.Visible = true;
            this.btnPP1.Enabled = true;
            this.btnPP2.Enabled = true;

            this.btnPP0.Enabled = false;

        }
        protected void btnPP1_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel7.Visible = false;
            this.btnPP1.Enabled = false;
            this.btnPP2.Enabled = false;

            this.btnPP0.Enabled = true;

        }
        protected void btnPP2_Click(object sender, EventArgs e)
        {
            // aggregar
            this.Panel8.Visible = true;
            this.btnPP3.Enabled = true;
            this.btnPP4.Enabled = true;

            this.btnPP1.Enabled = false;
            this.btnPP2.Enabled = false;

        }
        protected void btnPP3_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel8.Visible = false;
            this.btnPP3.Enabled = false;
            this.btnPP4.Enabled = false;

            this.btnPP1.Enabled = true;
            this.btnPP2.Enabled = true;
        }
        protected void btnPP4_Click(object sender, EventArgs e)
        {
            // aggregar
            this.Panel9.Visible = true;
            this.btnPP5.Enabled = true;
            this.btnPP6.Enabled = true;

            this.btnPP3.Enabled = false;
            this.btnPP4.Enabled = false;

        }
        protected void btnPP5_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel9.Visible = false;
            this.btnPP5.Enabled = false;
            this.btnPP6.Enabled = false;

            this.btnPP3.Enabled = true;
            this.btnPP4.Enabled = true;
        }
        protected void btnPP6_Click(object sender, EventArgs e)
        {
            // aggregar
            this.Panel10.Visible = true;
            this.btnPP7.Enabled = true;
            this.btnPP8.Enabled = true;

            this.btnPP5.Enabled = false;
            this.btnPP6.Enabled = false;

        }
        protected void btnPP7_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel10.Visible = false;
            this.btnPP7.Enabled = false;
            this.btnPP8.Enabled = false;

            this.btnPP5.Enabled = true;
            this.btnPP6.Enabled = true;
        }
        protected void btnPP8_Click(object sender, EventArgs e)
        {
            // aggregar
            this.Panel11.Visible = true;
            this.btnPP9.Enabled = true;
            this.btnPP10.Enabled = true;

            this.btnPP7.Enabled = false;
            this.btnPP8.Enabled = false;

        }
        protected void btnPP9_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel11.Visible = false;
            this.btnPP9.Enabled = false;
            this.btnPP10.Enabled = false;

            this.btnPP7.Enabled = true;
            this.btnPP8.Enabled = true;
        }
        protected void btnPP10_Click(object sender, EventArgs e)
        {
            // aggregar
            this.Panel12.Visible = true;
            this.btnPP11.Enabled = true;
            this.btnPP12.Enabled = true;

            this.btnPP9.Enabled = false;
            this.btnPP10.Enabled = false;

        }
        protected void btnPP11_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel12.Visible = false;
            this.btnPP11.Enabled = false;
            this.btnPP12.Enabled = false;

            this.btnPP9.Enabled = true;
            this.btnPP10.Enabled = true;
        }
        protected void btnPP12_Click(object sender, EventArgs e)
        {
            // aggregar
            this.Panel13.Visible = true;
            this.btnPP13.Enabled = true;
            

            this.btnPP11.Enabled = false;
            this.btnPP12.Enabled = false;

        }
        protected void btnPP13_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel13.Visible = false;
            this.btnPP13.Enabled = false;
           

            this.btnPP11.Enabled = true;
            this.btnPP12.Enabled = true;
        }
        #endregion (Botenes +- Practicas prohibidas)

        #region (Botones +- Secuencia Trabajo)

        protected void btnST0_Click(object sender, EventArgs e)
        {
            // Agregar
            this.Panel1.Visible = true;
            this.btnST0.Enabled = false;

            this.btnST1.Enabled = true;
            this.btnST2.Enabled = true;
        }
        protected void btnST1_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel1.Visible = false;
            this.btnST1.Enabled = false;
            this.btnST2.Enabled = false;

            this.btnST0.Enabled = true;
          
        }
        protected void btnST2_Click(object sender, EventArgs e)
        {
            // Agregar
            this.Panel2.Visible = true;
            this.btnST1.Enabled = false;
            this.btnST2.Enabled = false;

            this.btnST3.Enabled = true;
            this.btnST4.Enabled = true;
        }
        protected void btnST3_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel2.Visible = false;
            this.btnST3.Enabled = false;
            this.btnST4.Enabled = false;

            this.btnST1.Enabled = true;
            this.btnST2.Enabled = true;

        }
        protected void btnST4_Click(object sender, EventArgs e)
        {
            // Agregar
            this.Panel3.Visible = true;
            this.btnST3.Enabled = false;
            this.btnST4.Enabled = false;

            this.btnST5.Enabled = true;
            this.btnST6.Enabled = true;
        }
        protected void btnST5_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel3.Visible = false;
            this.btnST5.Enabled = false;
            this.btnST6.Enabled = false;

            this.btnST3.Enabled = true;
            this.btnST4.Enabled = true;

        }
        protected void btnST6_Click(object sender, EventArgs e)
        {
            // Agregar
            this.Panel4.Visible = true;
            this.btnST5.Enabled = false;
            this.btnST6.Enabled = false;

            this.btnST7.Enabled = true;
            this.btnST8.Enabled = true;
        }
        protected void btnST7_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel4.Visible = false;
            this.btnST7.Enabled = false;
            this.btnST8.Enabled = false;

            this.btnST5.Enabled = true;
            this.btnST6.Enabled = true;

        }
        protected void btnST8_Click(object sender, EventArgs e)
        {
            // Agregar
            this.Panel5.Visible = true;
            this.btnST7.Enabled = false;
            this.btnST8.Enabled = false;

            this.btnST9.Enabled = true;
            this.btnST10.Enabled = true;
        }
        protected void btnST9_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel5.Visible = false;
            this.btnST9.Enabled = false;
            this.btnST10.Enabled = false;

            this.btnST7.Enabled = true;
            this.btnST8.Enabled = true;

        }
        protected void btnST10_Click(object sender, EventArgs e)
        {
            // Agregar
            this.Panel6.Visible = true;
            this.btnST9.Enabled = false;
            this.btnST10.Enabled = false;

            this.btnST11.Enabled = true;
            
        }
        protected void btnST11_Click(object sender, EventArgs e)
        {
            // restar
            this.Panel6.Visible = false;
            this.btnST11.Enabled = false;
   

            this.btnST9.Enabled = true;
            this.btnST10.Enabled = true;

        }






        #endregion (Botones +- Secuencia Trabajo)


        #region (botones +1 Personal Involucrado)
        protected void btnPI0_Click(object sender, EventArgs e)
        {
            // Agregar
            this.Panel14.Visible = true;
            this.btnPI1.Enabled = true;
            this.btnPI2.Enabled = true;

            this.btnPI0.Enabled = false;


        }

        protected void btnPI1_Click(object sender, EventArgs e)
        {
            // Restar
            this.Panel14.Visible = false;
            this.btnPI1.Enabled = false;
            this.btnPI2.Enabled = false;

            this.btnPI0.Enabled = true;

        }

        protected void btnPI2_Click(object sender, EventArgs e)
        {
            // Agregar
            this.Panel15.Visible = true;
            this.btnPI3.Enabled = true;
            this.btnPI4.Enabled = true;

            this.btnPI1.Enabled = false;
            this.btnPI2.Enabled = false;

        }

        protected void btnPI3_Click(object sender, EventArgs e)
        {
            // Restar
            this.Panel15.Visible = false;
            this.btnPI3.Enabled = false;
            this.btnPI4.Enabled = false;

            this.btnPI1.Enabled = true;
            this.btnPI2.Enabled = true;
        }

        protected void btnPI4_Click(object sender, EventArgs e)
        {
            // Agregar
            this.Panel16.Visible = true;
            this.btnPI5.Enabled = true;


            this.btnPI3.Enabled = false;
            this.btnPI4.Enabled = false;
        }

        protected void btnPI5_Click(object sender, EventArgs e)
        {
            // Restar
            this.Panel16.Visible = false;
            this.btnPI5.Enabled = false;


            this.btnPI3.Enabled = true;
            this.btnPI4.Enabled = true;
        }

        #endregion (botones +1 Personal Involucrado)


        protected void Procesa_SendMail()
        {
            clsDocAst objEnviaMail = new clsDocAst();

            try
            {
                //objEnviaMail.SelectById();

                MailMessage mM = new MailMessage(); //Mail Message
                mM.SubjectEncoding = Encoding.UTF8;
                mM.IsBodyHtml = true;


                DataSet dsSendMail;

                dsSendMail = objEnviaMail.SelMailto_AstEmm();

                foreach (DataRow dRow in dsSendMail.Tables[0].Rows)
                {
                    if (dRow["MailFrom"].GetType().Name != "DBNull")
                    {
                        mM.From = new MailAddress(dRow["MailFrom"].ToString());
                        mM.Subject = dRow["MailSubject"].ToString();
                        mM.Body = dRow["MailBody1"].ToString();

                        mM.To.Clear();
                        mM.To.Add(dRow["MailTo"].ToString());

                        mM.IsBodyHtml = true;

                        //SmtpClient sC = new SmtpClient("smtp.live.com"); //SMTP client
                        //sC.Port = 587; //port number for Hot mail

                        //sC.Credentials = new NetworkCredential("aa_trading@live.com", "@123"); //credentials to login in to hotmail account
                        //sC.EnableSsl = true; //enabled SSL
                        //sC.Send(mM); //Send an email

                        SmtpClient sC = new SmtpClient("smtp.gmail.com"); //SMTP client
                        sC.Port = 25;  //587; //port number for Hot mail
                        sC.Credentials = new NetworkCredential("noreplayastemm@gmail.com", "3108astemm"); //credentials to login in to hotmail account
                        sC.EnableSsl = true;    // true    //enabled SSL
                        sC.Send(mM); //Send an email

                    }
                }

                

            }//end of try block
            catch (System.Exception ex)
            {

            }//end of ca
        }

       protected void ActStatus()
        {

            clsDocAst objEnviaMail = new clsDocAst();
            try
            {
                objEnviaMail.UpdStatus();
            }
            catch (System.Exception ex)
            {
            }


        }

    }
}