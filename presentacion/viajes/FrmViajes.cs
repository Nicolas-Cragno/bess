using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion.viajes
{
    public partial class FrmViajes : Form
    {
        private List<Viaje> listadoViajes;
        public FrmViajes()
        {
            InitializeComponent();
        }

        private void FrmViajes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ViajeNegocio viajeNegocio = new ViajeNegocio();
            listadoViajes = viajeNegocio.listar();
            dgvViajes.DataSource = listadoViajes;
            ocultarColumnas();
            ordenarColumnas();
            nombrarColumnas();
            anchoColumnas();
        }

        private void ocultarColumnas() 
        {
            dgvViajes.Columns["GasoilReal"].Visible = false;
            dgvViajes.Columns["GasoilSat"].Visible = false;
            dgvViajes.Columns["Kilometraje"].Visible = false;
            dgvViajes.Columns["Tipo"].Visible = false;
            dgvViajes.Columns["Detalle"].Visible = false;
            dgvViajes.Columns["Cliente"].Visible = false;
        }
        private void nombrarColumnas()
        {
            dgvViajes.Columns["Cliente"].HeaderText = "CLIENTE";
            dgvViajes.Columns["Promedio"].HeaderText = "LTS C/100 km";
            dgvViajes.Columns["Diferencia"].HeaderText = "DIFERENCIA";
            dgvViajes.Columns["Id"].HeaderText = "VIAJE";
            dgvViajes.Columns["Persona"].HeaderText = "CHOFER";
            dgvViajes.Columns["Tractor"].HeaderText = "TRACTOR";
            dgvViajes.Columns["Furgon"].HeaderText = "FURGON";
            dgvViajes.Columns["Fecha"].HeaderText = "FECHA";
        }
        private void ordenarColumnas() 
        {
            dgvViajes.Columns["Id"].DisplayIndex = 0;
            dgvViajes.Columns["Fecha"].DisplayIndex = 1;
            dgvViajes.Columns["Persona"].DisplayIndex = 2;
            dgvViajes.Columns["Tractor"].DisplayIndex = 3;
            dgvViajes.Columns["Furgon"].DisplayIndex = 4;
            dgvViajes.Columns["Promedio"].DisplayIndex = 5;
            dgvViajes.Columns["Diferencia"].DisplayIndex = 6;
        }
        private void anchoColumnas() 
        {
            dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvViajes.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvViajes.Columns)
            {
                column.Width += 15;
            }
            dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
    }
}
