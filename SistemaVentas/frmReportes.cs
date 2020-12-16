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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte1_Click(object sender, EventArgs e)
        {
            
            DataSet dsReporte1 = new DataSet();
            clsNegocioVenta objNegocioVenta = new clsNegocioVenta();
            clsGenerarReportes objGenerarReporte = new clsGenerarReportes();
            try
            {
                String fechaDesde = calendarioDesde1.Value.ToString("yyyy-MM-dd");
                String fechaHasta = calendarioHasta1.Value.ToString("yyyy-MM-dd");
                dsReporte1 = objNegocioVenta.consultarVentasTotales(fechaDesde, fechaHasta);

                string nombreReporte = "Reporte_ventas_" + DateTime.Today.ToString("yyyyMMdd") + DateTime.Today.Hour + DateTime.Today.Minute + DateTime.Today.Second;
                nombreReporte = nombreReporte.Replace("/", "");

                if (dsReporte1.Tables[0] != null)
                {
                    objGenerarReporte.generarReporteGenerico(dsReporte1, nombreReporte);
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

        private void cbReferenciaReporte2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            mesAnteriorCalendario();
            cargarReferencia();
        }

        private void mesAnteriorCalendario()
        {
            DateTime fechaActual = DateTime.Today;
            int mes = fechaActual.AddMonths(-1).Month;
            int dia = fechaActual.Day;

            int anio = 0;
            if (fechaActual.Month == 1)
            {
                anio = fechaActual.Year - 1;
            }
            else
            {
                anio = fechaActual.Year;
            }
            calendarioDesde1.Value = DateTime.Parse(dia+"/"+mes+"/"+anio);
            calendarioDesde2.Value = DateTime.Parse(dia + "/" + mes + "/" + anio);
            calendarioDesde3.Value = DateTime.Parse(dia + "/" + mes + "/" + anio);
        }

        private void btnGenerarReporte2_Click(object sender, EventArgs e)
        {
            DataSet dsReporte2 = new DataSet();
            clsNegocioVenta objNegocioVenta = new clsNegocioVenta();
            clsGenerarReportes objGenerarReporte = new clsGenerarReportes();
            clsNegocioReferencia objNegocioReferencia = new clsNegocioReferencia();
            DataSet dsReferencia = objNegocioReferencia.consultarTodosReferencias();
            try
            {
                String fechaDesde = calendarioDesde2.Value.ToString("yyyy-MM-dd");
                String fechaHasta = calendarioHasta2.Value.ToString("yyyy-MM-dd");
                int idReferencia = int.Parse(cbReferencia2.SelectedValue.ToString()); 
                int index = 1;
                if (idReferencia == 0)
                {
                    foreach(DataRow fila in dsReferencia.Tables[0].Rows)
                    {
                        int idReferenciaInterna = int.Parse(fila[0].ToString());
                        string nombreDataTable = fila[1].ToString();
                        DataTable dtReporte2 = new DataTable(nombreDataTable);
                        dtReporte2 = objNegocioVenta.consultarVentasPendientes(fechaDesde,fechaHasta,idReferenciaInterna);
                        if(dtReporte2!=null)
                        {
                            dtReporte2.TableName = nombreDataTable;                        
                            dsReporte2.Tables.Add(dtReporte2);
                        }
                        index++;
                    }
                    
                }
                else
                {
                    DataTable dtReporte2 = new DataTable(cbReferencia2.SelectedText);
                    dtReporte2 = objNegocioVenta.consultarVentasPendientes(fechaDesde, fechaHasta, idReferencia);
                    
                    dsReporte2.Tables.Add(dtReporte2);                        
                }

                string nombreReporte = "Cuentas_por_cobrar_cliente_" + DateTime.Today.ToShortDateString() + DateTime.Today.Hour + DateTime.Today.Minute + DateTime.Today.Second;
                nombreReporte = nombreReporte.Replace("/", "");

                if (dsReporte2.Tables[0] != null)
                {
                    objGenerarReporte.generarReporteGenerico(dsReporte2, nombreReporte);
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
        private void cargarReferencia()
        {
            clsNegocioReferencia objNegocioReferencia = new clsNegocioReferencia();
            DataSet dsReferencia = objNegocioReferencia.consultarTodosReferencias();
            cbReferencia2.DataSource = dsReferencia.Tables[0];
            cbReferencia2.ValueMember = "id_referencia";
            cbReferencia2.DisplayMember = "nombre_referencia";
            cbReferencia3.DataSource = dsReferencia.Tables[0];
            cbReferencia3.ValueMember = "id_referencia";
            cbReferencia3.DisplayMember = "nombre_referencia";

            DataRow dr = dsReferencia.Tables[0].NewRow();
            dr["nombre_referencia"] = "Todos";
            dr["id_referencia"] = 0;

            dsReferencia.Tables[0].Rows.InsertAt(dr, 0);
            cbReferencia2.SelectedIndex = 0;
            cbReferencia3.SelectedIndex = 0;

        }

        private void btnGenerarReporte3_Click(object sender, EventArgs e)
        {
            DataSet dsReporte3 = new DataSet();
            clsNegocioPaquete objNegocioPaquete = new clsNegocioPaquete();
            clsGenerarReportes objGenerarReporte = new clsGenerarReportes();
            clsNegocioReferencia objNegocioReferencia = new clsNegocioReferencia();
            DataSet dsReferencia = objNegocioReferencia.consultarTodosReferencias();
            try
            {
                String fechaDesde = calendarioDesde3.Value.ToString("yyyy-MM-dd");
                String fechaHasta = calendarioHasta3.Value.ToString("yyyy-MM-dd");
                int idReferencia = int.Parse(cbReferencia3.SelectedValue.ToString()); 
                int index = 1;
                if (idReferencia == 0)
                {
                    foreach(DataRow fila in dsReferencia.Tables[0].Rows)
                    {
                        int idReferenciaInterna = int.Parse(fila[0].ToString());
                        string nombreDataTable = fila[1].ToString();
                        DataTable dtReporte3 = new DataTable(nombreDataTable);
                        if (rbEntregados.Checked)
                        {
                            dtReporte3 = objNegocioPaquete.consultarPaquetesPendientes(fechaDesde, fechaHasta, idReferenciaInterna,1);
                        }
                        else
                        {
                            dtReporte3 = objNegocioPaquete.consultarPaquetesPendientes(fechaDesde, fechaHasta, idReferenciaInterna,2);
                        }

                        if(dtReporte3!=null)
                        {
                            dtReporte3.TableName = nombreDataTable;
                            dsReporte3.Tables.Add(dtReporte3);
                        }
                        index++;
                    }
                    
                }
                else
                {
                    DataTable dtReporte3 = new DataTable(cbReferencia3.SelectedText);
                    if (rbEntregados.Checked)
                    {
                        dtReporte3 = objNegocioPaquete.consultarPaquetesPendientes(fechaDesde, fechaHasta, idReferencia,1);
                    }
                    else
                    {
                        dtReporte3 = objNegocioPaquete.consultarPaquetesPendientes(fechaDesde, fechaHasta, idReferencia,2);
                    }
                    dsReporte3.Tables.Add(dtReporte3);                        
                }

                string nombreReporte = "Detalle_paquete_" + DateTime.Today.ToShortDateString() + DateTime.Today.Hour + DateTime.Today.Minute + DateTime.Today.Second;
                nombreReporte = nombreReporte.Replace("/", "");

                if (dsReporte3.Tables[0] != null)
                {
                    objGenerarReporte.generarReporteGenerico(dsReporte3, nombreReporte);
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

        private void CalendarioFechaHasta2_ValueChanged(object sender, EventArgs e)
        {

        }        
    }
}
