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
using CapaNegocio;

namespace SistemaVentas
{
    public partial class frmRespaldo : Form
    {
        string rutaRespaldo = "c:\\Respaldo";

        public frmRespaldo()
        {
            InitializeComponent();
        }

        private static frmRespaldo m_FormDefInstance;
        public static frmRespaldo DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmRespaldo();
                return m_FormDefInstance;

            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void btnBuscarRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();
            string fecha = DateTime.Today.ToShortDateString();
            fecha = fecha.Replace("/","_");
            openFileDialog1.SelectedPath = rutaRespaldo;
            string filename = @"\respaldo_" + fecha+".bak";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtRuta.Text = openFileDialog1.SelectedPath+filename;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnGenerarRespaldo_Click(object sender, EventArgs e)
        {
            clsNegocioRespaldo objRespaldo = new clsNegocioRespaldo();
            if (!Directory.Exists(rutaRespaldo))
            {
                Directory.CreateDirectory(rutaRespaldo);
            }
            try
            {
                objRespaldo.generarResplado(txtRuta.Text);
                MessageBox.Show("Se generó correctamente el respaldo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void frmRespaldo_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Today.ToShortDateString();
            fecha = fecha.Replace("/","_");
            txtRuta.Text = @"c:\Respaldo\respaldo_"+ fecha+".bak";
        }

        private void textbox_KeyPress_alfanum(object sender, KeyPressEventArgs e)
        {

            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || e.KeyChar == '-')
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
