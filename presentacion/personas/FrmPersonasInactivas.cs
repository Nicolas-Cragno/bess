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

namespace presentacion.personas
{
    public partial class FrmPersonasInactivas : Form
    {
        int puesto;
        List<Chofer> listadoChoferes = new List<Chofer>();
        List<Mecanico> listadoMecanicos = new List<Mecanico>();
        List<Persona> listadoPersonas = new List<Persona>();
        private int anchoMaximoDgv = 0;
        private Form formularioPadre;

        // Cargas
        public FrmPersonasInactivas(int pPuesto, Form padre=null)
        {
            InitializeComponent();
            puesto = pPuesto;   
            formularioPadre = padre;
        }
        private void FrmPersonasInactivas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar() 
        {
            this.ControlBox = false; // oculta el manejo de la ventana superior
            tabulaciones();
            ChoferNegocio choferNegocio = new ChoferNegocio();
            MecanicoNegocio mecanicoNegocio = new MecanicoNegocio();
            PersonaNegocio personaNegocio = new PersonaNegocio();
            switch (puesto)
            {
                case 1:
                    listadoChoferes = choferNegocio.listar(0, 1);
                    dgvPersonasInactivas.DataSource = listadoChoferes;
                    formatoColumnas(listadoChoferes);
                    break;
                case 3:
                    listadoMecanicos = mecanicoNegocio.listar(0, 3);
                    dgvPersonasInactivas.DataSource = listadoMecanicos;
                    formatoColumnas(listadoMecanicos);
                    break;
                default:
                    listadoPersonas = personaNegocio.listar(0);
                    dgvPersonasInactivas.DataSource = listadoPersonas;
                    formatoColumnas(listadoPersonas);
                    break;
            }
            colgarDerecha();
        }
        private void colgarDerecha()
        {
            if (formularioPadre != null)
            {
                Screen pantalla = Screen.FromControl(formularioPadre);
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(
                    pantalla.WorkingArea.Right - this.Width,
                    pantalla.WorkingArea.Top
                );
            }
        }
        private void tabulaciones()
        {
            tbxPersonasInactivasFiltro.TabIndex = 0;
            dgvPersonasInactivas.TabIndex = 1;
            btnPersonasInactivasClose.TabIndex = 2;
        }

        // Data Grid View
        private void filtrar()
        {
            switch (puesto)
            {
                case 1:
                    filtroChofer();
                    break;
                case 3:
                    filtroMecanico();
                    break;
                default:
                    filtroPersona();
                    break;
            }
        }
        private void filtroChofer()
        {
            List<Chofer> listaFiltrada;
            string filtro = tbxPersonasInactivasFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoChoferes.FindAll(ch => ch.Dni.ToString().Contains(filtro.ToUpper()) || ch.Apellido.ToString().Contains(filtro.ToUpper()) || ch.Nombres.ToString().Contains(filtro.ToUpper()) || ch.Empresa.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoChoferes;
            }

            dgvPersonasInactivas.DataSource = null;
            dgvPersonasInactivas.DataSource = listaFiltrada;
            formatoColumnas(listadoChoferes);
        }
        private void filtroMecanico()
        {
            List<Mecanico> listaFiltrada;
            string filtro = tbxPersonasInactivasFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoMecanicos.FindAll(m => m.Dni.ToString().Contains(filtro.ToUpper()) || m.Apellido.ToString().Contains(filtro.ToUpper()) || m.Nombres.ToString().Contains(filtro.ToUpper()) || m.Empresa.ToString().Contains(filtro.ToUpper()) || m.Detalle.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoMecanicos;
            }

            dgvPersonasInactivas.DataSource = null;
            dgvPersonasInactivas.DataSource = listaFiltrada;
            formatoColumnas(listadoMecanicos);
        }
        private void filtroPersona()
        {
            List<Persona> listaFiltrada;
            string filtro = tbxPersonasInactivasFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoPersonas.FindAll(p => p.Dni.ToString().Contains(filtro.ToUpper()) || p.Apellido.ToString().Contains(filtro.ToUpper()) || p.Nombres.ToString().Contains(filtro.ToUpper()) || p.Empresa.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoPersonas;
            }

            dgvPersonasInactivas.DataSource = null;
            dgvPersonasInactivas.DataSource = listaFiltrada;
            formatoColumnas(listadoPersonas);
        }
        private void formatoColumnas(object lista)
        {
            ocultarColumnas();
            anchoColumnas(lista);
            ordenarColumnas();
            nombrarColumnas();
            ajustarDgv(dgvPersonasInactivas);
        }
        private void ocultarColumnas()
        {
            dgvPersonasInactivas.Columns["Detalle"].Visible = false;
            dgvPersonasInactivas.Columns["Empresa"].Visible = false;
            switch (puesto)
            {
                case 1: // chofer larga distancia
                    dgvPersonasInactivas.Columns["Tractor"].Visible = false;
                    dgvPersonasInactivas.Columns["Diferencias"].Visible = false;
                    dgvPersonasInactivas.Columns["Puesto"].Visible = false;
                    dgvPersonasInactivas.Columns["Detalle"].Visible = false;
                    dgvPersonasInactivas.Columns["Activo"].Visible = false;
                    dgvPersonasInactivas.Columns["Viajes"].Visible = false;
                    dgvPersonasInactivas.Columns["Promedio"].Visible = false;
                    break;
                case 2: // chofer movimiento
                    break;
                case 3: // mecanicos
                    dgvPersonasInactivas.Columns["Sede"].Visible = false;
                    dgvPersonasInactivas.Columns["Vehiculo"].Visible = false;
                    dgvPersonasInactivas.Columns["Arreglos"].Visible = false;
                    dgvPersonasInactivas.Columns["Puesto"].Visible = false;
                    dgvPersonasInactivas.Columns["Detalle"].Visible = false;
                    dgvPersonasInactivas.Columns["Activo"].Visible = false;
                    break;
                default:  // sin asignar / otros
                    break;
            }
        }
        private void anchoColumnas(object listaOriginal)
        {
            if (listaOriginal == null) return;

            var lista = listaOriginal as IEnumerable<object>;
            if (lista == null) return;

            using (Graphics g = dgvPersonasInactivas.CreateGraphics())
            {
                foreach (DataGridViewColumn column in dgvPersonasInactivas.Columns)
                {
                    int maxWidth = 0;

                    // Medir encabezado con la fuente del encabezado (más precisa)
                    Font headerFont = dgvPersonasInactivas.ColumnHeadersDefaultCellStyle.Font ?? dgvPersonasInactivas.Font;
                    SizeF headerSize = g.MeasureString(column.HeaderText, headerFont);
                    maxWidth = (int)Math.Ceiling(headerSize.Width);

                    // Medir valores de celdas en la lista original
                    foreach (var item in lista)
                    {
                        var prop = item.GetType().GetProperty(column.DataPropertyName);
                        if (prop != null)
                        {
                            object value = prop.GetValue(item);
                            if (value != null)
                            {
                                SizeF cellSize = g.MeasureString(value.ToString(), dgvPersonasInactivas.Font);
                                maxWidth = Math.Max(maxWidth, (int)Math.Ceiling(cellSize.Width));
                            }
                        }
                    }

                    column.Width = maxWidth + 15; // +15 para padding visual
                }
            }
        }
        private void ordenarColumnas()
        {
            dgvPersonasInactivas.Columns["Dni"].DisplayIndex = 0;
            dgvPersonasInactivas.Columns["Apellido"].DisplayIndex = 1;
            dgvPersonasInactivas.Columns["Nombres"].DisplayIndex = 2;
        }
        private void nombrarColumnas()
        {
            dgvPersonasInactivas.Columns["Dni"].HeaderText = "DNI";
            dgvPersonasInactivas.Columns["Apellido"].HeaderText = "APELLIDO/S";
            dgvPersonasInactivas.Columns["Nombres"].HeaderText = "NOMBRES/S";
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
            this.Width = dgv.Left + dgv.Width + 30; // es para que el Form tome el tamaño del dgv
            btnPersonasInactivasClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        // Acciones
        private void tbxPersonasInactivasFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrar();
        }
        private void btnPersonasInactivasClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPersonasInactivas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Chofer sChofer = new Chofer();
            Mecanico sMecanico = new Mecanico();
            Fletero sFletero = new Fletero();
            Persona sPersona = new Persona();
            FrmFichaPersona ficha = null;
            if(e.RowIndex >= 0)
            {
                Object seleccion = (Object)dgvPersonasInactivas.CurrentRow.DataBoundItem;
                switch (puesto)
                {
                    case 1:
                        sChofer = seleccion as Chofer;
                        ficha = new FrmFichaPersona(puesto, 'F', sChofer, false);
                        break;
                    case 3:
                        sMecanico = seleccion as Mecanico;
                        ficha = new FrmFichaPersona(puesto, 'F', sMecanico, false);
                        break;
                    case 4:
                        sFletero = seleccion as Fletero;
                        ficha = new FrmFichaPersona(puesto, 'F', sFletero, false);
                        break;
                    default:
                        sPersona = seleccion as Persona;
                        ficha = new FrmFichaPersona(puesto, 'F', sPersona, false);
                        break;
                }
                ficha.ShowDialog();
                cargar();
            }
        }
    }
}
