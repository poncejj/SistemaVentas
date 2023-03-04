using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class MenuBase : Form
    {
        Form mdiParent;
        public MenuBase(int rolIngresado, Form form)
        {
            InitializeComponent();
            cargarBotones(rolIngresado);
            mdiParent = form;
        }
        private void MenuBase_Load(object sender, EventArgs e)
        {
            
        }


        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente.DefInstance.MdiParent = mdiParent;
            frmCliente.DefInstance.Show();
            frmCliente.DefInstance.Activate();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVenta.DefInstance.MdiParent = mdiParent;
            frmVenta.DefInstance.Show();
            frmVenta.DefInstance.Activate();
        }

        private void btnPaquete_Click(object sender, EventArgs e)
        {
            frmPaquete.DefInstance.MdiParent = mdiParent;
            frmPaquete.DefInstance.Show();
            frmPaquete.DefInstance.Activate();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmProducto.DefInstance.MdiParent = mdiParent;
            frmProducto.DefInstance.Show();
            frmProducto.DefInstance.Activate();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario.DefInstance.MdiParent = mdiParent;
            frmUsuario.DefInstance.Show();
            frmUsuario.DefInstance.Activate();

        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            frmCatalogos.DefInstance.MdiParent = mdiParent;
            frmCatalogos.DefInstance.Show();
            frmCatalogos.DefInstance.Activate();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes.DefInstance.MdiParent = mdiParent;
            frmReportes.DefInstance.Show();
            frmReportes.DefInstance.Activate();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            frmRespaldo.DefInstance.MdiParent = mdiParent;
            frmRespaldo.DefInstance.Show();
            frmRespaldo.DefInstance.Activate();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            mdiParent.Close();
        }

        private void cargarBotones(int rol)
        {
            if (rol == 1)
            {
                btnBackUp.Visible = true;
                btnUsuarios.Visible = true;
                btnConfiguracion.Visible = true;
                btnCliente.Visible = true;
                btnPaquete.Visible = true;
                btnProducto.Visible = true;
                btnVentas.Visible = true;
                btnSalir.Visible = true;
                btnVentas.Visible = true;
                btnReportes.Visible = true;
            }
            else
            {
                btnBackUp.Visible = false;
                btnUsuarios.Visible = false;
                btnConfiguracion.Visible = false;
                btnCliente.Visible = true;
                btnPaquete.Visible = true;
                btnProducto.Visible = true;
                btnVentas.Visible = true;
                btnSalir.Visible = true;
                btnVentas.Visible = true;
                btnReportes.Visible = true;
            }
        }

        private static MenuBase m_FormDefInstance;
        public static MenuBase DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new MenuBase(intRol, frmPrincipal);
                return m_FormDefInstance;

            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public static Form frmPrincipal;
        public static int intRol;

        private void ActivarHijos()
        {
            foreach (Form child in mdiParent.MdiChildren)
            {
                child.Activate();
            }
        }

        private void MenuBase_Enter(object sender, EventArgs e)
        {
            ActivarHijos();
        }
    }
}
