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
    public class clsNegocioColor
    {
        clsDatosColor objDatosColor = new clsDatosColor();

        public DataSet consultarColorId(int id)
        {
            return objDatosColor.consutarColorId(id);
        }

        public DataSet consultarColorProducto(int id)
        {
            return objDatosColor.consutarColorProducto(id);
        }
        
        public DataSet consultarColor(String nombre)
        {
            return objDatosColor.consutarColor(nombre);
        }

        public DataSet consultarTodosColores()
        {
            return objDatosColor.consutarTodoColor();
        }

        public bool insertarColor(clsColor objColor)
        {
            return objDatosColor.insertarColor(objColor.nombre_color);
        }

        public bool actualizarColor(clsColor objColor)
        {
            return objDatosColor.modificarColor(objColor.id_color, objColor.nombre_color);
        }

        public bool eliminarColor(int id)
        {
            return objDatosColor.eliminarColor(id);
        }

        public DataSet comboBoxColor()
        {
            return objDatosColor.consutarTodoColor();
        }

        public bool eliminarColorProducto(int idProducto)
        {
            return objDatosColor.eliminarColorProducto(idProducto);
        }

        public bool insertarColorProducto(int idProducto,int idColor)
        {
            return objDatosColor.insertarColorProducto(idProducto,idColor);
        }
    }
}