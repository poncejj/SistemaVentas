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

        public DataSet consutlarPago(int idCliente)
        {
            return objDatosPago.consutarPago(idCliente);
        }

        public bool insertarPago(decimal valor, int id_cliente, string fechaPago, string tipoPago)
        {
            clsNegocioSaldo objNegocioSaldo = new clsNegocioSaldo();
            if(objNegocioSaldo.consultarSaldo(id_cliente) < valor)
            {
                return false;
            }
            else
            {
                return objDatosPago.insertarPago(id_cliente, valor, fechaPago, tipoPago);
            }
        }

        public bool modificarPago(int idCliente, decimal valor)
        {
            return objDatosPago.modificarPago(idCliente, valor);
        }

        public bool eliminarPago(int idPago, int idCliente)
        {
            return objDatosPago.eliminarPago(idPago, idCliente);
        }

    }
}
