using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDatosCategoria
    {
        Conexion conect = new Conexion();
        DataSet dsCategoria;
        
        public DataSet consutarCategoria(String nombre)
        {
            dsCategoria = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_categoria", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCategoria);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsCategoria;
        }

        public DataSet consultarCategoriaId(int id)
        {
            dsCategoria = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_categoria_id", conect.conn);
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
               
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCategoria);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsCategoria;
        }

      
        public bool insertarCategoria(String nombre, String descripcion)
        {
            dsCategoria = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_categoria", conect.conn);
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

        public bool modificarCategoria(int id,String nombre, String descripcion)
        {
            dsCategoria = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_categoria", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar)).Value = descripcion;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCategoria);
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

        public bool eliminarCategoria(int id)
        {
            dsCategoria = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_categoria", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCategoria);
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
