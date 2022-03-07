using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace CapaAccesoDatos
{
    public class Conexion
    {

        #region "Patron Signleton"

        private static Conexion conexion = null;
        private Conexion() { }
        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }

        #endregion

        public SqlConnection conectarDB()
        {
            SqlConnection conexion = new SqlConnection();
            //conexion.ConnectionString =  "Data Source = DESKTOP-K9GNF1O; Initial Catalog = magnaDoc; Persist Security Info = True; UID=sa; PWD=3108sham";
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["CnxMegaDoc"].ToString();
            return conexion;

        }
         
    }
}
