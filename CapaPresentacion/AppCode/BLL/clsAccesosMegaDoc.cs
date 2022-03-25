using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MegaDoc.DAL;
using System.Data;
using System.Data.SqlClient;

namespace MegaDoc.BLL
{

    public class clsAccesosMegaDoc
    {

        #region Variables

        DBBridge objDBBridge = new DBBridge();
       

        public int user_id { get; set; }
        public DateTime fecha_alta { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }

        public string password { get; set; }
        public bool esActivo { get; set; }
        public int rol_id { get; set; }
        public int depto_id { get; set; }

        public string rol_nombre { get; set; }
        public string cia { get; set; }
        public string dpto_nombre { get; set; }
        public string mode { get; set; }

        //protected int _UsrId;
        //protected string _Mode;
        //protected int _CompanyId;




        #endregion //Variables

        #region Propiedades



        #endregion

        #region Metodos


        public void AccesoLogin(string correo, string pass)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@prmEmail", correo);
            param[1] = new SqlParameter("@prmPass", pass );
            DataTable dt = new DataTable();
            dt = objDBBridge.ExecuteDataset("splogin", param).Tables[0];
            if (dt.Rows.Count != 0)
            {
                DataRow dr;
                dr = dt.Rows[0];
                user_id = Convert.ToInt32(dr["user_id"].ToString());
                nombre = dr["nombre"].ToString();
                rol_nombre = dr["rol_nombre"].ToString();
            }
        }

        public DataSet UsuariosQuery()
        {
            return objDBBridge.ExecuteDataset("spUsuariosQuery");
        }

        public int User_Actualiza()
        {
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@mode", mode);
            param[1] = new SqlParameter("@user_id", user_id);
            param[2] = new SqlParameter("@nombre", nombre);
            param[3] = new SqlParameter("@email", email);
            param[4] = new SqlParameter("@password", password);
            param[5] = new SqlParameter("@esActivo", esActivo);
            param[6] = new SqlParameter("@rol_id", rol_id);
            param[7] = new SqlParameter("@dpto_id", depto_id);
            param[8] = new SqlParameter("@cia", cia);
           
            return objDBBridge.ExecuteNonQuery("spUsuariosUpd", param);
        }

        public DataSet UsuariosQuery_ById()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_id", user_id);

            return objDBBridge.ExecuteDataset("spUsuariosQuery_ById", param);
        }

        public DataSet RolesQuery()
        {
            return objDBBridge.ExecuteDataset("spRolesQuery");
        }

        #endregion //Metodos
    }
}