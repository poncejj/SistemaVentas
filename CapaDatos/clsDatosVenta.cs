using System;
using System.Data;
using System.Data.SqlClient;
using Utilitarios;

namespace CapaDatos
{
    public class clsDatosVenta
    {
        Conexion conect;
        DataSet dsVenta;

        public DataSet consutarVenta(int id_cliente, String fecha)
        {
            conect = new Conexion();
            dsVenta = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.Parameters.Add(new SqlParameter("@fecha_venta", SqlDbType.Date)).Value = fecha;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsVenta);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsVenta;
        }

        public DataSet consutarVentaId(int id_venta)
        {
            conect = new Conexion();
            dsVenta = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_venta_id", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_venta", SqlDbType.Int)).Value = id_venta;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsVenta);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsVenta;
        }

        public DataSet consutarVentaPorCliente(int id_cliente)
        {
            conect = new Conexion();
            dsVenta = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_venta_cliente", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsVenta);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsVenta;
        }

        public bool modificarTotalVenta(int id_venta, int id_cliente, decimal total)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_total_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_venta", SqlDbType.Int)).Value = id_venta;
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Money)).Value = total;
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

        public DataSet consutarVentaPorFecha(String fecha)
        {
            conect = new Conexion();
            dsVenta = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_venta_fecha", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date)).Value = fecha;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsVenta);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsVenta;
        }

        public DataSet consutarTodoVenta()
        {
            conect = new Conexion();
            dsVenta = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_todo_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsVenta);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsVenta;
        }

        public bool insertarVenta(String fecha, int id_cliente, decimal subtotal, decimal total, int estado)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@fecha_venta", SqlDbType.Date)).Value = fecha;
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.Parameters.Add(new SqlParameter("@subtotal", SqlDbType.Money)).Value = subtotal;
                cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Money)).Value = total;
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Int)).Value = estado;
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

        public bool modificarVenta(int id, String fecha, int id_cliente, decimal subtotal, decimal total, bool estado)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@fecha_venta", SqlDbType.Date)).Value = fecha;
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.Parameters.Add(new SqlParameter("@subtotal", SqlDbType.Money)).Value = subtotal;
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

        public bool eliminarVenta(int id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_venta", conect.conn);
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

        public DataSet consultarVentasTotales(string fechaDesde, string fechaHasta)
        {
            conect = new Conexion();
            dsVenta = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_venta_total", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date)).Value = fechaDesde;
                cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date)).Value = fechaHasta;
                
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsVenta);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsVenta;
        }

        public int consultarUltimoID()
        {
            dsVenta = new DataSet();
            conect = new Conexion();
            conect.abrirConexion();
            int idRetorno = 0;
            SqlCommand cmd = new SqlCommand("sp_consultar_ultimo_id_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsVenta);

                if (dsVenta.Tables[0].Rows.Count > 0)
                {
                    idRetorno = dsVenta.Tables[0].Rows[0][0].ToString().ToInt();
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
            return idRetorno;
        }

        public bool cambiarEstadoVenta(int idVenta,int estado)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_anular_venta", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_venta", SqlDbType.Int)).Value = idVenta;
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Int)).Value = estado;

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

        public DataSet consultarVentasPendientes(int idCliente, string fechaDesde, string fechaHasta, int idReferencia)
        {
            conect = new Conexion();
            dsVenta = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_venta_pendiente", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {

                cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date)).Value = fechaDesde;
                cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date)).Value = fechaHasta;
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = idCliente;
                cmd.Parameters.Add(new SqlParameter("@id_referencia", SqlDbType.Int)).Value = idReferencia;

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsVenta);
                return dsVenta;
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