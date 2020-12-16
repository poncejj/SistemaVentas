using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDatosDetalleVenta
    {
        Conexion conect;
        DataSet dsDetalleVenta;

        public DataSet consutarDetalleVenta(int id_venta)
        {
            conect = new Conexion();
            dsDetalleVenta = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_detalle_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_venta", SqlDbType.Int)).Value = id_venta;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsDetalleVenta);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsDetalleVenta;
        }

        public DataSet consutarTodoDetalleVenta(int idVenta)
        {
            conect = new Conexion();
            dsDetalleVenta = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_todo_detalle_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_venta", SqlDbType.Int)).Value = idVenta;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsDetalleVenta);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsDetalleVenta;
        }

        public DataTable consultarDetalleVentaLogico(int idVenta)
        {
            conect = new Conexion();
            dsDetalleVenta = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_detalle_venta_logico", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_venta", SqlDbType.Int)).Value = idVenta;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsDetalleVenta);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsDetalleVenta.Tables[0];
        }

        public bool modificarCantidad(int idDetalleVenta, int nuevaCantidad,double precioProducto)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_modificar_cantidad_detalle_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_detalle_venta", SqlDbType.Int)).Value = idDetalleVenta;
                cmd.Parameters.Add(new SqlParameter("@nueva_cantidad", SqlDbType.Int)).Value = nuevaCantidad;
                cmd.Parameters.Add(new SqlParameter("@precio_producto", SqlDbType.Decimal)).Value = precioProducto;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conect.cerrarConexion();
            }
        }

        public bool modificarPrecio(int idDetalleVenta, decimal nuevoPrecio)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_modificar_precio_detalle_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_detalle_venta", SqlDbType.Int)).Value = idDetalleVenta;
                cmd.Parameters.Add(new SqlParameter("@nuevo_precio", SqlDbType.Decimal)).Value = nuevoPrecio;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conect.cerrarConexion();
            }
        }

        public int consultarUltimoDetlleVenta()
        {
            int ultimoDetalleVenta = 0;
            conect = new Conexion();
            dsDetalleVenta = new DataSet();

            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_ultimo_detalle_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsDetalleVenta);
                ultimoDetalleVenta = int.Parse(dsDetalleVenta.Tables[0].Rows[0][0].ToString());
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return ultimoDetalleVenta;
        }

        public bool insertarDetalleVenta(int id_venta, int id_producto, int cantidad, double total,
            bool estado, int id_paquete, int id_detalle_paquete, int id_color, int id_tamano, double precio,
            string observacion)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_detalle_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_venta", SqlDbType.Int)).Value = id_venta;
                cmd.Parameters.Add(new SqlParameter("@id_producto", SqlDbType.Int)).Value = id_producto;
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int)).Value = cantidad;
                cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Money)).Value = total;
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit)).Value = estado;
                cmd.Parameters.Add(new SqlParameter("@id_detalle_paquete", SqlDbType.Int)).Value = id_detalle_paquete;
                cmd.Parameters.Add(new SqlParameter("@id_paquete", SqlDbType.Int)).Value = id_paquete;
                cmd.Parameters.Add(new SqlParameter("@id_color", SqlDbType.Int)).Value = id_color;
                cmd.Parameters.Add(new SqlParameter("@id_tamano", SqlDbType.Int)).Value = id_tamano;
                cmd.Parameters.Add(new SqlParameter("@precio", SqlDbType.Decimal)).Value = precio;
                cmd.Parameters.Add(new SqlParameter("@observacion", SqlDbType.VarChar)).Value = observacion;

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

        public bool modificarDetalleVenta(int id, int id_venta, int id_producto, int cantidad, double total,
            bool estado)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_detalle_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@id_venta", SqlDbType.Int)).Value = id_venta;
                cmd.Parameters.Add(new SqlParameter("@id_producto", SqlDbType.Int)).Value = id_producto;
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int)).Value = cantidad;
                cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Money)).Value = total;
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit)).Value = estado;
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

        public bool eliminarDetalleVenta(int idDetalle, int idVenta)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_detalle_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@idDetalle", SqlDbType.Int)).Value = idDetalle;
                cmd.Parameters.Add(new SqlParameter("@idVenta", SqlDbType.Int)).Value = idVenta;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conect.cerrarConexion();
            }
        }
    }
}