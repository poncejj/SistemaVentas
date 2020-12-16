using System;
using System.Data;
using System.Windows.Forms;
using ModeloDatos;
using CapaNegocio;
using System.Linq;

namespace SistemaVentas
{
    public partial class frmVenta : Form
    {
        clsNegocioVenta objNegocioVenta = new clsNegocioVenta();
        clsDetalleVenta objDetalleVenta = new clsDetalleVenta();
        clsNegocioDetalleVenta objNegocioDetalleVenta = new clsNegocioDetalleVenta();
        clsNegocioCliente objNegocioCliente = new clsNegocioCliente();
        DataSet dsVenta;
        DataSet dsDetalleVentaTodo;
        DataTable dtDetalleVentaLogico;
        int tipoPantalla = 0;
        int? idClienteBusqueda = 0;
        int indexCantidad = 0;
        bool flagDesbloquear = false;


        public frmVenta(int tipo,int? idCliente)
        {
            InitializeComponent();
            tipoPantalla = tipo;
            idClienteBusqueda = idCliente;
            cargarCombo();
            llenarVenta();
            bloquearPantalla();
        }

        private static frmVenta m_FormDefInstance;
        public static frmVenta DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmVenta(1,null);
                return m_FormDefInstance;

            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }


        private void calendario_ValueChanged(object sender, EventArgs e)
        {
            llenarVenta();
        }

        private void cbBusquedaCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            llenarVenta();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            //cargarCombo();
        }

        private void rbPorCliente_CheckedChanged(object sender, EventArgs e)
        {
            llenarVenta();
        }

        private void rbPorFecha_CheckedChanged(object sender, EventArgs e)
        {
            llenarVenta();
        }

        private void rbPorClienteFecha_CheckedChanged(object sender, EventArgs e)
        {
            llenarVenta();
        }

        private void lbVenta_MouseClick(object sender, MouseEventArgs e)
        {
            llenarDatosVenta();
        }

        private void lbVenta_Key(object sender, KeyEventArgs e)
        {
            llenarDatosVenta();
        }

        private void llenarDatosVenta()
        {
            DataSet dsVentaTemporal = new DataSet();
            if (lbVenta.Items.Count > 0)
            {
                int s = int.Parse(lbVenta.SelectedValue.ToString());
                dsVentaTemporal = objNegocioVenta.consultarVentaId(s);

                if (dsVentaTemporal.Tables[0].Rows.Count > 0)
                {
                    txtSubtotalVenta.Text = dsVentaTemporal.Tables[0].Rows[0][3].ToString();
                    cbEstado.SelectedIndex = int.Parse(dsVentaTemporal.Tables[0].Rows[0][5].ToString());
                    cargarValorPagado();
                    llenarDetalleVenta();
                }
            }
            else
            {
                MessageBox.Show("No existen ventas registradas");
            }
        }

        private void llenarDetalleVenta()
        {
            DataSet dsDetalleVenta = new DataSet();
            dtDetalleVentaLogico = new DataTable();
            dsDetalleVentaTodo = new DataSet();
            int idVenta = int.Parse(lbVenta.SelectedValue.ToString());
            dsDetalleVenta = objNegocioDetalleVenta.consultarDetalleVenta(idVenta);
            dsDetalleVentaTodo = objNegocioDetalleVenta.consultarTodosDetalleVentaes(idVenta);
            dtDetalleVentaLogico = objNegocioDetalleVenta.consultarDetalleVentaLogico(idVenta);
            dgDetalleVenta.DataSource = dsDetalleVenta.Tables[0];
            dgDetalleVenta.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn dc in dgDetalleVenta.Columns)
            {
                if (dc.Index.Equals(3))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }
        }

        public void llenarVenta()
        {
            limpiarPantalla();
            try

            {
                if (tipoPantalla != 1)
                {
                    int? idHistorial = idClienteBusqueda;
                    if (idHistorial != null)
                    {
                        cbBusquedaClienteVenta.SelectedValue = idHistorial.ToString();
                    }
                }

                if (rbPorCliente.Checked)
                {
                    int id_cliente = int.Parse(cbBusquedaClienteVenta.SelectedValue.ToString());
                    dsVenta = objNegocioVenta.consultarVentaPorCliente(id_cliente);

                }
                if (rbPorFecha.Checked)
                {
                    String fecha = calendario.Value.ToString("yyyy-MM-dd");
                    dsVenta = objNegocioVenta.consultarVentaPorFecha(fecha);
                }
                if (rbPorClienteFecha.Checked)
                {
                    int id_cliente = int.Parse(cbBusquedaClienteVenta.SelectedValue.ToString());
                    String fecha = calendario.Value.ToString("yyyy-MM-dd");
                    dsVenta = objNegocioVenta.consultarVenta(id_cliente, fecha);
                }

                if (dsVenta.Tables[0].Rows.Count > 0)
                {
                    if (rbPorClienteFecha.Checked || rbPorCliente.Checked)
                    {
                        lbVenta.DataSource = dsVenta.Tables[0];
                        lbVenta.DisplayMember = "fecha_venta";
                        lbVenta.ValueMember = "id_venta";
                        llenarDatosVenta();
                    }
                    if (rbPorFecha.Checked)
                    {
                        lbVenta.DataSource = dsVenta.Tables[0];
                        lbVenta.DisplayMember = "nombre_completo";
                        lbVenta.ValueMember = "id_venta";
                        llenarDatosVenta();
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void cargarCombo()
        {
            cbBusquedaClienteVenta.DataSource = objNegocioCliente.consultarTodosClientes().Tables[0];
            cbBusquedaClienteVenta.ValueMember = "id_cliente";
            cbBusquedaClienteVenta.DisplayMember = "nombre_completo";

        }

        private void cargarValorPagado()
        {
            clsNegocioPago objNegocioPago = new clsNegocioPago();
            double totalPago = 0;
            try
            {
                if (lbVenta.Items.Count > 0)
                {
                    int idVenta = int.Parse(lbVenta.SelectedValue.ToString());
                    DataSet dsPago = objNegocioPago.consutlarPago(idVenta);
                    
                    foreach (DataRow dr in dsPago.Tables[0].Rows)
                    {
                        totalPago += double.Parse(dr[1].ToString());
                    }
                }
                txtValorPagado.Text = totalPago.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            clsNegocioVenta objNegocioVenta = new clsNegocioVenta();
            clsNegocioSaldo objNegocioSaldo = new clsNegocioSaldo();
            clsSaldo objSaldo = new clsSaldo();

            try
            {
                if (lbVenta.Items.Count > 0)
                {
                    int idVenta = int.Parse(lbVenta.SelectedValue.ToString());
                    int id_cliente = int.Parse(cbBusquedaClienteVenta.SelectedValue.ToString());

                    if (objNegocioVenta.cambiarEstadoVenta(idVenta, 2))
                    {
                        MessageBox.Show("Se anulo correctamente la venta");
                        objSaldo.id_cliente = id_cliente;
                        objSaldo.saldo = double.Parse(txtSubtotalVenta.Text);
                        objNegocioSaldo.cambiarSaldo(objSaldo, 2);
                    }
                    else
                    {
                        MessageBox.Show("Error al anular la venta");
                    }
                }
                else
                {
                    MessageBox.Show("No existe venta seleccionada para anular");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_cliente = int.Parse(cbBusquedaClienteVenta.SelectedValue.ToString());
                if (cbEstado.SelectedIndex == 1)
                {
                    if (lbVenta.Items.Count > 0)
                    {
                        int id = int.Parse(lbVenta.SelectedValue.ToString());
                        frmPago objPago = new frmPago(id, id_cliente,0);
                        objPago.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No existe venta seleccionada para registrar el pago");
                    }
                }
                if (cbEstado.SelectedIndex == 0)
                {
                    MessageBox.Show("Venta esta pagada en su totalidad");
                }
                if (cbEstado.SelectedIndex == 2)
                {
                    MessageBox.Show("Venta anulada, no se pueden realizar pagos");

                }
            }
            catch (Exception)
            {

            }
            finally
            {
                llenarDatosVenta();
                cambiarEstado();
            }
        }

        private void cbBusquedaClienteVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarVenta();
        }

        private DataTable generarDetalle()
        {
            DataTable dtDetalle = new DataTable();
            try
            {
                dtDetalle.Columns.Add("Producto", typeof(string));
                dtDetalle.Columns.Add("Color", typeof(string));
                dtDetalle.Columns.Add("Tamano", typeof(string));
                dtDetalle.Columns.Add("Cantidad", typeof(int));
                dtDetalle.Columns.Add("Precio", typeof(double));
                dtDetalle.Columns.Add("Total", typeof(double));
                dtDetalle.Columns.Add("Observacion", typeof(string));
            }
            catch (Exception)
            {
            }
            return dtDetalle;
        }

        private void limpiarPantalla()
        {
            lbVenta.DataSource = null;
            dgDetalleVenta.DataSource = generarDetalle();
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

        private void lbVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cambiarEstado()
        {
            if (lbVenta.Items.Count > 0)
            {
                int idVenta = int.Parse(lbVenta.SelectedValue.ToString());
                double valorPagado = double.Parse(txtValorPagado.Text);
                double valorTotal = double.Parse(txtSubtotalVenta.Text);

                if (cbEstado.SelectedIndex == 1)
                {
                    if (valorPagado == valorTotal)
                    {
                        if (objNegocioVenta.cambiarEstadoVenta(idVenta, 0))
                        {
                            llenarDatosVenta();
                        }
                        else
                        {
                            //  MessageBox.Show("Error al registrar el pago");
                        }
                    }
                }
            }
            else
            {
                //MessageBox.Show("No existen ventas registradas");
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
           if(lbVenta.Items.Count > 0)
            {
                if (dgDetalleVenta.CurrentCell != null)
                {
                    int numeroFila = dgDetalleVenta.CurrentCell.RowIndex;
                    int idDetalle = int.Parse(dsDetalleVentaTodo.Tables[0].Rows[numeroFila][0].ToString());
                    int idVenta = int.Parse(lbVenta.SelectedValue.ToString());
                    if(objNegocioDetalleVenta.eliminarDetalleVenta(idDetalle,idVenta))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Error al devoler la prenda de ropa");
                    }
                    llenarDatosVenta();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila válida");
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una venta válida");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (lbVenta.Items.Count > 0)
            {
                if (cbEstado.SelectedIndex == 1)
                {
                    if (!flagDesbloquear)
                    {
                        sumarVenta();
                        desbloquearPantalla();
                    }
                    else
                    {
                        bloquearPantalla();
                    }
                }
                else
                {
                    MessageBox.Show("Error: No se puede modificar paquetes vendidos");
                }
            }
            else
            {
                MessageBox.Show("No existen paquetes seleccionados para modificar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idVenta = int.Parse(lbVenta.SelectedValue.ToString());
            double total = double.Parse(txtSubtotalVenta.Text);
            if (objNegocioVenta.cambiarTotal(idVenta,total))
            {
                bloquearPantalla();
            }
        }

        private void desbloquearPantalla()
        {
            cbBusquedaClienteVenta.Enabled = false;
            calendario.Enabled = false;
            rbPorCliente.Enabled = false;
            rbPorClienteFecha.Enabled = false;
            rbPorFecha.Enabled = false;
            dgDetalleVenta.ReadOnly = false;
            darFormatoDetalle();
            btnModificar.Enabled = true;
            btnGuardar.Enabled = true;
            btnPagar.Enabled = false;
            btnAnular.Enabled = false;
            lbVenta.Enabled = false;
            flagDesbloquear = true;
            btnModificar.Text = "Cancelar";

        }

        public void darFormatoDetalle()
        {
            foreach (DataGridViewColumn dc in dgDetalleVenta.Columns)
            {
                if (dc.Index.Equals(3) || dc.Index.Equals(4))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }
        }

        private void bloquearPantalla()
        {
            cbBusquedaClienteVenta.Enabled = true;
            calendario.Enabled = true;
            rbPorCliente.Enabled = true;
            rbPorClienteFecha.Enabled = true;
            rbPorFecha.Enabled = true;
            dgDetalleVenta.ReadOnly = true;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            btnPagar.Enabled = true;
            btnAnular.Enabled = true;
            lbVenta.Enabled = true;
            flagDesbloquear = false;
            btnModificar.Text = "Modificar";
        }

        private void dgDetalleVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            string nuevoPrecioTexto = dgDetalleVenta[4, indexCantidad].Value.ToString();
            string nuevaCantidadTexto = dgDetalleVenta[3, indexCantidad].Value.ToString();
            int idDetalleVenta = int.Parse(dtDetalleVentaLogico.Rows[indexCantidad][0].ToString());
            int idProductoLogico = int.Parse(dtDetalleVentaLogico.Rows[indexCantidad][1].ToString());
            int nuevaCantidad = int.Parse(nuevaCantidadTexto);
            DataTable dtProducto = dtProducto = objNegocioProducto.consultarProductoId(idProductoLogico).Tables[0];
            int cantidadProducto = int.Parse(dtProducto.Rows[0][7].ToString());
            int antiguaCantidad = int.Parse(dtDetalleVentaLogico.Rows[indexCantidad][4].ToString());
            double precioProducto = double.Parse(dtProducto.Rows[0][2].ToString());
            decimal nuevoPrecio = decimal.Parse(nuevoPrecioTexto);

            if(flagDesbloquear)
            {
                if (e.ColumnIndex == 3)
                {
                    if (nuevaCantidad >= 0)
                    {
                        if (idProductoLogico != 0)
                        {
                            if (antiguaCantidad < nuevaCantidad)
                            {
                                if (nuevaCantidad <= antiguaCantidad + cantidadProducto)
                                {
                                    int cantidad = nuevaCantidad - antiguaCantidad;
                                    if (objNegocioDetalleVenta.modificarCantidad(idDetalleVenta, nuevaCantidad, precioProducto))
                                    {
                                        objNegocioProducto.disminuirCantidad(idProductoLogico, cantidad);
                                        dtDetalleVentaLogico.Rows[indexCantidad][4] = nuevaCantidad;
                                        dtDetalleVentaLogico.Rows[indexCantidad][5] = nuevaCantidad * precioProducto;
                                        dgDetalleVenta[5, indexCantidad].Value = nuevaCantidad * precioProducto;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Cantidad de producto no disponible");
                                    dtDetalleVentaLogico.Rows[indexCantidad][4] = antiguaCantidad;
                                    dtDetalleVentaLogico.Rows[indexCantidad][5] = antiguaCantidad * precioProducto;
                                    dgDetalleVenta[3, indexCantidad].Value = antiguaCantidad;
                                    return;
                                }
                            }
                            if (antiguaCantidad > nuevaCantidad)
                            {
                                int cantidad = antiguaCantidad - nuevaCantidad;
                                if (objNegocioDetalleVenta.modificarCantidad(idDetalleVenta, nuevaCantidad, precioProducto))
                                {
                                    objNegocioProducto.aumentarCantidad(idProductoLogico, cantidad);
                                    dtDetalleVentaLogico.Rows[indexCantidad][4] = nuevaCantidad;
                                    dtDetalleVentaLogico.Rows[indexCantidad][5] = nuevaCantidad * precioProducto;
                                    dgDetalleVenta[5, indexCantidad].Value = nuevaCantidad * precioProducto;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede modificar la cantidad de un producto que no es parte del paquete");
                        }
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    if (nuevoPrecio >= 0)
                    {
                        if (idProductoLogico != 0)
                        {
                            if (objNegocioDetalleVenta.modificarPrecio(idDetalleVenta, nuevoPrecio))
                            {
                                decimal resultado = antiguaCantidad * nuevoPrecio;
                                dgDetalleVenta[5, indexCantidad].Value = resultado.ToString();
                            }
                            else
                                MessageBox.Show("No se puede modificar el precio del producto");
                        }
                    }
                }
                sumarVenta();
            }
        }

        private void dgDetallePaquete_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (dgDetalleVenta.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column3_KeyPress);

                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column3_KeyPress);
                }
            }


            if (dgDetalleVenta.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column4_KeyPress);

                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column4_KeyPress);
                }
            }
        }
        private void Column3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Column4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void dgDetalleVenta_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            indexCantidad = dgDetalleVenta.CurrentCell.RowIndex;
        }
        private void sumarVenta()
        {
            String subtotal = (dgDetalleVenta.Rows.Cast<DataGridViewRow>()
            .Sum(t => Convert.ToDouble(t.Cells[5].Value))).ToString();

            txtSubtotalVenta.Text = subtotal;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                int id_cliente = int.Parse(cbBusquedaClienteVenta.SelectedValue.ToString());

                if (lbVenta.Items.Count > 0)
                {
                    int id = int.Parse(lbVenta.SelectedValue.ToString());
                    frmPago objPago = new frmPago(id, id_cliente,1);
                    objPago.ShowDialog();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                llenarDatosVenta();
                cambiarEstado();
            }
        }
    }
}
