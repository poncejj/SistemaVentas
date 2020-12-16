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
    public class clsNegocioPago
    {
        clsDatosPago objDatosPago = new clsDatosPago();
        clsPago objPago = new clsPago();

        public DataSet consutlarPago(int idVenta)
        {
            return objDatosPago.consutarPago(idVenta);
        }

        public bool insertarPago(int idVenta,double valor,int id_cliente,string fechaPago, string tipoPago)
        {
            clsNegocioSaldo objNegocioSaldo = new clsNegocioSaldo();
            clsSaldo objSaldo = new clsSaldo(); 
 
            clsDatosVenta objDatosVenta = new clsDatosVenta();
            DataSet dsVenta = objDatosVenta.consutarVentaId(idVenta);
            DataSet dsPago = objDatosPago.consutarPago(idVenta);

            double totalVenta = double.Parse(dsVenta.Tables[0].Rows[0][3].ToString());
            double totalPagado = 0;
            foreach (DataRow dr in dsPago.Tables[0].Rows)
            {
                totalPagado += double.Parse(dr[1].ToString());
            }

            if (totalPagado + valor <= totalVenta)
            {
                objSaldo.id_cliente = id_cliente;
                objSaldo.saldo = valor;
                objNegocioSaldo.cambiarSaldo(objSaldo, 2);

                return objDatosPago.insertarPago(idVenta, valor,fechaPago,tipoPago);
            }
            else
            {
                return false;
            }
        }

        public bool modificarPago(int idVenta,double valor)
        {
            return objDatosPago.modificarPago(idVenta,valor);
        }

        public bool eliminarPago(int idPago)
        {
            return objDatosPago.eliminarMarca(idPago);
        }
    }
}
