using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using AAtrading.DAL;

namespace MegaDoc.DAL
{
    public enum DBCONNECTION
    {
        magnaDoc = 1,
        MYOB_SQL = 2,
        ExcelTemplate = 3,
        Consolida = 4,

    }

    public class DBConexion
    {

        public static string GetConexion(DBCONNECTION conexion)
        {
            return GetConexionSetting(conexion).ConnectionString;
        }

        public static ConnectionStringSettings GetConexionSetting(DBCONNECTION conexion)
        {
            try
            {
                switch (conexion)
                {
                    case DBCONNECTION.magnaDoc:
                        return ConfigurationManager.ConnectionStrings["CnxMegaDoc"];
                    case DBCONNECTION.MYOB_SQL:
                        return ConfigurationManager.ConnectionStrings["CnxMYOB2"];
                    case DBCONNECTION.ExcelTemplate:
                        return ConfigurationManager.ConnectionStrings["CnxTemplateExcel2"];
                    case DBCONNECTION.Consolida:
                        return ConfigurationManager.ConnectionStrings["CnxAATrading3"];


                    default:
                        return ConfigurationManager.ConnectionStrings["CnxAA2"];
                }
            }
            catch (Exception ce)
            {

                throw new ApplicationException("Unable to get DB Connection string from Config File. Contact Administrator" + ce);
            }
           
        }

    }
    /// <summary>
    /// Summary description for DBBridge.
    /// </summary>
    [Serializable]
    public class DBBridge
    {
        
        public DBBridge()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //public static string DBConnection()
        //{
        //    try
        //    {
        //        return ConfigurationManager.AppSettings["ConnectionString"];

        //    }
        //    catch (Exception ce)
        //    {

        //       throw new ApplicationException("Unable to get DB Connection string from Config File. Contact Administrator" + ce);
        //    }
        //}


        public int ExecuteNonQuery(string storedProcedure, SqlParameter[] param)
        {
            try
            {
                //return SqlHelper.ExecuteNonQuery(DBConnection(), CommandType.StoredProcedure, storedProcedure, param);
                return SqlHelper.ExecuteNonQuery(DBConexion.GetConexion(DBCONNECTION.magnaDoc), CommandType.StoredProcedure, storedProcedure, param);
                
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public int ExecuteNonQuerywithTrans(string storedProcedure, SqlParameter[] param)
        {
            SqlConnection conTrans = new SqlConnection(DBConexion.GetConexion(DBCONNECTION.magnaDoc));
            SqlTransaction sqlTrans;
            conTrans.Open();
            int returnResult = 0;
            using (sqlTrans = conTrans.BeginTransaction())
            {
                try
                {
                    returnResult = SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, storedProcedure, param);
                    sqlTrans.Commit();
                    return returnResult;
                }
                catch (Exception sq)
                {
                    sqlTrans.Rollback();
                    throw sq;
                }
                finally
                {
                    conTrans.Close();
                }
            }
        }

        public int ExecuteNonQuery(string storedProcedure)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(DBConexion.GetConexion(DBCONNECTION.magnaDoc), CommandType.StoredProcedure, storedProcedure);
            }
            catch (SqlException sq)
            {
               throw sq;
            }
        }
        public int ExecuteNonQueryMYOB(string storedProcedure)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(DBConexion.GetConexion(DBCONNECTION.MYOB_SQL), CommandType.StoredProcedure, storedProcedure);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public int ExecuteNonQuerySQL(string sqlquery)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(DBConexion.GetConexion(DBCONNECTION.magnaDoc), CommandType.Text, sqlquery);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public int ExecuteNonQuerywithTrans(string storedProcedure)
        {
            SqlConnection conTrans = new SqlConnection(DBConexion.GetConexion(DBCONNECTION.magnaDoc));
            SqlTransaction sqlTrans;
            conTrans.Open();
            int returnResult = 0;
            using (sqlTrans = conTrans.BeginTransaction())
            {
                try
                {
                    returnResult = SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, storedProcedure);
                    sqlTrans.Commit();
                    return returnResult;
                }
                catch (Exception sq)
                {
                    sqlTrans.Rollback();
                    throw sq;
                }
                finally
                {
                    conTrans.Close();
                }
            }
        }

        public int ExecuteNonQuerywithTransfromFrontEnd(SqlTransaction sqlTrans, string storedProcedure, SqlParameter[] param)
        {
            try
            {
                int returnResult = SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, storedProcedure, param);
                return returnResult;
            }
            catch (SqlException sq)
            {
               sqlTrans.Rollback();
               throw sq;
            }
        }

        public DataSet ExecuteDataset(string storedProcedure, SqlParameter[] param)
        {
            try
            {
                return SqlHelper.ExecuteDataset(DBConexion.GetConexion(DBCONNECTION.magnaDoc), CommandType.StoredProcedure, storedProcedure, param);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }
        public DataSet ExecuteDatasetMaster(string storedProcedure, SqlParameter[] param)
        {
            try
            {
                return SqlHelper.ExecuteDataset(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.StoredProcedure, storedProcedure, param);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }
        // para BD mexico
        //public DataSet ExecuteDatasetMex(string storedProcedure, SqlParameter[] param)
        //{
        //    try
        //    {
        //        return SqlHelper.ExecuteDataset(DBConexion.GetConexion(DBCONNECTION.Mexico), CommandType.StoredProcedure, storedProcedure, param);
        //    }
        //    catch (SqlException sq)
        //    {
        //        throw sq;
        //    }
        //}
        public DataSet ExecuteDatasetSQL(string storedProcedure)
        {
            try
            {
                return SqlHelper.ExecuteDataset(DBConexion.GetConexion(DBCONNECTION.magnaDoc), CommandType.Text, storedProcedure);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }
        public DataSet ExecuteDatasetSQLmaster(string storedProcedure)
        {
            try
            {
                return SqlHelper.ExecuteDataset(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.Text, storedProcedure);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public DataSet ExecuteDataset(string storedProcedure)
        {
            try
            {
                return SqlHelper.ExecuteDataset(DBConexion.GetConexion(DBCONNECTION.magnaDoc), CommandType.StoredProcedure, storedProcedure);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public object ExecuteScalar(string storedProcedure, SqlParameter[] param)
        {
            try
            {
                return SqlHelper.ExecuteScalar(DBConexion.GetConexion(DBCONNECTION.magnaDoc), CommandType.StoredProcedure, storedProcedure, param);
            }
            catch (SqlException sq)
            {
               throw sq;
            }
        }

        public object ExecuteScalar(SqlTransaction sqlTrans, string storedProcedure, SqlParameter[] param)
        {
            try
            {
                return SqlHelper.ExecuteScalar(sqlTrans, CommandType.StoredProcedure, storedProcedure, param);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }
        public SqlDataReader ExecuteReader(string storedProcedure, SqlParameter[] param)
        {
            SqlDataReader reader = null;
            try
            {
                reader = SqlHelper.ExecuteReader(DBConexion.GetConexion(DBCONNECTION.magnaDoc), CommandType.StoredProcedure, storedProcedure, param);
                return reader;
            }
            catch (SqlException sq)
            {
               throw sq;
            }
        }

        public SqlDataReader ExecuteReader(string storedProcedure)
        {
            SqlDataReader reader = null;
            try
            {
                reader = SqlHelper.ExecuteReader(DBConexion.GetConexion(DBCONNECTION.magnaDoc), CommandType.StoredProcedure, storedProcedure);
                return reader;
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public SqlDataReader ExecuteReaderSQL(string sqlquery)
        {
            SqlDataReader reader = null;
            try
            {
                reader = SqlHelper.ExecuteReader(DBConexion.GetConexion(DBCONNECTION.magnaDoc), CommandType.Text, sqlquery);
                return reader;
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public int ExecuteNonQuerywithMultipleTrans(SqlTransaction sqlTrans, string storedProcedure)
        {
            int returnResult = 0;
            try
            {
                returnResult = SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, storedProcedure);
                return returnResult;
            }
            catch (Exception sq)
            {
                throw sq;
            }
        }

        public int ExecuteNonQuerywithMultipleTrans(SqlTransaction sqlTrans, string storedProcedure, SqlParameter[] param)
        {
            int returnResult = 0;
            try
            {
                returnResult = SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, storedProcedure, param);
                return returnResult;
            }
            catch (Exception sq)
            {
                throw sq;
            }
        }
    }

    public class DBBridge_consolida
    {

        public DBBridge_consolida()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //public static string DBConnection()
        //{
        //    try
        //    {
        //        return ConfigurationManager.AppSettings["ConnectionString"];

        //    }
        //    catch (Exception ce)
        //    {

        //       throw new ApplicationException("Unable to get DB Connection string from Config File. Contact Administrator" + ce);
        //    }
        //}


        public int ExecuteNonQuery(string storedProcedure, SqlParameter[] param)
        {
            try
            {
                //return SqlHelper.ExecuteNonQuery(DBConnection(), CommandType.StoredProcedure, storedProcedure, param);
                return SqlHelper.ExecuteNonQuery(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.StoredProcedure, storedProcedure, param);

            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public int ExecuteNonQuerywithTrans(string storedProcedure, SqlParameter[] param)
        {
            SqlConnection conTrans = new SqlConnection(DBConexion.GetConexion(DBCONNECTION.Consolida));
            SqlTransaction sqlTrans;
            conTrans.Open();
            int returnResult = 0;
            using (sqlTrans = conTrans.BeginTransaction())
            {
                try
                {
                    returnResult = SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, storedProcedure, param);
                    sqlTrans.Commit();
                    return returnResult;
                }
                catch (Exception sq)
                {
                    sqlTrans.Rollback();
                    throw sq;
                }
                finally
                {
                    conTrans.Close();
                }
            }
        }

        public int ExecuteNonQuery(string storedProcedure)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.StoredProcedure, storedProcedure);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }
        public int ExecuteNonQueryMYOB(string storedProcedure)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(DBConexion.GetConexion(DBCONNECTION.MYOB_SQL), CommandType.StoredProcedure, storedProcedure);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public int ExecuteNonQuerySQL(string sqlquery)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.Text, sqlquery);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public int ExecuteNonQuerywithTrans(string storedProcedure)
        {
            SqlConnection conTrans = new SqlConnection(DBConexion.GetConexion(DBCONNECTION.Consolida));
            SqlTransaction sqlTrans;
            conTrans.Open();
            int returnResult = 0;
            using (sqlTrans = conTrans.BeginTransaction())
            {
                try
                {
                    returnResult = SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, storedProcedure);
                    sqlTrans.Commit();
                    return returnResult;
                }
                catch (Exception sq)
                {
                    sqlTrans.Rollback();
                    throw sq;
                }
                finally
                {
                    conTrans.Close();
                }
            }
        }

        public int ExecuteNonQuerywithTransfromFrontEnd(SqlTransaction sqlTrans, string storedProcedure, SqlParameter[] param)
        {
            try
            {
                int returnResult = SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, storedProcedure, param);
                return returnResult;
            }
            catch (SqlException sq)
            {
                sqlTrans.Rollback();
                throw sq;
            }
        }

        public DataSet ExecuteDataset(string storedProcedure, SqlParameter[] param)
        {
            try
            {
                return SqlHelper.ExecuteDataset(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.StoredProcedure, storedProcedure, param);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }
        // para BD mexico
        //public DataSet ExecuteDatasetMex(string storedProcedure, SqlParameter[] param)
        //{
        //    try
        //    {
        //        return SqlHelper.ExecuteDataset(DBConexion.GetConexion(DBCONNECTION.Mexico), CommandType.StoredProcedure, storedProcedure, param);
        //    }
        //    catch (SqlException sq)
        //    {
        //        throw sq;
        //    }
        //}
        public DataSet ExecuteDatasetSQL(string storedProcedure)
        {
            try
            {
                return SqlHelper.ExecuteDataset(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.Text, storedProcedure);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public DataSet ExecuteDataset(string storedProcedure)
        {
            try
            {
                return SqlHelper.ExecuteDataset(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.StoredProcedure, storedProcedure);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public object ExecuteScalar(string storedProcedure, SqlParameter[] param)
        {
            try
            {
                return SqlHelper.ExecuteScalar(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.StoredProcedure, storedProcedure, param);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public object ExecuteScalar(SqlTransaction sqlTrans, string storedProcedure, SqlParameter[] param)
        {
            try
            {
                return SqlHelper.ExecuteScalar(sqlTrans, CommandType.StoredProcedure, storedProcedure, param);
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }
        public SqlDataReader ExecuteReader(string storedProcedure, SqlParameter[] param)
        {
            SqlDataReader reader = null;
            try
            {
                reader = SqlHelper.ExecuteReader(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.StoredProcedure, storedProcedure, param);
                return reader;
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public SqlDataReader ExecuteReader(string storedProcedure)
        {
            SqlDataReader reader = null;
            try
            {
                reader = SqlHelper.ExecuteReader(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.StoredProcedure, storedProcedure);
                return reader;
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public SqlDataReader ExecuteReaderSQL(string sqlquery)
        {
            SqlDataReader reader = null;
            try
            {
                reader = SqlHelper.ExecuteReader(DBConexion.GetConexion(DBCONNECTION.Consolida), CommandType.Text, sqlquery);
                return reader;
            }
            catch (SqlException sq)
            {
                throw sq;
            }
        }

        public int ExecuteNonQuerywithMultipleTrans(SqlTransaction sqlTrans, string storedProcedure)
        {
            int returnResult = 0;
            try
            {
                returnResult = SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, storedProcedure);
                return returnResult;
            }
            catch (Exception sq)
            {
                throw sq;
            }
        }

        public int ExecuteNonQuerywithMultipleTrans(SqlTransaction sqlTrans, string storedProcedure, SqlParameter[] param)
        {
            int returnResult = 0;
            try
            {
                returnResult = SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, storedProcedure, param);
                return returnResult;
            }
            catch (Exception sq)
            {
                throw sq;
            }
        }
    }
}

