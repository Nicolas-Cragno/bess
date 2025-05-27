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

namespace presentacion.utilitarios
{
    public partial class FrmUtilitarios : Form
    {
        private List<Vehiculo> listadoUtilitarios;
        public FrmUtilitarios()
        {
            InitializeComponent();
        }

        private void FrmUtilitarios_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            int estado = 1;
            UtilitarioNegocio negocio = new UtilitarioNegocio();
            listadoUtilitarios = negocio.listar(estado);
            dgvUtilitarios.DataSource = listadoUtilitarios;
            ocultarColumnas();
            anchoColumnas();
            nombrarColumnas();
        }

        private void ocultarColumnas()
        {
            dgvUtilitarios.Columns["okDocumentacion"].Visible = false;
            dgvUtilitarios.Columns["activo"].Visible=false;
        }

        private void anchoColumnas()
        {
            dgvUtilitarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUtilitarios.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvUtilitarios.Columns)
            {
                column.Width += 15;
            }
            dgvUtilitarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void nombrarColumnas()
        {
            dgvUtilitarios.Columns["Dominio"].HeaderText = "DOMINIO";
            dgvUtilitarios.Columns["Empresa"].HeaderText = "EMPRESA";
            dgvUtilitarios.Columns["Marca"].HeaderText = "MARCA";
            dgvUtilitarios.Columns["Modelo"].HeaderText = "MODELO";
            dgvUtilitarios.Columns["Detalle"].HeaderText = "DETALLE";
        }
    }
}
