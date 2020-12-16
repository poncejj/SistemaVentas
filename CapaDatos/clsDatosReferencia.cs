using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDatosReferencia
    {
        Conexion conect;
        DataSet dsReferencia;

        public DataSet consutarReferencia(String nombre)
        {
            conect = new Conexion();
            dsReferencia = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_referencia", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReferencia);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsReferencia;
        }

        public DataSet consutarReferenciaId(int id)
        {
            conect = new Conexion();
            dsReferencia = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_referencia_id", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReferencia);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsReferencia;
        }

        public DataSet consutarTodoReferencia()
        {
            conect = new Conexion();
            dsReferencia = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_todo_referencia", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReferencia);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsReferencia;
        }

        public bool insertarReferencia(String nombre)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_referencia", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
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

        public bool modificarReferencia(int id, String nombre)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_referencia", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
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

        public bool eliminarReferencia(int id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_referencia", conect.conn);
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
    }
}