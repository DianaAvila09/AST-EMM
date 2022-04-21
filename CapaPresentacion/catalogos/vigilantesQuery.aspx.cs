using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaPresentacion.AppCode.BLL;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MegaDoc.BLL;

namespace CapaPresentacion.catalogos
{
    public partial class vigilantesQuery : System.Web.UI.Page
    {
        clsCatalogos objCatalogos = new clsCatalogos();

        object[] values;

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
                    Response.Redirect("../login.aspx");
                }

                cargaGrid();

            }
          

        }

       
        protected void cargaGrid()
        {
            ASPxGridView1.DataSource = objCatalogos.VigilantesQuery();
            ASPxGridView1.DataBind();

        }
    
        protected void agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("vigilantesReg.aspx");
        }

        protected void ASPxComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaGrid();
        }

        protected void btnUpd_Click(object sender, EventArgs e)
        {
            Int32 intKey = Convert.ToInt32(HiddenField2["hidden_value"]);

            Response.Redirect("vigilantesReg.aspx?id=" + intKey );

        }


       
       
    }
}