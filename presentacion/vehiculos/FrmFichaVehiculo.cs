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

namespace presentacion.vehiculos
{
    public partial class FrmFichaVehiculo : Form
    {
        private char tipo, modo;
        private Tractor tractor = new Tractor();
        private Furgon furgon = new Furgon();
        private Vehiculo vehiculo = new Vehiculo();
        private List<Evento> eventos = new List<Evento>();
        private Object stdVehiculo = new Object(); // para el form de editar
        private Form formularioPadre;

        // Cargas
        public FrmFichaVehiculo(char sTipo, char sModo, object sVehiculo, Form padre=null)
        {
            InitializeComponent();
            tipo = sTipo;
            modo = sModo;
            formularioPadre = padre;
            determinarObjeto(sVehiculo);

        }
        private Object determinarObjeto(Object obj)
        {
            switch (tipo)
            {
                case 'T':
                    return tractor = obj as Tractor;
                case 'F':
                    return furgon = obj as Furgon;
                default:
                    return vehiculo = obj as Vehiculo;
            }
        }
        private void FrmFichaVehiculo_Load(object sender, EventArgs e)
        {
            configuracion();
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
        private void configuracion()
        {
            this.ControlBox = false;
            btnFichaVehiculoNuevoEvento.Visible = false; // ocultar boton de agregar evento
            switch (modo)
            {
                case 'F':
                    formatoFicha();
                    break;
                case 'A':
                    formatoAgregar();
                    break;
                case 'M':
                    formatoModificar();
                    break;
                default:
                    
                    break;
            }
        }
        private string textoEstado(bool estado)
        {
            string textoEstado;
            if (estado) 
            {
                textoEstado = "ACTIVO";
            } else
            {
                textoEstado = "INACTIVO";
            }
            return textoEstado;
        }
        private void formatoFicha()
        {
            EventoNegocio eventoNegocio = new EventoNegocio();
            btnFichaVehiculoAlta.Visible = false;
            switch (tipo)
            {
                case 'T': // Tractor
                    lblFichaVehiculoTitulo.Text = "TRACTOR " + tractor.Interno;
                    cbxFichaVehiculoTipo.Text = "TRACTOR"; cbxFichaVehiculoTipo.Enabled = false;
                    cbxFichaVehiculoEmpresa.Text = tractor.Empresa; cbxFichaVehiculoEmpresa.Enabled = false;
                    tbxFichaVehiculoDominio.Text = tractor.Dominio; tbxFichaVehiculoDominio.ReadOnly = true;
                    tbxFichaVehiculoMarca.Text = tractor.Marca; tbxFichaVehiculoMarca.ReadOnly = true;
                    tbxFichaVehiculoModelo.Text = tractor.Modelo.ToString(); tbxFichaVehiculoModelo.ReadOnly = true;
                    tbxFichaVehiculoEstado.Text = textoEstado(tractor.Activo); tbxFichaVehiculoEstado.ReadOnly = true;
                    tbxFichaVehiculoDetalle.Text = tractor.Detalle; tbxFichaVehiculoDetalle.ReadOnly = true;
                    eventos = eventoNegocio.listarPorTractor(tractor.Interno);
                    break;
                case 'F': // Furgon
                    lblFichaVehiculoTitulo.Text = "FURGON " + furgon.Interno;
                    cbxFichaVehiculoTipo.Text = "FURGON"; cbxFichaVehiculoTipo.Enabled = false;
                    cbxFichaVehiculoEmpresa.Text = furgon.Empresa; cbxFichaVehiculoEmpresa.Enabled = false;
                    tbxFichaVehiculoDominio.Text = furgon.Dominio; tbxFichaVehiculoDominio.ReadOnly = true;
                    tbxFichaVehiculoMarca.Visible = false;
                    tbxFichaVehiculoModelo.Visible = false;
                    tbxFichaVehiculoEstado.Text = textoEstado(furgon.Activo); tbxFichaVehiculoEstado.ReadOnly = true;
                    tbxFichaVehiculoDetalle.Text = furgon.Detalle; tbxFichaVehiculoDetalle.ReadOnly = true;
                    lblFichaVehiculoMarca.Visible = false;
                    lblFichaVehiculoModelo.Visible = false;
                    eventos = eventoNegocio.listarPorFurgon(furgon.Interno);
                    break;
                default: // Por default
                    lblFichaVehiculoTitulo.Text = "TRACTOR " + tractor.Interno;
                    cbxFichaVehiculoTipo.Text = "TRACTOR"; cbxFichaVehiculoTipo.Enabled = false;
                    cbxFichaVehiculoEmpresa.Text = tractor.Empresa; cbxFichaVehiculoEmpresa.Enabled = false;
                    tbxFichaVehiculoDominio.Text = tractor.Dominio; tbxFichaVehiculoDominio.ReadOnly = true;
                    tbxFichaVehiculoMarca.Text = tractor.Marca; tbxFichaVehiculoMarca.ReadOnly = true;
                    tbxFichaVehiculoModelo.Text = tractor.Modelo.ToString(); tbxFichaVehiculoModelo.ReadOnly = true;
                    tbxFichaVehiculoEstado.Text = textoEstado(tractor.Activo); tbxFichaVehiculoEstado.ReadOnly = true;
                    tbxFichaVehiculoDetalle.Text = tractor.Detalle; tbxFichaVehiculoDetalle.ReadOnly = true;
                    eventos = eventoNegocio.listarPorTractor(tractor.Interno);
                    break;
            }
            dgvFichaVehiculoEventos.DataSource = eventos;
        }
        private void formatoModificar()
        {
            EventoNegocio eventoNegocio = new EventoNegocio();
            cargarListas();
            btnFichaVehiculoOK.Text = "Guardar";
            switch (tipo)
            {
                case 'T': 
                    lblFichaVehiculoTitulo.Text = "TRACTOR " + tractor.Interno;
                    cbxFichaVehiculoTipo.Text = "TRACTOR"; cbxFichaVehiculoTipo.Enabled = false;
                    cbxFichaVehiculoEmpresa.Text = tractor.Empresa; cbxFichaVehiculoEmpresa.Enabled = true;
                    tbxFichaVehiculoDominio.Text = tractor.Dominio; tbxFichaVehiculoDominio.ReadOnly = false;
                    tbxFichaVehiculoMarca.Text = tractor.Marca; tbxFichaVehiculoMarca.ReadOnly = false;
                    tbxFichaVehiculoModelo.Text = tractor.Modelo.ToString(); tbxFichaVehiculoModelo.ReadOnly = false;
                    tbxFichaVehiculoEstado.Text = textoEstado(tractor.Activo); tbxFichaVehiculoEstado.ReadOnly = true;
                    tbxFichaVehiculoDetalle.Text = tractor.Detalle; tbxFichaVehiculoDetalle.ReadOnly = false;
                    eventos = eventoNegocio.listarPorTractor(tractor.Interno);
                    if (tractor.Activo)
                        btnFichaVehiculoAlta.Text = "Dar de baja";
                    break;
                case 'F':
                    lblFichaVehiculoTitulo.Text = "FURGON " + furgon.Interno;
                    cbxFichaVehiculoTipo.Text = "FURGON"; cbxFichaVehiculoTipo.Enabled = false;
                    cbxFichaVehiculoEmpresa.Text = furgon.Empresa; cbxFichaVehiculoEmpresa.Enabled = true;
                    tbxFichaVehiculoDominio.Text = furgon.Dominio; tbxFichaVehiculoDominio.ReadOnly = false;
                    tbxFichaVehiculoMarca.Visible = false;
                    tbxFichaVehiculoModelo.Visible = false;
                    tbxFichaVehiculoEstado.Text = textoEstado(furgon.Activo); tbxFichaVehiculoEstado.ReadOnly = false;
                    tbxFichaVehiculoDetalle.Text = furgon.Detalle; tbxFichaVehiculoDetalle.ReadOnly = false;
                    lblFichaVehiculoMarca.Visible = false;
                    lblFichaVehiculoModelo.Visible = false;
                    eventos = eventoNegocio.listarPorFurgon(furgon.Interno);
                    if (furgon.Activo)
                        btnFichaVehiculoAlta.Text = "Dar de baja";

                    break;
                default:
                    lblFichaVehiculoTitulo.Text = "TRACTOR " + tractor.Interno;
                    cbxFichaVehiculoTipo.Text = "TRACTOR"; cbxFichaVehiculoTipo.Enabled = false;
                    cbxFichaVehiculoEmpresa.Text = tractor.Empresa; cbxFichaVehiculoEmpresa.Enabled = true;
                    tbxFichaVehiculoDominio.Text = tractor.Dominio; tbxFichaVehiculoDominio.ReadOnly = false;
                    tbxFichaVehiculoMarca.Text = tractor.Marca; tbxFichaVehiculoMarca.ReadOnly = false;
                    tbxFichaVehiculoModelo.Text = tractor.Modelo.ToString(); tbxFichaVehiculoModelo.ReadOnly = false;
                    tbxFichaVehiculoEstado.Text = textoEstado(tractor.Activo); tbxFichaVehiculoEstado.ReadOnly = false;
                    tbxFichaVehiculoDetalle.Text = tractor.Detalle; tbxFichaVehiculoDetalle.ReadOnly = true;
                    eventos = eventoNegocio.listarPorTractor(tractor.Interno);
                    if (tractor.Activo)
                        btnFichaVehiculoAlta.Text = "Dar de baja";

                    break;
            }
            dgvFichaVehiculoEventos.DataSource = eventos;
        }
        private void formatoAgregar()
        {
            cargarListas();
            btnFichaVehiculoOK.Text = "Guardar";
            btnFichaVehiculoAlta.Visible = false;
            this.Size = new Size(358, 436);

            switch (tipo)
            {
                case 'T':
                    lblFichaVehiculoTitulo.Text = "NUEVO TRACTOR";
                    cbxFichaVehiculoTipo.Text = "TRACTOR";
                    cbxFichaVehiculoTipo.Enabled = false;
                    cbxFichaVehiculoEmpresa.Enabled = true;
                    tbxFichaVehiculoDominio.ReadOnly = false;
                    tbxFichaVehiculoMarca.ReadOnly = false;
                    tbxFichaVehiculoModelo.ReadOnly = false;
                    tbxFichaVehiculoEstado.ReadOnly = false;
                    tbxFichaVehiculoDetalle.ReadOnly = false;
                    break;
                case 'F':
                    lblFichaVehiculoTitulo.Text = "NUEVO FURGON";
                    cbxFichaVehiculoTipo.Text = "FURGON"; cbxFichaVehiculoTipo.Enabled = false;
                    cbxFichaVehiculoEmpresa.Enabled = true;
                    tbxFichaVehiculoDominio.ReadOnly = false;
                    tbxFichaVehiculoMarca.Visible = false;
                    tbxFichaVehiculoModelo.Visible = false;
                    tbxFichaVehiculoEstado.ReadOnly = false;
                    tbxFichaVehiculoDetalle.ReadOnly = false;
                    lblFichaVehiculoMarca.Visible = false;
                    lblFichaVehiculoModelo.Visible = false;
                    break;
                default:
                    lblFichaVehiculoTitulo.Text = "NUEVO VEHICULO";
                    break;
            }
        }
        private void btnFichaVehiculoOK_Click(object sender, EventArgs e)
        {
            TractorNegocio tractorNegocio = new TractorNegocio();
            FurgonNegocio furgonNegocio = new FurgonNegocio();
            Validaciones validar = new Validaciones();
            switch (modo)
            {
                case 'F':
                    FrmFichaVehiculo fichaModificar;
                    switch (tipo)
                    {
                        case 'T':
                            fichaModificar = new FrmFichaVehiculo(tipo, 'M', tractor, this);
                            break;
                        case 'F':
                            fichaModificar = new FrmFichaVehiculo(tipo, 'M', furgon, this);
                            break;
                        default:
                            fichaModificar = new FrmFichaVehiculo(tipo, 'M', tractor, this);
                            break;
                    }
                    fichaModificar.ShowDialog();
                    break;
                case 'A':
                    switch (tipo)
                    {
                        case 'T':
                            Tractor auxTractor = new Tractor();
                            auxTractor.Interno = validar.validarInt(tbxFichaVehiculoEstado.Text);
                            auxTractor.Dominio = validar.validarTexto(tbxFichaVehiculoDominio.Text);
                            auxTractor.Empresa = cbxFichaVehiculoEmpresa.Text;
                            auxTractor.Marca = validar.validarTexto(tbxFichaVehiculoMarca.Text);
                            auxTractor.Modelo = validar.validarInt(tbxFichaVehiculoModelo.Text);
                            auxTractor.Detalle = validar.validarTexto(tbxFichaVehiculoDetalle.Text);

                            try
                            {
                                tractorNegocio.agregar(auxTractor);
                                MessageBox.Show("Tractor agregado.");
                                Close();
                            }
                            catch (SqlException ex)
                            {
                                if(ex.Number == 2627 || ex.Number == 2601)
                                {
                                    MessageBox.Show("El interno " + auxTractor.Interno.ToString() + " ya está registrado.");
                                }
                            }
                            break;
                        case 'F':
                            Furgon auxFurgon = new Furgon();
                            auxFurgon.Interno = validar.validarInt(tbxFichaVehiculoEstado.Text);
                            auxFurgon.Dominio = validar.validarTexto(tbxFichaVehiculoDominio.Text);
                            auxFurgon.Empresa = cbxFichaVehiculoEmpresa.Text;
                            auxFurgon.Detalle = validar.validarTexto(tbxFichaVehiculoDetalle.Text) ;
                            try
                            {
                                furgonNegocio.agregar(auxFurgon);
                                MessageBox.Show("Furgon agregado.");
                                Close();
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 2627 || ex.Number == 2601)
                                {
                                    MessageBox.Show("El interno " + auxFurgon.Interno.ToString() + " ya está registrado.");
                                }
                            }
                            break;
                        default:
                            MessageBox.Show("Agregar vehiculo.");
                            break;
                    }
                    break;
                case 'M':
                    switch (tipo)
                    {
                        case 'T':
                            Tractor auxTractor = new Tractor();
                            auxTractor.Interno = tractor.Interno;
                            auxTractor.Empresa = cbxFichaVehiculoEmpresa.Text;
                            auxTractor.Dominio = validar.validarTexto(tbxFichaVehiculoDominio.Text);
                            auxTractor.Marca = validar.validarTexto(tbxFichaVehiculoMarca.Text);
                            auxTractor.Modelo = validar.validarInt(tbxFichaVehiculoModelo.Text);
                            auxTractor.Detalle = validar.validarTexto(tbxFichaVehiculoDetalle.Text);

                            tractorNegocio.modificar(auxTractor);
                            MessageBox.Show("Cambios guardados.");
                            break;
                        case 'F':
                            Furgon auxFurgon = new Furgon();
                            auxFurgon.Interno = furgon.Interno;
                            auxFurgon.Dominio = validar.validarTexto(tbxFichaVehiculoDominio.Text);
                            auxFurgon.Empresa = cbxFichaVehiculoEmpresa.Text;
                            auxFurgon.Detalle = validar.validarTexto(tbxFichaVehiculoDetalle.Text);

                            furgonNegocio.modificar(auxFurgon);
                            MessageBox.Show("Cambios guardados.");
                            break;
                        default:

                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
            
            Close();
        }
        private void cargarListas()
        {
            VehiculoNegocio vehiculoNegocio = new VehiculoNegocio();
            EmpresaNegocio empresaNegocio = new EmpresaNegocio();
            List<string> tiposVehiculos = vehiculoNegocio.listarTipos();
            List<string> empresas = empresaNegocio.listaNombres("PROPIA");

            cbxFichaVehiculoTipo.DataSource = tiposVehiculos;
            cbxFichaVehiculoEmpresa.DataSource = empresas;

        }
        private void dgvFichaVehiculoEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Evento seleccion = (Evento)dgvFichaVehiculoEventos.CurrentRow.DataBoundItem;

                FrmFichaEvento fichaEvento = new FrmFichaEvento('F', seleccion, this);
                fichaEvento.ShowDialog();
                configuracion();
            }
        }

        // Botones y clicks
        private void btnFichaVehiculoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxFichaVehiculoFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrar();
        }
        private void btnFichaVehiculoAlta_Click(object sender, EventArgs e)
        {
            TractorNegocio tractorNegocio = new TractorNegocio();
            FurgonNegocio furgonNegocio = new FurgonNegocio();
            switch (tipo)
            {
                case 'T':
                    tractorNegocio.cambiarEstado(tractor.Interno, tractor.Activo);
                    if (tractor.Activo)
                    {
                        MessageBox.Show("Tractor dado de baja");
                    }
                    else
                    {
                        MessageBox.Show("Tractor dado de alta");
                    }
                    break;
                case 'F':
                    furgonNegocio.cambiarEstado(furgon.Interno, furgon.Activo);
                    if (furgon.Activo)
                    {
                        MessageBox.Show("Furgon dado de baja");
                    }
                    else
                    {
                        MessageBox.Show("Furgon dado de alta");
                    }
                    break;
                default:
                    break;
            }
            Close();
        }

        // Data grid view
        private void filtrar()
        {
            List<Evento> listaFiltrada;
            string filtro = tbxFichaVehiculoFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = eventos.FindAll(ev => ev.Tipo.ToString().Contains(filtro.ToUpper()) || ev.Fecha.ToString().Contains(filtro.ToUpper()) || ev.Persona.ToString().Contains(filtro.ToUpper()) || ev.Tractor.ToString().Contains(filtro.ToUpper()) || ev.Furgon.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = eventos;
            }

            dgvFichaVehiculoEventos.DataSource = null;
            dgvFichaVehiculoEventos.DataSource = listaFiltrada;
            formatoColumnas();
        }
        private void formatoColumnas()
        {
            nombrarColumnas();
            ocultarColumnas();
            ordenarColumnas();
            anchoColumnas();
        }
        private void nombrarColumnas()
        {
            dgvFichaVehiculoEventos.Columns["Tipo"].HeaderText = "";
            dgvFichaVehiculoEventos.Columns["Tractor"].HeaderText = "TRACTOR";
            dgvFichaVehiculoEventos.Columns["Furgon"].HeaderText = "FURGON";
            dgvFichaVehiculoEventos.Columns["Fecha"].HeaderText = "FECHA";
        }
        private void ocultarColumnas()
        {
            dgvFichaVehiculoEventos.Columns["Id"].Visible = false;
            dgvFichaVehiculoEventos.Columns["DniPersona"].Visible = false;
            dgvFichaVehiculoEventos.Columns["Persona"].Visible = false;
            dgvFichaVehiculoEventos.Columns["Detalle"].Visible = false;
        }
        private void ordenarColumnas()
        {
            dgvFichaVehiculoEventos.Columns["Tipo"].DisplayIndex = 0;
            dgvFichaVehiculoEventos.Columns["Fecha"].DisplayIndex = 1;
            dgvFichaVehiculoEventos.Columns["Tractor"].DisplayIndex = 2;
            dgvFichaVehiculoEventos.Columns["Furgon"].DisplayIndex = 3;
        }
        private void anchoColumnas()
        {
            dgvFichaVehiculoEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFichaVehiculoEventos.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvFichaVehiculoEventos.Columns)
            {
                column.Width += 15;
            }
            dgvFichaVehiculoEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void tbxFichaVehiculoEstado_TextChanged(object sender, EventArgs e)
        {
            string texto = tbxFichaVehiculoEstado.Text.ToUpper();

            if (texto == "ACTIVO")
            {
                tbxFichaVehiculoEstado.BackColor = Color.Green;
            } else if(texto == "INACTIVO")
            {
                tbxFichaVehiculoEstado.BackColor = Color.Red;
            }
        }


        // Sin uso
        private void dgvFichaVehiculoEventos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
