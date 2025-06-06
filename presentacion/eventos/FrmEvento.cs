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
        private int anchoMaximoDgv = 0;
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
            ajustarDgv();
        }
        private void ocultarColumnas()
        {
            dgvEventos.Columns["Id"].Visible = false;
            dgvEventos.Columns["DniPersona"].Visible = false;
            dgvEventos.Columns["Detalle"].Visible = false;
        }
        private void ajustarDgv()
        {
            if (anchoMaximoDgv == 0)
            {
                int anchoTotal = dgvEventos.RowHeadersVisible ? dgvEventos.RowHeadersWidth : 0;

                foreach (DataGridViewColumn col in dgvEventos.Columns)
                {
                    if (col.Visible)
                        anchoTotal += col.Width + 1;
                }

                // Si hay scroll vertical (más filas que alto disponible), lo sumamos. Si no, no.
                if (dgvEventos.DisplayedRowCount(false) < dgvEventos.RowCount)
                    anchoTotal += SystemInformation.VerticalScrollBarWidth;

                anchoMaximoDgv = anchoTotal;
            }

            dgvEventos.Width = anchoMaximoDgv;
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
            dgvEventos.Columns["Tipo"].DisplayIndex = 0;
            dgvEventos.Columns["Fecha"].DisplayIndex = 1;
            dgvEventos.Columns["Tractor"].DisplayIndex = 2;
            dgvEventos.Columns["Furgon"].DisplayIndex = 3;
            dgvEventos.Columns["Persona"].DisplayIndex = 4;
        }
        private void nombrarColumnas()
        {
            dgvEventos.Columns["Tipo"].HeaderText = "";
            dgvEventos.Columns["Persona"].HeaderText = "EMPLEADO";
            dgvEventos.Columns["Tractor"].HeaderText = "TRACTOR";
            dgvEventos.Columns["Furgon"].HeaderText = "FURGON";
            dgvEventos.Columns["Fecha"].HeaderText = "FECHA";
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

            FrmFichaEvento fichaEvento = new FrmFichaEvento(ficha, seleccion, this);
            fichaEvento.ShowDialog();
            cargar();
        }

        private void btnEventosNuevo_Click(object sender, EventArgs e)
        {
            FrmFichaEvento ventana = new FrmFichaEvento(agregar);
            ventana.ShowDialog();
            cargar();
        }

    }
}
