using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MegaDoc.DAL;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion.AppCode.BLL
{
    public class clsAstPracticasProh
    {
        #region Variables

        DBBridge objDBBridge = new DBBridge();


        public int ast_id { get; set; }
        public int practica_id { get; set; }
        public int practica_num { get; set; }
        public string desc_practica { get; set; }
  

        #endregion //Variables


        #region Metodos
        public DataSet DocAstPracticasProh_Sel()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@p_aspid", ast_id);

            return objDBBridge.ExecuteDataset("spConsultaAstPracticasProh_byId", param);
        }
        public int DocAstPracticasProh_insert()
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@p_practica_num", practica_num);
            param[1] = new SqlParameter("@p_desc_practica", desc_practica);
            param[2] = new SqlParameter("@p_ast_id", ast_id);

            return objDBBridge.ExecuteNonQuery("spInsertAstPP", param);
        }

        #endregion

    }
}