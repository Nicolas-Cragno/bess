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

namespace presentacion.choferes
{
    public partial class FrmChoferes : Form
    {
        private List<Chofer> listadoChoferes;
        public FrmChoferes()
        {
            InitializeComponent();
        }

        private void FrmChoferes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            int activo = 1, puesto = 1;
            ChoferNegocio choferNegocio = new ChoferNegocio();
            listadoChoferes = choferNegocio.listar(activo, puesto);
            dgvChoferes.DataSource = listadoChoferes;
            nombrarColumnas();
            ocultarColumnas();
            ordenarColumnas();
            anchoColumnas();    
        }

        private void ocultarColumnas()
        {
            //dgvChoferes.Columns["Puesto"].Visible = false;
            dgvChoferes.Columns["Empresa"].Visible = false;
            dgvChoferes.Columns["Detalle"].Visible = false;
            dgvChoferes.Columns["Activo"].Visible = false;
            dgvChoferes.Columns["Tractor"].Visible = false;
            dgvChoferes.Columns["Viajes"].Visible = false;
            dgvChoferes.Columns["Promedio"].Visible = false;
            dgvChoferes.Columns["Diferencias"].Visible = false;
        }

        

        private void anchoColumnas()
        {
            dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvChoferes.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvChoferes.Columns)
            {
                column.Width += 15;
            }
            dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void ordenarColumnas()
        {
            dgvChoferes.Columns["Dni"].DisplayIndex = 0;
            dgvChoferes.Columns["Apellido"].DisplayIndex = 1;
            dgvChoferes.Columns["Nombres"].DisplayIndex = 2;
            dgvChoferes.Columns["Puesto"].DisplayIndex = 4;
        }

        private void nombrarColumnas()
        {
            dgvChoferes.Columns["Dni"].HeaderText = "DOCUMENTO";
            dgvChoferes.Columns["Apellido"].HeaderText = "APELLIDO";
            dgvChoferes.Columns["Nombres"].HeaderText = "NOMBRE/S";
            dgvChoferes.Columns["Puesto"].HeaderText = "TIPO DE EMPLEADO";
        }
    }
}
