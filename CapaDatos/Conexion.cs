using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public SqlConnection conn = new SqlConnection();
        string strServidor = "";
        string strNombreBase = "";
        string strUsuario = "";
        string strPassword = "";
        string strRuta = @"C:\ProgramData\SV\settings.config";

        public void abrirConexion()
        {
            try
            {
                leerFichero();
                String cadena = "Data Source="+strServidor+";Initial Catalog="+strNombreBase+";User ID="+strUsuario+";Password="+strPassword;
                SqlConnection conn1 = new SqlConnection(cadena);

                conn1.Open();
                conn = conn1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void cerrarConexion()
        {
            conn.Close();
        }

        public void commit()
        {
            try
            {
                String sql1 = "COMMIT";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void rollback()
        {
            String sql1 = "ROLLBACK";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }
        private void leerFichero()
        {
            if (File.Exists(strRuta))
            {
                string[] lineas = File.ReadAllLines(strRuta);
                strServidor = DesEncriptar(lineas[0]);
                strNombreBase = DesEncriptar(lineas[1]);
                strUsuario = DesEncriptar(lineas[2]);
                strPassword = DesEncriptar(lineas[3]);

            }
        }
        public string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}