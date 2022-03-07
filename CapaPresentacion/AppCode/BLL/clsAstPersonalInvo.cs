using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MegaDoc.DAL;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion.AppCode.BLL
{
    public class clsAstPersonalInvo
    {
        #region Variables

        DBBridge objDBBridge = new DBBridge();


        public int ast_id { get; set; }
        public int personal_id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
  

        #endregion //Variables


        #region Metodos
        public DataSet DocAstPersonalInvo_Sel()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@p_aspid", ast_id);

            return objDBBridge.ExecuteDataset("spConsultaAstPersonalInvo_byId", param);
        }

        public int DocAstPersonalInvo_insert()
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@p_nombre", nombre);
            param[1] = new SqlParameter("@p_email", email);
            param[2] = new SqlParameter("@p_ast_id", ast_id);

            return objDBBridge.ExecuteNonQuery("spInsertAstPI", param);
        }


        #endregion

    }
}