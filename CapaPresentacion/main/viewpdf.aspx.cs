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
using DevExpress.XtraReports.UI;
using CapaPresentacion.main;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;

namespace CapaPresentacion.main
{
    public partial class viewpdf : System.Web.UI.Page
    {
        clsDocAst objDocAst = new clsDocAst();
        clsAstSecuenciaTrab objSecuenciaTrab = new clsAstSecuenciaTrab();
        clsAstPracticasProh objPracticasProh = new clsAstPracticasProh();
        clsAstPersonalInvo objPersonalInvolucrado = new clsAstPersonalInvo();

        Int32 _astid;
        string _area;

        protected void Page_Load(object sender, EventArgs e)
        {
            //ReportViewer1.Report = CreateReport(1);

        }

        protected void brnViewPdf_Click(object sender, EventArgs e)
        {
            string strNombreFile = "";
            string cadenaFinal = "";
            string strPlanRespuesta = "";

            DataTable dt = new DataTable();
            Document document = new Document(PageSize.A4,10, 10,10,10);

            PdfWriter writer = PdfWriter.GetInstance(document, HttpContext.Current.Response.OutputStream);
            dt = dtFormatoAST(1);

            if (dt.Rows.Count > 0)
            {
                document.Open();
                Font fontTitle = FontFactory.GetFont(FontFactory.COURIER_BOLD, 15);
                Font fontValue = FontFactory.GetFont(FontFactory.TIMES, 12);


                document.Add(new Paragraph( "      Analisis de Seguridad En El Trabjo. AST,  EMM.", fontTitle  ));
                document.Add(new Chunk("\n"));

                 cadenaFinal = "";

                foreach (DataRow dr in dt.Rows)
                {
                    cadenaFinal = "Area: " + dr["area"].ToString();
                    cadenaFinal += "                         Departamento: " + dr["dpto_nombre"].ToString();
                    document.Add(new Paragraph( cadenaFinal, fontValue) );

                    cadenaFinal = "Fecha: " + dr["fecha_creacion"].ToString();
                    cadenaFinal += "     Hora inicio: " + dr["hora_inicio"].ToString();
                    cadenaFinal += "     Hora fin: " + dr["hora_fin"].ToString();
                    document.Add(new Paragraph(cadenaFinal, fontValue));

                    cadenaFinal = "Correo del contacto en planta:   " + dr["email_contactoPlanta"].ToString();
                    document.Add(new Paragraph(cadenaFinal, fontValue));
                    document.Add(new Chunk("\n"));


                    cadenaFinal = "DESCRIPCION DEL TRABAJO";
                    document.Add(new Paragraph(cadenaFinal, fontValue));
                    cadenaFinal =  dr["desc_trabajo_realizar"].ToString();
                    document.Add(new Paragraph(cadenaFinal, fontValue));
                    document.Add(new Chunk("\n"));

                    cadenaFinal = "PUESTOS INVOLUCRADOS" ;
                    document.Add(new Paragraph(cadenaFinal, fontValue));
                    cadenaFinal = dr["puestos_involucrados"].ToString();
                    document.Add(new Paragraph(cadenaFinal, fontValue));
                    document.Add(new Chunk("\n"));

                    cadenaFinal = "EPP a utilizar";
                    document.Add(new Paragraph(cadenaFinal, fontValue));
                    cadenaFinal = dr["epp_utilizar"].ToString();
                    document.Add(new Paragraph(cadenaFinal, fontValue));
                    document.Add(new Chunk(""));

                    cadenaFinal = "           " + dr["elaboro"].ToString();
                    cadenaFinal += "                              " + dr["email_contactoPlanta"].ToString();
                    document.Add(new Paragraph(cadenaFinal, fontValue));

                    cadenaFinal =  "                  ELABORO";
                    cadenaFinal += "                              CONTACTO DE PLANTA";
                    cadenaFinal += "                                   SEGURIDAD PLANTA";
                    document.Add(new Paragraph(cadenaFinal, fontValue));
                    document.Add(new Chunk("\n"));

                    cadenaFinal = "SECUENCIA DEL TRABAJO";
                    document.Add(new Paragraph(cadenaFinal, fontValue));
                    document.Add(new Chunk(""));

                    strNombreFile = dr["nombre_docto"].ToString();

                    strPlanRespuesta = dr["plan_respuesta"].ToString();
                }

               
            }

#region secuencia trabajo
            Font _font9 = FontFactory.GetFont(FontFactory.TIMES, 11);
            dt = dtSecuenciaTrab(1);

            PdfPTable table = new PdfPTable(dt.Columns.Count);

            float[] widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                if (i != 0 && i != 5)
                {
                    if (i == 1)
                    {
                        widths[i] = 2f;
                    }
                    else
                    {

                        widths[i] = 4f;
                    }

                }

            table.SetWidths(widths);
            table.WidthPercentage = 95;

            PdfPCell cell = new PdfPCell(new Phrase("columns"));
            cell.Colspan = dt.Columns.Count;


            foreach (DataColumn c in dt.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, _font9));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int h = 0; h < dt.Columns.Count; h++)
                    {
                        table.AddCell(new Phrase(r[h].ToString(), _font9));
                    }
                }
            }
            document.Add(table);
            #endregion secuencia trabajo


#region practicas prohibidas

            dt = dtPracticasProhibidas(1);

            document.Add(new Chunk("\n"));
            cadenaFinal = "PRACTICAS PROHIBIDAS";
            document.Add(new Paragraph(cadenaFinal, _font9));
            document.Add(new Chunk(""));

            table = new PdfPTable(dt.Columns.Count);

             widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                if (i != 0 && i != 3)
                {
                    if (i == 1)
                    {
                        widths[i] = 2f;
                    }
                    else
                    {

                        widths[i] = 8f;
                    }

                }

            table.SetWidths(widths);
            table.WidthPercentage = 95;

             cell = new PdfPCell(new Phrase("columns"));
            cell.Colspan = dt.Columns.Count;

            //document.Add(new Chunk("\n"));

            foreach (DataColumn c in dt.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, _font9));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int h = 0; h < dt.Columns.Count; h++)
                    {
                        table.AddCell(new Phrase(r[h].ToString(), _font9));
                    }
                }
            }
            document.Add(table);

            #endregion practicas prohibidas

            document.Add(new Chunk("\n"));

            cadenaFinal = "Tengo Conocimiento del presente AST (ANALISIS DE SEGURIDAD EN EL TRABAJO), el cual he leido y comprendido de los riesgos y peligros que implica REALIZAR la tarea, asi como los las medidas de Seguridad implementadas para eliminar y controlar los riesgos y peligros, el cual me obligo y comprometo a seguir y respetar para prevenir los accidentes de trabjo.";
            PdfPTable tableNota = new PdfPTable(1);
            tableNota.WidthPercentage = 100;

            PdfPCell miCelda = new PdfPCell(new Phrase(cadenaFinal, _font9));
            tableNota.AddCell(miCelda);

            document.Add(tableNota);
            document.Add(new Chunk("\n"));


    #region Personal involucrados

            dt = dtPersonalInvolucrado(1);

            document.Add(new Chunk("\n"));
            cadenaFinal = "PERSONAL INVOLUCRADO";
            document.Add(new Paragraph(cadenaFinal, _font9));

            table = new PdfPTable(dt.Columns.Count);

            widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                if (i != 0 && i != 3)
                {
                    if (i == 1)
                    {
                        widths[i] = 4f;
                    }
                    else
                    {

                        widths[i] = 4f;
                    }

                }

            table.SetWidths(widths);
            table.WidthPercentage = 95;

            cell = new PdfPCell(new Phrase("columns"));
            cell.Colspan = dt.Columns.Count;

            //document.Add(new Chunk("\n"));

            foreach (DataColumn c in dt.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, _font9));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int h = 0; h < dt.Columns.Count; h++)
                    {
                        table.AddCell(new Phrase(r[h].ToString(), _font9));
                    }
                }
            }
            document.Add(table);

            #endregion Personal involucrados

            //   PLAN DE RESPUESTA
            document.Add(new Chunk("\n"));

            cadenaFinal = "PLAN DE RESPUESTA";
            document.Add(new Paragraph(cadenaFinal, _font9));

            cadenaFinal = strPlanRespuesta;
            PdfPTable tablePlan = new PdfPTable(1);
            tablePlan.WidthPercentage = 90;

            PdfPCell miCeldaPlan = new PdfPCell(new Phrase(cadenaFinal, _font9));
            tablePlan.AddCell(miCeldaPlan);

            document.Add(tablePlan);
            document.Add(new Chunk("\n"));



            document.Close();

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=" + strNombreFile );
            HttpContext.Current.Response.Write(document);
            Response.Flush();
            Response.End();

    }

        public DataTable dtFormatoAST(int astId)
        {
            DataTable dt = new DataTable();

            objDocAst.ast_id = astId;
            dt=  objDocAst.DocAstFormato_Sel().Tables[0];

           return dt;

        }

        public DataTable dtSecuenciaTrab(int astId)
        {
            DataTable dt = new DataTable();

            objSecuenciaTrab.ast_id = astId;
            dt = objSecuenciaTrab.DocAstSecuenciaTrab_Sel().Tables[0];

            return dt;

        }

        public DataTable dtPracticasProhibidas(int astId)
        {
            DataTable dt = new DataTable();

            objPracticasProh.ast_id = astId;
            dt = objPracticasProh.DocAstPracticasProh_Sel().Tables[0];
            return dt;

        }

        public DataTable dtPersonalInvolucrado(int astId)
        {
            DataTable dt = new DataTable();

            objPersonalInvolucrado.ast_id = astId;
            dt = objPersonalInvolucrado.DocAstPersonalInvo_Sel().Tables[0];
            return dt;

        }
    }
}