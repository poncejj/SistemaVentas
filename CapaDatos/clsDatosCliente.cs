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
    public class clsDatosCliente
    {
        Conexion conect;
        DataSet dsCliente;

        public DataSet consutarCliente(int id_nombre)
        {
            conect = new Conexion();
            dsCliente = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_cliente", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_nombre", SqlDbType.Int)).Value = id_nombre;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCliente);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsCliente;
        }

        public DataSet consutarTodoCliente()
        {
            conect = new Conexion();
            dsCliente = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_todo_cliente", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCliente);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsCliente;
        }

        public bool insertarCliente(String identificacion, String nombre, String apellido, String telefono1,
            String telefono2, String domicilio, String email,int id_referencia)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_cliente", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@identificacion", SqlDbType.VarChar)).Value = identificacion;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar)).Value = apellido;
                cmd.Parameters.Add(new SqlParameter("@telefono1", SqlDbType.VarChar)).Value = telefono1;
                cmd.Parameters.Add(new SqlParameter("@telefono2", SqlDbType.VarChar)).Value = telefono2;
                cmd.Parameters.Add(new SqlParameter("@domicilio", SqlDbType.VarChar)).Value = domicilio;
                cmd.Parameters.Add(new SqlParameter("@email_cliente", SqlDbType.VarChar)).Value = email;
                cmd.Parameters.Add(new SqlParameter("@id_referencia", SqlDbType.Int)).Value = id_referencia;                
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

        public bool modificarCliente(int id, String identificacion, String nombre, String apellido, String telefono1,
            String telefono2, String domicilio, String email, int id_referencia)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_cliente", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@identificacion", SqlDbType.VarChar)).Value = identificacion;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar)).Value = apellido;
                cmd.Parameters.Add(new SqlParameter("@telefono1", SqlDbType.VarChar)).Value = telefono1;
                cmd.Parameters.Add(new SqlParameter("@telefono2", SqlDbType.VarChar)).Value = telefono2;
                cmd.Parameters.Add(new SqlParameter("@domicilio", SqlDbType.VarChar)).Value = domicilio;
                cmd.Parameters.Add(new SqlParameter("@email_cliente", SqlDbType.VarChar)).Value = email;
                cmd.Parameters.Add(new SqlParameter("@id_referencia", SqlDbType.Int)).Value = id_referencia;                                
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

        public bool eliminarCliente(string id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_cliente", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar)).Value = id;
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

        public DataSet consultarClienteId(int id_cliente)
        {
            conect = new Conexion();
            dsCliente = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_cliente_cedula", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCliente);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsCliente;
        }

        public int consultarUltimoId()
        {
            int ultimoId = 0;
            conect = new Conexion();
            dsCliente = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_ultimo_id_cliente", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCliente);
                ultimoId = dsCliente.Tables[0].Rows[0][0].ToString().ToInt();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return ultimoId;
        }
    }
}