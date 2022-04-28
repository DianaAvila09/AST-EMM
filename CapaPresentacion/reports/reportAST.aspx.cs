using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion.reports
{
    public partial class reportAST : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var mireport = new XtraReportAst();
           

            var paramValue = Convert.ToInt32(Request.QueryString["p_astid"]);
            mireport.Parameters["p_astid"].Value = paramValue;
            mireport.Parameters["p_astid"].Visible = true;

            ASPxWebDocumentViewer1.OpenReport(mireport);

            mireport.Parameters.Clear();



        }
    }
}