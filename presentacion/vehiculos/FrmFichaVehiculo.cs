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

namespace presentacion.vehiculos
{
    public partial class FrmFichaVehiculo : Form
    {
        private char tipo, modo;
        private Tractor tractor = new Tractor();
        private Furgon furgon = new Furgon();
        private Vehiculo vehiculo = new Vehiculo();
        private Object stdVehiculo = new Object(); // para el form de editar
        private Form formularioPadre;
        public FrmFichaVehiculo(char sTipo, char sModo, object sVehiculo, Form padre=null)
        {
            InitializeComponent();
            tipo = sTipo;
            modo = sModo;
            formularioPadre = padre;
            stdVehiculo = sVehiculo;
            determinarObjeto(sVehiculo);
        }

        private void FrmFichaVehiculo_Load(object sender, EventArgs e)
        {
            configuracion();
        }
        private void configuracion()
        {
            this.ControlBox = false;
            colgarDerecha();

            switch (tipo)
            {
                case 'T':
                    cargarTractor();
                    break;
                case 'F':
                    break;
                default:
                    break;
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

        private void cargarListas()
        {
            VehiculoNegocio vehiculoNegocio = new VehiculoNegocio();
            EmpresaNegocio empresaNegocio = new EmpresaNegocio();

            List<string> vehiculos = vehiculoNegocio.listarTipos();
            List<string> empresas = empresaNegocio.listaNombres("PROPIA");

            cbxFichaVehiculoTipo.DataSource = vehiculos;
            cbxFichaVehiculoEmpresa.DataSource = empresas;
        }
        private void btnFichaVehiculoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Tractores
        private void cargarTractor()
        {

            switch (modo)
            {
                case 'F': // Ficha
                    formatoFichaT();
                    break;
                case 'A': // Agregar
                    formatoAgregarT();
                    break;
                case 'M': // Modificar
                    formatoModificarT();
                    break;
                default:
                    break;
            }
        }
        private void formatoFichaT()
        {
            lblFichaVehiculoTitulo.Text = "TRACTOR " + tractor.Interno;
            cbxFichaVehiculoTipo.Text = "TRACTOR";
            cbxFichaVehiculoEmpresa.Text = tractor.Empresa;
            tbxFichaVehiculoDominio.Text = tractor.Dominio;
            tbxFichaVehiculoMarca.Text = tractor.Marca;
            tbxFichaVehiculoModelo.Text = tractor.Modelo.ToString();
            cbxFichaVehiculoTaller.Checked = tractor.OkTaller;
            cbxFichaVehiculoDocumentacion.Checked = tractor.OkDocumentacion;
            if (tractor.Activo)
            {
                tbxFichaVehiculoEstado.Text = "ACTIVO";
            }
            else
            {
                tbxFichaVehiculoEstado.Text = "INACTIVO";
            }
            tbxFichaVehiculoDetalle.Text = tractor.Detalle;

            // bloquear escritura
            cbxFichaVehiculoTipo.Enabled = false;
            cbxFichaVehiculoEmpresa.Enabled = false;
            cbxFichaVehiculoTaller.Enabled = false;
            cbxFichaVehiculoDocumentacion.Enabled = false;
            tbxFichaVehiculoDominio.ReadOnly = true;
            tbxFichaVehiculoMarca.ReadOnly = true;
            tbxFichaVehiculoModelo.ReadOnly = true;
            tbxFichaVehiculoEstado.ReadOnly = true;
            tbxFichaVehiculoDetalle.ReadOnly = true;

            // Ocultar
            btnFichaVehiculoAlta.Visible = false;
        }
        private void formatoAgregarT()
        {
            cargarListas();
            lblFichaVehiculoTitulo.Text = "NUEVO TRACTOR";

            // Ocultar parte de Eventos
            this.Size = new Size(358, 436);
            colgarDerecha();

            // Habilitar escritura
            cbxFichaVehiculoTipo.Enabled = true;
            cbxFichaVehiculoEmpresa.Enabled = true;
            tbxFichaVehiculoDominio.ReadOnly = false;
            tbxFichaVehiculoMarca.ReadOnly = false;
            tbxFichaVehiculoModelo.ReadOnly = false;
            tbxFichaVehiculoDetalle.ReadOnly = false;

            // Modificar campo
            lblFichaVehiculoEstado.Text = "interno";
            tbxFichaVehiculoEstado.ReadOnly = false;
            btnFichaVehiculoOK.Text = "Guardar";

            // Oculto
            gbxFicahVehiculoEstado.Visible = false;
            cbxFichaVehiculoTaller.Visible = false;
            cbxFichaVehiculoDocumentacion.Visible = false;
            btnFichaVehiculoAlta.Visible = false;
        }

        private void btnFichaVehiculoOK_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case 'F': // Ficha
                    FrmFichaVehiculo editarVehiculo = new FrmFichaVehiculo(tipo, 'M', stdVehiculo, this);
                    editarVehiculo.ShowDialog();
                    Close();
                    break;
                case 'A': // Agregar
                    MessageBox.Show("agregar");
                    break;
                case 'M': // Modificar
                    MessageBox.Show("modificar");
                    break;
                default:
                    break;
            }
        }

        private void btnFichaVehiculoAlta_Click(object sender, EventArgs e)
        {

        }

        private void formatoModificarT()
        {
            cargarListas();

            lblFichaVehiculoTitulo.Text = "TRACTOR " + tractor.Interno;
            cbxFichaVehiculoTipo.Text = "TRACTOR";
            cbxFichaVehiculoEmpresa.Text = tractor.Empresa;
            tbxFichaVehiculoDominio.Text = tractor.Dominio;
            tbxFichaVehiculoMarca.Text = tractor.Marca;
            tbxFichaVehiculoModelo.Text = tractor.Modelo.ToString();
            cbxFichaVehiculoTaller.Checked = tractor.OkTaller;
            cbxFichaVehiculoDocumentacion.Checked = tractor.OkDocumentacion;
            if (tractor.Activo)
            {
                tbxFichaVehiculoEstado.Text = "ACTIVO";
                btnFichaVehiculoAlta.Text = "Dar baja";
            }
            else
            {
                tbxFichaVehiculoEstado.Text = "INACTIVO";
                btnFichaVehiculoAlta.Text = "Dar alta";
            }
            tbxFichaVehiculoDetalle.Text = tractor.Detalle;

            // bloquear escritura
            cbxFichaVehiculoTipo.Enabled = true;
            cbxFichaVehiculoEmpresa.Enabled = true;
            cbxFichaVehiculoTaller.Enabled = true;
            cbxFichaVehiculoDocumentacion.Enabled = true;
            tbxFichaVehiculoDominio.ReadOnly = false;
            tbxFichaVehiculoMarca.ReadOnly = false;
            tbxFichaVehiculoModelo.ReadOnly = false;
            tbxFichaVehiculoDetalle.ReadOnly = false;
        }

        // Furgones

        // Otros
    }
}
