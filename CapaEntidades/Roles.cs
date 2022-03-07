using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Roles
    {
        public int rol_id { get; set; }
        public string rol_nombre { get; set; }


        public Roles() { }

        public Roles(int rol_id, string rol_nombre) {

            this.rol_id = rol_id;
            this.rol_nombre = rol_nombre;

        }

    }
}
