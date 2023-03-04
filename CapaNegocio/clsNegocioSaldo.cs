using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using ModeloDatos;
using Utilitarios;

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
            decimal saldoTotal = 0;
            int id_cliente = objSaldo.id_cliente;
            decimal saldoNuevo = objSaldo.saldo;

            decimal saldoActual = consultarSaldo(id_cliente);
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

        public decimal consultarSaldo(int id_cliente)
        {
            DataSet dsSaldo = objDatosSaldo.consutarSaldoId(id_cliente, 0);
            decimal valorRetorno = 0;
            if (dsSaldo.Tables[0].Rows.Count > 0)
            {
                valorRetorno = dsSaldo.Tables[0].Rows[0][1].ToString().ToDouble();
            }
            return valorRetorno;
        }

        public void modificarSaldoInicial(clsSaldo objSaldo)
        {
            objDatosSaldo.modificarSaldo(objSaldo.id_cliente,objSaldo.saldo);
        }

        public DataSet ConsultarSaldoPendienteTodo(int idReferencia)
        {
            clsNegocioReferencia objNegocioReferencia = new clsNegocioReferencia();
            DataSet dsResultado = new DataSet();
            DataTable dtTemp = null;
            try
            {
                if (idReferencia == 0)
                {
                    DataSet dsReferencia = objNegocioReferencia.comboBoxReferencia();
                    if (dsReferencia != null && dsReferencia.Tables.Count > 0 && dsReferencia.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow drReferencia in dsReferencia.Tables[0].Rows)
                        {
                            int idRef = drReferencia[0].ToString().ToInt();
                            string nombreRef = drReferencia[1].ToString();

                            dtTemp = objDatosSaldo.ConsultarSaldoPendienteTodo(idRef).Tables[0].Copy();
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
                    dsResultado = objDatosSaldo.ConsultarSaldoPendienteTodo(idReferencia);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dsResultado;
        }

        public DataSet ConsultarSaldoPendiente(int idCliente)
        {
            return objDatosSaldo.consutarSaldoId(idCliente, 1);
        }

        public DataSet ConsultarPagoRecibido(int idCliente, string strFechaDesde, string strFechaHasta, int idReferencia)
        {
            clsNegocioReferencia objNegocioReferencia = new clsNegocioReferencia();
            DataSet dsResultado = new DataSet();
            DataTable dtTemp = null;
            try
            {
                if (idReferencia == 0)
                {
                    DataSet dsReferencia = objNegocioReferencia.comboBoxReferencia();
                    if (dsReferencia != null && dsReferencia.Tables.Count > 0 && dsReferencia.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow drReferencia in dsReferencia.Tables[0].Rows)
                        {
                            int idRef = drReferencia[0].ToString().ToInt();
                            string nombreRef = drReferencia[1].ToString();

                            dtTemp = objDatosSaldo.ConsultarPagoRecibido(idRef,idCliente,strFechaDesde, strFechaHasta).Tables[0].Copy();
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
                    dsResultado = objDatosSaldo.ConsultarPagoRecibido(idReferencia, idCliente, strFechaDesde, strFechaHasta);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dsResultado;
        }
    }
}
