using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDatosUsuario
    {
        Conexion conect;
        DataSet dsUsuario;

        public DataSet consutarUsuario(int idUsuario)
        {
            conect = new Conexion();
            dsUsuario = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_usuario", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_usuario", SqlDbType.Int)).Value = idUsuario;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsUsuario);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsUsuario;
        }

        public DataSet consutarTodoUsuario()
        {
            conect = new Conexion();
            dsUsuario = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_todo_usuario", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsUsuario);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conect.cerrarConexion();
            }
            return dsUsuario;
        }

        public bool insertarUsuario(String login, String contrasena, String identificacion, String nombre,
            String apellido, String telefono, int id_rol)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_usuario", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@login", SqlDbType.VarChar)).Value = login;
                cmd.Parameters.Add(new SqlParameter("@contrasena", SqlDbType.VarChar)).Value = contrasena;
                cmd.Parameters.Add(new SqlParameter("@identificacion", SqlDbType.VarChar)).Value = identificacion;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar)).Value = apellido;
                cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar)).Value = telefono;
                cmd.Parameters.Add(new SqlParameter("@id_rol", SqlDbType.Int)).Value = id_rol;
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

        public bool modificarUsuario(int id, String login, String contrasena, String identificacion, String nombre,
            String apellido, String telefono, int id_rol)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_actualizar_usuario", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("@login", SqlDbType.VarChar)).Value = login;
                cmd.Parameters.Add(new SqlParameter("@contrasena", SqlDbType.VarChar)).Value = contrasena;
                cmd.Parameters.Add(new SqlParameter("@identificacion", SqlDbType.VarChar)).Value = identificacion;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar)).Value = apellido;
                cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar)).Value = telefono;
                cmd.Parameters.Add(new SqlParameter("@id_rol", SqlDbType.Int)).Value = id_rol;
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

        public bool eliminarUsuario(int id)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_eliminar_usuario", conect.conn);
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

        public int login(string usuario, string password)
        {
            dsUsuario = new DataSet();
            int rol = 0;
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_login_usuario", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = usuario;
                cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar)).Value = password;

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsUsuario);

                if (dsUsuario.Tables[0] != null)
                {
                    rol = int.Parse(dsUsuario.Tables[0].Rows[0][0].ToString());
                }
                else
                {
                    rol = 0;
                }
                return rol;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                conect.cerrarConexion();
            }
        }
    }
}