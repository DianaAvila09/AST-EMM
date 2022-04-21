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

        public int vigilancia_id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }

        public int dpto_id { get; set; }
        public string dpto_nombre { get; set; }

        public int comite_id { get; set; }
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



        public DataSet VigilantesQuery()
        {
            return objDBBridge.ExecuteDataset("spGpoVigilancia_Query");
        }

        public int Vigilantes_Actualiza()
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@mode", mode);
            param[1] = new SqlParameter("@vigilancia_id", vigilancia_id);
            param[2] = new SqlParameter("@nombre", nombre);
            param[3] = new SqlParameter("@email", email);
            param[4] = new SqlParameter("@esActivo", esActivo);

            return objDBBridge.ExecuteNonQuery("spGpoVigilancia_Upd", param);
        }
        public DataSet VigilantesQuery_ById()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@vigilancia_id", vigilancia_id);

            return objDBBridge.ExecuteDataset("spGpoVigilancia_QueryById", param);
        }


        public DataSet DeptosQuery()
        {
            return objDBBridge.ExecuteDataset("spDeptosQuery");
        }

        public int Deptos_Actualiza()
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@mode", mode);
            param[1] = new SqlParameter("@dpto_id", dpto_id);
            param[2] = new SqlParameter("@dpto_nombre", dpto_nombre);
            param[3] = new SqlParameter("@esActivo", esActivo);

            return objDBBridge.ExecuteNonQuery("spDeptosUpd", param);
        }
        public DataSet DeptosQuery_ById()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dpto_id", dpto_id);

            return objDBBridge.ExecuteDataset("spDeptosQuery_ById", param);
        }


        public DataSet ComiteQuery()
        {
            return objDBBridge.ExecuteDataset("spComite_Query");
        }

        public int Comite_Actualiza()
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@mode", mode);
            param[1] = new SqlParameter("@comite_id", comite_id);
            param[2] = new SqlParameter("@nombre", nombre);
            param[3] = new SqlParameter("@email", email);
            param[4] = new SqlParameter("@esActivo", esActivo);

            return objDBBridge.ExecuteNonQuery("spComite_Upd", param);
        }
        public DataSet ComiteQuery_ById()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@comite_id", comite_id);

            return objDBBridge.ExecuteDataset("spComite_QueryById", param);
        }


    }
}