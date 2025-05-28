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

namespace presentacion.movimientos
{
    public partial class FrmMovimientos : Form
    {
        private List<Movimiento> listadoMovimientos;
        char ficha = 'F', agregar = 'A', modificar = 'M';
        public FrmMovimientos()
        {
            InitializeComponent();
        }

        private void btnMovimientosClose_Click(object sender, EventArgs e)
        {

        }

        private void btnMovimientosNuevo_Click(object sender, EventArgs e)
        {
            FrmFichaMovimiento ventana = new FrmFichaMovimiento(agregar);
            ventana.ShowDialog();
            cargar();
        }

        private void dgvMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxMovimientosFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMovimientosFiltro_Click(object sender, EventArgs e)
        {

        }

        private void lblMovimientosTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmMovimientos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            this.ControlBox = false;
            MovimientoNegocio negocio = new MovimientoNegocio();
            listadoMovimientos = negocio.listar();
            dgvMovimientos.DataSource = listadoMovimientos;
            ocultarColumnas();
            nombrarColumnas();
            anchoColumnas();
        }

        private void ocultarColumnas()
        {
            dgvMovimientos.Columns["Id"].Visible = false;
            dgvMovimientos.Columns["Detalle"].Visible = false;
            dgvMovimientos.Columns["Registro"].Visible = false;
            dgvMovimientos.Columns["Corte"].Visible = false;
            dgvMovimientos.Columns["Panico"].Visible = false;
            dgvMovimientos.Columns["Reporte"].Visible = false;
            dgvMovimientos.Columns["Desenganche"].Visible = false;
            dgvMovimientos.Columns["Cabina"].Visible = false;
            dgvMovimientos.Columns["Antivandalico"].Visible = false;
            dgvMovimientos.Columns["Efurgon"].Visible = false;
            dgvMovimientos.Columns["Llave"].Visible = false;
        }

        private void nombrarColumnas()
        {
            dgvMovimientos.Columns["Tipo"].HeaderText = "MOVIMIENTO";
            dgvMovimientos.Columns["Persona"].HeaderText = "EMPLEADO / CHOFER";
            dgvMovimientos.Columns["Tractor"].HeaderText = "TRACTOR";
            dgvMovimientos.Columns["Furgon"].HeaderText = "FURGON";
            dgvMovimientos.Columns["Fecha"].HeaderText = "FECHA Y HORA";
        }

        private void anchoColumnas()
        {
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMovimientos.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvMovimientos.Columns)
            {
                column.Width += 15;
            }
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void tbxMovimientosFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            List<Movimiento> listaFiltrada;
            string filtro = tbxMovimientosFiltro.Text;

            if(filtro!= "")
            {
                listaFiltrada = listadoMovimientos.FindAll(ev => ev.Tipo.ToString().Contains(filtro.ToUpper()) || ev.Fecha.ToString().Contains(filtro.ToUpper()) || ev.Persona.ToString().Contains(filtro.ToUpper()) || ev.Tractor.ToString().Contains(filtro.ToUpper()) || ev.Furgon.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoMovimientos;
            }

            dgvMovimientos.DataSource = null;
            dgvMovimientos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void dgvMovimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Movimiento seleccion = (Movimiento)dgvMovimientos.CurrentRow.DataBoundItem;

            FrmFichaMovimiento fichaMovimiento = new FrmFichaMovimiento(ficha, seleccion);
            fichaMovimiento.ShowDialog();
            cargar();
        }
    }
}
