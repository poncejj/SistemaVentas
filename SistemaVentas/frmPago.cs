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
using Utilitarios;

namespace SistemaVentas
{
    public partial class frmPago : Form
    {
        int idCliente = 0;
        int tipoPantalla = 0;
        DataSet dsPagos = null;
        public frmPago(int id_cliente,int tipo)
        {
            InitializeComponent();
            idCliente = id_cliente;
            tipoPantalla = tipo;
            bloquear();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar) || e.KeyChar == '.') //permitir teclas de control como retroceso
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clsNegocioPago objNegocioPago = new clsNegocioPago();
                if (txtValor.Text != "")
                {
                    string fechaPago = calFecha.Value.ToString("yyyy-MM-dd"); ;
                    string tipoPago = "";

                    if (rbEfectivo.Checked)
                    {
                        tipoPago = "Efectivo";
                    }
                    if (rbDeposito.Checked)
                    {
                        tipoPago = "Deposito";
                    }
                    if (rbCheque.Checked)
                    {
                        tipoPago = "Cheque";
                    }
                    if (rbDescuento.Checked)
                    {
                        tipoPago = "Descuento";
                    }
                    if (objNegocioPago.insertarPago(txtValor.Text.ToDouble(), idCliente,fechaPago, tipoPago))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Valor es mayor al saldo del cliente o es incorrecto");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo registrar el pago");
            }
            finally
            {
            }
        }

        private void cargarPagos()
        {
            clsNegocioPago objNegocioPago = new clsNegocioPago();
            try
            {
                dsPagos = objNegocioPago.consutlarPago(idCliente);
                dgPagos.DataSource = dsPagos.Tables[0];
                dgPagos.Columns[0].Visible = false;
            }
            catch(Exception)
            {
            }
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            cargarPagos();
            totalizar();
        }

        private void totalizar()
        {
            txtTotalPagado.Text = "0";
            String totalPagado = (dgPagos.Rows.Cast<DataGridViewRow>()
            .Sum(t => t.Cells[2].Value.ToString().ToDouble())).ToString();
            txtTotalPagado.Text = totalPagado;

        }

        private void dgPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bloquear()
        {
            if(tipoPantalla == 1)
            {
                lblValor.Visible = false;
                lblFecha.Visible = false;
                txtValor.Visible = false;
                rbCheque.Visible = false;
                rbDeposito.Visible = false;
                rbEfectivo.Visible = false;
                rbDescuento.Visible = false;
                btnGuardar.Visible = false;
                btnAnular.Visible = true;
                calFecha.Visible = false;
                dgPagos.Location = new Point(19, 35);
                dgPagos.Size = new Size(393,133); 
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                clsNegocioPago objNegocioPago = new clsNegocioPago();

                if (dgPagos.Rows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el pago?", "Aterta", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int idPago = dsPagos.Tables[0].Rows[dgPagos.CurrentCell.RowIndex][0].ToString().ToInt();
                        if (objNegocioPago.eliminarPago(idPago, idCliente))
                        {
                            cargarPagos();
                            totalizar();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("No existen pagos para eliminar");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al anular el pago");
            }
        }
    }
}
