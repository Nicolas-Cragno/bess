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
    public partial class FrmReparaciones : Form
    {
        // Carga del Form
        private List<Reparacion> listadoPendientes;
        private List<Reparacion> listadoFinalziadas;
        char ficha = 'F', agregar = 'A', modificar = 'M';
        public FrmReparaciones()
        {
            InitializeComponent();
        }

        private void FrmReparaciones_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            this.ControlBox = false; // oculta el manejo de la ventana superior
            ReparacionNegocio reparacionNegocio = new ReparacionNegocio();
            listadoPendientes = reparacionNegocio.listar(0);
            dgvReparaciones.DataSource = listadoPendientes;
            listadoFinalziadas = reparacionNegocio.listar(1);
            dgvReparacionesFinalizadas.DataSource = listadoFinalziadas;
            formatoColumnas();
        }

        // Hacia otros Forms / cerrar
        private void btnReparacionesNuevo_Click(object sender, EventArgs e)
        {
            FrmFichaReparaciones ventana = new FrmFichaReparaciones(agregar);
            ventana.ShowDialog();
            cargar();
        }

        // Formato de dgv
        private void filtrarPendientes()
        {
            List<Reparacion> listaFiltrada;
            string filtro = tbxReparacionesFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoPendientes.FindAll(rp => rp.Tipo.ToString().Contains(filtro.ToUpper()) || rp.Persona.ToString().Contains(filtro.ToUpper()) || rp.Tractor.ToString().Contains(filtro.ToUpper()) || rp.Fecha.ToString().Contains(filtro.ToUpper()) || rp.Mecanico.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoPendientes;
            }

            dgvReparaciones.DataSource = null;
            dgvReparaciones.DataSource = listaFiltrada;
            formatoColumnas();
        }

        private void filtrarFinalziadas()
        {
            List<Reparacion> listaFiltrada;
            string filtro = tbxReparacionesFinalizadasFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoPendientes.FindAll(rp => rp.Tipo.ToString().Contains(filtro.ToUpper()) || rp.Persona.ToString().Contains(filtro.ToUpper()) || rp.Tractor.ToString().Contains(filtro.ToUpper()) || rp.Fecha.ToString().Contains(filtro.ToUpper()) || rp.Mecanico.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoPendientes;
            }

            dgvReparacionesFinalizadas.DataSource = null;
            dgvReparacionesFinalizadas.DataSource = listaFiltrada;
            formatoColumnas();
        }
        private void tbxReparacionesFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarPendientes();
        }
        private void tbxReparacionesFinalizadasFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarFinalziadas();
        }
        private void dgvReparaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Reparacion seleccion = (Reparacion)dgvReparaciones.CurrentRow.DataBoundItem;

            //FrmFichaReparaciones fichaReparacion = new FrmFichaReparaciones(ficha, seleccion);
            //fichaReparacion.ShowDialog();
            FrmHistoriaReparacion historiaReparacion = new FrmHistoriaReparacion(seleccion);
            historiaReparacion.ShowDialog();
            cargar();
        }
        private void dgvReparacionesFinalizadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Reparacion seleccion = (Reparacion)dgvReparacionesFinalizadas.CurrentRow.DataBoundItem;

            FrmHistoriaReparacion historiaReparacion = new FrmHistoriaReparacion(seleccion);
            historiaReparacion.ShowDialog();
            cargar();
        }

        private void formatoColumnas()
        {
            ocultarColumnas();
            nombrarColumnas();
            anchoColumnas();
            ordenarColumnas();
        }

        private void ocultarColumnas()
        {
            dgvReparaciones.Columns["Id"].Visible = false;
            dgvReparaciones.Columns["Detalle"].Visible = false;
            dgvReparaciones.Columns["Estado"].Visible = false;
            dgvReparaciones.Columns["TipoVehiculo"].Visible = false;
            dgvReparaciones.Columns["Furgon"].Visible = false;
            dgvReparaciones.Columns["InternoAfectado"].Visible = false;
            dgvReparaciones.Columns["Persona"].Visible = false;
            dgvReparaciones.Columns["FechaFin"].Visible = false;

            dgvReparacionesFinalizadas.Columns["Id"].Visible = false;
            dgvReparacionesFinalizadas.Columns["Detalle"].Visible = false;
            dgvReparacionesFinalizadas.Columns["Estado"].Visible = false;
            dgvReparacionesFinalizadas.Columns["TipoVehiculo"].Visible = false;
            dgvReparacionesFinalizadas.Columns["Furgon"].Visible = false;
            dgvReparacionesFinalizadas.Columns["InternoAfectado"].Visible = false;
            dgvReparacionesFinalizadas.Columns["Persona"].Visible = false;
        }

        private void anchoColumnas()
        {
            dgvReparaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReparaciones.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvReparaciones.Columns)
            {
                column.Width += 15;
            }
            dgvReparaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvReparacionesFinalizadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReparacionesFinalizadas.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvReparacionesFinalizadas.Columns)
            {
                column.Width += 15;
            }
            dgvReparacionesFinalizadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        private void ordenarColumnas()
        {
            dgvReparaciones.Columns["Fecha"].DisplayIndex = 0;
            dgvReparaciones.Columns["Tipo"].DisplayIndex = 1;
            dgvReparaciones.Columns["Mecanico"].DisplayIndex = 2;
            dgvReparaciones.Columns["Tractor"].DisplayIndex = 3;

            dgvReparacionesFinalizadas.Columns["Fecha"].DisplayIndex = 0;
            dgvReparacionesFinalizadas.Columns["Tipo"].DisplayIndex = 1;
            dgvReparacionesFinalizadas.Columns["Mecanico"].DisplayIndex = 2;
            dgvReparacionesFinalizadas.Columns["Tractor"].DisplayIndex = 3;
            dgvReparacionesFinalizadas.Columns["FechaFin"].DisplayIndex = 4;

        }
        private void nombrarColumnas()
        {
            dgvReparaciones.Columns["Fecha"].HeaderText = "FECHA";
            dgvReparaciones.Columns["Tipo"].HeaderText = "TRABAJO";
            dgvReparaciones.Columns["Mecanico"].HeaderText = "MECANICO";
            dgvReparaciones.Columns["Tractor"].HeaderText = "TRACTOR";

            dgvReparacionesFinalizadas.Columns["Fecha"].HeaderText = "FECHA";
            dgvReparacionesFinalizadas.Columns["Tipo"].HeaderText = "TRABAJO";
            dgvReparacionesFinalizadas.Columns["Mecanico"].HeaderText = "MECANICO";
            dgvReparacionesFinalizadas.Columns["Tractor"].HeaderText = "TRACTOR";
            dgvReparacionesFinalizadas.Columns["FechaFin"].HeaderText = "FINALIZACION";
        }
    }
}
