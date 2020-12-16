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
    public partial class frmPanelPrincipal : Form
    {
        bool flagSalir = false;
        Form formaInicio = null;
        public frmPanelPrincipal(int rol,Form forma)
        {
            formaInicio = forma;
            InitializeComponent();
            if (rol == 1)
            {
                btnBackUp.Visible = true;
                btnUsuarios.Visible = true;
                btnVariables.Visible = true;
                btnCliente.Visible = true;
                btnPaquete.Visible = true;
                btnProducto.Visible = true;
                btnReportes.Visible = true;
                btnSalir.Visible = true;
                btnVentas.Visible = true;
            }
            else
            {
                btnBackUp.Visible = false;
                btnUsuarios.Visible = false;
                btnVariables.Visible = false;
                btnCliente.Visible = true;
                btnPaquete.Visible = true;
                btnProducto.Visible = true;
                btnReportes.Visible = true;
                btnSalir.Visible = true;
                btnVentas.Visible = true;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmPanelPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente.DefInstance.MdiParent = this;
            frmCliente.DefInstance.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVenta.DefInstance.MdiParent = this;
            frmVenta.DefInstance.Show();
        }

        private void btnPaquete_Click(object sender, EventArgs e)
        {
            frmPaquete.DefInstance.MdiParent = this;
            frmPaquete.DefInstance.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmProducto.DefInstance.MdiParent = this;
            frmProducto.DefInstance.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario.DefInstance.MdiParent = this;
            frmUsuario.DefInstance.Show();
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            frmCatalogos.DefInstance.MdiParent = this;
            frmCatalogos.DefInstance.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes.DefInstance.MdiParent = this;
            frmReportes.DefInstance.Show();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            frmRespaldo.DefInstance.MdiParent = this;
            frmRespaldo.DefInstance.Show();
         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            flagSalir = true;
            this.Close();
            formaInicio.Visible = true;
            
        }

        private void frmPanelPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flagSalir)
                Application.Exit();
        }

        
    }
}
