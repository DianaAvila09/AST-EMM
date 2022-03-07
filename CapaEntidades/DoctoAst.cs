using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidades
{
    public class DoctoAst
    {
        public int ast_id { get; set; }
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
        public string depto { get; set; }


        public DoctoAst() { }

        public DoctoAst(int ast_id, string email_contactoPlanta, string nombre_docto, DateTime fecha_creacion, 
                        string hora_fin, string hora_inicio, string desc_trabajo_realizar, string puestos_involucrados
                        , string epp_utilizar, int tipo_id, int user_id, string motivo_rechazo, string depto) {

            this.ast_id = ast_id;
            this.email_contactoPlanta = email_contactoPlanta;
            this.nombre_docto = nombre_docto;
            this.fecha_creacion = fecha_creacion;
            this.hora_fin = hora_fin;
            this.hora_inicio = hora_inicio;
            this.desc_trabajo_realizar = desc_trabajo_realizar;
            this.puestos_involucrados = puestos_involucrados;

            this.epp_utilizar = epp_utilizar;
            this.tipo_id = tipo_id;
            this.user_id = user_id;
            this.motivo_rechazo = motivo_rechazo;
            this.depto = depto;
            


        }



    }


}
