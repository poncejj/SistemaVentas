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
    public class clsNegocioMarca
    {
        clsDatosMarca objDatosMarca = new clsDatosMarca();

        public DataSet consultarMarca(String nombre)
        {
            return objDatosMarca.consutarMarca(nombre);
        }

        public DataSet consultarMarcaId(int id)
        {
            return objDatosMarca.consutarMarcaId(id);
        }

        public DataSet consultarTodosMarcas()
        {
            return objDatosMarca.consutarTodoMarca();
        }

        public bool insertarMarca(clsMarca objMarca)
        {
            return objDatosMarca.insertarMarca(objMarca.nombre_marca,objMarca.pais_marca);
        }

        public bool actualizarMarca(clsMarca objMarca)
        {
            return objDatosMarca.modificarMarca(objMarca.id_marca, objMarca.nombre_marca, objMarca.pais_marca);
        }

        public bool eliminarMarca(int id)
        {
            return objDatosMarca.eliminarMarca(id);
        }

        public DataSet comboBoxMarca()
        {
            return objDatosMarca.consutarTodoMarca();
        }
    }
}