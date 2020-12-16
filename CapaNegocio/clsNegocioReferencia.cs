using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDatos;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class clsNegocioReferencia
    {
        clsDatosReferencia objDatosReferencia = new clsDatosReferencia();

        public DataSet consultarReferencia(String nombre)
        {
            return objDatosReferencia.consutarReferencia(nombre);
        }

        public DataSet consultarReferenciaId(int id)
        {
            return objDatosReferencia.consutarReferenciaId(id);
        }

        public DataSet consultarTodosReferencias()
        {
            return objDatosReferencia.consutarTodoReferencia();
        }

        public bool insertarReferencia(clsReferencia objReferencia)
        {
            return objDatosReferencia.insertarReferencia(objReferencia.nombre_referencia);
        }

        public bool actualizarReferencia(clsReferencia objReferencia)
        {
            return objDatosReferencia.modificarReferencia(objReferencia.id_referencia, objReferencia.nombre_referencia);
        }

        public bool eliminarReferencia(int id)
        {
            return objDatosReferencia.eliminarReferencia(id);
        }

        public DataSet comboBoxReferencia()
        {
            return objDatosReferencia.consutarTodoReferencia();
        }
    }
}