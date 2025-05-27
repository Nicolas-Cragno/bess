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

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            listadoArticulos = articuloNegocio.listar(sector);
            dgvRepuestos.DataSource = listadoArticulos;
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
    }
}
