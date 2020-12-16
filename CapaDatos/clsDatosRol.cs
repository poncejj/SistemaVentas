using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDatosRol
    {
        Conexion conect;
        DataSet dsRol;

        public DataSet consutarRol(int id)
        {
            conect = new Conexion();
            dsRol = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_rol", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsRol);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsRol;
        }

        public DataSet consutarTodoRol()
        {
            conect = new Conexion();
            dsRol = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_todo_rol", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsRol);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsRol;
        }

        public bool insertarRol(String nombre, String descripcion)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_rol", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar)).Value = descripcion;
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

        public bool modificarRol(int id, String nombre, String descripcion)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_rol", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar)).Value = descripcion;
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

        public bool eliminarRol(int id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_rol", conect.conn);
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