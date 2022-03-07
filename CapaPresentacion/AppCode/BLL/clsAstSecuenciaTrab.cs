using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MegaDoc.DAL;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion.AppCode.BLL
{
    public class clsAstSecuenciaTrab
    {
        #region Variables

        DBBridge objDBBridge = new DBBridge();


        public int ast_id { get; set; }
        public int sec_id { get; set; }
        public int paso_num { get; set; }
        public string desc_secuencia { get; set; }
        public string identifica_riesgos { get; set; }
        public string procedmiento_realizar { get; set; }


        #endregion //Variables


        #region Metodos
        public DataSet DocAstSecuenciaTrab_Sel()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@p_aspid", ast_id);

            return objDBBridge.ExecuteDataset("spConsultaAstSecuenciaTrab_byId", param);
        }

        public int DocAstSecuenciaTrab_insert()
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@p_paso_num", paso_num);
            param[1] = new SqlParameter("@p_desc_secuencia", desc_secuencia);
            param[2] = new SqlParameter("@p_identifica_riesgos", identifica_riesgos);
            param[3] = new SqlParameter("@p_procedmiento_realizar", procedmiento_realizar);
            param[4] = new SqlParameter("@p_ast_id", ast_id);
           

            return objDBBridge.ExecuteNonQuery("spInsertAstSecuencia", param);
        }

        #endregion  

    }
}