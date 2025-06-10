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
        
        // Cargas
        public FrmVehiculos()
        {
            InitializeComponent();
        }
        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            configuracion();
        }

        private void configuracion()
        {
            this.ControlBox = false;
            cargarT();
            cargarF();
        }

        // Filtros
        private void filtrarT() 
        {
            List<Tractor> listaFiltrada;
            string filtro = tbxVehiculosT.Text;

            if(filtro != "")
            {
                listaFiltrada = listadoTractores.FindAll(tr => tr.Interno.ToString().Contains(filtro.ToUpper()) || tr.Dominio.ToString().Contains(filtro.ToUpper()) || tr.Marca.ToString().Contains(filtro.ToUpper()) || tr.Modelo.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoTractores;
            }

            dgvVehiculosT.DataSource = null;
            dgvVehiculosT.DataSource = listaFiltrada;
            formatoColumnasT();
        }
        private void tbxVehiculosT_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarT();
        }
        private void filtrarF() 
        {
            List<Furgon> listaFiltrada;
            string filtro = tbxVehiculosF.Text;

            if (filtro != "")
            {
                // no contempla marca por el momento, abajo listado que SI la contempla
                listaFiltrada = listadoFurgones.FindAll(fg => fg.Interno.ToString().Contains(filtro.ToUpper()) || fg.Dominio.ToString().Contains(filtro.ToUpper()) || fg.Modelo.ToString().Contains(filtro.ToUpper()));
                
               // listaFiltrada = listadoFurgones.FindAll(fg => fg.Interno.ToString().Contains(filtro.ToUpper()) || fg.Dominio.ToString().Contains(filtro.ToUpper()) || fg.Marca.ToString().Contains(filtro.ToUpper()) || fg.Modelo.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoFurgones;
            }

            dgvVehiculosF.DataSource = null;
            dgvVehiculosF.DataSource = listaFiltrada;
            formatoColumnasF();
        }
        private void tbxVehiculosF_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarF();
        }

        // Tabla tractores
        private void cargarT()
        {
            int estadoT = 1;
            TractorNegocio negocio = new TractorNegocio();
            listadoTractores = negocio.listar(estadoT);
            dgvVehiculosT.DataSource = listadoTractores;
            formatoColumnasT();
        }
        private void formatoColumnasT()
        {
            ocultarColumnasT();
            nombrarColumnasT();
            anchoColumnasT();
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
        private void nombrarColumnasT()
        {
            dgvVehiculosT.Columns["Interno"].HeaderText = "INT";
            dgvVehiculosT.Columns["Dominio"].HeaderText = "DOMINIO";
            dgvVehiculosT.Columns["Marca"].HeaderText = "MARCA";
            dgvVehiculosT.Columns["Modelo"].HeaderText = "AÑO";
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

        // Tabla furgones
        private void cargarF()
        {
            int estadoF = 1;
            FurgonNegocio negocio = new FurgonNegocio();
            listadoFurgones = negocio.listar(estadoF);
            dgvVehiculosF.DataSource = listadoFurgones;
            formatoColumnasF();
        }
        private void formatoColumnasF()
        {
            ocultarColumnasF();
            nombrarColumnasF();
            anchoColumnasF();
        }
        private void ocultarColumnasF()
        {
            dgvVehiculosF.Columns["Empresa"].Visible = false;
            dgvVehiculosF.Columns["Caracteristicas"].Visible = false;
            dgvVehiculosF.Columns["Detalle"].Visible = false;
            dgvVehiculosF.Columns["OkDocumentacion"].Visible = false;
            dgvVehiculosF.Columns["Activo"].Visible = false;
        }
        private void nombrarColumnasF()
        {
            dgvVehiculosF.Columns["Interno"].HeaderText = "INT";
            dgvVehiculosF.Columns["Dominio"].HeaderText = "DOMINIO";
            dgvVehiculosF.Columns["Marca"].HeaderText = "MARCA";
            dgvVehiculosF.Columns["Modelo"].HeaderText = "AÑO";
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

        private void dgvVehiculosT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Tractor seleccion = (Tractor)dgvVehiculosT.CurrentRow.DataBoundItem;

                FrmFichaVehiculo fichaVehiculo = new FrmFichaVehiculo('T', 'F', seleccion, this);
                fichaVehiculo.ShowDialog();
                configuracion();
            }
        }

        private void btnVehiculosT_Click(object sender, EventArgs e)
        {
            FrmFichaVehiculo nuevoTractor = new FrmFichaVehiculo('T', 'A', null, this);
            nuevoTractor.ShowDialog();
            configuracion();
        }
    }
}
