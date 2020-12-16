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

        public DataSet consultarDetallePaqueteLogico(int id)
        {
            return objDatosDetallePaquete.consutarDetallePaqueteLogico(id);
        }

        
        public bool insertarDetallePaquete(clsDetallePaquete objDetallePaquete)
        {
            return objDatosDetallePaquete.insertarDetallePaquete(objDetallePaquete.id_paquete,objDetallePaquete.id_producto,
                objDetallePaquete.cantidad, objDetallePaquete.total_detalle, objDetallePaquete.estado_detalle, objDetallePaquete.id_color, objDetallePaquete.id_tamano,
                objDetallePaquete.observacion_detalle_paquete);
        }

        public bool actualizarDetallePaquete(clsDetallePaquete objDetallePaquete)
        {
            return objDatosDetallePaquete.modificarDetallePaquete(objDetallePaquete.id_paquete,objDetallePaquete.id_detalle_paquete, objDetallePaquete.id_producto,
                objDetallePaquete.cantidad, objDetallePaquete.total_detalle, objDetallePaquete.estado_detalle, objDetallePaquete.id_color,objDetallePaquete.id_tamano,
                objDetallePaquete.observacion_detalle_paquete);
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