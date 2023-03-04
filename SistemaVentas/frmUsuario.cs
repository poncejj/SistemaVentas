using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using ModeloDatos;
using Utilitarios;

namespace SistemaVentas
{
    public partial class frmUsuario : Form
    {
        int index = 0;
        DataSet dsUsuario = new DataSet();
        clsNegocioUsuario objNegocioUsuario = new clsNegocioUsuario();
        clsUsuario objUsuario = new clsUsuario();
        clsNegocioRol objNegocioRol = new clsNegocioRol();
        int operacion = 0;
        bool flagBloqueado = true;

        public frmUsuario()
        {
            InitializeComponent();
            cargarRol();
            cargarUsuario();
            bloquearPantalla();
        }

        private static frmUsuario m_FormDefInstance;
        public static frmUsuario DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmUsuario();
                return m_FormDefInstance;

            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public void cargarRol()
        {
            cbRolUsuario.DataSource = objNegocioRol.consultarTodosRols().Tables[0];
            cbRolUsuario.ValueMember = "id_rol";
            cbRolUsuario.DisplayMember = "nombre_rol";

        }

        public void cargarUsuario()
        {
            try
            {
                cbBusquedaUsuario.DataSource = null;
                cbBusquedaUsuario.DataSource = objNegocioUsuario.consultarTodosUsuarios().Tables[0];
                cbBusquedaUsuario.ValueMember = "id_usuario";
                cbBusquedaUsuario.DisplayMember = "nombre_completo";
                cbBusquedaUsuario.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }

        }

        private void llenarUsuario()
        {
            try
            {
                int idUsuario = cbBusquedaUsuario.SelectedValue.ToString().ToInt();
                dsUsuario = objNegocioUsuario.consultarUsuario(idUsuario);

                txtIdentificacionUsuario.Text = dsUsuario.Tables[0].Rows[0][3].ToString();
                txtNombreUsuario.Text = dsUsuario.Tables[0].Rows[0][4].ToString();
                txtApellidoUsuario.Text = dsUsuario.Tables[0].Rows[0][5].ToString();
                txtTelefonoUsuario.Text = dsUsuario.Tables[0].Rows[0][6].ToString();
                cbRolUsuario.SelectedValue = dsUsuario.Tables[0].Rows[0][7].ToString();
                txtLoginUsuario.Text = dsUsuario.Tables[0].Rows[0][1].ToString();
                txtContrasena1Usuario.Text = dsUsuario.Tables[0].Rows[0][2].ToString();
                txtContrasena2Usuario.Text = dsUsuario.Tables[0].Rows[0][2].ToString();
            
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBusquedaUsuario.Items.Count > 0)
                {
                    if (objNegocioUsuario.eliminarUsuario(dsUsuario.Tables[0].Rows[index][0].ToString().ToInt()))
                    {
                        MessageBox.Show("Usuario eliminado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario");
                    }
                    llenarUsuario();
                }
                else
                {
                    MessageBox.Show("No existe usuario para eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                if (txtContrasena1Usuario.Text == txtContrasena2Usuario.Text)
                {
                    clsUsuario objUsuario = new clsUsuario();
                    objUsuario.identificacion_usuario = txtIdentificacionUsuario.Text;
                    objUsuario.nombre_usuario = txtNombreUsuario.Text;
                    objUsuario.apellido_usuario = txtApellidoUsuario.Text;
                    objUsuario.telefono_usuario = txtTelefonoUsuario.Text;
                    objUsuario.rol_usuario = cbRolUsuario.SelectedValue.ToString().ToInt();
                    objUsuario.login_usuario = txtLoginUsuario.Text;
                    objUsuario.contrasenia_usuario = txtContrasena1Usuario.Text;

                    if (objNegocioUsuario.insertarUsuario(objUsuario))
                    {
                        MessageBox.Show("Usuario ingresada con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar el Usuario");
                    }
                    cargarUsuario();
                    bloquearPantalla();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta ingrese nuevamente por favor.");
                    txtContrasena1Usuario.Text = "";
                    txtContrasena2Usuario.Text = "";

                }
            }
            if (operacion == 1)
            {
                if (txtContrasena1Usuario.Text == txtContrasena2Usuario.Text)
                {
                    clsUsuario objUsuario = new clsUsuario();
                    objUsuario.id_usuario = dsUsuario.Tables[0].Rows[index][0].ToString().ToInt();
                    objUsuario.identificacion_usuario = txtIdentificacionUsuario.Text;
                    objUsuario.nombre_usuario = txtNombreUsuario.Text;
                    objUsuario.apellido_usuario = txtApellidoUsuario.Text;
                    objUsuario.telefono_usuario = txtTelefonoUsuario.Text;
                    objUsuario.rol_usuario = cbRolUsuario.SelectedValue.ToString().ToInt();
                    objUsuario.login_usuario = txtLoginUsuario.Text;
                    objUsuario.contrasenia_usuario = txtContrasena1Usuario.Text;

                    if (objNegocioUsuario.actualizarUsuario(objUsuario))
                    {
                        MessageBox.Show("Usuario actualizado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el Usuario");
                    }
                    cargarUsuario();
                    bloquearPantalla();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta ingrese nuevamente por favor.");
                    txtContrasena1Usuario.Text = "";
                    txtContrasena2Usuario.Text = "";

                }
            }
          
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (cbBusquedaUsuario.Items.Count > 0)
            {
                operacion = 1;
                desbloquearPantalla();
            }
            else
            {
                MessageBox.Show("No existe usuario para modificar");
            }
        }

        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            operacion=0;
            if (flagBloqueado == true)
            {
                limpiarPantalla();
                desbloquearPantalla();
            }
            else
            {
                bloquearPantalla();
                llenarUsuario();
            }
        }

        
        private void cbBusquedaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarUsuario();
        }

        private void bloquearPantalla()
        {
            flagBloqueado = true;
            btnEliminarUsuario.Enabled = true;
            btnModificarUsuario.Enabled = true;
            btnNuevo.Text = "Nuevo";
            btnGuardarUsuario.Enabled = false;
            txtApellidoUsuario.Enabled = false;
            txtContrasena1Usuario.Enabled = false;
            txtContrasena2Usuario.Enabled = false;
            txtIdentificacionUsuario.Enabled = false;
            txtLoginUsuario.Enabled = false;
            txtNombreUsuario.Enabled = false;
            txtTelefonoUsuario.Enabled = false;
            cbBusquedaUsuario.Enabled = true;
            cbRolUsuario.Enabled = false;

        }

        private void desbloquearPantalla()
        {
            flagBloqueado = false;
            btnEliminarUsuario.Enabled = false;
            btnModificarUsuario.Enabled = false;
            btnNuevo.Text = "Cancelar";
            btnGuardarUsuario.Enabled = true;
            txtApellidoUsuario.Enabled = true;
            txtContrasena1Usuario.Enabled = true;
            txtContrasena2Usuario.Enabled = true;
            txtIdentificacionUsuario.Enabled = true;
            txtLoginUsuario.Enabled = true;
            txtNombreUsuario.Enabled = true;
            txtTelefonoUsuario.Enabled = true;
            cbBusquedaUsuario.Enabled = false;
            cbRolUsuario.Enabled = true;
        }

        private void limpiarPantalla()
        {
            txtApellidoUsuario.Text = "";
            txtContrasena1Usuario.Text = "";
            txtContrasena2Usuario.Text = "";
            txtIdentificacionUsuario.Text = "";
            txtLoginUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
            cbRolUsuario.SelectedIndex= 0;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            llenarUsuario();
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

        private void textbox_KeyPress_num(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
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

        private void textbox_KeyPress_alfanum_login(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
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
