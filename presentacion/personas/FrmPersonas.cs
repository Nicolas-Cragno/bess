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

namespace presentacion.personas
{
    public partial class FrmPersonas : Form
    {
        int puesto;
        private List<Chofer> listadoChoferes;
        private List<Mecanico> listadoMecanicos;
        private List<Fletero> listadoFleteros;
        private List<Persona> listadoPersonas;
        // private List<Administrativo> listadoAdministrativos;
        public FrmPersonas(int pPuesto)
        {
            InitializeComponent();
            puesto = pPuesto;

            AccesoDatos datos = new AccesoDatos();
            lblPersonasTitulo.Text = datos.buscarPuesto(puesto);
            lblPersonasTitulo.Left = (this.ClientSize.Width - lblPersonasTitulo.Width) / 2;
        }
        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            this.ControlBox = false; // oculta el manejo de la ventana superior
            PersonaNegocio personaNegocio = new PersonaNegocio();
            ChoferNegocio choferNegocio = new ChoferNegocio();
            MecanicoNegocio mecanicoNegocio = new MecanicoNegocio();
            FleteroNegocio fleteroNegocio = new FleteroNegocio();
            switch (puesto)
            {
                case 1: // chofer larga distancia
                    listadoChoferes = choferNegocio.listar(1, puesto);
                    dgvPersonas.DataSource = listadoChoferes;
                    formatoColumnas(listadoChoferes);
                    break;
                case 3: // mecanicos
                    listadoMecanicos = mecanicoNegocio.listar(1, puesto);
                    dgvPersonas.DataSource = listadoMecanicos;
                    formatoColumnas(listadoMecanicos);
                    break;
                case 4: // fleteros
                    listadoFleteros = fleteroNegocio.listar();
                    btnPersonasInactivas.Visible = false;
                    dgvPersonas.DataSource = listadoFleteros;
                    formatoColumnas(listadoFleteros);
                    break;
                default: // sin asignar / otros.
                    listadoPersonas = personaNegocio.listar(1);
                    dgvPersonas.DataSource = listadoPersonas;
                    formatoColumnas(listadoPersonas);
                    break;
            }
        }

        // Filtros a DGV
        private void tbxPersonasFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrar();
        }
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
                case 4:
                    filtroChofer();
                    break;
                default:
                    filtroPersona();
                    break;
            }
        }
        private void filtroChofer() 
        {
            List<Chofer> listaFiltrada;
            string filtro = tbxPersonasFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoChoferes.FindAll(ch => ch.Dni.ToString().Contains(filtro.ToUpper()) || ch.Apellido.ToString().Contains(filtro.ToUpper()) || ch.Nombres.ToString().Contains(filtro.ToUpper()) || ch.Empresa.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoChoferes;
            }

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = listaFiltrada;
            formatoColumnas(listadoChoferes);
        }
        private void filtroMecanico() 
        {
            List<Mecanico> listaFiltrada;
            string filtro = tbxPersonasFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoMecanicos.FindAll(m => m.Dni.ToString().Contains(filtro.ToUpper()) || m.Apellido.ToString().Contains(filtro.ToUpper()) || m.Nombres.ToString().Contains(filtro.ToUpper()) || m.Empresa.ToString().Contains(filtro.ToUpper()) || m.Detalle.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoMecanicos;
            }

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = listaFiltrada;
            formatoColumnas(listadoMecanicos);
        }   
        private void filtroPersona() 
        {
            List<Persona> listaFiltrada;
            string filtro = tbxPersonasFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoPersonas.FindAll(p => p.Dni.ToString().Contains(filtro.ToUpper()) || p.Apellido.ToString().Contains(filtro.ToUpper()) || p.Nombres.ToString().Contains(filtro.ToUpper()) || p.Empresa.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoPersonas;
            }

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = listaFiltrada;
            formatoColumnas(listadoPersonas);
        }

        // DGV & columnas
        private void formatoColumnas(object lista)
        {
            ocultarColumnas();
            anchoColumnas(lista);
            ordenarColumnas();
            nombrarColumnas();
        }
        private void ocultarColumnas()
        {
            switch (puesto)
            {
                case 1: // chofer larga distancia
                    dgvPersonas.Columns["Tractor"].Visible = false;
                    dgvPersonas.Columns["Diferencias"].Visible = false;
                    dgvPersonas.Columns["Puesto"].Visible = false;
                    dgvPersonas.Columns["Detalle"].Visible = false;
                    dgvPersonas.Columns["Activo"].Visible = false;
                    break;
                case 2: // chofer movimiento
                    break;
                case 3: // mecanicos
                    dgvPersonas.Columns["Sede"].Visible = false;
                    dgvPersonas.Columns["Vehiculo"].Visible = false;
                    dgvPersonas.Columns["Arreglos"].Visible = false;
                    dgvPersonas.Columns["Puesto"].Visible = false;
                    dgvPersonas.Columns["Detalle"].Visible = false;
                    dgvPersonas.Columns["Activo"].Visible = false;
                    break;
                case 4: // fleteros
                    dgvPersonas.Columns["Puesto"].Visible = false;
                    dgvPersonas.Columns["Activo"].Visible = false;
                    dgvPersonas.Columns["Ingreso"].Visible = false;
                    dgvPersonas.Columns["Empresa"].Visible = false;
                    dgvPersonas.Columns["ModeloTractor"].Visible = false;
                    dgvPersonas.Columns["MarcaTractor"].Visible = false;
                    dgvPersonas.Columns["DetalleTractor"].Visible = false;
                    dgvPersonas.Columns["MarcaFurgon"].Visible = false;
                    dgvPersonas.Columns["DetalleFurgon"].Visible = false;
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

            using (Graphics g = dgvPersonas.CreateGraphics())
            {
                foreach (DataGridViewColumn column in dgvPersonas.Columns)
                {
                    int maxWidth = 0;

                    // Medir encabezado
                    SizeF headerSize = g.MeasureString(column.HeaderText, dgvPersonas.Font);
                    maxWidth = (int)Math.Ceiling(headerSize.Width);

                    // Medir en toda la lista original (no filtrada)
                    foreach (var item in lista)
                    {
                        var prop = item.GetType().GetProperty(column.DataPropertyName);
                        if (prop != null)
                        {
                            object value = prop.GetValue(item);
                            if (value != null)
                            {
                                SizeF cellSize = g.MeasureString(value.ToString(), dgvPersonas.Font);
                                maxWidth = Math.Max(maxWidth, (int)Math.Ceiling(cellSize.Width));
                            }
                        }
                    }

                    column.Width = maxWidth + 5;
                }
            }
        }
        private void ordenarColumnas()
        {
            dgvPersonas.Columns["Dni"].DisplayIndex = 0;
            dgvPersonas.Columns["Apellido"].DisplayIndex = 1;
            dgvPersonas.Columns["Nombres"].DisplayIndex = 2;
            dgvPersonas.Columns["Detalle"].DisplayIndex = 3;
            dgvPersonas.Columns["Empresa"].DisplayIndex = 4;
            switch (puesto)
            {
                case 1: // chofer larga distancia
                    dgvPersonas.Columns["Viajes"].DisplayIndex = 5;
                    dgvPersonas.Columns["Promedio"].DisplayIndex = 6;
                    break;
                case 4: // fleteros
                    dgvPersonas.Columns["dominioTractor"].DisplayIndex = 5;
                    dgvPersonas.Columns["dominioFurgon"].DisplayIndex = 6;
                    break;
                default:  // sin asignar / otros
                    break;
            }
        }
        private void nombrarColumnas()
        {
            //dgvPersonas.Columns["Dni"].HeaderText = "";
            dgvPersonas.Columns["Dni"].HeaderText = "DNI";
            dgvPersonas.Columns["Apellido"].HeaderText = "APELLIDO/S";
            dgvPersonas.Columns["Nombres"].HeaderText = "NOMBRES/S";
            dgvPersonas.Columns["Detalle"].HeaderText = "DETALLE";
            switch (puesto)
            {
                case 1: // chofer larga distancia
                    dgvPersonas.Columns["Viajes"].HeaderText = "VIAJES";
                    dgvPersonas.Columns["Promedio"].HeaderText = "LTS C/100";
                    dgvPersonas.Columns["Empresa"].HeaderText = "";
                    break;
                case 4: // fleteros
                    dgvPersonas.Columns["dominioTractor"].HeaderText = "TRACTOR";
                    dgvPersonas.Columns["dominioFurgon"].HeaderText = "FURGON";
                    break;
                default:  // sin asignar / otros
                    break;
            }
        }
        private void btnPersonasInactivas_Click(object sender, EventArgs e)
        {
            FrmPersonasInactivas ventana = new FrmPersonasInactivas(puesto);
            ventana.ShowDialog();
            cargar();
        }

        private void dgvPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmFichaPersona ficha = null;
            switch (puesto)
            {
                case 1:
                    Chofer chofer = (Chofer)dgvPersonas.CurrentRow.DataBoundItem;
                    ficha = new FrmFichaPersona(puesto, chofer);
                    break;
                case 3:
                    Mecanico mecanico = (Mecanico)dgvPersonas.CurrentRow.DataBoundItem;
                    ficha = new FrmFichaPersona(puesto, mecanico);
                    break;
                case 4:
                    Fletero fletero = (Fletero)dgvPersonas.CurrentRow.DataBoundItem;
                    ficha = new FrmFichaPersona(puesto, fletero);
                    break;
                default:
                    Persona persona = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
                    ficha = new FrmFichaPersona(puesto, persona);
                    break;
            }
            ficha.ShowDialog();
            cargar();
        }
    }
}
