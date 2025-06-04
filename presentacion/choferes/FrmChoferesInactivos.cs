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

namespace presentacion.choferes
{
    public partial class FrmChoferesInactivos : Form
    {
        List<Chofer> listadoChoferes = new List<Chofer>();
        public FrmChoferesInactivos()
        {
            InitializeComponent();
        }

        private void FrmChoferesInactivos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ChoferNegocio choferNegocio = new ChoferNegocio();
            listadoChoferes = choferNegocio.listar(0, 1);
            dgvChoferesInactivos.DataSource = listadoChoferes;
            formatoColumnas();
        }

        private void formatoColumnas()
        {
            ocultarColumnas();
            ordenarColumnas();
            nombrarColumnas();
            anchoColumnas();
        }

        private void ocultarColumnas()
        {
            dgvChoferesInactivos.Columns["Tractor"].Visible = false;
            dgvChoferesInactivos.Columns["Viajes"].Visible = false;
            dgvChoferesInactivos.Columns["Diferencias"].Visible = false;
            dgvChoferesInactivos.Columns["Puesto"].Visible = false;
            dgvChoferesInactivos.Columns["Empresa"].Visible = false;
            dgvChoferesInactivos.Columns["Detalle"].Visible = false;
            dgvChoferesInactivos.Columns["Activo"].Visible = false;
        }

        private void anchoColumnas()
        {
            dgvChoferesInactivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvChoferesInactivos.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvChoferesInactivos.Columns)
            {
                column.Width += 15;
            }
            dgvChoferesInactivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        private void ordenarColumnas()
        {
            dgvChoferesInactivos.Columns["Dni"].DisplayIndex = 0;
            dgvChoferesInactivos.Columns["Apellido"].DisplayIndex = 1;
            dgvChoferesInactivos.Columns["Nombres"].DisplayIndex = 2;
            dgvChoferesInactivos.Columns["Promedio"].DisplayIndex = 3;
        }
        private void nombrarColumnas()
        {
            dgvChoferesInactivos.Columns["Dni"].HeaderText = "DNI";
            dgvChoferesInactivos.Columns["Apellido"].HeaderText = "APELLIDO/S";
            dgvChoferesInactivos.Columns["Nombres"].HeaderText = "NOMBRE/S";
            dgvChoferesInactivos.Columns["Promedio"].HeaderText = "PROMEDIO";
        }

        private void btnChoferesInactivosClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
