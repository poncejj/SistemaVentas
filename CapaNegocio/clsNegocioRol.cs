using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDatos;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class clsNegocioRol
    {
        clsDatosRol objDatosRol = new clsDatosRol();

        public DataSet consultarRol(int id)
        {
            return objDatosRol.consutarRol(id);
        }

        public DataSet consultarTodosRols()
        {
            return objDatosRol.consutarTodoRol();
        }

        public bool insertarRol(clsRol objRol)
        {
            return objDatosRol.insertarRol(objRol.nombre_rol, objRol.descripcion_rol);
        }

        public bool actualizarRol(clsRol objRol)
        {
            return objDatosRol.modificarRol(objRol.id_rol, objRol.nombre_rol, objRol.descripcion_rol);
        }

        public bool eliminarRol(int id)
        {
            return objDatosRol.eliminarRol(id);
        }

        public DataSet comboBoxRol()
        {
            return objDatosRol.consutarTodoRol();
        }
    }
}