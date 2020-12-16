using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class clsDatosProducto
    {
        Conexion conect;
        DataSet dsProducto;
        DataSet dsImagen;

        public DataSet consutarProducto(String nombre)
        {
            conect = new Conexion();
            dsProducto = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_producto", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProducto);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsProducto;
        }

        public DataSet consutarProductoId(int id)
        {
            conect = new Conexion();
            dsProducto = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_producto_id", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProducto);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsProducto;
        }

        public DataSet consutarTodoProducto()
        {
            conect = new Conexion();
            dsProducto = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_todo_producto", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProducto);
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsProducto;
        }

        public bool insertarProducto(String nombre, double precio, int id_categoria, int id_marca, 
            bool estado,int cantidad,string descripcion)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_producto", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@precio", SqlDbType.Money)).Value = precio;
                cmd.Parameters.Add(new SqlParameter("@id_categoria", SqlDbType.Int)).Value = id_categoria;
                cmd.Parameters.Add(new SqlParameter("@id_marca", SqlDbType.Int)).Value = id_marca;
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit)).Value = estado;
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int)).Value = cantidad;
                cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar)).Value = descripcion;

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

        public bool modificarProducto(int id,String nombre, double precio, int id_categoria, int id_marca, 
            bool estado,int cantidad,string descripcion)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_producto", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@precio", SqlDbType.Money)).Value = precio;
                cmd.Parameters.Add(new SqlParameter("@id_categoria", SqlDbType.Int)).Value = id_categoria;
                cmd.Parameters.Add(new SqlParameter("@id_marca", SqlDbType.Int)).Value = id_marca;
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit)).Value = estado;
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int)).Value = cantidad;
                cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar)).Value = descripcion;

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

        public bool eliminarProducto(int id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_producto", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
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

        public bool insertarImagen(int idProducto,byte[] imagen)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_imagen", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_producto", SqlDbType.Int)).Value = idProducto;
                cmd.Parameters.Add(new SqlParameter("@imagen", SqlDbType.Image)).Value = imagen;
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

        public bool eliminarImagen(int idImagen)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_imagen", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = idImagen;
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

        public DataSet consultarImagen(int idProducto)
        {
            dsImagen = new DataSet();
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_imagen", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = idProducto;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsImagen);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsImagen;
        }

        public void modificarCantidadProducto(int idProducto, int cantidadRestante)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_cantidad_producto", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_producto", SqlDbType.Int)).Value = idProducto;
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int)).Value = cantidadRestante;
                
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

        public DataSet consutarProductoActivo(string nombre, int categoria, int marca)
        {
            conect = new Conexion();
            dsProducto = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_producto_activo", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@categoria", SqlDbType.Int)).Value = categoria;
                cmd.Parameters.Add(new SqlParameter("@marca", SqlDbType.Int)).Value = marca;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProducto);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsProducto;
        }

        public int consultarUltimoProducto()
        {
            int ultimoId = 0;
            conect = new Conexion();
            dsProducto = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_ultimo_id_producto", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProducto);

                ultimoId = int.Parse(dsProducto.Tables[0].Rows[0][0].ToString());

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