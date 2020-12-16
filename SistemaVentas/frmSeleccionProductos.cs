using CapaNegocio;
using ModeloDatos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class frmSeleccionProductos : Form
    {
        clsNegocioProducto objNegocioProducto = new clsNegocioProducto();

        frmPaquete objPaquete;
        DataSet dsProducto;
        DataSet dsImagen;
        int idImagen = 0;
        bool flagBloqueado = true;

        public frmSeleccionProductos(frmPaquete pantalla)
        {
            InitializeComponent();
            cargarComboCategoria();
            cargarComboMarca();
            objPaquete = pantalla;
            dsProducto = objNegocioProducto.consultarProductoActivo("",0,0);
            lblCantidadProducto.Text = "Cantidad";
            cargarProducto(dsProducto);

        }

        private void cargarProducto(DataSet dsProductoTemporal)
        {
            clsNegocioCategoria objNegocioCategoria = new clsNegocioCategoria();

            try
            {
                lbProducto.DataSource = dsProductoTemporal.Tables[0];
                lbProducto.DisplayMember = "nombre_producto";
                lbProducto.ValueMember = "id_producto";
                llenarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmSeleccionProductos_Load(object sender, EventArgs e)
        {
            bloquear();
        }

        private void gbSeleccionarProducto_Enter(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                clsDetallePaquete objDetallePaquete = new clsDetallePaquete();
                objDetallePaquete.cantidad = Convert.ToInt32(cantidadProducto.Value.ToString());
                objDetallePaquete.id_producto = Convert.ToInt32(lbProducto.SelectedValue.ToString());
                if (cbColorProducto.Items.Count != 0)
                {
                    objDetallePaquete.id_color = Convert.ToInt32(cbColorProducto.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un color válido");

                    return;
                }

                if (cbTamanoProducto.Items.Count != 0)
                {
                    objDetallePaquete.id_tamano = Convert.ToInt32(cbTamanoProducto.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un tamaño válido");
                    return;

                }
                objDetallePaquete.estado_detalle = true;
                objPaquete.lista.Add(objDetallePaquete);
                objPaquete.actualizareDetalle();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarComboCategoria()
        {
            clsNegocioCategoria objNegocioCategoria = new clsNegocioCategoria();

            DataSet dsCategoriaCombo = new DataSet();
            try
            {
                dsCategoriaCombo = objNegocioCategoria.consultarCategoria("");
                DataRow filaDefault = dsCategoriaCombo.Tables[0].NewRow();
                filaDefault[0] = 0;
                filaDefault[1] = "Seleccione Categoria";
                dsCategoriaCombo.Tables[0].Rows.InsertAt(filaDefault,0);

                cbCategoriaProducto.DataSource = dsCategoriaCombo.Tables[0];
                cbCategoriaProducto.DisplayMember = "nombre_categoria";
                cbCategoriaProducto.ValueMember = "id_categoria";

                cbCategoriaProducto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargarComboColor(int id)
        {
            clsNegocioColor objNegocioColor = new clsNegocioColor();

            DataSet dsColorCombo = new DataSet();
            try
            {
                dsColorCombo = objNegocioColor.consultarColorProducto(id);

                cbColorProducto.DataSource = dsColorCombo.Tables[0];

                cbColorProducto.DisplayMember = "nombre_color";
                cbColorProducto.ValueMember = "id_color";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargarComboTamano(int id)
        {
            clsNegocioTamano objNegocioTamano = new clsNegocioTamano();
            DataSet dsTamanoCombo = new DataSet();
            try
            {
                dsTamanoCombo = objNegocioTamano.consultarTamanoProducto(id);

                cbTamanoProducto.DataSource = dsTamanoCombo.Tables[0];
                cbTamanoProducto.DisplayMember = "nombre_tamano";
                cbTamanoProducto.ValueMember = "id_tamano";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargarComboMarca()
        {
            DataSet dsMarcaCombo = new DataSet();
            clsNegocioMarca objNegocioMarca = new clsNegocioMarca();

            try
            {
                dsMarcaCombo = objNegocioMarca.consultarTodosMarcas();
                DataRow filaDefault = dsMarcaCombo.Tables[0].NewRow();
                filaDefault[0] = 0;
                filaDefault[1] = "Seleccione Marca";
                dsMarcaCombo.Tables[0].Rows.InsertAt(filaDefault, 0);

                cbMarcaProducto.DataSource = dsMarcaCombo.Tables[0];

                cbMarcaProducto.DisplayMember = "nombre_marca";
                cbMarcaProducto.ValueMember = "id_marca";

                cbMarcaProducto.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void llenarProducto()
        {
            try
            {
                cbColorProducto.DataSource = null;
                cbTamanoProducto.DataSource = null;

                DataSet dsProductoTemporal = new DataSet();
                int codigo = int.Parse(lbProducto.SelectedValue.ToString());

                dsProductoTemporal = objNegocioProducto.consultarProductoId(codigo);
                String nombre = dsProductoTemporal.Tables[0].Rows[0][1].ToString();
                double precio = double.Parse(dsProductoTemporal.Tables[0].Rows[0][2].ToString());
                int categoria = int.Parse(dsProductoTemporal.Tables[0].Rows[0][3].ToString());
                int marca = int.Parse(dsProductoTemporal.Tables[0].Rows[0][4].ToString());
                bool estado = bool.Parse(dsProductoTemporal.Tables[0].Rows[0][6].ToString());
                int cantidadDisponible = int.Parse(dsProductoTemporal.Tables[0].Rows[0][7].ToString());
                string descripcion = dsProductoTemporal.Tables[0].Rows[0][8].ToString();
                cantidadProducto.Value = 0;
                cantidadProducto.Maximum = cantidadDisponible;
                txtNombreProducto.Text = nombre;
                
                txtPrecio.Text = precio.ToString();
                txtDescripcion.Text = descripcion;
                cargarComboColor(codigo);
                cargarComboTamano(codigo);

                consultarImagen(codigo);

                if (estado == true)
                {
                    rbActivo.Checked = true;
                }
                else
                {
                    rbInactivo.Checked = true;
                }
                if (cbTamanoProducto.Items.Count > 0)
                {
                    cbTamanoProducto.Enabled = true;
                }
                else
                {
                    cbTamanoProducto.Enabled = false;
                }
                if (cbColorProducto.Items.Count > 0)
                {
                    cbColorProducto.Enabled = true;
                }
                else
                {
                    cbColorProducto.Enabled = false;
                }
            }
            catch (Exception)
            {
                // MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void llenarCategoria(int id)
        {
            clsNegocioCategoria objNegocioCategoria = new clsNegocioCategoria();
            DataSet dsCategoria = new DataSet();

            try
            {
                dsCategoria = objNegocioCategoria.consultarCategoriaId(id);
                cbCategoriaProducto.SelectedValue = int.Parse(dsCategoria.Tables[0].Rows[0][0].ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void consultarImagen(int id)
        {
            pbImagenProducto.Image = null;
            dsImagen = new DataSet();
            try
            {
                if (dsImagen != null)
                {
                    dsImagen = objNegocioProducto.consultarImagen(id);
                    byte[] imageBuffer = (byte[])dsImagen.Tables[0].Rows[0][2];
                    idImagen = int.Parse(dsImagen.Tables[0].Rows[0][0].ToString());
                    // Se crea un MemoryStream a partir de ese buffer
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                    // Se utiliza el MemoryStream para extraer la imagen
                    pbImagenProducto.Image = Image.FromStream(ms);
                }
                else
                {
                    pbImagenProducto.Image.Dispose();
                    pbImagenProducto.Image = null;
                }
            }
            catch (Exception)
            {

                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bloquear()
        {
            flagBloqueado = true;
            txtNombreProducto.Enabled = false;
            txtPrecio.Enabled = false;
            cbCategoriaProducto.Enabled = true;
            cbMarcaProducto.Enabled = true;
            txtDescripcion.Enabled = false;
            txtProductoSeleccion.Enabled = true;
            lbProducto.Enabled = true;
            cantidadProducto.Enabled = true;
            btnFotoAnteriorProducto.Enabled = true;
            btnFotoSiguienteProducto.Enabled = true;
            rbActivo.Enabled = false;
            rbInactivo.Enabled = false;
        }

        private void lbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarProducto();
        }

        private void txtProductoSeleccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dsProducto = new DataSet();
                String busqueda = txtProductoSeleccion.Text;
                int categoria = int.Parse(cbCategoriaProducto.SelectedValue.ToString());
                int marca = int.Parse(cbMarcaProducto.SelectedValue.ToString());

                dsProducto = objNegocioProducto.consultarProductoActivo(busqueda, categoria, marca);
                cargarProducto(dsProducto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dsProducto = new DataSet();
                String busqueda = txtProductoSeleccion.Text;
                int categoria = int.Parse(cbCategoriaProducto.SelectedValue.ToString());
                int marca = int.Parse(cbMarcaProducto.SelectedValue.ToString());

                dsProducto = objNegocioProducto.consultarProductoActivo(busqueda, categoria, marca);
                cargarProducto(dsProducto);
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbMarcaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dsProducto = new DataSet();
                String busqueda = txtProductoSeleccion.Text;
                int categoria = int.Parse(cbCategoriaProducto.SelectedValue.ToString());
                int marca = int.Parse(cbMarcaProducto.SelectedValue.ToString());

                dsProducto = objNegocioProducto.consultarProductoActivo(busqueda, categoria, marca);
                cargarProducto(dsProducto);
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private static frmSeleccionProductos m_FormDefInstance;
        public static frmSeleccionProductos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmSeleccionProductos(null);
                return m_FormDefInstance;

            }
            set
            {
                m_FormDefInstance = value;
            }
        }
    }
}
