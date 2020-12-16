using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class frmVariablesSistema : Form
    {
        string directorio = @"C:\ProgramData\SV\";
        string archivo = "settings.config";

        public frmVariablesSistema()
        {
            InitializeComponent();
        }

        private void gbCredenciales_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string servidor = txtServidor.Text;
            string nombreBase = txtNoombreBase.Text;
            string usuarioBase = txtUsuarioBase.Text;
            string passwordBase = txtPasswordBase.Text;

            servidor = Encriptar(servidor);
            nombreBase = Encriptar(nombreBase);
            usuarioBase = Encriptar(usuarioBase);
            passwordBase = Encriptar(passwordBase);

            if (guardarArchivo(servidor,nombreBase,usuarioBase,passwordBase))
            {
                MessageBox.Show("Servidor configurado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al configurar servidor");
                
            }
        }

        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public bool guardarArchivo(string server,string data,string user,string password)
        {
         
            try
            {
                
                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }

                using (StreamWriter escribir = new StreamWriter(directorio+archivo,false))
                {
                    escribir.WriteLine(server);
                    escribir.WriteLine(data);
                    escribir.WriteLine(user);
                    escribir.WriteLine(password);

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void leerFichero()
        {
            if (File.Exists(directorio + archivo))
            {
                string[] lineas = File.ReadAllLines(directorio + archivo);
                txtServidor.Text = DesEncriptar(lineas[0]);
                txtNoombreBase.Text = DesEncriptar(lineas[1]);
                txtUsuarioBase.Text = DesEncriptar(lineas[2]);
                txtPasswordBase.Text = DesEncriptar(lineas[3]);

            }
        }

        private void frmVariablesSistema_Load(object sender, EventArgs e)
        {
            leerFichero();
        }
        
        private void textbox_KeyPress_alfanum(object sender, KeyPressEventArgs e)
        {

            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
            }
        }
    }
}
