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
    public partial class frmPaquete : Form
    {
        clsNegocioPaquete objNegocioPaquete = new clsNegocioPaquete();
        clsDetallePaquete objDetallePaquete = new clsDetallePaquete();
        clsNegocioDetallePaquete objNegocioDatallePaquete = new clsNegocioDetallePaquete();
        clsNegocioCliente objNegocioCliente = new clsNegocioCliente();
        DataSet dsDetallePaquete = new DataSet();
        DataTable dtDetallePaquete = new DataTable();
        DataTable dtDetallePaqueteLogico = new DataTable();
        DataTable dtDetallePaqueteLogicoTemporal = new DataTable();                  
        public List<clsDetallePaquete> lista = new List<clsDetallePaquete>();
        int indexDataGrid = 0;
        bool flagDesbloquear = true;
        int operacion = 0;
        int ultimoID = 0;
        int indexCantidad;
        DataSet dsPaquete;
        bool flagConsultarObservacion = false;

        public frmPaquete()
        {
            InitializeComponent();
            bloquearPantalla();
            generarDataTable();
            generarDataTableLogico();
        }

        private void btnAgregarProductoPaquete_Click(object sender, EventArgs e)
        {
            frmSeleccionProductos objProducto = new frmSeleccionProductos(this);
            objProducto.Show();
        }

        private void frmPaquete_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        private void calendarioPaquete_ValueChanged(object sender, EventArgs e)
        {
            if(rbPorClienteFecha.Checked || rbPorFecha.Checked)
                llenarPaquete();
        }

        private void lbPaquete_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarPaquete();
        }

        public void actualizareDetalle()
        {
            int index = lista.Count-1;
            DataSet dsProducto = new DataSet();
            DataSet dsColor = new DataSet();
            DataSet dsTamano = new DataSet();
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            clsNegocioColor objNegocioColor = new clsNegocioColor();
            clsNegocioTamano objNegocioTamano = new clsNegocioTamano();
            try
            {
                if (index >= 0)
                {
                    int idProducto = lista[index].id_producto;
                    int idColor = lista[index].id_color;
                    int idTamano = lista[index].id_tamano;

                    dsProducto = objNegocioProducto.consultarProductoId(idProducto);
                    dsColor = objNegocioColor.consultarColorId(idColor);
                    dsTamano = objNegocioTamano.consultarTamanoId(idTamano);

                    string producto = dsProducto.Tables[0].Rows[0][1].ToString();
                    string color = dsColor.Tables[0].Rows[0][1].ToString();
                    string tamano = dsTamano.Tables[0].Rows[0][1].ToString();
                    decimal precio = dsProducto.Tables[0].Rows[0][2].ToString().ToDouble();
                    int cantidad = lista[index].cantidad;
                    decimal total = lista[index].cantidad * precio;
                    bool estado = lista[index].estado_detalle;
                    string observacion = lista[index].observacion_detalle_paquete;


                    if (objNegocioProducto.disminuirCantidad(idProducto, cantidad))
                    {
                        DataRow filaLogica = dtDetallePaqueteLogico.NewRow();

                        filaLogica[0] = 0;
                        filaLogica[1] = idProducto;
                        filaLogica[2] = idColor;
                        filaLogica[3] = idTamano;
                        filaLogica[4] = lista[index].cantidad;
                        filaLogica[5] = total;
                        filaLogica[6] = estado;
                        filaLogica[7] = observacion;
                        filaLogica[8] = precio;

                        dtDetallePaqueteLogico.Rows.Add(filaLogica);

                        DataRow fila = dtDetallePaquete.NewRow();
                        fila[0] = 0;
                        fila[1] = producto;
                        fila[2] = color;
                        fila[3] = tamano;
                        fila[4] = lista[index].cantidad;
                        fila[5] = precio;
                        fila[6] = total;
                        fila[7] = estado;
                        dtDetallePaquete.Rows.Add(fila);

                        dgDetallePaquete.DataSource = dtDetallePaquete;

                        darFormatoDetalle();
                        ajustarTamanioColumna();
                    }
                    else
                    {
                        MessageBox.Show("Cantidad no disponible en el producto");
                    }
                    sumarPaquete();
                }
            }
            catch(Exception)
            {

            }
        }

        private void cbBusquedaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBusquedaCliente != null)
            {
                llenarPaquete();
            }
        
        }

        private void rbPorFecha_CheckedChanged(object sender, EventArgs e)
        {
            llenarPaquete();
        }

        private void rbPorCliente_CheckedChanged(object sender, EventArgs e)
        {
            llenarPaquete();
        }

        private void rbPorClienteFecha_CheckedChanged(object sender, EventArgs e)
        {
            llenarPaquete();
        }

        private void llenarDatosPaquete()
        {
            DataSet dsPaqueteTemporal = new DataSet();
            try
            {
                int idPaquete = lbPaquete.SelectedValue.ToString().ToInt();
                dsPaqueteTemporal = objNegocioPaquete.consultarPaqueteId(idPaquete);

                if (dsPaqueteTemporal.Tables[0].Rows.Count > 0)
                {
                    if (bool.Parse(dsPaqueteTemporal.Tables[0].Rows[0][5].ToString()) == true)
                    {
                        cbEstadoPaquete.SelectedIndex = 0;
                    }

                    if (bool.Parse(dsPaqueteTemporal.Tables[0].Rows[0][5].ToString()) == false)
                    {
                        cbEstadoPaquete.SelectedIndex = 1;
                    }
                    if (rbPorCliente.Checked)
                        calendarioPaquete.Text = dsPaqueteTemporal.Tables[0].Rows[0][1].ToString();

                    llenarDetallePaquete();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Paquete no disponible");
            }
        }

        private void llenarDetallePaquete()
        {
            txtObservaciones.Text = "";

            generarDataTableLogicoTemporal();
            try
            {
                int idPaquete  = 0;
                if (lbPaquete.SelectedValue != null)
                {
                  idPaquete  = lbPaquete.SelectedValue.ToString().ToInt();
                }
                else
                {
                    idPaquete = 0;
                }
                dtDetallePaqueteLogico = objNegocioDatallePaquete.consultarDetallePaqueteLogico(idPaquete).Tables[0];
                dtDetallePaqueteLogicoTemporal = objNegocioDatallePaquete.consultarDetallePaqueteLogico(idPaquete).Tables[0];
                dsDetallePaquete = objNegocioDatallePaquete.consultarDetallePaquete(idPaquete);
                dtDetallePaquete = dsDetallePaquete.Tables[0];
                
                dgDetallePaquete.DataSource = dtDetallePaquete;

                darFormatoDetalle();
                ajustarTamanioColumna();
                sumarPaquete();
                txtObservaciones.Text = dtDetallePaqueteLogico.Rows[indexCantidad][7].ToString();
                flagConsultarObservacion = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void darFormatoDetalle()
        {
            if(operacion == 1)
            {
                foreach (DataGridViewColumn dc in dgDetallePaquete.Columns)
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
        }

        private void ajustarTamanioColumna()
        {
            dgDetallePaquete.Columns[0].Visible = false;
            dgDetallePaquete.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetallePaquete.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetallePaquete.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetallePaquete.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetallePaquete.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetallePaquete.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDetallePaquete.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void llenarPaquete()
        {
            int idCliente = 0;
            try
            {
                if (flagDesbloquear == true)
                {
                    idCliente = cbBusquedaCliente.SelectedValue.ToString().ToInt();

                    limpiarPantalla();
                    if (rbPorCliente.Checked)
                    {

                        dsPaquete = objNegocioPaquete.consultarPaquetePorCliente(idCliente);

                    }
                    if (rbPorFecha.Checked)
                    {
                        String fecha = calendarioPaquete.Value.ToString("yyyy-MM-dd");
                        dsPaquete = objNegocioPaquete.consultarPaquetePorFecha(fecha);
                    }
                    if (rbPorClienteFecha.Checked)
                    {
                        String fecha = calendarioPaquete.Value.ToString("yyyy-MM-dd");
                        dsPaquete = objNegocioPaquete.consultarPaquete(idCliente, fecha);
                    }

                    if (rbPorClienteFecha.Checked || rbPorCliente.Checked)
                    {
                        lbPaquete.DataSource = dsPaquete.Tables[0];
                        lbPaquete.DisplayMember = "fecha_paquete";
                        lbPaquete.ValueMember = "id_paquete";
                        llenarDatosPaquete();
                    }
                    if (rbPorFecha.Checked)
                    {
                        lbPaquete.DataSource = dsPaquete.Tables[0];
                        lbPaquete.DisplayMember = "nombre_completo";
                        lbPaquete.ValueMember = "id_paquete";
                        llenarDatosPaquete();
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
            cbBusquedaCliente.DataSource = objNegocioCliente.consultarTodosClientes().Tables[0];
            cbBusquedaCliente.ValueMember = "id_cliente";
            cbBusquedaCliente.DisplayMember = "nombre_completo";

        }

        private void lbPaquete_MouseClick(object sender, MouseEventArgs e)
        {
            llenarDatosPaquete();
        }

        private void lbPaquete_Key(object sender, KeyEventArgs e)
        {
            llenarDatosPaquete();
        }

        private void limpiarPantalla()
        {
            txtObservaciones.Text = "";
            txtSubtotalPaquete.Text = "0";
            cbEstadoPaquete.SelectedValue = 0;
            dgDetallePaquete.DataSource = null;
        }

        private void dgDetallePaquete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtObservaciones.Text = "";
            txtObservaciones.Text = dtDetallePaqueteLogico.Rows[indexDataGrid][7].ToString();
            sumarPaquete();
        }

        private void dgDetallePaquete_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            sumarPaquete();
        }

        private void dgDetallePaquete_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            sumarPaquete();
        }

        private void sumarPaquete()
        {
            string subtotal = "0";
            try
            {
             subtotal = (dgDetallePaquete.Rows.Cast<DataGridViewRow>()
            .Where(r => Convert.ToBoolean(r.Cells[7].Value).Equals(true))
            .Sum(t => t.Cells[6].Value.ToString().ToDouble())).ToString();

                txtSubtotalPaquete.Text = subtotal;
            }
            catch(Exception)
            {
                txtSubtotalPaquete.Text = subtotal;
                throw;
            }
            
        }

        private void desbloquearPantalla()
        {
            calendarioPaquete.Enabled = true;
            rbPorCliente.Enabled = false;
            rbPorClienteFecha.Enabled = false;
            rbPorFecha.Enabled = false;
            dgDetallePaquete.ReadOnly = false;
            darFormatoDetalle();
            btnAgregarProductoPaquete.Enabled = true;
            btnNuevo.Text = "Cancelar";
            btnEliminarPaquete.Enabled = false;
            btnModificarPaquete.Enabled = false;
            btnVender.Enabled = false;
            btnGuardarPaquete.Enabled = true;
            btnIncluirProducto.Enabled = true;
            btnNoIncluirProducto.Enabled = true;
            txtObservaciones.Enabled = true;
            lbPaquete.Enabled = false;
            flagDesbloquear = false;
            
        }

        private void bloquearPantalla()
        {
            calendarioPaquete.Enabled = true;
            rbPorCliente.Enabled = true;
            rbPorClienteFecha.Enabled = true;
            rbPorFecha.Enabled = true;
            dgDetallePaquete.ReadOnly = true;
            btnAgregarProductoPaquete.Enabled = false;
            btnNuevo.Text = "Nuevo";
            btnEliminarPaquete.Enabled = true;
            btnModificarPaquete.Enabled = true;
            btnVender.Enabled = true;
            btnGuardarPaquete.Enabled = false;
            btnIncluirProducto.Enabled = false;
            btnNoIncluirProducto.Enabled = false;
            lbPaquete.Enabled = true;
            flagDesbloquear = true;
            dtDetallePaquete = new DataTable();
            dtDetallePaqueteLogico = new DataTable();
            txtObservaciones.Enabled = false;
        }

        private void generarDataTable()
        {
            if (dtDetallePaquete.Columns.Count<=0)
            {
                dtDetallePaquete.Columns.Add("idDetalle", typeof(string));
                dtDetallePaquete.Columns.Add("Producto", typeof(string));
                dtDetallePaquete.Columns.Add("Color", typeof(string));
                dtDetallePaquete.Columns.Add("Tamano", typeof(string));
                dtDetallePaquete.Columns.Add("Cantidad", typeof(int));
                dtDetallePaquete.Columns.Add("Precio", typeof(decimal));
                dtDetallePaquete.Columns.Add("Total", typeof(decimal));
                dtDetallePaquete.Columns.Add("Estado", typeof(bool));
            }
        }

        private void generarDataTableLogico()
        {
            if (dtDetallePaqueteLogico.Columns.Count <= 0)
            {
                dtDetallePaqueteLogico.Columns.Add("idDetalle", typeof(int));
                dtDetallePaqueteLogico.Columns.Add("idProducto", typeof(int));
                dtDetallePaqueteLogico.Columns.Add("idColor", typeof(int));
                dtDetallePaqueteLogico.Columns.Add("idTamano", typeof(int));
                dtDetallePaqueteLogico.Columns.Add("Cantidad", typeof(int));
                dtDetallePaqueteLogico.Columns.Add("Total", typeof(decimal));
                dtDetallePaqueteLogico.Columns.Add("Estado", typeof(bool));
                dtDetallePaqueteLogico.Columns.Add("Observacion", typeof(string));
                dtDetallePaqueteLogico.Columns.Add("Precio", typeof(decimal));
            }

        }

        private void generarDataTableLogicoTemporal()
        {
            if (dtDetallePaqueteLogico.Columns.Count <= 0)
            {
                dtDetallePaqueteLogico.Columns.Add("idDetalle", typeof(int));
                dtDetallePaqueteLogico.Columns.Add("idProducto", typeof(int));
                dtDetallePaqueteLogico.Columns.Add("idColor", typeof(int));
                dtDetallePaqueteLogico.Columns.Add("idTamano", typeof(int));
                dtDetallePaqueteLogico.Columns.Add("Cantidad", typeof(int));
                dtDetallePaqueteLogico.Columns.Add("Total", typeof(decimal));
                dtDetallePaqueteLogico.Columns.Add("Estado", typeof(bool));
                dtDetallePaqueteLogico.Columns.Add("Observacion", typeof(string));
                dtDetallePaqueteLogico.Columns.Add("Precio", typeof(decimal));

            }

        }

        private List<int> obtenerDiferencia()
        {
            List<int> id_table1 = dtDetallePaqueteLogicoTemporal.AsEnumerable().Select(val => (int)val["id_detalle_paquete"]).ToList();
            List<int> id_table2 = dtDetallePaqueteLogico.AsEnumerable().Select(val => (int)val["id_detalle_paquete"]).ToList();
            List<int> diferencia = id_table1.Except(id_table2).ToList();
            return diferencia;
        }

        private void restaurarCantidades()
        {
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            try
            {
                foreach(DataRow fila in dtDetallePaqueteLogico.Rows)
                {
                    int idProducto = fila[1].ToString().ToInt();
                    int cantidad = fila[4].ToString().ToInt();
                    
                    if(bool.Parse(fila[6].ToString()))
                    {
                        objNegocioProducto.aumentarCantidad(idProducto, cantidad);
                    }
                }
            }
            catch(Exception)
            {
            }
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (flagDesbloquear == true)
            {
                clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
                DataSet dsProducto = objNegocioProducto.consultarTodosProductos();
                if (dsProducto != null)
                {
                    if (cbBusquedaCliente.Items.Count > 0)
                    {
                        operacion = 0;
                        //cbBusquedaCliente.SelectedIndex = 0;
                        calendarioPaquete.Value = DateTime.Today;
                        cbEstadoPaquete.SelectedIndex = 1;
                        dgDetallePaquete.DataSource = null;
                        dgDetallePaquete.Refresh();
                        txtSubtotalPaquete.Text = "0";
                        txtObservaciones.Text = "";
                        desbloquearPantalla();
                        dtDetallePaquete = new DataTable();
                        dtDetallePaqueteLogico = new DataTable();
                        generarDataTable();
                        generarDataTableLogico();
                    }
                    else
                    {
                        MessageBox.Show("Error: No existen clientes registrados para agregar paquetes");
                    }
                }
                else
                {
                    MessageBox.Show("Error: No existen productos registrados para agregar al paquete");
                }
            }
            else
            {
                devolverDetalle();
                bloquearPantalla();
                dgDetallePaquete.DataSource = null;
                dgDetallePaquete.Refresh();
                dtDetallePaqueteLogico = new DataTable();
                dtDetallePaquete = new DataTable();
                llenarPaquete();
            }                
        }

        private void devolverDetalle()
        {
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            int idProducto = 0;
            int cantidad = 0;
            if(operacion == 1)
            {
                foreach (DataRow fila in dtDetallePaqueteLogico.Rows)
                {
                    if(fila[0].ToString().ToInt() == 0)
                    {
                        idProducto = fila[1].ToString().ToInt();
                        cantidad = fila[4].ToString().ToInt();

                        if (bool.Parse(fila[6].ToString()))
                        {
                            objNegocioProducto.aumentarCantidad(idProducto, cantidad);
                        }
                    }
                    else
                    {
                        foreach(DataRow filaOiginal in dtDetallePaqueteLogicoTemporal.Rows)
                        {
                            int idDetalleOriginal = filaOiginal[0].ToString().ToInt();
                            int idDetalle = fila[0].ToString().ToInt();
                            if (idDetalleOriginal == idDetalle)
                            {
                                int cantidadOriginal = filaOiginal[4].ToString().ToInt();
                                int cantidadLogica = fila[4].ToString().ToInt();
                                bool estadoOriginal = bool.Parse(filaOiginal[6].ToString());
                                bool estadoLogico = bool.Parse(fila[6].ToString());
                                idProducto = fila[1].ToString().ToInt();

                                if(estadoLogico)
                                {
                                    if (cantidadOriginal > cantidadLogica)
                                    {
                                        int diferencia = cantidadOriginal - cantidadLogica;
                                        objNegocioProducto.disminuirCantidad(idProducto, diferencia);
                                    }
                                    if (cantidadLogica > cantidadOriginal)
                                    {
                                        int diferencia = cantidadLogica - cantidadOriginal;
                                        objNegocioProducto.aumentarCantidad(idProducto, diferencia);
                                    }
                                }
                               

                                if(estadoOriginal != estadoLogico)
                                {
                                    if(estadoOriginal)
                                    {
                                        objNegocioProducto.disminuirCantidad(idProducto, cantidadOriginal);
                                    }
                                    else
                                    {
                                        objNegocioProducto.aumentarCantidad(idProducto, cantidadOriginal);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                try
                {
                    foreach (DataRow fila in dtDetallePaqueteLogico.Rows)
                    {
                        idProducto = fila[1].ToString().ToInt();
                        cantidad = fila[4].ToString().ToInt();

                        if (bool.Parse(fila[6].ToString()))
                        {
                            objNegocioProducto.aumentarCantidad(idProducto, cantidad);
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnModificarPaquete_Click(object sender, EventArgs e)
        {
            List<int> diferencia = new List<int>();
            
            if (lbPaquete.Items.Count>0)
            {
                if (cbEstadoPaquete.SelectedIndex == 1)
                {
                    operacion = 1;
                    if (flagDesbloquear)
                    {
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

        private void btnEliminarProductoPaquete_Click(object sender, EventArgs e)
        {
            bool estado = false;
            int idProducto = 0;
            int cantidad = 0;
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            foreach (DataGridViewCell onCell in dgDetallePaquete.SelectedCells)
            {
                if (onCell.Selected)
                {
                    indexDataGrid = onCell.RowIndex;
                    int idDetalle = dgDetallePaquete[0, indexDataGrid].Value.ToString().ToInt();
                
                    foreach(DataRow drDetalle in dtDetallePaqueteLogico.Rows)
                    {
                        if(drDetalle[0].ToString().ToInt() == idDetalle)
                        {
                            estado = bool.Parse(drDetalle[6].ToString());
                            idProducto = drDetalle[1].ToString().ToInt();
                            cantidad = drDetalle[4].ToString().ToInt();
                        }
                    }

                    
                    dgDetallePaquete.Rows.RemoveAt(indexDataGrid);
                    dtDetallePaqueteLogico.Rows.RemoveAt(indexDataGrid);
                    if (idDetalle != 0)
                    {
                        if(objNegocioDatallePaquete.eliminarDetallePaquete(idDetalle))
                        {
                            if(estado)
                            objNegocioProducto.aumentarCantidad(idProducto, cantidad);
                        }
                    }
                    sumarPaquete();

                }
            }
        }

        private void btnEliminarPaquete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbPaquete.Items.Count > 0)
                {
                    if (cbEstadoPaquete.SelectedIndex == 1)
                    {
                        int idPaquete = lbPaquete.SelectedValue.ToString().ToInt();
                        objNegocioDatallePaquete.eliminarDetallePaquete(idPaquete);
                        objNegocioPaquete.eliminarPaquete(idPaquete);
                        restaurarCantidades();
                        llenarPaquete();
                    }
                    else
                    {
                        MessageBox.Show("Error: No se puede eliminar paquetes que están vendidos");
                    }
                }
                else
                {
                    MessageBox.Show("Error: No existen paquetes registrados");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No existe paquete seleccionado para eliminar");
            }
        }

        private void btnGuardarPaquete_Click(object sender, EventArgs e)
        {
            List<int> diferencia = new List<int>();
            int contadorFilas = 0;
            clsPaquete objPaqueteTemporal = new clsPaquete();
            clsDetallePaquete objDetallePaqueteTemporal = new clsDetallePaquete();
            try
            {
        if (operacion == 0)
                {
                    contadorFilas = 0;
                    objPaqueteTemporal.id_cliente = cbBusquedaCliente.SelectedValue.ToString().ToInt();
                    objPaqueteTemporal.subtotal_paquete = txtSubtotalPaquete.Text.ToDouble();
                    objPaqueteTemporal.fecha_paquete = calendarioPaquete.Value.ToString("yyyy-MM-dd");
                    objPaqueteTemporal.estado_paquete = false;

                    bool flagIngresoPaquete = false;

                    if (objNegocioPaquete.insertarPaquete(objPaqueteTemporal))
                    {

                        foreach (DataRow fila in dtDetallePaqueteLogico.Rows)
                        {
                            ultimoID = objNegocioPaquete.ultimoID();
                            objDetallePaqueteTemporal.id_paquete = ultimoID;
                            objDetallePaqueteTemporal.id_producto = fila[1].ToString().ToInt();
                            objDetallePaqueteTemporal.id_color = fila[2].ToString().ToInt();
                            objDetallePaqueteTemporal.id_tamano = fila[3].ToString().ToInt();
                            objDetallePaqueteTemporal.cantidad = fila[4].ToString().ToInt();
                            objDetallePaqueteTemporal.total_detalle = fila[5].ToString().ToDouble();
                            objDetallePaqueteTemporal.estado_detalle = bool.Parse(fila[6].ToString());
                            objDetallePaqueteTemporal.observacion_detalle_paquete = fila[7].ToString();
                            objDetallePaqueteTemporal.precio_producto = fila[8].ToString().ToDouble();
                            contadorFilas++;

                            if (objNegocioDatallePaquete.insertarDetallePaquete(objDetallePaqueteTemporal))
                            {
                                flagIngresoPaquete = true;
                            }
                            else
                            {
                                MessageBox.Show("Error al ingresar el detalle");
                                flagIngresoPaquete = false;
                                objNegocioPaquete.eliminarPaquete(ultimoID);
                            }
                        }

                        if (flagIngresoPaquete)
                        {
                            MessageBox.Show("Paquete ingresado con exito");
                        }
                    }
                }

                if (operacion == 1)
                {
                    contadorFilas = 0;
                    int idPaquete = lbPaquete.SelectedValue.ToString().ToInt();
                    objPaqueteTemporal.id_paquete = idPaquete;
                    objPaqueteTemporal.id_cliente = cbBusquedaCliente.SelectedValue.ToString().ToInt();
                    objPaqueteTemporal.subtotal_paquete = txtSubtotalPaquete.Text.ToDouble();
                    objPaqueteTemporal.fecha_paquete = calendarioPaquete.Value.ToString("yyyy-MM-dd");
                    objPaqueteTemporal.estado_paquete = false;

                    if (objNegocioPaquete.actualizarPaquete(objPaqueteTemporal))
                    {
                        diferencia = obtenerDiferencia();

                        foreach (int idDetalle in diferencia)
                        {
                            if (dtDetallePaqueteLogico.Rows[contadorFilas][0].ToString().ToInt() != 0)
                            {
                                objNegocioDatallePaquete.eliminarDetallePaqueteID(idDetalle);
                            }
                        }

                        foreach (DataRow fila in dtDetallePaqueteLogico.Rows)
                        {
                            if (fila[0].ToString().ToInt() != 0)
                            {
                                objDetallePaqueteTemporal.id_paquete = idPaquete;
                                objDetallePaqueteTemporal.id_detalle_paquete = fila[0].ToString().ToInt();
                                objDetallePaqueteTemporal.id_producto = fila[1].ToString().ToInt();
                                objDetallePaqueteTemporal.id_color = fila[2].ToString().ToInt();
                                objDetallePaqueteTemporal.id_tamano = fila[3].ToString().ToInt();
                                objDetallePaqueteTemporal.cantidad = fila[4].ToString().ToInt();
                                objDetallePaqueteTemporal.total_detalle = fila[5].ToString().ToDouble();
                                objDetallePaqueteTemporal.estado_detalle = bool.Parse(fila[6].ToString());
                                objDetallePaqueteTemporal.observacion_detalle_paquete = fila[7].ToString();
                                objDetallePaqueteTemporal.precio_producto = fila[8].ToString().ToDouble();

                                if (objNegocioDatallePaquete.actualizarDetallePaquete(objDetallePaqueteTemporal))
                                {

                                }
                                else
                                {
                                    MessageBox.Show("Error al ingresar el detalle");
                                }
                            }
                            else
                            {
                                objDetallePaqueteTemporal.id_paquete = idPaquete;
                                objDetallePaqueteTemporal.id_detalle_paquete = fila[0].ToString().ToInt();
                                objDetallePaqueteTemporal.id_producto = fila[1].ToString().ToInt();
                                objDetallePaqueteTemporal.id_color = fila[2].ToString().ToInt();
                                objDetallePaqueteTemporal.id_tamano = fila[3].ToString().ToInt();
                                objDetallePaqueteTemporal.cantidad = fila[4].ToString().ToInt();
                                objDetallePaqueteTemporal.total_detalle = fila[5].ToString().ToDouble();
                                objDetallePaqueteTemporal.estado_detalle = bool.Parse(fila[6].ToString());
                                objDetallePaqueteTemporal.observacion_detalle_paquete = fila[7].ToString();
                                objDetallePaqueteTemporal.precio_producto = fila[8].ToString().ToDouble();

                                if (objNegocioDatallePaquete.insertarDetallePaquete(objDetallePaqueteTemporal))
                                {

                                }
                                else
                                {
                                    MessageBox.Show("Error al ingresar el detalle");
                                }
                            }
                            contadorFilas++;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            bloquearPantalla();
            llenarPaquete();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int idPaquete = 0;
            int idDetallePaquete = 0; 
            int count = 0;
            DataTable dtProducto = new DataTable(); 
            clsVenta objVenta = new clsVenta();
            clsDetalleVenta objDetalleVenta = new clsDetalleVenta();
            clsNegocioVenta objNegocioVenta = new clsNegocioVenta();
            clsNegocioDetalleVenta objNegocioDetalleVenta = new clsNegocioDetalleVenta();
            clsNegocioSaldo objNegocioSaldo = new clsNegocioSaldo();
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            clsPaquete objPaqueteTemporal = new clsPaquete();
            clsSaldo objSaldo = new clsSaldo();

            try
            {
                if (lbPaquete.Items.Count > 0)
                {
                    if(dgDetallePaquete.Rows.Count > 0)
                    {
                        idPaquete = lbPaquete.SelectedValue.ToString().ToInt();

                        if (cbEstadoPaquete.SelectedIndex == 1)
                        {
                            objVenta.id_cliente = cbBusquedaCliente.SelectedValue.ToString().ToInt();
                            objVenta.fecha_venta = calendarioPaquete.Text;
                            objVenta.estado_venta = 0;
                            objVenta.subtotal_venta = txtSubtotalPaquete.Text.ToDouble();

                            if (objNegocioVenta.insertarVenta(objVenta))
                            {
                                foreach (DataRow fila in dtDetallePaqueteLogico.Rows)
                                {
                                    if (bool.Parse(fila[6].ToString()))
                                    {
                                        idDetallePaquete = dtDetallePaqueteLogicoTemporal.Rows[count][0].ToString().ToInt();
                                        int idVenta = objNegocioVenta.consultarUltimoID();
                                        objDetalleVenta.id_venta = idVenta;
                                        int id_producto = fila[1].ToString().ToInt();
                                        objDetalleVenta.id_producto = id_producto;
                                        objDetalleVenta.cantidad = fila[4].ToString().ToInt();
                                        objDetalleVenta.total_detalle = fila[5].ToString().ToDouble();
                                        objDetalleVenta.estado_detalle = true;
                                        objDetalleVenta.id_detalle_paquete = idDetallePaquete;
                                        objDetallePaquete.id_paquete = idPaquete;
                                        objDetalleVenta.id_color = fila[2].ToString().ToInt();
                                        objDetalleVenta.id_tamano = fila[3].ToString().ToInt();
                                        objDetalleVenta.observacion_detalle_venta = fila[7].ToString();

                                        objDetalleVenta.precio_producto = fila[8].ToString().ToDouble();

                                        if (objNegocioDetalleVenta.insertarDetalleVenta(objDetalleVenta))
                                        {

                                        }
                                        else
                                        {
                                            int idDetalleVenta = objNegocioDetalleVenta.ConsultarUltimoDetalleVenta();
                                            objNegocioDetalleVenta.eliminarDetalleVenta(idDetalleVenta, idVenta);
                                        }
                                    }
                                    count++;
                                }
                                objNegocioPaquete.cambiarEstadoPaquete(idPaquete);
                                objSaldo.id_cliente = cbBusquedaCliente.SelectedValue.ToString().ToInt();
                                objSaldo.saldo = txtSubtotalPaquete.Text.ToDouble();
                                objNegocioSaldo.cambiarSaldo(objSaldo, 1);
                                MessageBox.Show("Venta registrada con exito");

                            }
                            else
                            {
                                objNegocioVenta.eliminarVenta(idPaquete);

                                MessageBox.Show("Error al ingresar la venta");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Paquete ya vendido, no se puede volver a vender.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe ningun paquete seleccionado para la venta");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede vender paquete vacio");
                }
            }
            
            catch (Exception)
            {
                MessageBox.Show("Error al vender el paquete");
            }
            llenarDatosPaquete();
        }

        private static frmPaquete m_FormDefInstance;
        public static frmPaquete DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmPaquete();
                return m_FormDefInstance;

            }
            set
            {
                m_FormDefInstance = value;
            }
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

        private void dgDetallePaquete_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgDetallePaquete.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    indexCantidad = dgDetallePaquete.CurrentCell.RowIndex;

                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }

            
            if (dgDetallePaquete.CurrentCell.ColumnIndex == 7) //Desired Column
            {
                CheckBox cb = e.Control as CheckBox;
                if (cb != null)
                {
                    indexCantidad = dgDetallePaquete.CurrentCell.RowIndex;       
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgDetallePaquete_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int idProducto = 0;
            int cantidadProducto = 0;
            int antiguaCantidad = 0;
            decimal precioProducto = 0;
            bool estadoProduto = false;
            int idProductoLogico = 0;

            DataTable dtProducto = new DataTable();
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            int nuevaCantidad;

            //MessageBox.Show();
            string nuevaCantidadTexto = dgDetallePaquete[4, e.RowIndex].Value.ToString();
            int idDetalle = dgDetallePaquete[0, e.RowIndex].Value.ToString().ToInt();
            Int32.TryParse(nuevaCantidadTexto, out nuevaCantidad);
            int contador = 0;
            foreach (DataRow drDetalle in dtDetallePaqueteLogico.Rows)
            {
                if (idDetalle == drDetalle[0].ToString().ToInt())
                {

                    if (e.ColumnIndex == 4)
                    {
                        if (nuevaCantidad > 0)
                        {
                            idProducto = drDetalle[1].ToString().ToInt();
                            dtProducto = objNegocioProducto.consultarProductoId(idProducto).Tables[0];
                            cantidadProducto = dtProducto.Rows[0][7].ToString().ToInt();
                            antiguaCantidad = drDetalle[4].ToString().ToInt();
                            precioProducto = drDetalle[8].ToString().ToDouble();
                            estadoProduto = bool.Parse(drDetalle[6].ToString());
                            idProductoLogico = drDetalle[0].ToString().ToInt();

                            if (idProductoLogico != 0)
                            {
                                if (estadoProduto)
                                {
                                    if (antiguaCantidad < nuevaCantidad)
                                    {
                                        if (nuevaCantidad <= antiguaCantidad + cantidadProducto)
                                        {
                                            int cantidad = nuevaCantidad - antiguaCantidad;
                                            objNegocioProducto.disminuirCantidad(idProducto, cantidad);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Cantidad de producto no disponible");
                                            dtDetallePaqueteLogico.Rows[contador][4] = antiguaCantidad;
                                            dtDetallePaqueteLogico.Rows[contador][5] = antiguaCantidad * precioProducto;
                                            dgDetallePaquete[4, e.RowIndex].Value = antiguaCantidad;
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        int cantidad = antiguaCantidad - nuevaCantidad;
                                        objNegocioProducto.aumentarCantidad(idProducto, cantidad);
                                    }
                                    dtDetallePaqueteLogico.Rows[contador][4] = nuevaCantidad;
                                    dtDetallePaqueteLogico.Rows[contador][5] = nuevaCantidad * precioProducto;
                                    dgDetallePaquete[6, e.RowIndex].Value = nuevaCantidad * precioProducto;
                                    sumarPaquete();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede modificar la cantidad de un producto que no es parte del paquete");
                                }
                            }
                            else
                            {
                                dgDetallePaquete[4, e.RowIndex].Value = antiguaCantidad;
                                dgDetallePaquete[6, e.RowIndex].Value = nuevaCantidad * precioProducto;
                                sumarPaquete();
                                return;
                            }
                        }
                    }
                    if (e.ColumnIndex == 5)
                    {
                        precioProducto = dgDetallePaquete[5, e.RowIndex].Value.ToString().ToDouble();
                        dtDetallePaqueteLogico.Rows[contador][8] = precioProducto;
                        dtDetallePaqueteLogico.Rows[contador][5] = nuevaCantidad * precioProducto;
                        dgDetallePaquete[6, e.RowIndex].Value = nuevaCantidad * precioProducto;
                        sumarPaquete();

                    }
                }
                contador++;
            }
        }

        private void btnNoIncluirProducto_Click(object sender, EventArgs e)
        {
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();

            if (dgDetallePaquete.RowCount > 0)
            {
                indexDataGrid = dgDetallePaquete.CurrentCell.RowIndex;
                bool valor = Boolean.Parse(dtDetallePaqueteLogico.Rows[indexDataGrid][6].ToString());

                if (valor)
                {
                    int idProducto = dtDetallePaqueteLogico.Rows[indexDataGrid][1].ToString().ToInt();
                    int cantidad = dtDetallePaqueteLogico.Rows[indexDataGrid][4].ToString().ToInt();
                    dtDetallePaqueteLogico.Rows[indexDataGrid][6] = false;
                    objNegocioProducto.aumentarCantidad(idProducto, cantidad);
                    DataGridViewRow row = dgDetallePaquete.Rows[indexDataGrid];
                    row.Cells["Estado"].Value = false;
                }
            }
        }


        private void btnIncluirProducto_Click(object sender, EventArgs e)
        {
            clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
            if (dgDetallePaquete.RowCount > 0)
            {
                indexDataGrid = dgDetallePaquete.CurrentCell.RowIndex.ToString().ToInt();

                bool valor = Boolean.Parse(dtDetallePaqueteLogico.Rows[indexDataGrid][6].ToString());

                if (!valor)
                {
                    int idProducto = dtDetallePaqueteLogico.Rows[indexDataGrid][1].ToString().ToInt();
                    int cantidad = dtDetallePaqueteLogico.Rows[indexDataGrid][4].ToString().ToInt();
                    if (objNegocioProducto.disminuirCantidad(idProducto, cantidad))
                    {
                        dtDetallePaqueteLogico.Rows[indexDataGrid][6] = true;
                        DataGridViewRow row = dgDetallePaquete.Rows[indexDataGrid];
                        row.Cells["Estado"].Value = true;
                    }
                    else
                    {
                        MessageBox.Show("Cantidad no disponible del producto");
                        dgDetallePaquete[indexDataGrid, indexCantidad].Value = false;
                    }
                }
            }
        }

        private void dgDetallePaquete_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if(dgDetallePaquete.Rows.Count > 0)
                {

                    indexDataGrid = dgDetallePaquete.CurrentCell.RowIndex;
                    txtObservaciones.Text = "";
                    txtObservaciones.Text = dtDetallePaqueteLogico.Rows[indexDataGrid][7].ToString();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        private void dgDetallePaquete_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(flagConsultarObservacion)
                {
                    txtObservaciones.Text = "";
                    indexDataGrid = dgDetallePaquete.CurrentCell.RowIndex;
                    txtObservaciones.Text = dtDetallePaqueteLogico.Rows[indexDataGrid][7].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void txtObservaciones_Leave(object sender, EventArgs e)
        {
            try
            {
                dtDetallePaqueteLogico.Rows[indexDataGrid][7] = txtObservaciones.Text;
            }
            catch
            {
                throw;
            }
        }

        //private void dgDetallePaquete_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    //indexDataGrid = dgDetallePaquete.CurrentCell.RowIndex;
        //    int idDetalle = dtDetallePaqueteLogico.Rows[indexDataGrid][0].ToString());

        //    txtObservaciones.Text = objNegocioDatallePaquete.consultarObservacionDetallePaquete(idDetalle);
        //}
    }
}
