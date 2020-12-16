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

        public double consutarSaldoId(int id_cliente)
        {
            conect = new Conexion();
            dsSaldo = new DataSet();
            double valorRetorno = 0;
            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_consultar_saldo", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id_cliente", SqlDbType.Int)).Value = id_cliente;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsSaldo);

                if(dsSaldo.Tables[0].Rows.Count>0)
                {
                    valorRetorno = double.Parse(dsSaldo.Tables[0].Rows[0][2].ToString()); 
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
            return valorRetorno;
        }

        public bool modificarSaldo(int id_cliente, double saldo)
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

        public bool insertarSaldo(int id_cliente, double saldo)
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
    }
}
