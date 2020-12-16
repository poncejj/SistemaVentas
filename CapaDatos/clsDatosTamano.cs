using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDatosTamano
    {
        Conexion conect;
        DataSet dsTamano;

        public DataSet consutarTamanoId(int id)
        {
            conect = new Conexion();
            dsTamano = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_tamano_id", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTamano);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsTamano;
        }

        public DataSet consutarTamano(String nombre)
        {
            conect = new Conexion();
            dsTamano = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_tamano", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTamano);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsTamano;
        }

        public DataSet consutarTodoTamano()
        {
            conect = new Conexion();
            dsTamano = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_todo_tamano", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTamano);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsTamano;
        }

        public DataSet consultarTamanoProducto(int id)
        {
            conect = new Conexion();
            dsTamano = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_tamano_producto", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_producto", SqlDbType.Int)).Value = id;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTamano);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsTamano;
        }

        public bool insertarTamano(String nombre, String letra)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_tamano", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@letra", SqlDbType.VarChar)).Value = letra;
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

        public bool modificarTamano(int id, String nombre, String letra)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_tamano", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@letra", SqlDbType.VarChar)).Value = letra;
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

        public bool eliminarTamano(int id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_tamano", conect.conn);
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

        public bool eliminarTamanoProducto(int id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_tamano_producto", conect.conn);
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

        public bool insertarTamanoProducto(int id,int idtamano)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_tamano_producto", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@id_tamano", SqlDbType.Int)).Value = idtamano;

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