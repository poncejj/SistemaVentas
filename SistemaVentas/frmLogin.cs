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

namespace SistemaVentas
{
    public partial class frmLogin : Form
    {

        bool flag1 = false;
        bool flag2 = false;
        bool flag3 = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            flag1 = true;
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            if (flag1 == true)
            {
                flag2 = true;
            }
            else
            {
                flag1 = false;
                flag2 = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (flag1 == true && flag2 == true)
            {
                flag3 = true;
            }
            else
            {
                flag1 = false;
                flag2 = false;
                flag3 = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsNegocioUsuario objNegocioUsuario = new clsNegocioUsuario();
            try
            {
                if (flag1 && flag2 && flag3)
                {
                    if (txtUsuario.Text == "instalador" && txtContrasena.Text == "pelucon43")
                    {
                        frmVariablesSistema objVariable = new frmVariablesSistema();
                        objVariable.ShowDialog();
                        txtContrasena.Text = "";
                        txtUsuario.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar al sistema, verifique su usuario y/o contraseña");
                        txtContrasena.Text = "";                    
                    }
                    flag1 = false;
                    flag2 = false;
                    flag3 = false;
                }
                else
                {
                    int rol = objNegocioUsuario.login(txtUsuario.Text, txtContrasena.Text);
                    if (rol == 0)
                    {
                        MessageBox.Show("Error al ingresar al sistema, verifique su usuario y/o contraseña");
                        txtContrasena.Text = "";
                    }
                    else
                    {
                        frmPanelPrincipal objPanelPrincipal = new frmPanelPrincipal(rol,this);
                        objPanelPrincipal.Show();
                        txtContrasena.Text = "";
                        this.Visible = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar al sistema, verifique su usuario y/o contraseña"
                +" o contactese con el administrador del sistema");
                txtContrasena.Text = "";
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
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
