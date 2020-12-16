using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsRol
    {
        public clsRol()
        {
        }

        public clsRol(int id_rol, String nombre_rol, String descripcion_rol)
        {
            this.id_rol = id_rol;
            this.nombre_rol = nombre_rol;
            this.descripcion_rol = descripcion_rol;
        }

        public int id_rol {get;set;}
        public String nombre_rol {get;set;}
        public String descripcion_rol { get; set; }
    }
}
