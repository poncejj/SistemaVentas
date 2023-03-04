using ModeloDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDatosDetallePaquete
    {
        Conexion conect;
        DataSet dsDetallePaquete;

        public DataSet consutarDetallePaquete(int id_paquete)
        {
            conect = new Conexion();
            dsDetallePaquete = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_detalle_paquete", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_paquete", SqlDbType.Int)).Value = id_paquete;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsDetallePaquete);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsDetallePaquete;
        }

        public DataSet consutarDetallePaqueteLogico(int idPaquete)
        {
            conect = new Conexion();
            dsDetallePaquete = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_detalle_paquete_logico", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_paquete", SqlDbType.Int)).Value = idPaquete;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsDetallePaquete);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsDetallePaquete;
        }

        public string consultarObservacionDetallePaquete(int id_detalle_paquete)
        {
            string strObservacionDetalle = string.Empty;
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_observacion_detalle_paquete", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_detalle", SqlDbType.Int)).Value = id_detalle_paquete;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsDetallePaquete);

                if(dsDetallePaquete!=null)
                {
                    strObservacionDetalle = dsDetallePaquete.Tables[0].Rows[0][0].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return strObservacionDetalle;
        }

        public bool insertarDetallePaquete(clsDetallePaquete objDetallePaquete)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_detalle_paquete", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_paquete", SqlDbType.Int)).Value = objDetallePaquete.id_paquete;
                cmd.Parameters.Add(new SqlParameter("@id_producto", SqlDbType.Int)).Value = objDetallePaquete.id_producto;
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int)).Value = objDetallePaquete.cantidad;
                cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Money)).Value = objDetallePaquete.total_detalle;
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit)).Value = objDetallePaquete.estado_detalle;
                cmd.Parameters.Add(new SqlParameter("@id_color", SqlDbType.Int)).Value = objDetallePaquete.id_color;
                cmd.Parameters.Add(new SqlParameter("@id_tamano", SqlDbType.Int)).Value = objDetallePaquete.id_tamano;                
                cmd.Parameters.Add(new SqlParameter("@observacion_detalle", SqlDbType.VarChar)).Value = objDetallePaquete.observacion_detalle_paquete;                
                cmd.Parameters.Add(new SqlParameter("@precio_producto", SqlDbType.Money)).Value = objDetallePaquete.precio_producto;                
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }

        }

        public bool modificarDetallePaquete(clsDetallePaquete objDetallePaquete)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_detalle_paquete", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_detalle", SqlDbType.Int)).Value = objDetallePaquete.id_detalle_paquete;
                cmd.Parameters.Add(new SqlParameter("@id_paquete", SqlDbType.Int)).Value = objDetallePaquete.id_paquete;
                cmd.Parameters.Add(new SqlParameter("@id_producto", SqlDbType.Int)).Value = objDetallePaquete.id_producto;
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int)).Value = objDetallePaquete.cantidad;
                cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Money)).Value = objDetallePaquete.total_detalle;
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit)).Value = objDetallePaquete.estado_detalle;
                cmd.Parameters.Add(new SqlParameter("@id_color", SqlDbType.Int)).Value = objDetallePaquete.id_color;
                cmd.Parameters.Add(new SqlParameter("@id_tamano", SqlDbType.Int)).Value = objDetallePaquete.id_tamano;
                cmd.Parameters.Add(new SqlParameter("@observacion_detalle", SqlDbType.VarChar)).Value = objDetallePaquete.observacion_detalle_paquete;
                cmd.Parameters.Add(new SqlParameter("@precio_producto", SqlDbType.Money)).Value = objDetallePaquete.precio_producto;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
        }

        public bool eliminarDetallePaquete(int id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_detalle_paquete", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
        }

        public bool eliminarDetallePaqueteId(int idDetalle)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_detalle_paquete_id", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = idDetalle;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
        }
    }
}