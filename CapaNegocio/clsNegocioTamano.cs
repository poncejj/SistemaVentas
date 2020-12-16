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
    public class clsNegocioTamano
    {
        clsDatosTamano objDatosTamano = new clsDatosTamano();

        public DataSet consultarTamanoId(int id)
        {
            return objDatosTamano.consutarTamanoId(id);
        }

        public DataSet consultarTamano(String nombre)
        {
            return objDatosTamano.consutarTamano(nombre);
        }

        public DataSet consultarTodosTamanos()
        {
            return objDatosTamano.consutarTodoTamano();
        }

        public DataSet consultarTamanoProducto(int id)
        {
            return objDatosTamano.consultarTamanoProducto(id);
        }

        public bool insertarTamano(clsTamano objTamano)
        {
            return objDatosTamano.insertarTamano(objTamano.nombre_tamano, objTamano.letra_tamano);
        }

        public bool actualizarTamano(clsTamano objTamano)
        {
            return objDatosTamano.modificarTamano(objTamano.id_tamano, objTamano.nombre_tamano, objTamano.letra_tamano);
        }

        public bool eliminarTamano(int id)
        {
            return objDatosTamano.eliminarTamano(id);
        }

        public DataSet comboBoxTamano()
        {
            return objDatosTamano.consutarTodoTamano();
        }

        public bool eliminarTamanoProducto(int idProducto)
        {
            return objDatosTamano.eliminarTamanoProducto(idProducto);
        }

        public bool insertarTamanoProducto(int idProducto, int idTamano)
        {
            return objDatosTamano.insertarTamanoProducto(idProducto, idTamano);
        }
    }
}