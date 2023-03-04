using System;
using System.Data;
using System.Windows.Forms;
using ModeloDatos;
using CapaNegocio;
using System.Linq;
using Utilitarios;

namespace SistemaVentas
{
    public partial class frmVenta : Form
    {
        clsNegocioVenta objNegocioVenta = new clsNegocioVenta();
        clsDetalleVenta objDetalleVenta = new clsDetalleVenta();
        clsNegocioDetalleVenta objNegocioDetalleVenta = new clsNegocioDetalleVenta();
        clsNegocioCliente objNegocioCliente = new clsNegocioCliente();
        DataSet dsVenta;
        DataTable dtDetalleVentaLogico;
        int tipoPantalla = 0;
        int? idClienteBusqueda = 0;
        int indexCantidad = 0;
        bool flagDesbloquear = false;
        int id_cliente = 0;
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
                int idVenta = lbVenta.SelectedValue.ToString().ToInt();
                dsVentaTemporal = objNegocioVenta.consultarVentaId(idVenta);

                if (dsVentaTemporal.Tables[0].Rows.Count > 0)
                {
                    txtSubtotalVenta.Text = dsVentaTemporal.Tables[0].Rows[0][3].ToString();
                    cbEstado.SelectedIndex = dsVentaTemporal.Tables[0].Rows[0][5].ToString().ToInt();
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
            int idVenta = lbVenta.SelectedValue.ToString().ToInt();
            dsDetalleVenta = objNegocioDetalleVenta.consultarDetalleVenta(idVenta);
            dtDetalleVentaLogico = objNegocioDetalleVenta.consultarDetalleVentaLogico(idVenta);
            dgDetalleVenta.DataSource = dsDetalleVenta.Tables[0];
            dgDetalleVenta.Columns[0].Visible = false;
            dgDetalleVenta.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetalleVenta.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn dc in dgDetalleVenta.Columns)
            {
                if (dc.Index.Equals(4))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }
            sumarVenta();
            objNegocioVenta.cambiarTotal(idVenta, id_cliente, txtSubtotalVenta.Text.ToDouble());
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
                    id_cliente = cbBusquedaClienteVenta.SelectedValue.ToString().ToInt();
                    dsVenta = objNegocioVenta.consultarVentaPorCliente(id_cliente);

                }
                if (rbPorFecha.Checked)
                {
                    String fecha = calendario.Value.ToString("yyyy-MM-dd");
                    dsVenta = objNegocioVenta.consultarVentaPorFecha(fecha);
                }
                if (rbPorClienteFecha.Checked)
                {
                    id_cliente = cbBusquedaClienteVenta.SelectedValue.ToString().ToInt();
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
        private void btnAnular_Click(object sender, EventArgs e)
        {
            clsNegocioVenta objNegocioVenta = new clsNegocioVenta();
            clsNegocioSaldo objNegocioSaldo = new clsNegocioSaldo();
            clsSaldo objSaldo = new clsSaldo();
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            try
            {
                if (lbVenta.Items.Count > 0)
                {
                    int idVenta = lbVenta.SelectedValue.ToString().ToInt();
                    id_cliente = cbBusquedaClienteVenta.SelectedValue.ToString().ToInt();

                    if (objNegocioVenta.cambiarEstadoVenta(idVenta, 1))
                    {
                        foreach(DataRow dr in dtDetalleVentaLogico.Rows)
                        {
                            int idProducto = dr[1].ToString().ToInt();
                            int cantidad = dr[4].ToString().ToInt();
                            objNegocioProducto.aumentarCantidad(idProducto, cantidad);
                        }
                        objNegocioVenta.cambiarTotal(idVenta, id_cliente, 0);
                        MessageBox.Show("Se anulo correctamente la venta");
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
            finally
            {
                llenarVenta();
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
                dtDetalle.Columns.Add("Precio", typeof(decimal));
                dtDetalle.Columns.Add("Total", typeof(decimal));
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

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            int idProducto = 0;
            int cantidad = 0;

            if (lbVenta.Items.Count > 0)
            {
                if(cbEstado.SelectedIndex == 0)
                {
                    if (dgDetalleVenta.CurrentCell != null)
                    {
                        int numeroFila = dgDetalleVenta.CurrentCell.RowIndex;
                        int idDetalle = dgDetalleVenta[0, numeroFila].Value.ToString().ToInt();
                        foreach(DataRow drDetalle in dtDetalleVentaLogico.Rows)
                        {
                            if(drDetalle[0].ToString().ToInt() == idDetalle)
                            {
                                idProducto = drDetalle[1].ToString().ToInt();
                                cantidad = drDetalle[4].ToString().ToInt();
                            }
                        }

                        int idVenta = lbVenta.SelectedValue.ToString().ToInt();
                        if (objNegocioDetalleVenta.eliminarDetalleVenta(idDetalle, idVenta))
                        {
                            objNegocioProducto.aumentarCantidad(idProducto, cantidad);

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
                    MessageBox.Show("No se puede eliminar articulos de ventas entregadas ni anuladas");
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
                if (cbEstado.SelectedIndex == 0)
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
                    MessageBox.Show("Error: No se puede modificar ventas anuladas ni entregadas");
                }
            }
            else
            {
                MessageBox.Show("No existen paquetes seleccionados para modificar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idVenta = lbVenta.SelectedValue.ToString().ToInt();
            decimal total = txtSubtotalVenta.Text.ToDouble();
            if (objNegocioVenta.cambiarTotal(idVenta, id_cliente,total))
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
            btnAnular.Enabled = false;
            btnEntregar.Enabled = false;
            lbVenta.Enabled = false;
            flagDesbloquear = true;
            btnModificar.Text = "Cancelar";

        }

        public void darFormatoDetalle()
        {
            foreach (DataGridViewColumn dc in dgDetalleVenta.Columns)
            {
                if (dc.Index.Equals(4) || dc.Index.Equals(5))
                {
                    dc.ReadOnly = false;
                    dc.SortMode = DataGridViewColumnSortMode.NotSortable;
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dc.ReadOnly = true;
                    dc.SortMode = DataGridViewColumnSortMode.NotSortable;
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            btnAnular.Enabled = true;
            btnEntregar.Enabled = true;
            lbVenta.Enabled = true;
            flagDesbloquear = false;
            btnModificar.Text = "Modificar";
            darFormatoDetalle();
        }

        private void dgDetalleVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int idProductoLogico = 0;
            int nuevaCantidad = 0;
            DataTable dtProducto = null;
            int cantidadProducto = 0;
            int antiguaCantidad = 0;
            decimal nuevoPrecio = 0;

            indexCantidad = e.RowIndex;
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            string nuevoPrecioTexto = dgDetalleVenta[5, indexCantidad].Value.ToString();
            string nuevaCantidadTexto = dgDetalleVenta[4, indexCantidad].Value.ToString();
            int idDetalleVenta = dgDetalleVenta[0, indexCantidad].Value.ToString().ToInt();

            foreach (DataRow drDetalle in dtDetalleVentaLogico.Rows)
            {
                if (drDetalle[0].ToString().ToInt() == idDetalleVenta)
                {
                    idProductoLogico = drDetalle[1].ToString().ToInt();
                    nuevaCantidad = nuevaCantidadTexto.ToInt();
                    dtProducto = dtProducto = objNegocioProducto.consultarProductoId(idProductoLogico).Tables[0];
                    cantidadProducto = dtProducto.Rows[0][7].ToString().ToInt();
                    antiguaCantidad = drDetalle[4].ToString().ToInt();
                    nuevoPrecio = nuevoPrecioTexto.ToDouble();

                    if (flagDesbloquear)
                    {
                        if (e.ColumnIndex == 4)
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
                                            if (objNegocioDetalleVenta.modificarCantidad(idDetalleVenta, nuevaCantidad, nuevoPrecio.ToString().ToDouble()))
                                            {
                                                objNegocioProducto.disminuirCantidad(idProductoLogico, cantidad);
                                                drDetalle[4] = nuevaCantidad;
                                                drDetalle[5] = nuevaCantidad * nuevoPrecio;
                                                dgDetalleVenta[6, indexCantidad].Value = nuevaCantidad * nuevoPrecio;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Cantidad de producto no disponible");
                                            drDetalle[4] = antiguaCantidad;
                                            drDetalle[5] = antiguaCantidad * nuevoPrecio;
                                            dgDetalleVenta[4, indexCantidad].Value = antiguaCantidad;
                                            return;
                                        }
                                    }
                                    if (antiguaCantidad > nuevaCantidad)
                                    {
                                        int cantidad = antiguaCantidad - nuevaCantidad;
                                        if (objNegocioDetalleVenta.modificarCantidad(idDetalleVenta, nuevaCantidad, nuevoPrecio.ToString().ToDouble()))
                                        {
                                            objNegocioProducto.aumentarCantidad(idProductoLogico, cantidad);
                                            drDetalle[4] = nuevaCantidad;
                                            drDetalle[5] = nuevaCantidad * nuevoPrecio;
                                            dgDetalleVenta[6, indexCantidad].Value = nuevaCantidad * nuevoPrecio;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se puede modificar la cantidad de un producto que no es parte del paquete");
                                }
                            }
                        }

                        if (e.ColumnIndex == 5)
                        {
                            if (nuevoPrecio >= 0)
                            {
                                if (idProductoLogico != 0)
                                {
                                    if (objNegocioDetalleVenta.modificarPrecio(idDetalleVenta, nuevoPrecio))
                                    {
                                        decimal resultado = antiguaCantidad * nuevoPrecio;
                                        dgDetalleVenta[6, indexCantidad].Value = resultado.ToString();
                                    }
                                    else
                                        MessageBox.Show("No se puede modificar el precio del producto");
                                }
                            }
                        }
                        sumarVenta();
                    }
                }
            }
        }
        private void dgDetallePaquete_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (dgDetalleVenta.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column4_KeyPress);

                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column4_KeyPress);
                }
            }


            if (dgDetalleVenta.CurrentCell.ColumnIndex == 5) //Desired Column
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column5_KeyPress);

                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column5_KeyPress);
                }
            }
        }
        private void Column4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Column5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
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
            string subtotal = string.Empty;

            if (cbEstado.SelectedIndex == 1)
            {
                subtotal = "0";

            }
            else
            {
                subtotal = (dgDetalleVenta.Rows.Cast<DataGridViewRow>()
            .Sum(t => t.Cells[6].Value.ToString().ToDouble())).ToString();

            }

            txtSubtotalVenta.Text = subtotal;
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            clsNegocioVenta objNegocioVenta = new clsNegocioVenta();
            clsNegocioSaldo objNegocioSaldo = new clsNegocioSaldo();
            clsSaldo objSaldo = new clsSaldo();
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            try
            {
                if(lbVenta.Items.Count > 0)
                {
                    if (cbEstado.SelectedIndex == 0)
                    {
                        int idVenta = lbVenta.SelectedValue.ToString().ToInt();

                        if (objNegocioVenta.cambiarEstadoVenta(idVenta, 2))
                        {
                            MessageBox.Show("Se entrego correctamente la venta");
                        }
                        else
                        {
                            MessageBox.Show("Error al entregar la venta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede entregar ventas anuladas o ya entregadas");
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
            finally
            {
                llenarVenta();
            }
        }

        
    }
}
