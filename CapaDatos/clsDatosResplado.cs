using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsDatosResplado
    {
        Conexion conect;
        public void generarResplado(string ruta)
        {
            conect = new Conexion();

            conect.abrirConexion();
            SqlCommand cmd = new SqlCommand("sp_generar_resplado", conect.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@ruta_respaldo", SqlDbType.VarChar)).Value = ruta;
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
    }
}
