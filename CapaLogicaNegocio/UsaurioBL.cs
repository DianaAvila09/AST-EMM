using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;


namespace CapaLogicaNegocio
{
    public class UsaurioBL
    {
        #region "Patron Signleton"

        private static UsaurioBL objEmpleado = null;
        private UsaurioBL() { }
        public static UsaurioBL getInstance()
        {
            if (objEmpleado == null)
            {
                objEmpleado = new UsaurioBL();
            }
            return objEmpleado;
        }

        #endregion

     
        public Usuario AccesoSistema(string email, string pass)
        {
            try
            {
                return UsuarioDAO.getInstance().AccesoSistema(email, pass);
            }
            catch(Exception ex)
            {
                throw ex;
            }
           

        }

    }
}
