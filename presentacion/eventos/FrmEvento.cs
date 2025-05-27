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

namespace presentacion.eventos
{
    public partial class FrmEvento : Form
    {
        private List<Evento> listadoEventos;
        public FrmEvento()
        {
            InitializeComponent();
        }

        private void FrmEvento_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            EventoNegocio negocio = new EventoNegocio();
            listadoEventos = negocio.listar();
            dgvEventos.DataSource = listadoEventos;
            nombrarColumnas();
            ocultarColumnas();
            ordenarColumnas();
            anchoColumnas();
        }

        private void ocultarColumnas()
        {
            
            //dgvEventos.Columns[""].Visible = false;
        }



        private void anchoColumnas()
        {
            dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEventos.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvEventos.Columns)
            {
                column.Width += 15;
            }
            dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void ordenarColumnas()
        {
            /*
            dgvEventos.Columns[""].DisplayIndex = 0;
            dgvEventos.Columns[""].DisplayIndex = 1;
            dgvEventos.Columns[""].DisplayIndex = 2;
            dgvEventos.Columns[""].DisplayIndex = 4;
             */
        }

        private void nombrarColumnas()
        {
            //dgvEventos.Columns[""].HeaderText = "";
        }
    }
}
