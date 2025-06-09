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
        private int anchoMaximoDgv = 0;

        // Cargas
        public FrmMovimientos()
        {
            InitializeComponent();
        }
        private void FrmMovimientos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            this.ControlBox = false; // oculta el manejo de la ventana superior
            tabulaciones();
            MovimientoNegocio negocio = new MovimientoNegocio();
            listadoMovimientos = negocio.listar();
            dgvMovimientos.DataSource = listadoMovimientos;
            formatoColumnas();
        }
        private void tabulaciones()
        {
            tbxMovimientosFiltro.TabIndex = 0;
            btnMovimientosNuevo.TabIndex = 1;
            dgvMovimientos.TabIndex = 2;
        }

        // Botones - clicks
        private void btnMovimientosNuevo_Click(object sender, EventArgs e)
        {
            FrmFichaMovimiento ventana = new FrmFichaMovimiento(agregar, null, this);
            ventana.ShowDialog();
            cargar();
        }
        private void btnMovimientosClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Data grid view
        private void filtrar()
        {
            List<Movimiento> listaFiltrada;
            string filtro = tbxMovimientosFiltro.Text;

            if(filtro!= "")
            {
                listaFiltrada = listadoMovimientos.FindAll(mv => mv.Tipo.ToString().Contains(filtro.ToUpper()) || mv.Fecha.ToString().Contains(filtro.ToUpper()) || mv.Persona.ToString().Contains(filtro.ToUpper()) || mv.Tractor.ToString().Contains(filtro.ToUpper()) || mv.Furgon.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoMovimientos;
            }

            dgvMovimientos.DataSource = null;
            dgvMovimientos.DataSource = listaFiltrada;
            formatoColumnas();
        }
        private void formatoColumnas()
        {
            ocultarColumnas();
            nombrarColumnas();
            anchoColumnas();
            ajustarDgv(dgvMovimientos);
        }
        private void nombrarColumnas()
        {
            dgvMovimientos.Columns["Tipo"].HeaderText = "";
            dgvMovimientos.Columns["Persona"].HeaderText = "EMPLEADO / CHOFER";
            dgvMovimientos.Columns["Tractor"].HeaderText = "TRACTOR";
            dgvMovimientos.Columns["Furgon"].HeaderText = "FURGON";
            dgvMovimientos.Columns["Fecha"].HeaderText = "FECHA Y HORA";
        }
        private void ocultarColumnas()
        {
            dgvMovimientos.Columns["Id"].Visible = false;
            dgvMovimientos.Columns["DniPersona"].Visible = false;
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
        private void ajustarDgv(DataGridView dgv)
        {
            if (anchoMaximoDgv == 0)
            {
                int anchoTotal = dgv.RowHeadersVisible ? dgv.RowHeadersWidth : 0;

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (col.Visible)
                        anchoTotal += col.Width + 1;
                }

                // Si hay scroll vertical (más filas que alto disponible), lo sumamos. Si no, no.
                if (dgv.DisplayedRowCount(false) < dgv.RowCount)
                    anchoTotal += SystemInformation.VerticalScrollBarWidth;

                anchoMaximoDgv = anchoTotal;
            }

            dgv.Width = anchoMaximoDgv;
        }
        private void tbxMovimientosFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrar();
        }
        private void dgvMovimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Movimiento seleccion = (Movimiento)dgvMovimientos.CurrentRow.DataBoundItem;

                FrmFichaMovimiento fichaMovimiento = new FrmFichaMovimiento(ficha, seleccion, this);
                fichaMovimiento.ShowDialog();
                cargar();
            }
        }

        // Sin uso
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
    }
}
