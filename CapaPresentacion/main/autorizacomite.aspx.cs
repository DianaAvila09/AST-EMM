using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaPresentacion.AppCode.BLL;
using System.Net.Mail;
using System.Net;
using System.Text;


namespace CapaPresentacion.main
{
    public partial class autorizacomite : System.Web.UI.Page
    {
        clsDocAst objDocAst = new clsDocAst();
        Int32 _astid;
        Int16 _comiteId;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Page page = HttpContext.Current.Handler as Page;
            //ScriptManager.RegisterStartupScript(page, page.GetType(), null, "document.getElementById('divPrincipal').style.display = 'inline' ", true);
             _astid = Convert.ToInt16(Request.QueryString["astId"]);
            _comiteId = Convert.ToInt16(Request.QueryString["vigid"]);



            if (_astid !=  0)
            {
                Int16 intApproved;
                intApproved = Convert.ToInt16(Request.QueryString["ApprovedStatus"].ToString());

                // buscar la info del ast
                this.BucarAST_Formato();

                 ScriptManager.RegisterStartupScript(this, this.GetType(), "script", " document.getElementById('frm1').style.display = 'inline' ", true);

                if (intApproved == 0 )
                {
                    // autorizado

                    this.lblAceptado.Visible = true;

                    this.tituloRechazo.Visible = false;
                    this.txtMotivo.Visible = false;
                    this.btnEnviar.Visible = false;

                    // Actualiza el estatus
                    objDocAst.ast_id = _astid;
                    objDocAst.estatus = "Autorizado";
                    objDocAst.isAutorizado = true;

                    objDocAst.EstatusAst_Upd();

                    // Actualiza en la bitacora de registro del COMITE 
                    objDocAst.comite_id = _comiteId;

                    objDocAst.BitacoraComite_insert();



                }
                else
                {

                    // rechazado
                    objDocAst.ast_id = _astid;
                    objDocAst.estatus = "Rechazado";
                    objDocAst.comite_id = _comiteId;
                    objDocAst.BitacoraComite_insert();


                    this.tituloRechazo.Visible = true;
                    this.txtMotivo.Visible = true;
                    this.btnEnviar.Visible = true;

                    txtMotivo.Focus();


                }

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", " document.getElementById('frm1').style.display = 'none' ", true);
            }
        }

        protected bool MotivoRequerido()
        {
            if (this.txtMotivo.Text == "")
            {
                return false;
            }

            return true;

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!MotivoRequerido())
            {
               lblMsgErr.Visible = true;
                return;
            }

            this.lblRechazado.Visible = true;

            this.tituloRechazo.Visible = false;
            this.txtMotivo.Visible = false;
            this.btnEnviar.Visible = false;
            lblMsgErr.Visible = false;

            objDocAst.ast_id = _astid;
            objDocAst.estatus = "Rechazado";
            objDocAst.isAutorizado = false;
            objDocAst.motivo_rechazo = txtMotivo.Text;

            objDocAst.EstatusAst_Upd();

        }


        protected void BucarAST_Formato()
        {

            DataTable dt = new DataTable();
            objDocAst.ast_id = _astid;

            dt = objDocAst.DocAstFormato_Sel().Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[0];
                lblArea.Text = dr["area"].ToString();
                //cmbDepto.Value = dr["dpto_id"].ToString();
                lblFecha.Value =  String.Format("{0:dd/MMM/yyyy}", Convert.ToDateTime(dr["fecha_creacion"].ToString()) );
                //txtHoraIni.Text = dr["hora_inicio"].ToString();
                //txtHoraFin.Text = dr["hora_fin"].ToString();
                lblTrabajoRealizar.Text = dr["desc_trabajo_realizar"].ToString();
                //txtPuestoInvolucrado.Text = dr["puestos_involucrados"].ToString();
               lblEpp.Text = dr["epp_utilizar"].ToString();
                //txtMotivorechazo.Text = dr["motivo_rechazo"].ToString();
                //txtContactoPlanta.Text = dr["email_contactoPlanta"].ToString();
                //txtPlanRespuesta.Text = dr["plan_respuesta"].ToString();
                //txtElabora.Text = dr["elaboro"].ToString();
            }


        }

       
    }
}