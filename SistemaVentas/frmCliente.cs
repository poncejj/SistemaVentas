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
    public partial class frmCliente : Form
    {
        DataSet dsCliente;
        DataTable dtCliente = null;
        clsNegocioCliente objNegocioCliente = new clsNegocioCliente();
        clsNegocioReferencia objNegocioReferencia = new clsNegocioReferencia();
        int operacion = 0;
        int idCliente = 0;
        bool flagNuevo = true;
        public frmCliente()
        {
            InitializeComponent();
            cargarReferncia();
            if(dsCliente!=null)
            llenarCliente(dsCliente);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private static frmCliente m_FormDefInstance;
        public static frmCliente DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmCliente();
                return m_FormDefInstance;

            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void listarClientes()
        {
            try
            {
                cbBusquedaCliente.DataSource = null;

                clsNegocioCliente objNegocioCliente = new clsNegocioCliente();
                dtCliente = objNegocioCliente.consultarTodosClientes().Tables[0];
                cbBusquedaCliente.DataSource = dtCliente;
                cbBusquedaCliente.ValueMember = "id_cliente";
                cbBusquedaCliente.DisplayMember = "nombre_completo";
            }
            catch (Exception)
            {
            }
        }

        private void llenarCliente(DataSet dsClienteTemporal)
        {
            clsNegocioSaldo objNegocioSaldo = new clsNegocioSaldo();
            try
            {
                if (dsClienteTemporal.Tables != null)
                {
                    int idCliente = dsClienteTemporal.Tables[0].Rows[0][0].ToString().ToInt();
                    txtIdentificacionCliente.Text = dsClienteTemporal.Tables[0].Rows[0][1].ToString();
                    txtNombreCliente.Text = dsClienteTemporal.Tables[0].Rows[0][2].ToString();
                    txtApellidoCliente.Text = dsClienteTemporal.Tables[0].Rows[0][3].ToString();
                    txtTelefono1Cliente.Text = dsClienteTemporal.Tables[0].Rows[0][4].ToString();
                    txtTelefono2Cliente.Text = dsClienteTemporal.Tables[0].Rows[0][5].ToString();
                    cbReferencia.SelectedValue = dsClienteTemporal.Tables[0].Rows[0][8].ToString();
                    txtDomicilioCliente.Text = dsClienteTemporal.Tables[0].Rows[0][6].ToString();
                    txtEmailCliente.Text = dsClienteTemporal.Tables[0].Rows[0][7].ToString();
                    txtSaldo.Text = objNegocioSaldo.consultarSaldo(idCliente).ToString();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHistorialCliente_Click(object sender, EventArgs e)
        {
            if (cbBusquedaCliente.Items.Count > 0)
            {
                int idCliente = cbBusquedaCliente.SelectedValue.ToString().ToInt();
                frmVenta objVenta = new frmVenta(0, idCliente);
                objVenta.ShowDialog();
            }
            else
            {
                MessageBox.Show("No exise ningun cliente seleccionado");
            }
            
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (objNegocioCliente.eliminarCliente(cbBusquedaCliente.SelectedValue.ToString()))
                {
                    MessageBox.Show("Cliente eliminado con exito");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente");
                }
                listarClientes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No hay ningún cliente seleccionado para eliminar");
            }
        }

        public void cargarReferncia()
        {
            cbReferencia.DataSource = objNegocioReferencia.consultarTodosReferencias().Tables[0];
            cbReferencia.ValueMember = "id_referencia";
            cbReferencia.DisplayMember = "nombre_referencia";
            
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            clsCliente objCliente = new clsCliente();
            clsSaldo objSaldo = new clsSaldo();
            clsNegocioSaldo objNegocioSaldo = new clsNegocioSaldo();

            if (operacion == 0)
            {
                if(!txtNombreCliente.Text.Equals(""))
                {

                    objCliente.identiicacion_cliente = txtIdentificacionCliente.Text;
                    objCliente.nombre_cliente = txtNombreCliente.Text;
                    objCliente.apellido_cliente = txtApellidoCliente.Text;
                    objCliente.telefono1_cliente = txtTelefono1Cliente.Text;
                    objCliente.telefono2_cliente = txtTelefono2Cliente.Text;
                    try
                    {
                        objCliente.id_referencia = cbReferencia.SelectedValue.ToString().ToInt();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingrese un referencia válida por favor");
                        return;
                    }
                    objCliente.domicilio_cliente = txtDomicilioCliente.Text;
                    objCliente.email_cliente = txtEmailCliente.Text;

                    if (objNegocioCliente.insertarCliente(objCliente))
                    {
                        MessageBox.Show("Cliente ingresado con exito");
                        objSaldo.id_cliente = objNegocioCliente.consultarUltimoId();
                        objSaldo.saldo = txtSaldo.Text.ToDouble();
                        objNegocioSaldo.insertarSaldoInicial(objSaldo);
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar el Cliente");
                    }
                    llenarCliente(dsCliente);
                }                
            }
            if (operacion == 1)
            {
                objCliente.id_cliente = idCliente;
                objCliente.identiicacion_cliente = txtIdentificacionCliente.Text;
                objCliente.nombre_cliente = txtNombreCliente.Text;
                objCliente.apellido_cliente = txtApellidoCliente.Text;
                objCliente.telefono1_cliente = txtTelefono1Cliente.Text;
                objCliente.telefono2_cliente = txtTelefono2Cliente.Text;
                objCliente.id_referencia = cbReferencia.SelectedValue.ToString().ToInt();
                objCliente.domicilio_cliente = txtDomicilioCliente.Text;
                objCliente.email_cliente = txtEmailCliente.Text;
                objSaldo.id_cliente = idCliente;
                if(txtSaldo.Text=="")
                {
                    txtSaldo.Text = "0";
                }
                objSaldo.saldo = txtSaldo.Text.ToDouble();
                objNegocioSaldo.modificarSaldoInicial(objSaldo);

                if (objNegocioCliente.actualizarCliente(objCliente))
                {
                    MessageBox.Show("Cliente actualizado con exito");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el Cliente");
                
                }
                llenarCliente(dsCliente);
            }
            listarClientes();
            bloquearPantalla();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (cbBusquedaCliente.Items.Count > 0)
            {
                operacion = 1;
                desbloquearPantalla();
            }
            else
            {
                MessageBox.Show("No existe un cliente seleccionado para modificar");
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            operacion = 0;
            if (flagNuevo == false)
            {

                if (cbReferencia.Items.Count == 0)
                {
                    MessageBox.Show("No se puede agregar cliente sin una referencia ingresada");
                    bloquearPantalla();
                }
                else
                {
                    desbloquearPantalla();
                    limpiarPantalla();
                }
            }
            else
            {
                llenarCliente(dsCliente);
                bloquearPantalla();
            }
        }

        private void desbloquearPantalla()
        {          
            flagNuevo = true;
            txtApellidoCliente.ReadOnly = false;
            txtDomicilioCliente.ReadOnly = false;
            txtEmailCliente.ReadOnly = false;
            txtIdentificacionCliente.ReadOnly = false;
            txtNombreCliente.ReadOnly = false;
            txtTelefono1Cliente.ReadOnly = false;
            txtTelefono2Cliente.ReadOnly = false;
            cbBusquedaCliente.Enabled = false;
            cbReferencia.Enabled = true;
            btnBuscarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
            btnGuardarCliente.Enabled = true;
            btnHistorialCliente.Enabled = false;
            btnModificarCliente.Enabled = false;
            btnPago.Enabled = false;
            btnPagos.Enabled = false;
            btnNuevo.Text = "Cancelar";
            txtSaldo.ReadOnly = false;
        }

        private void bloquearPantalla()
        {
            flagNuevo = false;
            txtApellidoCliente.ReadOnly = true;
            txtDomicilioCliente.ReadOnly = true;
            txtEmailCliente.ReadOnly = true;
            txtIdentificacionCliente.ReadOnly = true;
            txtNombreCliente.ReadOnly = true;
            txtTelefono1Cliente.ReadOnly = true;
            txtTelefono2Cliente.ReadOnly = true;
            txtSaldo.ReadOnly = true;
            cbBusquedaCliente.Enabled = true;
            cbReferencia.Enabled = false;
            btnBuscarCliente.Enabled = true;
            btnEliminarCliente.Enabled = true;
            btnGuardarCliente.Enabled = false;
            btnHistorialCliente.Enabled = true;
            btnModificarCliente.Enabled = true;
            btnPago.Enabled = true;
            btnPagos.Enabled = true;
            btnNuevo.Text = "Nuevo";
        }

        private void limpiarPantalla()
        {
            txtApellidoCliente.Text = "";
            txtDomicilioCliente.Text = "";
            txtEmailCliente.Text = "";
            txtNombreCliente.Text = "";
            txtIdentificacionCliente.Text = "";
            txtTelefono1Cliente.Text = "";
            txtTelefono2Cliente.Text = "";
            txtSaldo.Text = "0";
            cbReferencia.SelectedIndex = 0;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            bloquearPantalla();
            listarClientes();
        }

        private void cbBusquedaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBusquedaCliente.Items.Count > 0)
            {
                if (cbBusquedaCliente.SelectedValue != null)
                {
                    string idCliente = cbBusquedaCliente.SelectedValue.ToString();

                    if (!idCliente.Equals("System.Data.DataRowView"))
                    {
                        this.idCliente = idCliente.ToInt();

                        dsCliente = objNegocioCliente.consultarClienteId(this.idCliente);
                        if (dsCliente != null)
                        {
                            llenarCliente(dsCliente);
                        }
                    }
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

        private void textbox_KeyPress_alfanum_email(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar)
                || e.KeyChar == '@' || e.KeyChar == '.')
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSaldo.Text.ToDouble() > 0)
                {
                    int idcliente = cbBusquedaCliente.SelectedValue.ToString().ToInt();
                    frmPago objPago = new frmPago(idcliente, 0);
                    objPago.ShowDialog();
                    dsCliente = objNegocioCliente.consultarClienteId(idCliente);
                    if (dsCliente != null)
                    {
                        llenarCliente(dsCliente);
                    }
                }
                else
                {
                    MessageBox.Show("No existen valores por pagar");
                }
                
            }
            catch (Exception)
            {

            }
            finally
            {
            }
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            try
            {
                int id_cliente = cbBusquedaCliente.SelectedValue.ToString().ToInt();
                frmPago objPago = new frmPago(id_cliente, 1);
                objPago.ShowDialog();
            }
            catch (Exception)
            {

            }
            finally
            {
            }
        }
        //to filter comboBox with names that contains pressed characters do in 
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cbBusquedaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            string name = cbBusquedaCliente.Text; //join previous text and new pressed char
            DataRow[] rows = dtCliente.Select("nombre_completo like  '%" + name + "%'");
            DataTable filteredTable = dtCliente.Clone();
            foreach (DataRow r in rows)
                filteredTable.ImportRow(r);
            cbBusquedaCliente.DataSource = null;
            cbBusquedaCliente.DataSource = filteredTable.DefaultView;
            cbBusquedaCliente.ValueMember = "id_cliente";
            cbBusquedaCliente.DisplayMember = "nombre_completo";
        }
    }
}
