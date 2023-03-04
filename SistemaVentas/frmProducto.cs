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
    public partial class frmProducto : Form
    {
        clsNegocioProducto objNegocioProducto = new clsNegocioProducto();
        List<object> listaImagenes = new List<object>();
        List<int> listaColores = new List<int>();
        List<int> listaTamanos = new List<int>();

        DataSet dsProducto;
        DataSet dsImagen;
        int idImagen = 0;
        int indexImagen = 0;
        int idPanel = 0;
        int operacion = 0;
        bool flagBloqueado = true;

        public frmProducto()
        {
            InitializeComponent();
            cargarComboCategoria();
            cargarComboMarca();
            dsProducto = objNegocioProducto.consultarProducto("");
            lblCantidadProducto.Text = "Disponible";
            btnNuevo.Visible = true;

            cargarProducto(dsProducto);

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            bloquear();
                       
        }

        private void cargarComboCategoria()
        {
            clsNegocioCategoria objNegocioCategoria = new clsNegocioCategoria();

            DataSet dsCategoriaCombo = new DataSet();
            try
            {
                dsCategoriaCombo = objNegocioCategoria.consultarCategoria("");

                cbCategoriaProducto.DataSource = dsCategoriaCombo.Tables[0];

                cbCategoriaProducto.DisplayMember = "nombre_categoria";
                cbCategoriaProducto.ValueMember = "id_categoria";
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

                cbMarcaProducto.DataSource = dsMarcaCombo.Tables[0];

                cbMarcaProducto.DisplayMember = "nombre_marca";
                cbMarcaProducto.ValueMember = "id_marca";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
        
        private void llenarProducto()
        {
            try
            {
                cbColorProducto.DataSource = null;
                cbTamanoProducto.DataSource = null;

                DataSet dsProductoTemporal = new DataSet();
                int idProducto = lbProducto.SelectedValue.ToString().ToInt();
                
                 dsProductoTemporal = objNegocioProducto.consultarProductoId(idProducto);
                String nombre = dsProductoTemporal.Tables[0].Rows[0][1].ToString();
                decimal precio = dsProductoTemporal.Tables[0].Rows[0][2].ToString().ToDouble();
                int idCategoria = dsProductoTemporal.Tables[0].Rows[0][3].ToString().ToInt();
                int idMarca = dsProductoTemporal.Tables[0].Rows[0][4].ToString().ToInt();
                bool estado =bool.Parse(dsProductoTemporal.Tables[0].Rows[0][6].ToString());
                int cantidadDisponible = dsProductoTemporal.Tables[0].Rows[0][7].ToString().ToInt();
                string descripcion = dsProductoTemporal.Tables[0].Rows[0][8].ToString();
                
                cantidadProducto.Maximum = 9999;
                cantidadProducto.Minimum = 0;
                cantidadProducto.Value = cantidadDisponible;
                
                txtNombreProducto.Text = nombre;
                cbMarcaProducto.SelectedValue = idMarca;
                llenarCategoria(idCategoria);
                txtPrecio.Text = precio.ToString();
                txtDescripcion.Text = descripcion;
                cargarComboColor(idProducto);
                cargarComboTamano(idProducto);
                consultarImagen(idProducto);
                
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
                cbCategoriaProducto.SelectedValue = dsCategoria.Tables[0].Rows[0][0].ToString().ToInt();

            }catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
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
                    idImagen = dsImagen.Tables[0].Rows[0][0].ToString().ToInt();
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

        private void desbloquear()
        {
            flagBloqueado = false;
            txtNombreProducto.Enabled = true;
            txtPrecio.Enabled = true;
            cbCategoriaProducto.Enabled = true;
            cbMarcaProducto.Enabled = true;
            txtDescripcion.Enabled = true;
            btnNuevo.Text = "Cancelar";
            btnEliminarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;
            btnGuardarProducto.Enabled = true;
            btnAgregarFotoProducto.Enabled = true;
            btnEliminarFotoProducto.Enabled = true;
            btnFotoSiguienteProducto.Enabled = true;
            btnFotoAnteriorProducto.Enabled = true;
            cantidadProducto.Enabled = true;
            rbActivo.Enabled = true;
            rbInactivo.Enabled = true;
            txtProductoSeleccion.Enabled = false;
            lbProducto.Enabled = false;

        }

        private void bloquear()
        {
            flagBloqueado = true;
            txtNombreProducto.Enabled = false;
            txtPrecio.Enabled = false;
            cbCategoriaProducto.Enabled = false;
            cbMarcaProducto.Enabled = false;
            txtDescripcion.Enabled = false;
            btnNuevo.Text = "Nuevo";
            btnEliminarProducto.Enabled = true;
            btnModificarProducto.Enabled = true;
            btnGuardarProducto.Enabled = false;
            btnAgregarFotoProducto.Enabled = false;
            btnEliminarFotoProducto.Enabled = false;
            txtProductoSeleccion.Enabled = true;
            lbProducto.Enabled = true;
            cantidadProducto.Enabled = false;
            btnFotoAnteriorProducto.Enabled = true;
            btnFotoSiguienteProducto.Enabled = true;
            
            rbActivo.Enabled = false;
            rbInactivo.Enabled = false;
        }

        private void limpiarPantalla()
        {
            try
            {
                cantidadProducto.Value = 0;
                txtNombreProducto.Text = "";
                txtPrecio.Text = "";
                txtDescripcion.Text = "";
                if (cbCategoriaProducto.Items != null)
                {
                    cbCategoriaProducto.SelectedIndex = 0;

                }

              
                if (cbMarcaProducto.Items != null)
                {
                    cbMarcaProducto.SelectedIndex = 0;

                }
                cbColorProducto.DataSource = null;
                cbTamanoProducto.DataSource = null;
                pbImagenProducto.Image = null;
            }
            catch (Exception)
            {
            }
            
        }

        private void llenarCheckBoxListColor()
        {
            int idProducto = 0;
            int contador = 0;
            clsNegocioColor objColor = new clsNegocioColor();
            DataTable dtColor = objColor.consultarTodosColores().Tables[0];

            idPanel = 0;
            chkLista.DataSource = null;
            try
            {
                if (operacion == 1)
                {
                    idProducto = lbProducto.SelectedValue.ToString().ToInt();

                    DataTable dtColorProducto = objColor.consultarColorProducto(idProducto).Tables[0];

                    chkLista.DataSource = dtColor;
                    chkLista.DisplayMember = "nombre_color";
                    chkLista.ValueMember = "id_color";

                    foreach (DataRow filaColor in dtColor.Rows)
                    {
                        foreach (DataRow filaColorProducto in dtColorProducto.Rows)
                        {
                            if (filaColor[0].ToString() == filaColorProducto[0].ToString())
                            {
                                chkLista.SetItemCheckState(contador, CheckState.Checked);
                            }
                        }
                        contador++;
                    }
                }
                if (operacion == 0)
                {
                    chkLista.DataSource = dtColor;
                    chkLista.DisplayMember = "nombre_color";
                    chkLista.ValueMember = "id_color";
                }
            }
            catch (Exception)
            {
            }
        }

        private void llenarCheckBoxListTamano()
        {
            idPanel = 1;
            int contador = 0;
            clsNegocioTamano objTamano = new clsNegocioTamano();
            DataTable dtTamano = objTamano.consultarTodosTamanos().Tables[0];
            chkLista.DataSource = null;
            if (operacion == 1)
            {
                int idProducto = lbProducto.SelectedValue.ToString().ToInt();
                DataTable dtTamanoProducto = objTamano.consultarTamanoProducto(idProducto).Tables[0];

                chkLista.DataSource = dtTamano;
                chkLista.DisplayMember = "nombre_tamano";
                chkLista.ValueMember = "id_tamano";

                foreach (DataRow filaTamano in dtTamano.Rows)
                {
                    foreach (DataRow filaTamanoProducto in dtTamanoProducto.Rows)
                    {
                        if (filaTamano[0].ToString() == filaTamanoProducto[1].ToString())
                        {
                            chkLista.SetItemCheckState(contador, CheckState.Checked);
                        }
                    }
                    contador++;
                }
            }
            if (operacion == 0)
            {
                chkLista.DataSource = dtTamano;
                chkLista.DisplayMember = "nombre_tamano";
                chkLista.ValueMember = "id_tamano";
            }
        }

        private void cbCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtProductoSeleccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dsProducto = new DataSet();
                String busqueda = txtProductoSeleccion.Text;
                dsProducto = objNegocioProducto.consultarProducto(busqueda);
                cargarProducto(dsProducto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregarFotoProducto_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pbImagenProducto.Image = Image.FromFile(dialog.FileName);
                int id = lbProducto.SelectedValue.ToString().ToInt();

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pbImagenProducto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                objNegocioProducto.insertarImagen(id, ms.GetBuffer());
            }
        }

        private void btnEliminarFotoProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (objNegocioProducto.eliminarImagen(idImagen))
                {
                    dsImagen = objNegocioProducto.consultarImagen(lbProducto.SelectedValue.ToString().ToInt());
                }
            }
            catch (Exception)
            {
            }
        }

        
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacion == 0)
                {
                    clsProducto objProducto = new clsProducto();
                    clsNegocioColor objNegocioColor = new clsNegocioColor();
                    clsNegocioTamano objNegocioTamano = new clsNegocioTamano();

                    objProducto.nombre_producto = txtNombreProducto.Text;
                    objProducto.id_categoria = cbCategoriaProducto.SelectedValue.ToString().ToInt();
                    objProducto.id_marca = cbMarcaProducto.SelectedValue.ToString().ToInt();
                    if (txtPrecio.Text == "")
                        txtPrecio.Text = "0";
                    else
                    objProducto.precio_producto = txtPrecio.Text.ToDouble();
                    objProducto.cantidad = cantidadProducto.Value.ToString().ToInt();
                    objProducto.descripcion = txtDescripcion.Text;
                    if (rbActivo.Checked)
                        objProducto.estado_producto = true;
                    if (rbInactivo.Checked)
                        objProducto.estado_producto = false;
                    if(listaColores.Count == 0)
                    {
                        MessageBox.Show("Por favor seleccione un color para este producto");
                        return;
                    }

                    if (listaTamanos.Count == 0)
                    {
                        MessageBox.Show("Por favor seleccione un tamaño para este producto");
                        return;
                    }
                    if (objNegocioProducto.insertarProducto(objProducto))
                    {
                        int idUltimoProducto = objNegocioProducto.consultarUltimoProducto();
                        
                        if(listaColores.Count > 0)
                        {
                            foreach (int color in listaColores)
                            {
                                objNegocioColor.insertarColorProducto(idUltimoProducto, color);
                            }
                        }
                        

                        if (listaTamanos.Count > 0)
                        {
                            foreach (int tamano in listaTamanos)
                            {
                                objNegocioTamano.insertarTamanoProducto(idUltimoProducto, tamano);
                            }
                        }
                        
                        MessageBox.Show("Producto creado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al crear la producto");
                        return;
                    }
                    dsProducto = objNegocioProducto.consultarProducto("");
                    cargarProducto(dsProducto);
                }
                if (operacion == 1)
                {
                    clsProducto objProducto = new clsProducto();
                    objProducto.id_producto = lbProducto.SelectedValue.ToString().ToInt();
                    objProducto.nombre_producto = txtNombreProducto.Text;
                    objProducto.id_categoria = cbCategoriaProducto.SelectedValue.ToString().ToInt();
                    objProducto.id_marca = cbMarcaProducto.SelectedValue.ToString().ToInt();
                    objProducto.precio_producto = txtPrecio.Text.ToDouble();
                    objProducto.cantidad = cantidadProducto.Value.ToString().ToInt();
                    objProducto.descripcion = txtDescripcion.Text;
                    if (rbActivo.Checked)
                        objProducto.estado_producto = true;
                    if (rbInactivo.Checked)
                        objProducto.estado_producto = false;

                    if (objNegocioProducto.actualizarProducto(objProducto))
                    {
                        MessageBox.Show("Producto actualizado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la producto");
                        return;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            limpiarPantalla();
            bloquear();
            dsProducto = objNegocioProducto.consultarProducto("");
            cargarProducto(dsProducto);
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbProducto.Items.Count > 0)
                {
                    cantidadProducto.Maximum = 9999;
                    operacion = 1;
                    desbloquear();
                }
                else
                {
                    MessageBox.Show("No existen productos para modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbProducto.Items.Count > 0)
                {
                    limpiarPantalla();
                    if (objNegocioProducto.eliminarProducto(lbProducto.SelectedValue.ToString().ToInt()))
                    {
                        MessageBox.Show("Producto eliminado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto");
                    }
                }
                else
                {
                    MessageBox.Show("No eixsten productos para eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            dsProducto = objNegocioProducto.consultarProducto("");
            cargarProducto(dsProducto);
        }

        private void lbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarProducto();
        }

        private void btnGuardarPanel_Click(object sender, EventArgs e)
        {
            //listaColores = new List<int>();
            //listaTamanos = new List<int>();
            clsNegocioColor objNegocioColor = new clsNegocioColor();
            clsNegocioTamano objNegocioTamano = new clsNegocioTamano();

            if (operacion == 1)
            {
                int idProducto = lbProducto.SelectedValue.ToString().ToInt();

                if (idPanel == 0)
                {
                    DataTable dtColor = objNegocioColor.consultarTodosColores().Tables[0];
                    objNegocioColor.eliminarColorProducto(idProducto);
                    for (int i = 0; i < chkLista.Items.Count; i++)
                    {
                        if (chkLista.GetItemChecked(i))
                        {
                            int idColor = dtColor.Rows[i][0].ToString().ToInt();
                            objNegocioColor.insertarColorProducto(idProducto, idColor);
                        }
                    }
                }
                if (idPanel == 1)
                {
                    DataTable dtTamano = objNegocioTamano.consultarTodosTamanos().Tables[0];
                    objNegocioTamano.eliminarTamanoProducto(idProducto);
                    for (int i = 0; i < chkLista.Items.Count; i++)
                    {
                        if (chkLista.GetItemChecked(i))
                        {
                            int idTamano = dtTamano.Rows[i][0].ToString().ToInt();
                            objNegocioTamano.insertarTamanoProducto(idProducto, idTamano);
                        }
                    }
                }
            }

            if (operacion == 0)
            {
                if (idPanel == 0)
                {
                    DataTable dtColor = objNegocioColor.consultarTodosColores().Tables[0];
                    for (int i = 0; i < chkLista.Items.Count; i++)
                    {
                        if (chkLista.GetItemChecked(i))
                        {
                            int idColor = dtColor.Rows[i][0].ToString().ToInt();
                            listaColores.Add(idColor);
                        }
                    }
                }
                if (idPanel == 1)
                {
                    DataTable dtTamano = objNegocioTamano.consultarTodosTamanos().Tables[0];
                    for (int i = 0; i < chkLista.Items.Count; i++)
                    {
                        if (chkLista.GetItemChecked(i))
                        {
                            int idTamano = dtTamano.Rows[i][0].ToString().ToInt();
                            listaTamanos.Add(idTamano);
                        }
                    }
                }
            }

            panelSeleccion.Visible = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                listaColores = new List<int>();
                listaTamanos = new List<int>();
                clsNegocioColor objNegocioColor = new clsNegocioColor();
                clsNegocioTamano objNegocioTamano = new clsNegocioTamano();
                clsNegocioCategoria objNegocioCategoria = new clsNegocioCategoria(); 

                operacion = 0;
                if (flagBloqueado == true)
                {
                    limpiarPantalla();
                    desbloquear();
                    if (objNegocioCategoria.consultarCategoria("").Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No se puede crear productos porque no existe categorias creadas");
                        bloquear();
                    }
                    else
                    {
                        cbCategoriaProducto.SelectedIndex = 0;
                    }
                    if (cbMarcaProducto.Items.Count == 0)
                    {
                        MessageBox.Show("No se puede crear productos porque no existe marcas creadas creadas");
                        bloquear();
                    }
                    if (objNegocioColor.consultarTodosColores().Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No se puede crear productos porque no existen colores creados");
                        bloquear();
                    }
                    if (objNegocioTamano.consultarTodosTamanos().Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No se puede crear productos porque no existen tamaños creados");
                        bloquear();
                    }
                }
                else
                {
                    bloquear();
                    int idProduto = lbProducto.SelectedValue.ToString().ToInt();
                    llenarProducto();
                }
            }
            catch (Exception)
            {
            }
        }

        private void lblTamanoProducto_DoubleClick(object sender, EventArgs e)
        {
            if (flagBloqueado==false)
            {
                panelSeleccion.Visible = true;
                llenarCheckBoxListTamano();
            }
        }

        private void btnFotoSiguienteProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsImagen != null)
                {

                    if (dsImagen.Tables[0].Rows.Count > indexImagen + 1)
                    {
                        indexImagen = indexImagen + 1;
                        byte[] imageBuffer = (byte[])dsImagen.Tables[0].Rows[indexImagen][2];
                        idImagen = dsImagen.Tables[0].Rows[indexImagen][0].ToString().ToInt();
                        // Se crea un MemoryStream a partir de ese buffer
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        // Se utiliza el MemoryStream para extraer la imagen
                        pbImagenProducto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbImagenProducto.Image = null;
                }
            }
            catch (Exception)
            {

                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnFotoAnteriorProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsImagen != null)
                {

                    if (0 >= indexImagen - 1)
                    {
                        indexImagen = indexImagen - 1;
                        byte[] imageBuffer = (byte[])dsImagen.Tables[0].Rows[indexImagen][2];
                        idImagen = dsImagen.Tables[0].Rows[indexImagen][0].ToString().ToInt();
                        // Se crea un MemoryStream a partir de ese buffer
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        // Se utiliza el MemoryStream para extraer la imagen
                        pbImagenProducto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbImagenProducto.Image = null;
                }
            }
            catch (Exception)
            {

                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblColorProducto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (flagBloqueado==false)
            {
                panelSeleccion.Visible = true;
                llenarCheckBoxListColor();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelarPanel_Click(object sender, EventArgs e)
        {
            panelSeleccion.Visible = false;
        }

        private static frmProducto m_FormDefInstance;
        public static frmProducto DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmProducto();
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

        private void textbox_KeyPress_number(object sender, KeyPressEventArgs e)
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
    }
}
