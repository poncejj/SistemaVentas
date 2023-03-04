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
    public class clsNegocioPaquete
    {
        clsDatosPaquete objDatosPaquete = new clsDatosPaquete();

        public DataSet consultarPaquete(int id_cliente, String fecha)
        {
            return objDatosPaquete.consutarPaquete(id_cliente,fecha);
        }
        public DataSet consultarTodosPaquetees()
        {
            return objDatosPaquete.consutarTodoPaquete();
        }

        public bool insertarPaquete(clsPaquete objPaquete)
        {
            return objDatosPaquete.insertarPaquete(objPaquete.fecha_paquete,objPaquete.id_cliente,objPaquete.subtotal_paquete,
                objPaquete.valor_total_paquete,objPaquete.estado_paquete);
        }

        public bool actualizarPaquete(clsPaquete objPaquete)
        {
            return objDatosPaquete.modificarPaquete(objPaquete.id_paquete, objPaquete.fecha_paquete, objPaquete.id_cliente, 
                objPaquete.subtotal_paquete, objPaquete.valor_total_paquete, objPaquete.estado_paquete);
        }

        public bool eliminarPaquete(int id)
        {
            return objDatosPaquete.eliminarPaquete(id);
        }

        public DataSet comboBoxPaquete()
        {
            return objDatosPaquete.consutarTodoPaquete();
        }

        public DataSet consultarPaqueteId(int id)
        {
            return objDatosPaquete.consutarPaqueteId(id);
        }

        public DataSet consultarPaquetePorCliente(int id)
        {
            return objDatosPaquete.consutarPaquetePorCliente(id);
        }

        public DataSet consultarPaquetePorFecha(String fecha)
        {
            return objDatosPaquete.consutarPaquetePorFecha(fecha);
        }

        public int ultimoID()
        {
            return objDatosPaquete.ultimoID();
        }


        public void cambiarEstadoPaquete(int idPaquete)
        {
            objDatosPaquete.cambiarEstadoPaquete(idPaquete);
        }

        public DataSet ConsultarPaqueteTodo(string strFechaDesde, string strFechaHasta, int idReferencia)
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

                        dtTemp = objDatosPaquete.consultarPaquetes(0, strFechaDesde, strFechaHasta, idRef).Tables[0].Copy();
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
                dsResultado = objDatosPaquete.consultarPaquetes(0, strFechaDesde, strFechaHasta, idReferencia);
            }
            return dsResultado;
        }

        public DataSet ConsultarPaquete(int idCliente, string strFechaDesde, string strFechaHasta, int idReferencia)
        {
            return objDatosPaquete.consultarPaquetes(idCliente,strFechaDesde, strFechaHasta, idReferencia);
        }
    }
}