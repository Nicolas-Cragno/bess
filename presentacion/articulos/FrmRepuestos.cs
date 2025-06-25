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

namespace presentacion.articulos
{
    public partial class FrmRepuestos : Form
    {
        private List<Articulo> listadoArticulos;
        public FrmRepuestos()
        {
            InitializeComponent();
        }

        private void FrmRepuestos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            string sector = "TALLER CAMIONES";
            this.ControlBox = false; // oculta el manejo de la ventana superior
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            listadoArticulos = articuloNegocio.listar(sector);
            dgvRepuestos.DataSource = listadoArticulos;
            formatoColumnas();
        }

        private void formatoColumnas()
        {
            ordenarColumnas();
            nombrarColumnas();
            ocultarColumnas();
            anchoColumnas();
        }

        private void ocultarColumnas()
        {
           dgvRepuestos.Columns["Id"].Visible = false;
        }

        private void anchoColumnas()
        {
            dgvRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRepuestos.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvRepuestos.Columns)
            {
                column.Width += 15;
            }
            dgvRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void ordenarColumnas()
        {
            dgvRepuestos.Columns["Nombre"].DisplayIndex = 0;
            dgvRepuestos.Columns["CodigoProveedor"].DisplayIndex = 1;
            dgvRepuestos.Columns["Marca"].DisplayIndex = 2;
            dgvRepuestos.Columns["Detalle"].DisplayIndex = 3;
            dgvRepuestos.Columns["Stock"].DisplayIndex = 4;
        }

        private void nombrarColumnas()
        {
            dgvRepuestos.Columns["CodigoProveedor"].HeaderText = "CODIGO";
            dgvRepuestos.Columns["Nombre"].HeaderText = "NOMBRE";
            dgvRepuestos.Columns["Detalle"].HeaderText = "DESCRIPCION";
            dgvRepuestos.Columns["Marca"].HeaderText = "MARCA";
            dgvRepuestos.Columns["Stock"].HeaderText = "STOCK";
        }

        private void tbxRepuestosFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            List<Articulo> listaFiltrada;
            string filtro = tbxRepuestosFiltro.Text.ToUpper();

            if(filtro != "")
            {
                listaFiltrada = listadoArticulos.FindAll(rp => rp.Nombre.ToString().Contains(filtro) || rp.Marca.ToString().Contains(filtro) || rp.CodigoProveedor.ToString().Contains(filtro) || rp.Detalle.ToString().Contains(filtro));
            } else
            {
                listaFiltrada = listadoArticulos;
            }

            dgvRepuestos.DataSource = null;
            dgvRepuestos.DataSource = listaFiltrada;
            formatoColumnas();
        }

        private void dgvRepuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo art = (Articulo)dgvRepuestos.CurrentRow.DataBoundItem;
            FrmFichaArticulo ficha = new FrmFichaArticulo('F', 4, art, this);
            ficha.ShowDialog();
            cargar();
        }

        private void btnRepuestosNuevo_Click(object sender, EventArgs e)
        {
            FrmFichaArticulo ficha = new FrmFichaArticulo('N', 4, null, this);
            ficha.ShowDialog();
            cargar();
        }
    }
}
