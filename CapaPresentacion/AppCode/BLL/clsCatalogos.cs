using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MegaDoc.DAL;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion.AppCode.BLL
{
    public class clsCatalogos

    {
        #region Variables

        DBBridge objDBBridge = new DBBridge();

        public string mode { get; set; }
        public int tipo_id { get; set; }
        public string desc_docto { get; set; }
        public bool esActivo { get; set; }


        #endregion //Variables

      

        public DataSet DoctosQuery()
        {
            return objDBBridge.ExecuteDataset("spDoctosQuery");
        }

        public int Doctos_Actualiza()
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@mode", mode);
            param[1] = new SqlParameter("@tipo_id", tipo_id);
            param[2] = new SqlParameter("@desc_docto", desc_docto);
            param[3] = new SqlParameter("@esActivo", esActivo);

            return objDBBridge.ExecuteNonQuery("spDoctosUpd", param);
        }
        public DataSet DoctosQuery_ById()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@tipo_id", tipo_id);

            return objDBBridge.ExecuteDataset("spDoctosQuery_ById", param);
        }


    }
}