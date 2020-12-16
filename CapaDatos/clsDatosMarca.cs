using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDatosMarca
    {
        Conexion conect;
        DataSet dsMarca;

        public DataSet consutarMarca(String nombre)
        {
            conect = new Conexion();
            dsMarca = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_marca", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMarca);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsMarca;
        }

        public DataSet consutarMarcaId(int id)
        {
            conect = new Conexion();
            dsMarca = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_marca_id", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMarca);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsMarca;
        }

        public DataSet consutarTodoMarca()
        {
            conect = new Conexion();
            dsMarca = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_todo_marca", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMarca);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsMarca;
        }

        public bool insertarMarca(String nombre, String pais_marca)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_marca", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@pais_marca", SqlDbType.VarChar)).Value = pais_marca;
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

        public bool modificarMarca(int id, String nombre, String pais_marca)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_marca", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@pais_marca", SqlDbType.VarChar)).Value = pais_marca;
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

        public bool eliminarMarca(int id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_marca", conect.conn);
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