using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using ModeloDatos;
using System.Data;

namespace CapaNegocio
{
    public class clsNegocioUsuario
    {
        clsDatosUsuario objDatosUsuario = new clsDatosUsuario();

        public DataSet consultarUsuario(int idUsuario)
        {
            return objDatosUsuario.consutarUsuario(idUsuario);
        }

        public DataSet consultarTodosUsuarios()
        {
            return objDatosUsuario.consutarTodoUsuario();
        }

        public bool insertarUsuario(clsUsuario objUsuario)
        {
            return objDatosUsuario.insertarUsuario(objUsuario.login_usuario, objUsuario.contrasenia_usuario, objUsuario.identificacion_usuario,
                objUsuario.nombre_usuario,objUsuario.apellido_usuario,objUsuario.telefono_usuario,objUsuario.rol_usuario);
        }

        public bool actualizarUsuario(clsUsuario objUsuario)
        {
            return objDatosUsuario.modificarUsuario(objUsuario.id_usuario, objUsuario.login_usuario, objUsuario.contrasenia_usuario, 
                objUsuario.identificacion_usuario, objUsuario.nombre_usuario, objUsuario.apellido_usuario, objUsuario.telefono_usuario, objUsuario.rol_usuario);
        }

        public bool eliminarUsuario(int id)
        {
            return objDatosUsuario.eliminarUsuario(id);
        }

        public DataSet comboBoxUsuario()
        {
            return objDatosUsuario.consutarTodoUsuario();
        }

        public int login(string usuario, string password)
        {
            return objDatosUsuario.login(usuario,password);
        }
    }
}