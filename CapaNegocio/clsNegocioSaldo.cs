using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using ModeloDatos;

namespace CapaNegocio
{
    public class clsNegocioSaldo
    {
        clsDatosSaldo objDatosSaldo = new clsDatosSaldo();

        public bool insertarSaldoInicial(clsSaldo objSaldo)
        {
            return objDatosSaldo.insertarSaldo(objSaldo.id_cliente, objSaldo.saldo);
        }

        public bool cambiarSaldo(clsSaldo objSaldo, int operacion)
        {
            double saldoTotal = 0;
            int id_cliente = objSaldo.id_cliente;
            double saldoNuevo = objSaldo.saldo;

            double saldoActual = objDatosSaldo.consutarSaldoId(id_cliente);
            if (operacion == 1)
            {
                saldoTotal = saldoActual + saldoNuevo;
            }
            if (operacion == 2)
            {
                saldoTotal = saldoActual - saldoNuevo;                
            }
            if (operacion == 3)
            {
                saldoTotal = saldoNuevo;                
            }

            return objDatosSaldo.modificarSaldo(id_cliente, saldoTotal);
        }

        public double consultarSaldo(int id_cliente)
        {
            return objDatosSaldo.consutarSaldoId(id_cliente);
        }

        public void modificarSaldoInicial(clsSaldo objSaldo)
        {
            objDatosSaldo.modificarSaldo(objSaldo.id_cliente,objSaldo.saldo);
        }
    }
}
