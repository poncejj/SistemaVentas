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
    public class clsNegocioCategoria
    {
        clsDatosCategoria objDatosCategoria = new clsDatosCategoria();
        
        public DataSet consultarCategoria(String busqueda)
        {
            return objDatosCategoria.consutarCategoria(busqueda);
        }

        public DataSet consultarCategoriaId(int id)
        {
            return objDatosCategoria.consultarCategoriaId(id);
        }

        
        public bool insertarCategoria(clsCategoria objCategoria)
        {
            return objDatosCategoria.insertarCategoria(objCategoria.nombre_categoria,objCategoria.descripcion_categoria);
        }

        public bool actualizarCategoria(clsCategoria objCategoria)
        {
            return objDatosCategoria.modificarCategoria(objCategoria.id_categoria,objCategoria.nombre_categoria, objCategoria.descripcion_categoria);
        }

        public bool eliminarCategoria(int id)
        {
            return objDatosCategoria.eliminarCategoria(id);
        }
    }
}
