using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class UsuarioDAO
    {
        #region "Patron Signleton"

        private static UsuarioDAO usuarioDao = null;
        private UsuarioDAO() { }
        public static UsuarioDAO getInstance()
        {
            if (usuarioDao == null)
            {
                usuarioDao = new UsuarioDAO();
            }
            return usuarioDao;
        }

        #endregion

        public Usuario AccesoSistema(string email, string pass)
        {

            SqlConnection cnn = null;
            SqlCommand cmd ;
            Usuario objUsuario = new Usuario();
            SqlDataReader dr;

            try
            {
                cnn = Conexion.getInstance().conectarDB();
                cmd = new SqlCommand("spLogin", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmEmail", email);
                cmd.Parameters.AddWithValue("@prmPass", pass);
                cnn.Open();

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objUsuario.user_id = Convert.ToInt32(dr["user_id"].ToString());
                    objUsuario.nombre = dr["nombre"].ToString();
                }


            }
            catch(Exception ex)
            {
                objUsuario = null;
                throw ex;
            }
            finally
            {
                cnn.Close();
            }



            return objUsuario;

        }

    }
}
