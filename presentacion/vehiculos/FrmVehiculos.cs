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

namespace presentacion.vehiculos
{
    public partial class FrmVehiculos : Form
    {
        private List<Tractor> listadoTractores;
        private List<Furgon> listadoFurgones;
        public FrmVehiculos()
        {
            InitializeComponent();
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            cargarT();
            cargarF();
        }

        private void ocultarColumnasT()
        {
            dgvVehiculosT.Columns["Empresa"].Visible = false;
            dgvVehiculosT.Columns["Detalle"].Visible = false;
            dgvVehiculosT.Columns["OkTaller"].Visible = false;
            dgvVehiculosT.Columns["OkDocumentacion"].Visible = false;
            dgvVehiculosT.Columns["Activo"].Visible = false;
            dgvVehiculosT.Columns["Color"].Visible = false;
        }

        private void ocultarColumnasF()
        {
            dgvVehiculosF.Columns["Empresa"].Visible = false;
            dgvVehiculosF.Columns["Caracteristicas"].Visible = false;
            dgvVehiculosF.Columns["Detalle"].Visible = false;
            dgvVehiculosF.Columns["OkDocumentacion"].Visible = false;
            dgvVehiculosF.Columns["Activo"].Visible = false;
        }


        private void cargarT()
        {
            int estadoT = 1;
            TractorNegocio negocio = new TractorNegocio();
            listadoTractores = negocio.listar(estadoT);
            dgvVehiculosT.DataSource = listadoTractores;
            ocultarColumnasT();
            nombrarColumnasT();
            anchoColumnasT();
        }

        private void cargarF()
        {
            int estadoF = 1;
            FurgonNegocio negocio = new FurgonNegocio();
            listadoFurgones = negocio.listar(estadoF);
            dgvVehiculosF.DataSource = listadoFurgones;
            ocultarColumnasF();
            nombrarColumnasF();
            anchoColumnasF();
        }

        private void anchoColumnasT()
        {
            dgvVehiculosT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVehiculosT.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvVehiculosT.Columns)
            {
                column.Width += 5;
            }
            dgvVehiculosT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void anchoColumnasF()
        {
            dgvVehiculosF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVehiculosF.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvVehiculosF.Columns)
            {
                column.Width += 15;
            }
            dgvVehiculosF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void nombrarColumnasT()
        {
            dgvVehiculosT.Columns["Interno"].HeaderText = "INT";
            dgvVehiculosT.Columns["Dominio"].HeaderText = "DOMINIO";
            dgvVehiculosT.Columns["Marca"].HeaderText = "MARCA";
            dgvVehiculosT.Columns["Modelo"].HeaderText = "AÑO";
        }

        private void nombrarColumnasF()
        {
            dgvVehiculosF.Columns["Interno"].HeaderText = "INT";
            dgvVehiculosF.Columns["Dominio"].HeaderText = "DOMINIO";
            dgvVehiculosF.Columns["Marca"].HeaderText = "MARCA";
            dgvVehiculosF.Columns["Modelo"].HeaderText = "AÑO";
        }
    }
}
