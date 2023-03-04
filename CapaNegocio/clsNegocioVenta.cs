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

        public bool cambiarTotal(int id_venta, int id_cliente, decimal total)
        {
            return objDatosVenta.modificarTotalVenta(id_venta, id_cliente,total);
        }

        public DataSet ConsultarVentaTodo(string strFechaDesde, string strFechaHasta, int idReferencia)
        {
            clsNegocioReferencia objNegocioReferencia = new clsNegocioReferencia();
            DataSet dsResultado = new DataSet();
            DataTable dtTemp = null;
            if (idReferencia == 0)
            {
                DataSet dsReferencia = objNegocioReferencia.comboBoxReferencia();
                if (dsReferencia != null && dsReferencia.Tables.Count > 0 && dsReferencia.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow drReferencia in dsReferencia.Tables[0].Rows)
                    {
                        int idRef = drReferencia[0].ToString().ToInt();
                        string nombreRef = drReferencia[1].ToString();

                        dtTemp = objDatosVenta.consultarVentasPendientes(0, strFechaDesde, strFechaHasta, idRef).Tables[0].Copy();
                        if (dtTemp != null && dtTemp.Rows.Count > 0)
                        {
                            dtTemp.TableName = nombreRef;
                            dsResultado.Tables.Add(dtTemp);
                        }

                    }
                }
            }
            else
            {
                dsResultado = objDatosVenta.consultarVentasPendientes(0, strFechaDesde, strFechaHasta, idReferencia);
            }
            return dsResultado;
        }

        public DataSet ConsultarVenta(int idCliente, string strFechaDesde, string strFechaHasta, int idReferencia)
        {
            return objDatosVenta.consultarVentasPendientes(idCliente, strFechaDesde, strFechaHasta, idReferencia);
        }
    }
}