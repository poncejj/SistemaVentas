using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace CapaDatos
{
    public class clsDatosPaquete
    {
        Conexion conect;
        DataSet dsPaquete;

        public DataSet consutarPaquete(int id_cliente,String fecha)
        {
            conect = new Conexion();
            dsPaquete = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_paquete", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.Parameters.Add(new SqlParameter("@fecha_paquete", SqlDbType.Date)).Value = fecha;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPaquete);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsPaquete;
        }

        public DataSet consutarPaqueteId(int id_paquete)
        {
            conect = new Conexion();
            dsPaquete = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_paquete_id", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_paquete", SqlDbType.Int)).Value = id_paquete;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPaquete);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsPaquete;
        }

        public DataSet consutarPaquetePorCliente(int id_cliente)
        {
            conect = new Conexion();
            dsPaquete = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_paquete_cliente", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPaquete);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsPaquete;
        }

        public DataSet consutarPaquetePorFecha(String fecha)
        {
            conect = new Conexion();
            dsPaquete = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_paquete_fecha", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date)).Value = fecha;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPaquete);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsPaquete;
        }

        
        public DataSet consutarTodoPaquete()
        {
            conect = new Conexion();
            dsPaquete = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_todo_paquete", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPaquete);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsPaquete;
        }

        public bool insertarPaquete(String fecha, int id_cliente, decimal subtotal, decimal total, bool estado)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_paquete", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@fecha_paquete", SqlDbType.Date)).Value = fecha;
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

        public bool modificarPaquete(int id, String fecha, int id_cliente, decimal subtotal, decimal total, bool estado)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_paquete", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@fecha_paquete", SqlDbType.Date)).Value = fecha;
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

        public bool eliminarPaquete(int id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_paquete", conect.conn);
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

        public int ultimoID()
        {
            dsPaquete = new DataSet();
            conect = new Conexion();
            conect.abrirConexion();
            int idRetorno = 0;
            SqlCommand cmd = new SqlCommand("sp_consultar_ultimo_id", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPaquete);

                if (dsPaquete.Tables[0].Rows.Count > 0)
                {
                    idRetorno = dsPaquete.Tables[0].Rows[0][0].ToString().ToInt();
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

        public DataSet consultarPaquetes(int idCliente, string fechaDesde, string fechaHasta, int idReferencia)
        {
            SqlCommand cmd;
            conect = new Conexion();
            dsPaquete = new DataSet();
            DataTable dtPaquete = new DataTable();
            conect.abrirConexion();
            cmd = new SqlCommand("sp_consultar_paquetes_entregados", conect.conn);

            cmd.CommandType = CommandType.StoredProcedure;
            try
            {

                cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.VarChar)).Value = fechaDesde;
                cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.VarChar)).Value = fechaHasta;
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = idCliente;
                cmd.Parameters.Add(new SqlParameter("@id_referencia", SqlDbType.Int)).Value = idReferencia;

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPaquete);
                return dsPaquete;
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


        public void cambiarEstadoPaquete(int idPaquete)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_estado_paquete", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_paquete", SqlDbType.Int)).Value = idPaquete;
                cmd.ExecuteNonQuery();

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