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

namespace SistemaVentas
{
    public partial class frmCatalogos : Form
    {
        
        clsNegocioCategoria objNegocioCategoria = new clsNegocioCategoria();
        DataSet dsCategoria = new DataSet();
        clsNegocioColor objNegocioColor = new clsNegocioColor();
        DataSet dsColor = new DataSet();
        clsNegocioTamano objNegocioTamano = new clsNegocioTamano();
        DataSet dsTamano = new DataSet();
        clsNegocioMarca objNegocioMarca = new clsNegocioMarca();
        DataSet dsMarca = new DataSet();
        clsNegocioReferencia objNegocioReferencia = new clsNegocioReferencia();
        DataSet dsReferencia = new DataSet();

        public frmCatalogos()
        {
            InitializeComponent();
            dsCategoria = objNegocioCategoria.consultarCategoria("");
            cargarCategoria(dsCategoria);
            
            dsColor = objNegocioColor.consultarColor("");
            cargarColor(dsColor);

            dsTamano = objNegocioTamano.consultarTamano("");
            cargarTamano(dsTamano);

            dsMarca = objNegocioMarca.consultarMarca("");
            cargarMarca(dsMarca);

            dsReferencia = objNegocioReferencia.consultarReferencia("");
            cargarReferencia(dsReferencia);
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                dsCategoria = new DataSet();
                String busqueda = txtBusquedaCategoria.Text;
                dsCategoria = objNegocioCategoria.consultarCategoria(busqueda);
                cargarCategoria(dsCategoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargarCategoria(DataSet dsCategoriaTemporal)
        {
            try
            {
                lbCategoria.DataSource = dsCategoria.Tables[0];
                lbCategoria.DisplayMember = "nombre_categoria";
                lbCategoria.ValueMember = "id_categoria";
                llenarCategoria();
                
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void llenarCategoria()
        {
            try
            {
                DataSet dsCategoriaTemporal = new DataSet();
                int codigo = int.Parse(lbCategoria.SelectedValue.ToString());
                dsCategoriaTemporal = objNegocioCategoria.consultarCategoriaId(codigo);
                String nombre = dsCategoriaTemporal.Tables[0].Rows[0][1].ToString();
                String descripcion = dsCategoriaTemporal.Tables[0].Rows[0][2].ToString();
                txtNombreCategoria.Text = nombre;
                txtDescripcionCategoria.Text = descripcion;
                
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lbCategoria_Click(object sender, EventArgs e)
        {
            llenarCategoria();
        }


        private void txtBusquedaCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dsCategoria = new DataSet();
                String busqueda = txtBusquedaCategoria.Text;
                dsCategoria = objNegocioCategoria.consultarCategoria(busqueda);
                cargarCategoria(dsCategoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tpCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbCategoria.Items.Count > 0)
                {
                    if (objNegocioCategoria.eliminarCategoria(int.Parse(lbCategoria.SelectedValue.ToString())))
                    {
                        MessageBox.Show("Categoria eliminada con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la categoria");
                    }
                    dsCategoria = objNegocioCategoria.consultarCategoria("");
                    cargarCategoria(dsCategoria);
                }
                else
                {
                    MessageBox.Show("No existen Categorias para eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbCategoria.Items.Count > 0)
                {
                    clsCategoria objCategoria = new clsCategoria();
                    objCategoria.id_categoria = int.Parse(lbCategoria.SelectedValue.ToString());
                    objCategoria.nombre_categoria = txtNombreCategoria.Text;
                    objCategoria.descripcion_categoria = txtDescripcionCategoria.Text;
                   
                    if (objNegocioCategoria.actualizarCategoria(objCategoria))
                    {
                        MessageBox.Show("Categoria actualizada con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la categoria");
                    }
                    dsCategoria = objNegocioCategoria.consultarCategoria("");
                    cargarCategoria(dsCategoria);
                }
                else
                {
                    MessageBox.Show("No existe categoria para modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCategoria.Text != "")
                {
                    clsCategoria objCategoria = new clsCategoria();
                    objCategoria.nombre_categoria = txtNombreCategoria.Text;
                    objCategoria.descripcion_categoria = txtDescripcionCategoria.Text;
                   

                    if (objNegocioCategoria.insertarCategoria(objCategoria))
                    {
                        MessageBox.Show("Categoria ingresada con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar la categoria");
                    }
                    dsCategoria = objNegocioCategoria.consultarCategoria("");
                    cargarCategoria(dsCategoria);
                }
                else
                {
                    MessageBox.Show("No se puede agregar categoria vacia");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la categoria");
            }
        }

        private void lbCategoria_flechas(object sender, KeyEventArgs e)
        {
            llenarCategoria();
        }

        /*FUNCIONES PANTALLA DE COLOR*/

        private void txtBusquedaColor_TextChanged(object sender, EventArgs e)
        {
            dsCategoria = new DataSet();
            String busqueda = txtBusquedaCategoria.Text;
            dsCategoria = objNegocioCategoria.consultarCategoria(busqueda);
            cargarCategoria(dsCategoria);
        }

        private void btnBuscarColor_Click(object sender, EventArgs e)
        {
            try
            {
                dsColor = new DataSet();
                String busqueda = txtBusquedaColor.Text;
                dsColor = objNegocioColor.consultarColor(busqueda);
                cargarColor(dsColor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cargarColor(DataSet dsColorTemporal)
        {
            try
            {
                lbColor.DataSource = dsColorTemporal.Tables[0];
                lbColor.DisplayMember = "nombre_color";
                lbColor.ValueMember = "id_color";
                llenarColor();

            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lbColor_Click(object sender, EventArgs e)
        {
            llenarColor();
        }

        private void llenarColor()
        {
            try
            {
                DataSet dsColorTemporal = new DataSet();
                int codigo = int.Parse(lbColor.SelectedValue.ToString());
                dsColorTemporal = objNegocioColor.consultarColorId(codigo);
                String nombre = dsColorTemporal.Tables[0].Rows[0][1].ToString();
                txtNombreColor.Text = nombre;
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lbColor_KeyPress(object sender, KeyEventArgs e)
        {
            llenarColor();
        }

        private void txtBusquedaColor_TextChanged(object sender, KeyPressEventArgs e)
        {
            try
            {
                dsColor = new DataSet();
                String busqueda = txtBusquedaColor.Text;
                dsColor = objNegocioColor.consultarColor(busqueda);
                cargarColor(dsColor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbColor.Items.Count > 0)
                {
                    if (objNegocioColor.eliminarColor(int.Parse(lbColor.SelectedValue.ToString())))
                    {
                        MessageBox.Show("Color eliminada con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la color");
                    }
                    dsColor = objNegocioColor.consultarColor("");
                    cargarColor(dsColor);
                }
                else
                {
                    MessageBox.Show("No existen colores para eliminar");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el color");
            }
        }

        private void btnModificarColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbColor.Items.Count > 0)
                {
                    clsColor objColor = new clsColor();
                    objColor.id_color = int.Parse(lbColor.SelectedValue.ToString());
                    objColor.nombre_color = txtNombreColor.Text;
                    if (objNegocioColor.actualizarColor(objColor))
                    {
                        MessageBox.Show("Color actualizar con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la color");
                    }
                    dsColor = objNegocioColor.consultarColor("");
                    cargarColor(dsColor);
                }
                else
                {
                    MessageBox.Show("No existen colores para modificar");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar el color");
            }
        }

        private void btnAgregarColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreColor.Text != "")
                {
                    clsColor objColor = new clsColor();
                    objColor.nombre_color = txtNombreColor.Text;
                    if (objNegocioColor.insertarColor(objColor))
                    {
                        MessageBox.Show("Color actualizar con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la color");
                    }
                    dsColor = objNegocioColor.consultarColor("");
                    cargarColor(dsColor);
                }
                else
                {
                    MessageBox.Show("No se puede agregar colores vacios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /*FUNCIONES PANTALLA DE MARCA*/

        private void txtBusquedaTamano_TextChanged(object sender, EventArgs e)
        {
            dsCategoria = new DataSet();
            String busqueda = txtBusquedaCategoria.Text;
            dsCategoria = objNegocioCategoria.consultarCategoria(busqueda);
            cargarCategoria(dsCategoria);
        }

        private void btnBuscarTamano_Click(object sender, EventArgs e)
        {
            try
            {
                dsTamano = new DataSet();
                String busqueda = txtBusquedaTamano.Text;
                dsTamano = objNegocioTamano.consultarTamano(busqueda);
                cargarTamano(dsTamano);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cargarTamano(DataSet dsTamanoTemporal)
        {
            try
            {
                lbTamano.DataSource = dsTamanoTemporal.Tables[0];
                lbTamano.DisplayMember = "nombre_tamano";
                lbTamano.ValueMember = "id_tamano";
                llenarTamano();

            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lbTamano_Click(object sender, EventArgs e)
        {
            llenarTamano();
        }

        private void llenarTamano()
        {
            try
            {
                DataSet dsTamanoTemporal = new DataSet();
                int codigo = int.Parse(lbTamano.SelectedValue.ToString());
                dsTamanoTemporal = objNegocioTamano.consultarTamanoId(codigo);
                String nombre = dsTamanoTemporal.Tables[0].Rows[0][1].ToString();
                String letra = dsTamanoTemporal.Tables[0].Rows[0][2].ToString();
                txtNombreTamano.Text = nombre;
                txtLetraTamano.Text = letra;
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lbTamano_KeyPress(object sender, KeyEventArgs e)
        {
            llenarTamano();
        }

        private void txtBusquedaTamano_TextChanged(object sender, KeyPressEventArgs e)
        {
            try
            {
                dsTamano = new DataSet();
                String busqueda = txtBusquedaTamano.Text;
                dsTamano = objNegocioTamano.consultarTamano(busqueda);
                cargarTamano(dsTamano);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarTamano_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbTamano.Items.Count > 0)
                {
                    if (objNegocioTamano.eliminarTamano(int.Parse(lbTamano.SelectedValue.ToString())))
                    {
                        MessageBox.Show("Tamano eliminada con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la tamano");
                    }
                    dsTamano = objNegocioTamano.consultarTamano("");
                    cargarTamano(dsTamano);
                }
                else
                {
                    MessageBox.Show("No existen tamaños para ser eliminados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificarTamano_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbTamano.Items.Count > 0)
                {
                    clsTamano objTamano = new clsTamano();
                    objTamano.id_tamano = int.Parse(lbTamano.SelectedValue.ToString());
                    objTamano.nombre_tamano = txtNombreTamano.Text;
                    objTamano.letra_tamano = txtLetraTamano.Text;
                    if (objNegocioTamano.actualizarTamano(objTamano))
                    {
                        MessageBox.Show("Tamano actualizar con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la tamano");
                    }
                    dsTamano = objNegocioTamano.consultarTamano("");
                    cargarTamano(dsTamano);
                }
                else
                {
                    MessageBox.Show("No existen tamaños para modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregarTamano_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreTamano.Text != "")
                {
                    clsTamano objTamano = new clsTamano();
                    objTamano.nombre_tamano = txtNombreTamano.Text;
                    objTamano.letra_tamano = txtLetraTamano.Text;
                    if (objNegocioTamano.insertarTamano(objTamano))
                    {
                        MessageBox.Show("Tamano actualizar con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la tamano");
                    }
                    dsTamano = objNegocioTamano.consultarTamano("");
                    cargarTamano(dsTamano);
                }
                else
                {
                    MessageBox.Show("No se puede agregar tamaños vacios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /*FUNCIONES PANTALLA DE MARCA*/

        private void txtBusquedaMarca_TextChanged(object sender, EventArgs e)
        {
            dsCategoria = new DataSet();
            String busqueda = txtBusquedaCategoria.Text;
            dsCategoria = objNegocioCategoria.consultarCategoria(busqueda);
            cargarCategoria(dsCategoria);
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                dsMarca = new DataSet();
                String busqueda = txtBusquedaMarca.Text;
                dsMarca = objNegocioMarca.consultarMarca(busqueda);
                cargarMarca(dsMarca);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cargarMarca(DataSet dsMarcaTemporal)
        {
            try
            {
                lbMarca.DataSource = dsMarcaTemporal.Tables[0];
                lbMarca.DisplayMember = "nombre_marca";
                lbMarca.ValueMember = "id_marca";
                llenarMarca();

            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lbMarca_Click(object sender, EventArgs e)
        {
            llenarMarca();
        }

        private void llenarMarca()
        {
            try
            {
                DataSet dsMarcaTemporal = new DataSet();
                int codigo = int.Parse(lbMarca.SelectedValue.ToString());
                dsMarcaTemporal = objNegocioMarca.consultarMarcaId(codigo);
                String nombre = dsMarcaTemporal.Tables[0].Rows[0][1].ToString();
                String pais = dsMarcaTemporal.Tables[0].Rows[0][2].ToString();
                txtNombreMarca.Text = nombre;
                txtPais.Text = pais;
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lbMarca_KeyPress(object sender, KeyEventArgs e)
        {
            llenarMarca();
        }

        private void txtBusquedaMarca_TextChanged(object sender, KeyPressEventArgs e)
        {
            try
            {
                dsMarca = new DataSet();
                String busqueda = txtBusquedaMarca.Text;
                dsMarca = objNegocioMarca.consultarMarca(busqueda);
                cargarMarca(dsMarca);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbMarca.Items.Count>0)
                {
                    if (objNegocioMarca.eliminarMarca(int.Parse(lbMarca.SelectedValue.ToString())))
                    {
                        MessageBox.Show("Marca eliminada con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la marca");
                    }
                    dsMarca = objNegocioMarca.consultarMarca("");
                    cargarMarca(dsMarca);
                }
                else
                {
                    MessageBox.Show("No existen marcas para eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbMarca.Items.Count > 0)
                {
                    clsMarca objMarca = new clsMarca();
                    objMarca.id_marca = int.Parse(lbMarca.SelectedValue.ToString());
                    objMarca.nombre_marca = txtNombreMarca.Text;
                    objMarca.pais_marca = txtPais.Text;
                    if (objNegocioMarca.actualizarMarca(objMarca))
                    {
                        MessageBox.Show("Marca actualizar con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la marca");
                    }
                    dsMarca = objNegocioMarca.consultarMarca("");
                    cargarMarca(dsMarca);
                }
                else
                {
                    MessageBox.Show("No existen marcas para modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreMarca.Text != "")
                {
                    clsMarca objMarca = new clsMarca();
                    objMarca.nombre_marca = txtNombreMarca.Text;
                    objMarca.pais_marca = txtPais.Text;
                    if (objNegocioMarca.insertarMarca(objMarca))
                    {
                        MessageBox.Show("Marca actualizar con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la marca");
                    }
                    dsMarca = objNegocioMarca.consultarMarca("");
                    cargarMarca(dsMarca);
                }
                else
                {
                    MessageBox.Show("No se puede agregar marcas vacias");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /*FUNCIONES PANTALLA DE REFERENCIA*/

        private void txtBusquedaReferencia_TextChanged(object sender, EventArgs e)
        {
            dsReferencia = new DataSet();
            String busqueda = txtBusquedaReferencia.Text;
            dsReferencia = objNegocioReferencia.consultarReferencia(busqueda);
            cargarReferencia(dsReferencia);
        }

        private void btnBuscarReferencia_Click(object sender, EventArgs e)
        {
            try
            {
                dsReferencia = new DataSet();
                String busqueda = txtBusquedaReferencia.Text;
                dsReferencia = objNegocioReferencia.consultarReferencia(busqueda);
                cargarReferencia(dsReferencia);
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cargarReferencia(DataSet dsReferenciaTemporal)
        {
            try
            {
                lbReferencia.DataSource = dsReferenciaTemporal.Tables[0];
                lbReferencia.DisplayMember = "nombre_referencia";
                lbReferencia.ValueMember = "id_referencia";
                llenarReferencia();

            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lbReferencia_Click(object sender, EventArgs e)
        {
            llenarReferencia();
        }

        private void llenarReferencia()
        {
            try
            {
                DataSet dsReferenciaTemporal = new DataSet();
                int codigo = int.Parse(lbReferencia.SelectedValue.ToString());
                dsReferenciaTemporal = objNegocioReferencia.consultarReferenciaId(codigo);
                String nombre = dsReferenciaTemporal.Tables[0].Rows[0][1].ToString();
                txtNombreReferencia.Text = nombre;
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lbReferencia_KeyPress(object sender, KeyEventArgs e)
        {
            llenarReferencia();
        }

        private void txtBusquedaReferencia_TextChanged(object sender, KeyPressEventArgs e)
        {
            try
            {
                dsReferencia = new DataSet();
                String busqueda = txtBusquedaReferencia.Text;
                dsReferencia = objNegocioReferencia.consultarReferencia(busqueda);
                cargarReferencia(dsReferencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarReferencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbReferencia.Items.Count > 0)
                {
                    if (objNegocioReferencia.eliminarReferencia(int.Parse(lbReferencia.SelectedValue.ToString())))
                    {
                        MessageBox.Show("Referencia eliminada con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la referencia");
                    }
                    dsReferencia = objNegocioReferencia.consultarReferencia("");
                    cargarReferencia(dsReferencia);
                }
                else
                {
                    MessageBox.Show("No existen referencias que se pueda eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificarReferencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbReferencia.Items.Count > 0)
                {
                    clsReferencia objReferencia = new clsReferencia();
                    objReferencia.id_referencia = int.Parse(lbReferencia.SelectedValue.ToString());
                    objReferencia.nombre_referencia = txtNombreReferencia.Text;
                    if (objNegocioReferencia.actualizarReferencia(objReferencia))
                    {
                        MessageBox.Show("Referencia actualizar con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la referencia");
                    }
                    dsReferencia = objNegocioReferencia.consultarReferencia("");
                    cargarReferencia(dsReferencia);
                }
                else
                {
                    MessageBox.Show("No existen referencias para modificar");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la referencia");
            }
        }

        private void btnAgregarReferencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreReferencia.Text != "")
                {
                    clsReferencia objReferencia = new clsReferencia();
                    objReferencia.nombre_referencia = txtNombreReferencia.Text;
                    if (objNegocioReferencia.insertarReferencia(objReferencia))
                    {
                        MessageBox.Show("Referencia actualizar con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la referencia");
                    }
                    dsReferencia = objNegocioReferencia.consultarReferencia("");
                    cargarReferencia(dsReferencia);
                }
                else
                {
                    MessageBox.Show("No se puede agregar referencias vacias");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

         private static frmCatalogos m_FormDefInstance;
         public static frmCatalogos DefInstance
         {
             get
             {
                 if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                     m_FormDefInstance = new frmCatalogos();
                 return m_FormDefInstance;

             }
             set
             {
                 m_FormDefInstance = value;
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

         private void lbCategoria_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

        
    }
}
