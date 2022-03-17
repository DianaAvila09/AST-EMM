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


       

        #endregion //Metodos
    }
}