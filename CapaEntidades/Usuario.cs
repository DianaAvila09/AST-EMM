using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidades
{
    public class Usuario
    {
        public int user_id { get; set; }
        public DateTime fecha_alta { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }

        public string password { get; set; }
        public bool esActivo { get; set; }
        public int rol_id { get; set; }
        public int depto_id { get; set; }


        public Usuario() { }

        public Usuario(int user_id, DateTime fecha_alta, string nombre, string email, string password, bool esActivo, int rol_id, int depto_id) {

            this.user_id = user_id;
            this.fecha_alta = fecha_alta;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
            this.esActivo = esActivo;
            this.rol_id = rol_id;
            this.depto_id = depto_id;
        
        
        }



    }


}
