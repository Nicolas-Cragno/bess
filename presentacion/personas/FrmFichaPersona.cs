using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using presentacion.eventos;

namespace presentacion.personas
{
    public partial class FrmFichaVehiculo : Form
    {
        private Form formularioPadre;
        private List<Evento> eventos = new List<Evento>();
        private Persona persona = new Persona();
        private Chofer chofer = new Chofer();
        private Mecanico mecanico = new Mecanico();
        private Fletero fletero = new Fletero();
        private int anchoMaximoDgv = 0;
        private int puesto;
        private char modo;
        private bool est;

        // Cargas
        public FrmFichaVehiculo(int oPuesto, char oModo, object oPersona = null, bool oEst = true, Form padre =null)
        {
            InitializeComponent();
            puesto = oPuesto;
            modo = oModo;
            est = oEst;
            formularioPadre = padre;
            determinarObjeto(oPersona);
        }
        private void FrmFichaPersona_Load(object sender, EventArgs e)
        {
            configuracion();
        }
        private void configuracion()
        {
            this.ControlBox = false; // oculta el manejo de la ventana superior
            colgarDerecha();
            btnFichaPersonaEventos.Visible = false; // ocultar boton de agregar evento
            switch (modo)
            {
                case 'F':
                    cargarDatos();
                    cargarEventos();
                    formatoColumnas();
                    break;
                case 'A':
                    formatoAgregar();
                    break;
                case 'M':
                    formatoModificar();
                    break;
                default:
                    cargarDatos();
                    cargarEventos();
                    formatoColumnas();
                    break;
            }

            if (est)
            {
                btnFichaPersonaAlta.Visible = false;
            }
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
        private void formatoAgregar()
        {
            if (modo == 'A')
            {
                cargarListas();
                lblFichaPersonaTitulo.Text = "NUEVO EMPLEADO";

                // Ocultar partede Eventos
                this.Size = new Size(358, 436);
                colgarDerecha();
                lblFichaPersonaFiltroEventos.Visible = false;
                tbxFichaPersonaFiltroEventos.Visible = false;
                btnFichaPersonaEventos.Visible = false;
                dgvFichaPersonaEventos.Visible = false;
                btnFichaPersonaEditar.Text = "Guardar";
                btnFichaPersonaAlta.Visible = false;

                // Datos especiales
                lblFichaPersonaData2.Text = "apellido/s";
                tbxFichaPersonaData2.ReadOnly = false;
                lblFichaPersonaData3.Text = "nombre/s";
                tbxFichaPersonaData3.ReadOnly = false;

                // Habilitar escritura
                tbxFichaPersonaDNI.ReadOnly = false;
                cbxFichaPersonaEmpresa.Enabled = true;
                tbxFichaPersonaDetalle.ReadOnly = false;

                // Ocultar
                lblFichaPersonaData1.Visible = false;
                tbxFichaPersonaData1.Visible = false;
                lblFichaPersonaData4.Visible = false;
                tbxFichaPersonaData4.Visible = false;
            }
        }
        private void formatoModificar()
        {
            AccesoDatos datos = new AccesoDatos();
            if (modo == 'M')
            {
                cargarListas();
                cargarDatos();
                cargarEventos();
                formatoColumnas();
                Persona persona = new Persona();
                int dni = int.Parse(tbxFichaPersonaDNI.Text);
                tbxFichaPersonaDNI.ReadOnly = true; // el dni queda bloqueado

                // Etiquetas
                btnFichaPersonaEditar.Text = "Guardar";
                lblFichaPersonaData2.Text = "apellido/s";
                lblFichaPersonaData3.Text = "nombre/s";

                // Información agregada
                persona = datos.buscarPersonaFull(dni);
                tbxFichaPersonaData2.Text = persona.Apellido;
                tbxFichaPersonaData3.Text = persona.Nombres;
               

                // Habilitar escritura
                cbxFichaPersonaEmpresa.Enabled = true;
                tbxFichaPersonaDetalle.ReadOnly = false;
                tbxFichaPersonaData2.ReadOnly = false;
                tbxFichaPersonaData3.ReadOnly = false;
                cbxFichaPersonaPuesto.Enabled = true;

                // Ocultar
                lblFichaPersonaData1.Visible = false;
                tbxFichaPersonaData1.Visible = false;
                lblFichaPersonaData4.Visible = false;
                tbxFichaPersonaData4.Visible = false;
                btnFichaPersonaAlta.Visible = false;
            }
        }
        private Object determinarObjeto(Object obj)
        {
            switch (puesto)
            {
                case 1: // choferes
                    return chofer = obj as Chofer;
                case 3: // mecanicos 
                    return mecanico = obj as Mecanico;
                case 4: // fleteros
                    return fletero = obj as Fletero;
                default: // otros
                    return persona = obj as Persona;
            }
        }
        private void cargarDatos()
        {
            if(modo == 'F' || modo == 'M') // Ficha o modificar trae la informacion de la persona
            {
                switch (puesto)
                {
                    case 1: // choferes
                        lblFichaPersonaTitulo.Text = chofer.Apellido + ", " + chofer.Nombres;
                        tbxFichaPersonaDNI.Text = chofer.Dni.ToString();
                        cbxFichaPersonaEmpresa.Text = chofer.Empresa;
                        cbxFichaPersonaPuesto.Text = chofer.Puesto;
                        cbxFichaPersonaEmpresa.Enabled = false;
                        cbxFichaPersonaPuesto.Enabled = false;
                        tbxFichaPersonaDetalle.Text = chofer.Detalle;
                        // variables segun puesto
                        lblFichaPersonaData1.Text = "tractor";
                        tbxFichaPersonaData1.Text = chofer.Tractor.ToString();
                        lblFichaPersonaData2.Text = "viajes";
                        tbxFichaPersonaData2.Text = chofer.Viajes.ToString();
                        lblFichaPersonaData3.Text = "promedio";
                        tbxFichaPersonaData3.Text = chofer.Promedio.ToString();
                        lblFichaPersonaData4.Text = "estado";
                        tbxFichaPersonaData4.Text = estado(chofer.Activo);
                        break;
                    case 3: // mecanicos 
                        lblFichaPersonaTitulo.Text = mecanico.Apellido + ", " + mecanico.Nombres;
                        tbxFichaPersonaDNI.Text = mecanico.Dni.ToString();
                        cbxFichaPersonaEmpresa.Text = mecanico.Empresa;
                        cbxFichaPersonaPuesto.Text = mecanico.Puesto;
                        cbxFichaPersonaEmpresa.Enabled = false;
                        cbxFichaPersonaPuesto.Enabled = false;
                        tbxFichaPersonaDetalle.Text = mecanico.Detalle;
                        // variables segun puesto
                        lblFichaPersonaData2.Text = "arreglos";
                        tbxFichaPersonaData2.Text = mecanico.Arreglos.ToString();
                        // oculto
                        lblFichaPersonaData1.Visible = false;
                        tbxFichaPersonaData1.Visible = false;
                        lblFichaPersonaData3.Visible = false;
                        tbxFichaPersonaData3.Visible = false;
                        lblFichaPersonaData4.Visible = false;
                        tbxFichaPersonaData4.Visible = false;
                        break;
                    case 4: // fleteros
                        lblFichaPersonaTitulo.Text = fletero.Apellido + ", " + fletero.Nombres;
                        tbxFichaPersonaDNI.Text = fletero.Dni.ToString();
                        cbxFichaPersonaEmpresa.Text = fletero.Empresa;
                        cbxFichaPersonaPuesto.Text = fletero.Puesto;
                        cbxFichaPersonaEmpresa.Enabled = false;
                        cbxFichaPersonaPuesto.Enabled = false;
                        tbxFichaPersonaDetalle.Text = fletero.Detalle;
                        // variables segun puesto
                        lblFichaPersonaData2.Text = "tractor";
                        tbxFichaPersonaData2.Text = fletero.MarcaTractor + " - " + fletero.ModeloTractor;
                        lblFichaPersonaData3.Text = "furgon";
                        tbxFichaPersonaData3.Text = fletero.MarcaFurgon;
                        // oculto
                        lblFichaPersonaData1.Visible = false;
                        tbxFichaPersonaData1.Visible = false;
                        lblFichaPersonaData4.Visible = false;
                        tbxFichaPersonaData4.Visible = false;
                        break;
                    default: // otros

                        break;
                }
            }
            else
            {
                lblFichaPersonaTitulo.Text = "NUEVO EMPLEADO";
                tbxFichaPersonaDNI.ReadOnly = false;
                cbxFichaPersonaEmpresa.Enabled = true;
                cbxFichaPersonaPuesto.Enabled = true;
                tbxFichaPersonaData2.ReadOnly = false;
                tbxFichaPersonaData3.ReadOnly = false;
                tbxFichaPersonaData3.ReadOnly = false;
                tbxFichaPersonaDetalle.ReadOnly = false;
                
            }
        }
        private void cargarEventos()
        {
            if(modo != 'A')
            {
                EventoNegocio eventoNegocio = new EventoNegocio();
                switch (puesto)
                {
                    case 1: // choferes
                        eventos = eventoNegocio.listarPorPersona(chofer.Dni);
                        break;
                    case 3: // mecanicos 
                        eventos = eventoNegocio.listarPorPersona(mecanico.Dni);
                        break;
                    case 4: // fleteros
                        eventos = eventoNegocio.listarPorPersona(fletero.Dni);
                        break;
                    default: // otros
                        eventos = eventoNegocio.listarPorPersona(persona.Dni);
                        break;
                }
                dgvFichaPersonaEventos.DataSource = eventos;
            }
        }
        private void cargarListas()
        {
            EmpresaNegocio empresaNegocio = new EmpresaNegocio();
            AccesoDatos datos = new AccesoDatos();

            List<string> empresas = empresaNegocio.listaNombres("PROPIA");
            List<string> puestos = datos.listarPuestos();

            cbxFichaPersonaEmpresa.DataSource = empresas;
            cbxFichaPersonaEmpresa.SelectedIndex = 0;
            cbxFichaPersonaPuesto.DataSource = puestos;
            cbxFichaPersonaPuesto.SelectedIndex = 0;
        }

        // Botones - Clicks
        private void btnFichaPersonaCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnFichaPersonaEditar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case 'A':
                    bool accion = agregar();
                    if (accion)
                        Close();
                    break;
                case 'M':
                    modificar();
                    Close();
                    break;
                case 'F':
                    FrmFichaVehiculo fichaModificar = null;
                    switch (puesto)
                    {
                        case 1:
                            fichaModificar = new FrmFichaVehiculo(puesto, 'M', chofer, chofer.Activo, this);
                            break;
                        case 3:
                            fichaModificar = new FrmFichaVehiculo(puesto, 'M', mecanico, mecanico.Activo, this);
                            break;
                        case 4:
                            fichaModificar = new FrmFichaVehiculo(puesto, 'M', fletero, fletero.Activo, this);
                            break;
                        default:
                            fichaModificar = new FrmFichaVehiculo(puesto, 'M', persona, persona.Activo, this);
                            break;
                    }
                    fichaModificar.ShowDialog();
                    Close();
                    break;
                default:
                    break;
            }
        }

        // Data Grid View
        private void filtrar()
        {
            List<Evento> listaFiltrada;
            string filtro = tbxFichaPersonaFiltroEventos.Text;

            if (filtro != "")
            {
                listaFiltrada = eventos.FindAll(ev => ev.Tipo.ToString().Contains(filtro.ToUpper()) || ev.Fecha.ToString().Contains(filtro.ToUpper()) || ev.Persona.ToString().Contains(filtro.ToUpper()) || ev.Tractor.ToString().Contains(filtro.ToUpper()) || ev.Furgon.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = eventos;
            }

            dgvFichaPersonaEventos.DataSource = null;
            dgvFichaPersonaEventos.DataSource = listaFiltrada;
            formatoColumnas();
        }
        private void tbxFichaPersonaFiltroEventos_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrar();
        }
        private void dgvFichaPersonaEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0){
                Evento seleccion = (Evento)dgvFichaPersonaEventos.CurrentRow.DataBoundItem;

                FrmFichaEvento fichaEvento = new FrmFichaEvento('F', seleccion, this);
                fichaEvento.ShowDialog();
                configuracion();
            }
        }
        private void formatoColumnas()
        {
            nombrarColumnas();
            ocultarColumnas();
            ordenarColumnas();
            anchoColumnas();
            // ajustarDgv();
        }
        private void nombrarColumnas()
        {
            dgvFichaPersonaEventos.Columns["Tipo"].HeaderText = "";
            dgvFichaPersonaEventos.Columns["Tractor"].HeaderText = "TRACTOR";
            dgvFichaPersonaEventos.Columns["Furgon"].HeaderText = "FURGON";
            dgvFichaPersonaEventos.Columns["Fecha"].HeaderText = "FECHA";
        }
        private void ocultarColumnas()
        {
            dgvFichaPersonaEventos.Columns["Id"].Visible = false;
            dgvFichaPersonaEventos.Columns["DniPersona"].Visible = false;
            dgvFichaPersonaEventos.Columns["Persona"].Visible = false;
            dgvFichaPersonaEventos.Columns["Detalle"].Visible = false;
        }
        private void ordenarColumnas()
        {
            dgvFichaPersonaEventos.Columns["Tipo"].DisplayIndex = 0;
            dgvFichaPersonaEventos.Columns["Fecha"].DisplayIndex = 1;
            dgvFichaPersonaEventos.Columns["Tractor"].DisplayIndex = 2;
            dgvFichaPersonaEventos.Columns["Furgon"].DisplayIndex = 3;
        }
        private void anchoColumnas()
        {
            dgvFichaPersonaEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFichaPersonaEventos.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvFichaPersonaEventos.Columns)
            {
                column.Width += 15;
            }
            dgvFichaPersonaEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        private void ajustarDgv()
        {
            if (anchoMaximoDgv == 0)
            {
                int anchoTotal = dgvFichaPersonaEventos.RowHeadersVisible ? dgvFichaPersonaEventos.RowHeadersWidth : 0;

                foreach (DataGridViewColumn col in dgvFichaPersonaEventos.Columns)
                {
                    if (col.Visible)
                        anchoTotal += col.Width + 1;
                }

                // Si hay scroll vertical (más filas que alto disponible), lo sumamos. Si no, no.
                if (dgvFichaPersonaEventos.DisplayedRowCount(false) < dgvFichaPersonaEventos.RowCount)
                    anchoTotal += SystemInformation.VerticalScrollBarWidth;

                anchoMaximoDgv = anchoTotal;
            }

            dgvFichaPersonaEventos.Width = anchoMaximoDgv;
        }

        // Agregar - Modificar
        private bool agregar()
        {
            PersonaNegocio personaNegocio = new PersonaNegocio();
            Persona auxPersona = new Persona();
            Validaciones validaciones = new Validaciones();
            int campos = 3, validos = 0;

            if(modo == 'A')
            {
                // Campos obligatorios = 3
                if (tbxFichaPersonaDNI.Text != null && tbxFichaPersonaDNI.Text != "")
                {
                    auxPersona.Dni = int.Parse(tbxFichaPersonaDNI.Text);
                    validos++;
                }
                if (tbxFichaPersonaData2.Text != null && tbxFichaPersonaData2.Text != "")
                {
                    auxPersona.Apellido = tbxFichaPersonaData2.Text;
                    validos++;
                }
                if (tbxFichaPersonaData3.Text != null && tbxFichaPersonaData3.Text != "")
                {
                    auxPersona.Nombres = tbxFichaPersonaData3.Text;
                    validos++;
                }

                // Campos que pueden estar sin definir
                auxPersona.Empresa = cbxFichaPersonaEmpresa.Text;
                auxPersona.Puesto = cbxFichaPersonaPuesto.Text;
                auxPersona.Detalle = tbxFichaPersonaDetalle.Text;

                if (validaciones.validarCampos(campos, validos))
                {
                    try
                    {
                        personaNegocio.agregar(auxPersona);
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627 || ex.Number == 2601)
                        {
                            MessageBox.Show("La persona ya se encuentra registrada, revisar inactivos.");
                            return false;
                        }
                        else
                        {
                            MessageBox.Show("Error en la carga, verificar datos.");
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos obligatorios");
                    return false;
                }
            }

            return false;
        }
        private bool modificar() 
        {
            Persona auxPersona = new Persona();
            PersonaNegocio personaNegocio = new PersonaNegocio();
            Validaciones validaciones = new Validaciones();
            int campos = 2, validos = 0;
            if (modo == 'M')
            {
                auxPersona.Dni = int.Parse(tbxFichaPersonaDNI.Text);

                // Campos obligatorios = 3
                if (tbxFichaPersonaData2.Text != null && tbxFichaPersonaData2.Text != "")
                {
                    auxPersona.Apellido = tbxFichaPersonaData2.Text;
                    validos++;
                }
                if (tbxFichaPersonaData3.Text != null && tbxFichaPersonaData3.Text != "")
                {
                    auxPersona.Nombres = tbxFichaPersonaData3.Text;
                    validos++;
                }

                // Campos que pueden estar vacios
                auxPersona.Puesto = cbxFichaPersonaPuesto.Text;
                auxPersona.Detalle = tbxFichaPersonaDetalle.Text;
                auxPersona.Empresa = cbxFichaPersonaEmpresa.Text;
                
                if (validaciones.validarCampos(campos, validos))
                {
                    try
                    {
                        personaNegocio.modificar(auxPersona);
                        MessageBox.Show("Modificado correctamente.");
                        return true;
                    }
                    catch (SqlException ex)
                    {
                            MessageBox.Show("Error en la carga, verificar datos.");
                            return false;
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos obligatorios");
                    return false;
                }

            }
                return false;
        }


        // Otros
        private string estado(bool activo)
        {
            string estado;
            if (activo)
            {
                estado = "ACTIVO";
            } else
            {
                estado = "INACTIVO";
            }
            return estado;
        }
        private void btnFichaPersonaAlta_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.estadoPersona(int.Parse(tbxFichaPersonaDNI.Text), true);
                MessageBox.Show("Alta dada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.");
            }

            Close();
        }

        private void btnFichaPersonaEventos_Click(object sender, EventArgs e)
        {

        }
    }
}
