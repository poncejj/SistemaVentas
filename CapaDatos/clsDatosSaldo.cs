using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDatosSaldo
    {
        Conexion conect;
        DataSet dsSaldo;

        public DataSet consutarSaldoId(int id_cliente, int tipo)
        {
            conect = new Conexion();
            dsSaldo = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_saldo", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.Parameters.Add(new SqlParameter("@tipo", SqlDbType.Int)).Value = tipo;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsSaldo);

                return dsSaldo;
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

        public bool modificarSaldo(int id_cliente, decimal saldo)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_cambiar_saldo", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Decimal)).Value = saldo;
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

        public DataSet ConsultarSaldoPendienteTodo(int idReferencia)
        {
            conect = new Conexion();
            dsSaldo = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_saldo_todo", conect.conn);
            cmd.Parameters.Add(new SqlParameter("@id_referencia", SqlDbType.Int)).Value = idReferencia;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsSaldo);

                return dsSaldo;
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

        public bool insertarSaldo(int id_cliente, decimal saldo)
        {
            conect = new Conexion();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_insertar_saldo", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Decimal)).Value = saldo;
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

        public DataSet ConsultarPagoRecibido(int idReferencia, int idCliente, string strFechaDesde, string strFechaHasta)
        {
            conect = new Conexion();
            dsSaldo = new DataSet();
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_reporte_pago", conect.conn);
            cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = idCliente;
            cmd.Parameters.Add(new SqlParameter("@id_referencia", SqlDbType.Int)).Value = idReferencia;
            cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date)).Value = strFechaDesde;
            cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date)).Value = strFechaHasta;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsSaldo);

                return dsSaldo;
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
