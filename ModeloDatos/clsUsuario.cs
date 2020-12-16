using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsUsuario
    {
        public clsUsuario()
        {
        }

        public clsUsuario(int id_usuario, String login_usuario, String contrasenia_usuario, String identificacion_usuario, 
            String nombre_usuario, String apellido_usuario, String telefono_usuario, int rol_usuario)
        {
            this.id_usuario = id_usuario;
            this.contrasenia_usuario = contrasenia_usuario;
            this.identificacion_usuario = identificacion_usuario;
            this.nombre_usuario = nombre_usuario;
            this.apellido_usuario = apellido_usuario;
            this.telefono_usuario = telefono_usuario;
            this.rol_usuario = rol_usuario;
        }

        public int id_usuario { get; set; }
        public String login_usuario { get; set; }
        public String contrasenia_usuario { get; set; }
        public String identificacion_usuario { get; set; } 
        public String nombre_usuario { get; set; }
        public String apellido_usuario { get; set; }
        public String telefono_usuario { get; set; }
        public int rol_usuario { get; set; }
    }
}
