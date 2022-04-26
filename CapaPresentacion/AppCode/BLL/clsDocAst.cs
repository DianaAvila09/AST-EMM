using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MegaDoc.DAL;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion.AppCode.BLL
{
    public class clsDocAst
    {
        #region Variables

        DBBridge objDBBridge = new DBBridge();


        public int ast_id { get; set; }
        public string area { get; set; }
        public string email_contactoPlanta { get; set; }
        public string nombre_docto { get; set; }
        public DateTime fecha_creacion { get; set; }
        public string hora_fin { get; set; }
        public string hora_inicio { get; set; }
        public string desc_trabajo_realizar { get; set; }
        public string puestos_involucrados { get; set; }
        public string epp_utilizar { get; set; }
        public int tipo_id { get; set; }
        public int user_id { get; set; }
        public string motivo_rechazo { get; set; }
        public int dpto_id { get; set; }
        public string estatus { get; set; }
        public string plan_respuesta { get; set; }

        public bool isAutorizado { get; set; }

        public int vigilante_id { get; set; }
        public string rol_name { get; set; }

        public bool trabajo_enAlturas { get; set; }
        public bool trabajo_equipoMovil { get; set; }
        public bool trabajo_espacioConfinado { get; set; }
        public int comite_id { get; set; }


        #endregion //Variables


        #region Metodos
        public DataSet DocAst_Sel()
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@prmTipoDocto", tipo_id);
            param[1] = new SqlParameter("@p_UserId", user_id);
            param[2] = new SqlParameter("@p_RolName", rol_name);

            return objDBBridge.ExecuteDataset("spConsultaAst", param);
        }

        public DataSet TipoDocto_Sel()
        {
            return objDBBridge.ExecuteDataset("spTipoDocQuery");
        }

        public DataSet Deptos_Sel()
        {
            return objDBBridge.ExecuteDataset("spDeptos");
        }

        public int Doctos_insert()
        {
            SqlParameter[] param = new SqlParameter[18];
            param[0] = new SqlParameter("@p_area", area);
            param[1] = new SqlParameter("@p_fecha", fecha_creacion);
            param[2] = new SqlParameter("@p_hora_inicio", hora_inicio);
            param[3] = new SqlParameter("@p_hora_fin", hora_fin);
            param[4] = new SqlParameter("@p_email_contactoPlanta", email_contactoPlanta);
            param[5] = new SqlParameter("@p_nombre_docto", nombre_docto);
            param[6] = new SqlParameter("@p_desc_trabajo_realizar", desc_trabajo_realizar);
            param[7] = new SqlParameter("@p_puestos_involucrados", puestos_involucrados);
            param[8] = new SqlParameter("@p_epp_utilizar", epp_utilizar);
            param[9] = new SqlParameter("@p_tipo_id", tipo_id);
            param[10] = new SqlParameter("@p_user_id", user_id);
            param[11] = new SqlParameter("@p_dpto_id", dpto_id);
            param[12] = new SqlParameter("@p_motivo_rechazo", motivo_rechazo);
            param[13] = new SqlParameter("@p_estatus", estatus);
            param[14] = new SqlParameter("@p_plan_respuesta", plan_respuesta);
            param[15] = new SqlParameter("@p_trabajo_enAlturas", trabajo_enAlturas);
            param[16] = new SqlParameter("@p_trabajo_equipoMovil", trabajo_equipoMovil);
            param[17] = new SqlParameter("@p_trabajo_espacioConfinado", trabajo_espacioConfinado);

            return objDBBridge.ExecuteNonQuery("spInsertAstFormato", param);
        }

        public DataSet DocAstFormato_Sel()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@p_astid", ast_id);

            return objDBBridge.ExecuteDataset("spConsultaAstFormato_byId", param);
        }

        public DataSet GetASTid_Sel()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@p_nombre_docto", nombre_docto);

            return objDBBridge.ExecuteDataset("spGetASTid", param);
        }

        public int DocAstFormato_Del()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@p_astid", ast_id);
            return objDBBridge.ExecuteNonQuery("spEliminaAst", param);
        }

        public int DocAstFormato_Upd()
        {
            SqlParameter[] param = new SqlParameter[17];
            param[0] = new SqlParameter("@p_area", area);
            param[1] = new SqlParameter("@p_hora_inicio", hora_inicio);
            param[2] = new SqlParameter("@p_hora_fin", hora_fin);
            param[3] = new SqlParameter("@p_email_contactoPlanta", email_contactoPlanta);
            param[4] = new SqlParameter("@p_desc_trabajo_realizar", desc_trabajo_realizar);
            param[5] = new SqlParameter("@p_puestos_involucrados", puestos_involucrados);
            param[6] = new SqlParameter("@p_epp_utilizar", epp_utilizar);
            param[7] = new SqlParameter("@p_tipo_id", tipo_id);
            param[8] = new SqlParameter("@p_user_id", user_id);
            param[9] = new SqlParameter("@p_dpto_id", dpto_id);
            param[10] = new SqlParameter("@p_motivo_rechazo", motivo_rechazo);
            param[11] = new SqlParameter("@p_plan_respuesta", plan_respuesta);
            param[12] = new SqlParameter("@p_astid", ast_id);
            param[13] = new SqlParameter("@p_estatus", estatus);
            param[14] = new SqlParameter("@p_trabajo_enAlturas", trabajo_enAlturas);
            param[15] = new SqlParameter("@p_trabajo_equipoMovil", trabajo_equipoMovil);
            param[16] = new SqlParameter("@p_trabajo_espacioConfinado", trabajo_espacioConfinado);

            return objDBBridge.ExecuteNonQuery("spUpdateAstFormato", param);
        }

        public int DocDetalleAst_Del()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@p_astid", ast_id);
            return objDBBridge.ExecuteNonQuery("spEliminaDetalleAst", param);
        }

        public int EnviaMail_Proc()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@p_ast_id", ast_id);
            return objDBBridge.ExecuteNonQuery("spMailAstEMM", param);
        }
        public int EnviaMailVigilancia_Proc()
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@p_ast_id", ast_id);
            param[1] = new SqlParameter("@p_vigilante_id", vigilante_id);
            return objDBBridge.ExecuteNonQuery("spMailAstEMM_vigilancia", param);
        }
        public int EnviaMailComite_Proc()
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@p_ast_id", ast_id);
            param[1] = new SqlParameter("@p_comite_id", comite_id);
            return objDBBridge.ExecuteNonQuery("spMailAstEMM_comite", param);
        }

        public int EstatusAst_Upd()
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@p_astid", ast_id);
            param[1] = new SqlParameter("@p_estatus", estatus);
            param[2] = new SqlParameter("@p_autorizado", isAutorizado);
            param[3] = new SqlParameter("@p_motivoRechazo", motivo_rechazo);

            return objDBBridge.ExecuteNonQuery("spUpdateEstatusAST", param);
        }



        public int UpdStatus()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Mode", "UpdStatus");
            return objDBBridge.ExecuteNonQuery("spMailtoSendIns", param);
        }
        public DataSet SelMailto_AstEmm()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Mode", "SelMailto_AstEmm");

            return objDBBridge.ExecuteDataset("spMailtoSendIns", param);

        }

        public DataSet Vigilantes_Sel()
        { 
            return objDBBridge.ExecuteDataset("spVigilantes_sel");
        }

        public DataSet GpoComite_Sel()
        {
            return objDBBridge.ExecuteDataset("spGpoComite_sel");
        }

        public int BitacoraVigilantes_insert()
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@p_ast_id", ast_id);
            param[1] = new SqlParameter("@p_vigilante_id", vigilante_id);
            
            return objDBBridge.ExecuteNonQuery("spInsBitacoraVigilantes", param);
        }

        public int BitacoraComite_insert()
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@p_ast_id", ast_id);
            param[1] = new SqlParameter("@p_comite_id", comite_id);
            param[2] = new SqlParameter("@p_estatus", estatus);

            return objDBBridge.ExecuteNonQuery("spInsBitacoraComite", param);
        }
        #endregion

    }
}