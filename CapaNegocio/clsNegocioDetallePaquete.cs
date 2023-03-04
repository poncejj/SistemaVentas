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
    public class clsNegocioDetallePaquete
    {
        clsDatosDetallePaquete objDatosDetallePaquete = new clsDatosDetallePaquete();

        public DataSet consultarDetallePaquete(int id)
        {
            return objDatosDetallePaquete.consutarDetallePaquete(id);
        }

        public DataSet consultarDetallePaqueteLogico(int idPaquete)
        {
            return objDatosDetallePaquete.consutarDetallePaqueteLogico(idPaquete);
        }

        
        public bool insertarDetallePaquete(clsDetallePaquete objDetallePaquete)
        {
            return objDatosDetallePaquete.insertarDetallePaquete(objDetallePaquete);
        }

        public bool actualizarDetallePaquete(clsDetallePaquete objDetallePaquete)
        {
            return objDatosDetallePaquete.modificarDetallePaquete(objDetallePaquete);
        }

        public bool eliminarDetallePaquete(int idPaquete)
        {
            return objDatosDetallePaquete.eliminarDetallePaquete(idPaquete);
        }

        public bool eliminarDetallePaqueteID(int idDetallePaquete)
        {
            return objDatosDetallePaquete.eliminarDetallePaqueteId(idDetallePaquete);
        }

       
        public string consultarObservacionDetallePaquete(int idDetalle)
        {
            return objDatosDetallePaquete.consultarObservacionDetallePaquete(idDetalle);
        }
    }
}