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
    public class clsNegocioDetalleVenta
    {
        clsDatosDetalleVenta objDatosDetalleVenta = new clsDatosDetalleVenta();

        public DataSet consultarDetalleVenta(int id)
        {
            return objDatosDetalleVenta.consutarDetalleVenta(id);
        }

        public bool insertarDetalleVenta(clsDetalleVenta objDetalleVenta)
        {
            return objDatosDetalleVenta.insertarDetalleVenta(objDetalleVenta.id_venta, objDetalleVenta.id_producto,
                objDetalleVenta.cantidad, objDetalleVenta.total_detalle, objDetalleVenta.estado_detalle,objDetalleVenta.id_paquete,
                objDetalleVenta.id_detalle_paquete,objDetalleVenta.id_color,objDetalleVenta.id_tamano,objDetalleVenta.precio_producto,
                objDetalleVenta.observacion_detalle_venta);
        }

        public bool actualizarDetalleVenta(clsDetalleVenta objDetalleVenta)
        {
            return objDatosDetalleVenta.modificarDetalleVenta(objDetalleVenta.id_venta, objDetalleVenta.id_venta, objDetalleVenta.id_producto,
                objDetalleVenta.cantidad, objDetalleVenta.total_detalle, objDetalleVenta.estado_detalle);
        }

        public bool eliminarDetalleVenta(int idDetalleVenta,int idVenta)
        {
            return objDatosDetalleVenta.eliminarDetalleVenta(idDetalleVenta,idVenta);
        }

        public int ConsultarUltimoDetalleVenta()
        {
            return objDatosDetalleVenta.consultarUltimoDetlleVenta();
        }

        public DataTable consultarDetalleVentaLogico(int idVenta)
        {
            return objDatosDetalleVenta.consultarDetalleVentaLogico(idVenta);
        }

        public bool modificarPrecio(int idDetalleVenta, decimal nuevoPrecio)
        {
            return objDatosDetalleVenta.modificarPrecio(idDetalleVenta, nuevoPrecio);
        }

        public bool modificarCantidad(int idDetalleVenta, int nuevaCantidad, decimal precioProducto)
        {
            return objDatosDetalleVenta.modificarCantidad(idDetalleVenta,nuevaCantidad,precioProducto);
        }
    }
}