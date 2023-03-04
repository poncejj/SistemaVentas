using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDatos;
using CapaDatos;
using System.Data;
using Utilitarios;

namespace CapaNegocio
{
    public class clsNegocioProducto
    {
        clsDatosProducto objDatosProducto = new clsDatosProducto();

        public DataSet consultarProducto(string busqueda)
        {
            return objDatosProducto.consutarProducto(busqueda);
        }

        public DataSet consultarProductoId(int id)
        {
            return objDatosProducto.consutarProductoId(id);
        }

        public DataSet consultarTodosProductos()
        {
            return objDatosProducto.consutarTodoProducto();
        }

        public bool insertarProducto(clsProducto objProducto)
        {
            return objDatosProducto.insertarProducto(objProducto.nombre_producto, objProducto.precio_producto,objProducto.id_categoria,
                objProducto.id_marca, objProducto.estado_producto, objProducto.cantidad,objProducto.descripcion);
        }

        public bool actualizarProducto(clsProducto objProducto)
        {
            return objDatosProducto.modificarProducto(objProducto.id_producto, objProducto.nombre_producto, objProducto.precio_producto, 
                objProducto.id_categoria,objProducto.id_marca, objProducto.estado_producto,objProducto.cantidad,objProducto.descripcion);
        }

        public bool eliminarProducto(int id)
        {
            return objDatosProducto.eliminarProducto(id);
        }

        public DataSet comboBoxProducto()
        {
            return objDatosProducto.consutarTodoProducto();
        }

        public bool insertarImagen(int idProducto, byte[] imagen)
        {
            return objDatosProducto.insertarImagen(idProducto, imagen);
        }

        public bool eliminarImagen(int idImagen)
        {
            return objDatosProducto.eliminarImagen(idImagen);
        }

        public DataSet consultarImagen(int idProducto)
        {
            return objDatosProducto.consultarImagen(idProducto);
        }

        public void aumentarCantidad(int idProducto, int cantidad)
        {
            DataSet dsProducto = objDatosProducto.consutarProductoId(idProducto);

            try
            {
                int cantidadActual = dsProducto.Tables[0].Rows[0][7].ToString().ToInt();
                int cantidadRestante = cantidad + cantidadActual;

                objDatosProducto.modificarCantidadProducto(idProducto,cantidadRestante);

            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool disminuirCantidad(int idProducto, int cantidad)
        {
            DataSet dsProducto = objDatosProducto.consutarProductoId(idProducto);

            try
            {
                int cantidadActual = dsProducto.Tables[0].Rows[0][7].ToString().ToInt();
                int cantidadRestante = cantidadActual - cantidad;
                if (cantidadRestante >= 0)
                {
                    objDatosProducto.modificarCantidadProducto(idProducto, cantidadRestante);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet consultarProductoActivo(string busqueda, int categoria, int marca)
        {
            return objDatosProducto.consutarProductoActivo(busqueda, categoria, marca);
        }

        public int consultarUltimoProducto()
        {
            return objDatosProducto.consultarUltimoProducto();
        }
    }
}