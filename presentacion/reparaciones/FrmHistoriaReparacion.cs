using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion.reparaciones
{
    public partial class FrmHistoriaReparacion : Form
    {
        // Carga del Form
        private Reparacion reparacion;
        private List<UsoStock> listaRepuestos;
        int activo = 1, choferL = 1, mecanico = 3;
        public FrmHistoriaReparacion(Reparacion hReparacion)
        {
            InitializeComponent();
            reparacion = hReparacion;
        }

        private void btnHistoriaReparacionCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmHistoriaReparacion_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            AccesoDatos datos = new AccesoDatos();
            UsoStockNegocio usoStockNegocio = new UsoStockNegocio();
            cbxHistoriaReparacionTipo.Text = reparacion.TipoVehiculo;
            cbxHistoriaReparacionInt.Text = reparacion.InternoAfectado.ToString();
            cbxHistoriaReparacionTipoTrabajo.Text = reparacion.Tipo;
            cbxHistoriaReparacionChofer.Text = reparacion.Persona;
            cbxHistoriaReparacionMecanico.Text = reparacion.Mecanico;
            lblHistoriaReparacionInicioFecha.Text = reparacion.Fecha.Date.ToString("dd/MM/yyyy");
            lblHistoriaReparacionInicioHora.Text = reparacion.Fecha.ToString("HH:mm");
            lblHistoriaReparacionFinFecha.Text = reparacion.FechaFin.Date.ToString("dd/MM/yyyy");
            lblHistoriaReparacionFinHora.Text = reparacion.FechaFin.ToString("HH:mm");
            tbxHistoriaReparacionDetalle.Text = reparacion.Detalle;

            listaRepuestos = usoStockNegocio.listar(reparacion.Id);
            dgvHistoriaReparacionRepuestos.DataSource = listaRepuestos;
            formatoColumnas();
        }

        private void formatoColumnas() 
        {
            ocultarColumnas();
            nombrarColumnas();
            anchoColumnas();
        }

        private void ocultarColumnas()
        {
           dgvHistoriaReparacionRepuestos.Columns["Id"].Visible = false;
           dgvHistoriaReparacionRepuestos.Columns["Reparacion"].Visible = false;
        }

        private void nombrarColumnas()
        {
            dgvHistoriaReparacionRepuestos.Columns["Articulo"].HeaderText = "REPUESTO";
            dgvHistoriaReparacionRepuestos.Columns["Cantidad"].HeaderText = "CANT";
            dgvHistoriaReparacionRepuestos.Columns["Unidad"].HeaderText = "U. M.";
        }

        private void anchoColumnas()
        {
            dgvHistoriaReparacionRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHistoriaReparacionRepuestos.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvHistoriaReparacionRepuestos.Columns)
            {
                column.Width += 15;
            }
            dgvHistoriaReparacionRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
    }
}
