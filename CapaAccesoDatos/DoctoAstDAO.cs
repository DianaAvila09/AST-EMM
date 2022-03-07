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
    public class DoctoAstDAO
    {
        #region "Patron Signleton"

        private static DoctoAstDAO doctastDao = null;
        private DoctoAstDAO() { }
        public static DoctoAstDAO getInstance()
        {
            if (doctastDao == null)
            {
                doctastDao = new DoctoAstDAO();
            }
            return doctastDao;
        }

        #endregion

        public DoctoAst getDoctoAst()
        {

            SqlConnection cnn = null;
            SqlCommand cmd ;
            DoctoAst objDoctAst = new DoctoAst();
            SqlDataReader dr;

            try
            {
                cnn = Conexion.getInstance().conectarDB();
                cmd = new SqlCommand("spConsutaAst", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmTipoDocto", 1);
                cnn.Open();

                dr = cmd.ExecuteReader();
              

            }
            catch(Exception ex)
            {
                objDoctAst = null;
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return objDoctAst;
        }

    }
}
