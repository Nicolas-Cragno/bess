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
        private List<Reparacion> listadoReparaciones;
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
            ReparacionNegocio reparacionNegocio = new ReparacionNegocio();
            listadoReparaciones = reparacionNegocio.listar();
            dgvReparaciones.DataSource = listadoReparaciones;
            nombrarColumnas();
            ocultarColumnas();
            ordenarColumnas();
            anchoColumnas();
        }

        private void ocultarColumnas()
        {
            dgvReparaciones.Columns["Id"].Visible = false;
            dgvReparaciones.Columns["Detalle"].Visible = false;
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
        }

        private void ordenarColumnas()
        {
            dgvReparaciones.Columns["Fecha"].DisplayIndex = 0;
            dgvReparaciones.Columns["Tipo"].DisplayIndex = 1;
            dgvReparaciones.Columns["Mecanico"].DisplayIndex = 2;
            dgvReparaciones.Columns["Tractor"].DisplayIndex = 3;
            dgvReparaciones.Columns["Furgon"].DisplayIndex = 4;
            dgvReparaciones.Columns["Persona"].DisplayIndex = 5;
        }

        private void nombrarColumnas()
        {
            dgvReparaciones.Columns["Fecha"].HeaderText = "FECHA";
            dgvReparaciones.Columns["Tipo"].HeaderText = "TRABAJO";
            dgvReparaciones.Columns["Mecanico"].HeaderText = "MECANICO";
            dgvReparaciones.Columns["Tractor"].HeaderText = "TRACTOR";
            dgvReparaciones.Columns["Furgon"].HeaderText = "FURGON";
            dgvReparaciones.Columns["Persona"].HeaderText = "CHOFER";
        }
    }
}
