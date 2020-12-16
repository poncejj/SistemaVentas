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
    public class clsNegocioVenta
    {
        clsDatosVenta objDatosVenta = new clsDatosVenta();

        public DataSet consultarVenta(int id_cliente, String fecha)
        {
            return objDatosVenta.consutarVenta(id_cliente, fecha);
        }

        public DataSet consultarVentaPorCliente(int id_cliente)
        {
            return objDatosVenta.consutarVentaPorCliente(id_cliente);
        }

        public DataSet consultarVentaPorFecha(String fecha)
        {
            return objDatosVenta.consutarVentaPorFecha(fecha);
        }

        public DataSet consultarVentaId(int id)
        {
            return objDatosVenta.consutarVentaId(id);
        }

        public DataSet consultarTodosVentaes()
        {
            return objDatosVenta.consutarTodoVenta();
        }

        public bool insertarVenta(clsVenta objVenta)
        {
            return objDatosVenta.insertarVenta(objVenta.fecha_venta, objVenta.id_cliente, objVenta.subtotal_venta,
                objVenta.valor_total_venta, objVenta.estado_venta);
        }

        public DataSet consultarVentasTotales(string fechaDesde, string fechaHasta)
        {
            return objDatosVenta.consultarVentasTotales(fechaDesde, fechaHasta);
        }

        public int consultarUltimoID()
        {
            return objDatosVenta.consultarUltimoID();
        }

        public bool cambiarEstadoVenta(int idVenta,int estado)
        {
            return objDatosVenta.cambiarEstadoVenta(idVenta,estado);
        }

        public bool eliminarVenta(int id)
        {
            return objDatosVenta.eliminarVenta(id);
        }

        public DataTable consultarVentasPendientes(string fechaDesde, string fechaHasta, int idReferenciaInterna)
        {
            return objDatosVenta.consultarVentasPendientes(fechaDesde, fechaHasta, idReferenciaInterna);
        }

        public bool cambiarTotal(int id, double total)
        {
            return objDatosVenta.modificarTotalVenta(id,total);
        }
    }
}