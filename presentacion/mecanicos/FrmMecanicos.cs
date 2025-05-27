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

namespace presentacion.mecanicos
{
    public partial class FrmMecanicos : Form
    {
        private List<Mecanico> listadoMecanicos;
        public FrmMecanicos()
        {
            InitializeComponent();
        }

        private void FrmMecanicos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            int activo = 1, puesto = 3;
            MecanicoNegocio mecanicoNegocio = new MecanicoNegocio();
            listadoMecanicos = mecanicoNegocio.listar(activo, puesto);
            dgvMecanicos.DataSource = listadoMecanicos;
            ocultarColumnas();
            ordenarColumnas();
            nombrarColumnas();
            anchoColumnas();
        }

        private void ocultarColumnas()
        {
            dgvMecanicos.Columns["Sede"].Visible = false;
            dgvMecanicos.Columns["Vehiculo"].Visible = false;
            dgvMecanicos.Columns["Arreglos"].Visible = false;
            dgvMecanicos.Columns["Activo"].Visible = false;
            dgvMecanicos.Columns["Puesto"].Visible = false;
        }
        private void anchoColumnas()
        {
            dgvMecanicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMecanicos.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvMecanicos.Columns)
            {
                column.Width += 15;
            }
            dgvMecanicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void ordenarColumnas()
        {
            dgvMecanicos.Columns["Dni"].DisplayIndex = 0;
            dgvMecanicos.Columns["Apellido"].DisplayIndex = 1;
            dgvMecanicos.Columns["Nombres"].DisplayIndex = 2;
            dgvMecanicos.Columns["Empresa"].DisplayIndex = 3;
            dgvMecanicos.Columns["Detalle"].DisplayIndex = 4;
        }

        private void nombrarColumnas()
        {
            dgvMecanicos.Columns["Dni"].HeaderText = "DOCUMENTO";
            dgvMecanicos.Columns["Apellido"].HeaderText = "APELLIDO";
            dgvMecanicos.Columns["Nombres"].HeaderText = "NOMBRES";
            dgvMecanicos.Columns["Empresa"].HeaderText = "EMPRESA";
            dgvMecanicos.Columns["Detalle"].HeaderText = "DETALLE";
        }
    }
}
