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
    public partial class frmReportes : Form
    {
        DataSet dsReporte = null;
        int idCliente = 0;
        bool blCargaCompleta = false;
        public frmReportes()
        {
            InitializeComponent();
            fechaDesde.Value = DateTime.Now.AddMonths(-1);
            CargarCombos();
            CargarDetalleReporte();
        }

        private void CargarCombos()
        {
            clsNegocioCliente clsNegocioCliente = new clsNegocioCliente();
            clsNegocioReferencia objNegocioReferencia = new clsNegocioReferencia();
            try
            {
                DataSet dsClientes = clsNegocioCliente.consultarTodosClientes();
                DataSet dsReferencias = objNegocioReferencia.comboBoxReferencia();
                if(dsClientes != null)
                {
                    DataRow dr = dsClientes.Tables[0].NewRow();
                    dr["nombre_completo"] = "Todos";
                    dr["id_cliente"] = 0;

                    dsClientes.Tables[0].Rows.InsertAt(dr, 0);
                    cbBusquedaCliente.DataSource = dsClientes.Tables[0];
                    cbBusquedaCliente.ValueMember = "id_cliente";
                    cbBusquedaCliente.DisplayMember = "nombre_completo";

                    cbBusquedaCliente.SelectedIndex = 0;
                }

                if(dsReferencias != null)
                {
                    DataRow dr = dsReferencias.Tables[0].NewRow();
                    dr["nombre_referencia"] = "Todos";
                    dr["id_referencia"] = 0;

                    dsReferencias.Tables[0].Rows.InsertAt(dr, 0);
                    cbReferencia.DataSource = dsReferencias.Tables[0];
                    cbReferencia.ValueMember = "id_referencia";
                    cbReferencia.DisplayMember = "nombre_referencia";

                    cbReferencia.SelectedIndex = 0;

                }
                cbTipoReporte.SelectedIndex = 0;
                blCargaCompleta = true;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void cbClienteBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDetalleReporte();
            
            }
            catch (Exception)
            {

                MessageBox.Show("Error al generar el reporte");
            };
        }

        private void CargarDetalleReporte()
        {
            clsNegocioSaldo clsNegocioSaldo = new clsNegocioSaldo();
            clsNegocioPaquete clsNegocioPaquete = new clsNegocioPaquete();
            clsNegocioVenta clsNegocioVenta = new clsNegocioVenta();
            try
            {
                if (blCargaCompleta)
                {
                    int idReferencia = cbReferencia.SelectedValue.ToString().ToInt();
                    idCliente = cbBusquedaCliente.SelectedValue.ToString().ToInt();
                    String strFechaDesde = fechaDesde.Value.ToString("yyyy-MM-dd");
                    String strFechaHasta = fechaHasta.Value.ToString("yyyy-MM-dd");

                    if (cbBusquedaCliente.SelectedIndex == 0)
                    {
                        if (cbTipoReporte.SelectedIndex == 0)
                            dsReporte = clsNegocioSaldo.ConsultarSaldoPendienteTodo(idReferencia);
                        else if (cbTipoReporte.SelectedIndex == 1)
                            dsReporte = clsNegocioSaldo.ConsultarPagoRecibido(0, strFechaDesde, strFechaHasta, idReferencia);
                        else if (cbTipoReporte.SelectedIndex == 2)
                            dsReporte = clsNegocioPaquete.ConsultarPaqueteTodo(strFechaDesde, strFechaHasta, idReferencia);
                        else if (cbTipoReporte.SelectedIndex == 3)
                            dsReporte = clsNegocioVenta.ConsultarVentaTodo(strFechaDesde, strFechaHasta, idReferencia);
                    }
                    else
                    {
                        if (cbTipoReporte.SelectedIndex == 0)
                            dsReporte = clsNegocioSaldo.ConsultarSaldoPendiente(idCliente);
                        else if (cbTipoReporte.SelectedIndex == 1)
                            dsReporte = clsNegocioSaldo.ConsultarPagoRecibido(idCliente, strFechaDesde, strFechaHasta, idReferencia);
                        else if (cbTipoReporte.SelectedIndex == 2)
                            dsReporte = clsNegocioPaquete.ConsultarPaquete(idCliente, strFechaDesde, strFechaHasta,idReferencia);
                        else if (cbTipoReporte.SelectedIndex == 2)
                            dsReporte = clsNegocioVenta.ConsultarVenta(idCliente, strFechaDesde, strFechaHasta, idReferencia);
                    }
                    if(dsReporte.Tables.Count > 0)
                    {
                        DataTable dtDatos = dsReporte.Tables[0].Clone();
                        foreach(DataTable dt in dsReporte.Tables)
                        {
                            foreach (DataRow drTemp in dt.Rows)
                            {
                                dtDatos.ImportRow(drTemp);

                            }
                        }
                        dgReporte.DataSource = dtDatos;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al generar los reportes");
                //throw;
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            clsGenerarReportes clsGenerarReporte = new clsGenerarReportes();
            try
            {
                string nombreReporte = cbBusquedaCliente.SelectedText + DateTime.Today.ToShortDateString() + DateTime.Today.Hour + DateTime.Today.Minute + DateTime.Today.Second;
                nombreReporte = nombreReporte.Replace("/", "");

                if (dsReporte.Tables[0] != null)
                {
                    clsGenerarReporte.generarReporteGenerico(dsReporte, nombreReporte);
                }
                else
                {
                    MessageBox.Show("No existen datos para generar el reporte");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al generar el reporte, por favor compruebe que no este abierto el archivo");
            }
        }

        private static frmReportes m_FormDefInstance;
        public static frmReportes DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmReportes();
                return m_FormDefInstance;

            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void cbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDetalleReporte();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al generar el reporte");
            };
        }
    }
}
