using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MegaDoc.DAL;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion.AppCode.BLL
{
    public class clsAstGpoAprobacion
    {
        #region Variables

        DBBridge objDBBridge = new DBBridge();


        public int ast_id { get; set; }
        public int gpa_id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
  

        #endregion //Variables


        #region Metodos
        public DataSet DocAstGpoAprobacion_Sel()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@p_aspid", ast_id);

            return objDBBridge.ExecuteDataset("spConsultaAstGpoAprobacion_byId", param);
        }
        public DataSet DocAstGpoComite_Sel()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@p_aspid", ast_id);

            return objDBBridge.ExecuteDataset("spConsultaAstGpoComite_byId", param);
        }

        #endregion

    }
}