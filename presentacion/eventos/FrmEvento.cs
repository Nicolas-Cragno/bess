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
        char ficha = 'F', agregar = 'A', modificar = 'M';
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
            this.ControlBox = false;
            EventoNegocio negocio = new EventoNegocio();
            listadoEventos = negocio.listar();
            dgvEventos.DataSource = listadoEventos;
            formatoColumnas();
        }

        private void formatoColumnas()
        {
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

        private void tbxEventosFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            List<Evento> listaFiltrada;
            string filtro = tbxEventosFiltro.Text;

            if(filtro != "")
            {
                listaFiltrada = listadoEventos.FindAll(ev => ev.Tipo.ToString().Contains(filtro.ToUpper()) || ev.Fecha.ToString().Contains(filtro.ToUpper()) || ev.Persona.ToString().Contains(filtro.ToUpper()) || ev.Tractor.ToString().Contains(filtro.ToUpper()) || ev.Furgon.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoEventos;
            }

            dgvEventos.DataSource = null;
            dgvEventos.DataSource = listaFiltrada;
            formatoColumnas();
        }

        private void dgvEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento seleccion = (Evento)dgvEventos.CurrentRow.DataBoundItem;

            FrmFichaEvento fichaEvento = new FrmFichaEvento(ficha, seleccion);
            fichaEvento.ShowDialog();
            cargar();
        }

        private void btnEventosNuevo_Click(object sender, EventArgs e)
        {
            FrmFichaEvento ventana = new FrmFichaEvento(agregar);
            ventana.ShowDialog();
            cargar();
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
