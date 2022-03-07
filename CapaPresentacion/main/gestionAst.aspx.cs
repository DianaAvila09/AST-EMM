using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaPresentacion.AppCode.BLL;


namespace CapaPresentacion.main
{
    public partial class gestionAst : System.Web.UI.Page
    {
        clsDocAst objDocAst = new clsDocAst();
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientScript.GetPostBackEventReference(this, string.Empty);
            if (Request.Form["__EVENTTARGET"] == "btnUpd_Click")
            {
                btnUpd_Click(this, new EventArgs());
            }

            if (!Page.IsPostBack)
            {
                if ((Session["useremail"] == null) || (Session["useremail"].ToString() == ""))
                {
                    Response.Redirect("login.aspx");
                }

                cargaComboDoctos();

                DateTime fecha = DateTime.Now;
                Int64 valor = fecha.Ticks;

                //637816594108884655
            }
          

        }

        protected void cargaComboDoctos()
        {
           
            ASPxComboBox1.TextField = "desc_docto";
            ASPxComboBox1.ValueField = "tipo_id";
            ASPxComboBox1.DataSource = objDocAst.TipoDocto_Sel();
            ASPxComboBox1.DataBind();

            ASPxComboBox1.SelectedIndex = 0;

            cargaGrid();
        }
        protected void cargaGrid()
        {
            objDocAst.tipo_id = int.Parse(ASPxComboBox1.Value.ToString());


            this.ASPxGridView1.DataSource = objDocAst.DocAst_Sel();
            this.ASPxGridView1.DataBind();

        }
    
        protected void agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("capAst.aspx");
        }

        protected void ASPxComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaGrid();
        }

        protected void btnUpd_Click(object sender, EventArgs e)
        {
            Int32 intKey = Convert.ToInt32(HiddenField2["hidden_value"]);

            Response.Redirect("capAst.aspx?astid=" + intKey );

        }


        }
}