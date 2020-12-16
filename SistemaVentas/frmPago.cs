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
    public partial class frmPago : Form
    {
        int idVenta = 0;
        int idCliente = 0;
        int tipoPantalla = 0;
        public frmPago(int venta,int id_cliente,int tipo)
        {
            InitializeComponent();
            idVenta = venta;
            id_cliente = idCliente;
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
                if (Char.IsControl(e.KeyChar) || e.KeyChar == ',') //permitir teclas de control como retroceso
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
                double valor = 0;
                clsNegocioPago objNegocioPago = new clsNegocioPago();
                if (txtValor.Text != "")
                {
                    valor = double.Parse(txtValor.Text);
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
                    if (objNegocioPago.insertarPago(idVenta, valor,idCliente,fechaPago, tipoPago))
                    {
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Valor ingresado es incorrecto");
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
                DataSet dsPagos = objNegocioPago.consutlarPago(idVenta);
                dgPagos.DataSource = dsPagos.Tables[0];
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
            .Sum(t => double.Parse(t.Cells[1].Value.ToString()))).ToString();
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
                btnGuardar.Visible = false;
                calFecha.Visible = false;
                dgPagos.Location = new Point(19, 35);
                dgPagos.Size = new Size(393,133); 
            }
        }
    }
}
