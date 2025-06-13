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
        private char tipo;

        // Cargas
        public FrmVehiculos(char tTipo)
        {
            InitializeComponent();
            tipo = tTipo;
        }
        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            configuracion();
        }

        private void configuracion()
        {
            this.ControlBox = false;
            TractorNegocio tractorNegocio = new TractorNegocio();
            FurgonNegocio furgonNegocio = new FurgonNegocio();
            switch (tipo)
            {
                case 'T': // Tractores
                    listadoTractores = tractorNegocio.listar(1);
                    dgvVehiculos.DataSource = listadoTractores;
                    formatoColumnas(listadoTractores);
                    lblVehiculosTitulo.Text = "TRACTORES";
                    break;
                case 'F': // Furgones
                    listadoFurgones = furgonNegocio.listar(1);
                    dgvVehiculos.DataSource = listadoFurgones;
                    formatoColumnas(listadoFurgones);
                    lblVehiculosTitulo.Text = "FURGONES";
                    break;
                default: // Por defecto tractores
                    listadoTractores = tractorNegocio.listar(1);
                    dgvVehiculos.DataSource = listadoTractores;
                    formatoColumnas(listadoTractores);
                    lblVehiculosTitulo.Text = "VEHICULOS";
                    break;
            }
        }

        // Data Grid View
        private void filtrar() 
        {
            switch (tipo)
            {
                case 'T': // Tractores
                    filtroTractor();
                    break;
                case 'F': // Furgones
                    filtroFurgon();
                    break;
                default: // Por defecto tractores
                    filtroTractor();
                    break;
            }
        }
        private void filtroTractor() 
        {
            List<Tractor> listaFiltrada;
            string filtro = tbxVehiculos.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoTractores.FindAll(tr => tr.Interno.ToString().Contains(filtro.ToUpper()) || tr.Dominio.ToString().Contains(filtro.ToUpper()) || tr.Marca.ToString().Contains(filtro.ToUpper()) || tr.Modelo.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoTractores;
            }

            dgvVehiculos.DataSource = null;
            dgvVehiculos.DataSource = listaFiltrada;
            formatoColumnas(listadoTractores);
        }
        private void filtroFurgon() 
        {
            List<Furgon> listaFiltrada;
            string filtro = tbxVehiculos.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoFurgones.FindAll(fg => fg.Interno.ToString().Contains(filtro.ToUpper()) || fg.Dominio.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoFurgones;
            }

            dgvVehiculos.DataSource = null;
            dgvVehiculos.DataSource = listaFiltrada;
            formatoColumnas(listadoFurgones);
        }
        private void tbxVehiculosT_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrar();
        }
        private void formatoColumnas(object lista)
        {
            ocultarColumnas();
            nombrarColumnas();
            anchoColumnas(lista);
            ordenarColumnas();
        }
        private void ocultarColumnas()
        {
           dgvVehiculos.Columns["Marca"].Visible = false;
           dgvVehiculos.Columns["Modelo"].Visible = false;
           dgvVehiculos.Columns["Activo"].Visible = false;
           dgvVehiculos.Columns["OkDocumentacion"].Visible = false;
           dgvVehiculos.Columns["Detalle"].Visible = false;
            if (tipo == 'T')
            {
                dgvVehiculos.Columns["OkTaller"].Visible = false;
                dgvVehiculos.Columns["Color"].Visible = false;
            }else if (tipo == 'F')
            {
                dgvVehiculos.Columns["Caracteristicas"].Visible = false;
            }
        }
        private void nombrarColumnas()
        {
            dgvVehiculos.Columns["Interno"].HeaderText = "INT";
            dgvVehiculos.Columns["Dominio"].HeaderText = "DOMINIO";
            dgvVehiculos.Columns["Empresa"].HeaderText = "";
            if (tipo == 'T')
            {
                dgvVehiculos.Columns["Marca"].HeaderText = "MARCA";
                dgvVehiculos.Columns["Modelo"].HeaderText = "AÑO";
            }
        }
        private void anchoColumnas(object listaOriginal)
        {
            if (listaOriginal == null) return;

            var lista = listaOriginal as IEnumerable<object>;
            if (lista == null) return;

            using (Graphics g = dgvVehiculos.CreateGraphics())
            {
                foreach (DataGridViewColumn column in dgvVehiculos.Columns)
                {
                    int maxWidth = 0;

                    // Medir encabezado
                    SizeF headerSize = g.MeasureString(column.HeaderText, dgvVehiculos.Font);
                    maxWidth = (int)Math.Ceiling(headerSize.Width);

                    // Medir en toda la lista original (no filtrada)
                    foreach (var item in lista)
                    {
                        var prop = item.GetType().GetProperty(column.DataPropertyName);
                        if (prop != null)
                        {
                            object value = prop.GetValue(item);
                            if (value != null)
                            {
                                SizeF cellSize = g.MeasureString(value.ToString(), dgvVehiculos.Font);
                                maxWidth = Math.Max(maxWidth, (int)Math.Ceiling(cellSize.Width));
                            }
                        }
                    }

                    column.Width = maxWidth + 5;
                }
            }
        }
        private void ordenarColumnas()
        {
            dgvVehiculos.Columns["Interno"].DisplayIndex = 0;
            dgvVehiculos.Columns["Dominio"].DisplayIndex = 1;
            dgvVehiculos.Columns["Empresa"].DisplayIndex = 2;
            if (tipo == 'T')
            {
            dgvVehiculos.Columns["Marca"].DisplayIndex = 3;
                dgvVehiculos.Columns["Modelo"].DisplayIndex = 4;
            }
        }

        private void dgvVehiculosT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (tipo == 'T')
                {
                    abrirFichaTractor();
                } else if ( tipo == 'F')
                {
                    abrirFichaFurgon();
                }
            }
        }
        private void abrirFichaTractor()
        {
            Tractor seleccion = (Tractor)dgvVehiculos.CurrentRow.DataBoundItem;

            FrmFichaVehiculo fichaVehiculo = new FrmFichaVehiculo('T', 'F', seleccion, this);
            fichaVehiculo.ShowDialog();
            configuracion();
        }
        private void abrirFichaFurgon()
        {
            Furgon seleccion = (Furgon)dgvVehiculos.CurrentRow.DataBoundItem;

            FrmFichaVehiculo fichaVehiculo = new FrmFichaVehiculo('F', 'F', seleccion, this);
            fichaVehiculo.ShowDialog();
            configuracion();
        }
        private void btnVehiculosT_Click(object sender, EventArgs e)
        {
            FrmFichaVehiculo nuevoTractor = new FrmFichaVehiculo(tipo, 'A', null, this);
            nuevoTractor.ShowDialog();
            configuracion();
        }
    }
}
