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

        public DataTable consultarPaquetesPendientes(string fechaDesde, string fechaHasta, int idReferenciaInterna,int tipo)
        {
            return objDatosPaquete.consultarPaquetesPendientes(fechaDesde, fechaHasta, idReferenciaInterna,tipo);
        }

        public void cambiarEstadoPaquete(int idPaquete)
        {
            objDatosPaquete.cambiarEstadoPaquete(idPaquete);
        }
    }
}