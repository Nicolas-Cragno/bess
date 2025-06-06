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
        private Reparacion reparacion;
        private List<UsoStock> listaRepuestos;
        int activo = 1, choferL = 1, mecanico = 3;
        char modo; 

        // Cargas
        public FrmHistoriaReparacion(Reparacion hReparacion, char rModo = 'F')
        {
            InitializeComponent();
            reparacion = hReparacion;
            modo = rModo;
        }
        private void cargar()
        {
            tabulaciones();
            this.ControlBox = false; // oculta el manejo de la ventana superior
            AccesoDatos datos = new AccesoDatos();
            UsoStockNegocio usoStockNegocio = new UsoStockNegocio();
            lblHistoriaReparacionTitulo.Text = reparacion.Fecha.ToString("dd/MM/yyyy");
            cbxHistoriaReparacionTipo.Text = reparacion.TipoVehiculo;
            cbxHistoriaReparacionInt.Text = reparacion.InternoAfectado.ToString();
            cbxHistoriaReparacionTipoTrabajo.Text = reparacion.Tipo;
            cbxHistoriaReparacionChofer.Text = reparacion.Persona;
            cbxHistoriaReparacionMecanico.Text = reparacion.Mecanico;
            tbxHistoriaReparacionDetalle.Text = reparacion.Detalle;

            switch (modo)
            {
                case 'P': // Pendiente
                    btnHistoriaReparacionFinalizar.Visible = true;
                    lblHistoriaReparacionEstado.Text = "Pendiente.";
                    break;
                case 'F': // Finalizado
                    btnHistoriaReparacionFinalizar.Visible = false;
                    lblHistoriaReparacionEstado.Text = "Finalizado el " + reparacion.Fecha.ToString("dd/MM/yyyy") +".";
                    break;
                default:
                    break;
            }

            listaRepuestos = usoStockNegocio.listar(reparacion.Id);
            dgvHistoriaReparacionRepuestos.DataSource = listaRepuestos;
            formatoColumnas();
        }
        private void tabulaciones()
        {
            cbxHistoriaReparacionTipo.TabIndex = 0;
            cbxHistoriaReparacionInt.TabIndex = 1;
            cbxHistoriaReparacionTipoTrabajo.TabIndex = 2;
            cbxHistoriaReparacionChofer.TabIndex = 3;
            cbxHistoriaReparacionMecanico.TabIndex = 4;
            tbxHistoriaReparacionDetalle.TabIndex = 5;
            dgvHistoriaReparacionRepuestos.TabIndex = 6;
            btnHistoriaReparacionOK.TabIndex = 7;
            btnHistoriaReparacionFinalizar.TabIndex = 8;
            btnHistoriaReparacionCerrar.TabIndex = 9;
        }

        // Data Grid View
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

        // Acciones
        private void btnHistoriaReparacionCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmHistoriaReparacion_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void btnHistoriaReparacionFinalizar_Click(object sender, EventArgs e)
        {
            FrmFinalizar ventanaFinalizar = new FrmFinalizar(reparacion.Id);
            ReparacionNegocio reparacionNegocio = new ReparacionNegocio();
            ventanaFinalizar.ShowDialog();
            if(reparacionNegocio.verificarEstado(reparacion.Id))
            {
                modo = 'F';
                cargar();
            }
        }
        private void btnHistoriaReparacionOK_Click(object sender, EventArgs e)
        {
            FrmFichaReparaciones editarReparacion = new FrmFichaReparaciones('M', reparacion);
            editarReparacion.ShowDialog();
        }
    }
}
