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

namespace presentacion.reparaciones
{
    public partial class FrmFichaReparaciones : Form
    {
        // Carga del Form
        private char modo;
        private Reparacion reparacion;
        int activo = 1, choferL = 1, mecanico = 3;
        public FrmFichaReparaciones(char rModo, Reparacion rReparacion = null)
        {
            InitializeComponent();
            modo = rModo;
            reparacion = rReparacion;
        }
        private void FrmFichaReparaciones_Load(object sender, EventArgs e)
        {
            configuracion(modo);
        }


        private void cargarListas()
        {
            VehiculoNegocio vehiculoNegocio = new VehiculoNegocio();
            ChoferNegocio choferNegocio = new ChoferNegocio();
            TractorNegocio tractorNegocio = new TractorNegocio();
            ReparacionNegocio reparacionNegocio = new ReparacionNegocio();
            MecanicoNegocio mecanicoNegocio = new MecanicoNegocio();
            AccesoDatos datos = new AccesoDatos();
            cbxFichaReparacionesTipo.DataSource = vehiculoNegocio.listarTipos();
            cbxFichaReparacionesTipo.SelectedIndexChanged += cbxFichaReparacionesTipo_SelectedIndexChanged; // depende la selección se captura el tipo y se listan los internos en la funcion de abajo
            cbxFichaReparacionesTipoTrabajo.DataSource = reparacionNegocio.listarTipos() ;
            cbxFichaReparacionesChofer.DataSource = choferNegocio.listarNombres(activo, choferL);
            cbxFichaReparacionesMecanico.DataSource = mecanicoNegocio.listarNombres(activo, mecanico);
            cbxFichaReparacionesChofer.SelectedIndex = -1;
            cbxFichaReparacionesMecanico.SelectedIndex = -1;
            // fechas y horarios
            int inicio = 8, fin = 18; // jornada laboral
            dtpFichaReparacionesFechaInicio.Value = DateTime.Today;
            dtpFichaReparacionesFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFichaReparacionesFechaInicio.CustomFormat = "dd/MM/yyyy";
            cbxFichaReparacionesHoraInicio.DataSource = datos.horarios(inicio, fin);
            dtpFichaReparacionesFechaFin.Value = DateTime.Today;
            dtpFichaReparacionesFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFichaReparacionesFechaFin.CustomFormat = "dd/MM/yyyy";
            cbxFichaReparacionesHoraFin.DataSource = datos.horarios(inicio, fin);


        }
        private void cbxFichaReparacionesTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehiculoNegocio vehiculoNegocio = new VehiculoNegocio();
            string tipo = cbxFichaReparacionesTipo.SelectedItem.ToString();
            cbxFichaReparacionesInt.DataSource = vehiculoNegocio.listarInternos(tipo);
        }

        // Funciones particulares segun MODO
        private void configuracion (char rSelect)
        {
            this.ControlBox = false; // oculta la barra de control superior

            switch (rSelect)
            {
                case 'F':
                    formularioFicha();
                    btnFichaReparacionesOK.Text = "Editar";
                    break;
                case 'A':
                    formularioAgregar();
                    break;
                case 'M':
                    formularioModificar();
                    break;
                default:
                    formularioAgregar();
                    break;
            }
        }
        private void formularioFicha() 
        {
            bloquearDatos();
            cargarDatos(reparacion.Id);
        }
        private void formularioAgregar() 
        {
            cargarListas();
        }
        private void formularioModificar() 
        {
            cargarListas();
            cargarDatos(reparacion.Id);
            lblFichaReparacionTitulo.Text = reparacion.Fecha.ToString("dd/MM/yyyy");
            lblFichaReparacionTitulo.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void cargarDatos(long idReparacion) 
        {
            cbxFichaReparacionesTipo.Text = reparacion.TipoVehiculo.ToString();
            dtpFichaReparacionesFechaInicio.Text = reparacion.Fecha.ToString("dd/MM/yy");
            cbxFichaReparacionesHoraInicio.Text = reparacion.Fecha.ToString("HH:mm");
            dtpFichaReparacionesFechaFin.Text = reparacion.FechaFin.ToString("dd/MM/yy");
            cbxFichaReparacionesHoraFin.Text = reparacion.FechaFin.ToString("HH:mm");

            // listados
            cbxFichaReparacionesTipoTrabajo.Text = reparacion.Tipo.ToString();
            cbxFichaReparacionesChofer.Text = reparacion.Persona.ToString();
            cbxFichaReparacionesMecanico.Text = reparacion.Mecanico.ToString();
            cbxFichaReparacionesInt.Text = reparacion.Tractor.ToString();

            // ingreso datos
            tbxFichaReparacionesDetalle.Text = reparacion.Detalle.ToString();
        }


        private void bloquearDatos() 
        {
            // listados
            dtpFichaReparacionesFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFichaReparacionesFechaInicio.CustomFormat = "dd/MM/yy";
            dtpFichaReparacionesFechaInicio.Enabled = false;
            dtpFichaReparacionesFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFichaReparacionesFechaFin.CustomFormat = "dd/MM/yy";
            dtpFichaReparacionesFechaFin.Enabled = false;
            cbxFichaReparacionesHoraFin.Enabled = false;
            cbxFichaReparacionesHoraInicio.Enabled = false;
            cbxFichaReparacionesTipo.Enabled = false;
            cbxFichaReparacionesInt.Enabled = false;
            cbxFichaReparacionesTipoTrabajo.Enabled = false;
            cbxFichaReparacionesChofer.Enabled = false;
            cbxFichaReparacionesMecanico.Enabled = false;

            // ingreso datos
            tbxFichaReparacionesDetalle.ReadOnly = true;
        }    

        // Hacia otros Forms / cerrar
        private void btnFichaReparacionesCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Acciones contra DB

        private Reparacion capturarReparacion() 
        {
            Reparacion auxReparacion = new Reparacion();
            Validaciones validar =  new Validaciones();
            AccesoDatos datos = new AccesoDatos();
            DateTime dInicio = dtpFichaReparacionesFechaInicio.Value.Date;
            TimeSpan hInicio = TimeSpan.Parse(cbxFichaReparacionesHoraInicio.Text);
            DateTime dFin = dtpFichaReparacionesFechaFin.Value.Date;
            TimeSpan hFin = TimeSpan.Parse(cbxFichaReparacionesHoraFin.Text);

            auxReparacion.Tipo = validar.cbxString(cbxFichaReparacionesTipoTrabajo.Text);
            auxReparacion.Persona = validar.cbxString(cbxFichaReparacionesChofer.Text);
            auxReparacion.TipoVehiculo = validar.cbxString(cbxFichaReparacionesTipo.Text);
            int tipo = datos.buscarIdTipoVehiculo(auxReparacion.TipoVehiculo);
            switch (tipo)
            {
                case 1:
                    auxReparacion.Tractor = validar.cbxInt(cbxFichaReparacionesInt.Text);
                    auxReparacion.Furgon = 0;
                    break;
                case 2:
                    auxReparacion.Tractor = 0;
                    auxReparacion.Furgon = validar.cbxInt(cbxFichaReparacionesInt.Text);
                    break;
                default:
                    auxReparacion.Tractor = 0;
                    auxReparacion.Furgon = 0;
                    break;
            }
            auxReparacion.Mecanico = validar.cbxString(cbxFichaReparacionesMecanico.Text);
            auxReparacion.Detalle = tbxFichaReparacionesDetalle.Text;
            auxReparacion.Fecha = validar.dtpFecha(dInicio, hInicio);
            auxReparacion.FechaFin = validar.dtpFecha(dFin, hFin);


            return auxReparacion;
        }

        private void agregar() { }
        private void modificar(long id) { }
        private void editar() { }

        private void btnFichaReparacionesOK_Click(object sender, EventArgs e)
        {
            ejecutar(modo);
            Close();
        }

        private void ejecutar(char tmodo) 
        {
            switch (tmodo)
            {
                case 'F':
                    editar();
                    break;
                case 'A':
                    agregar();
                    break;
                case 'M':
                    modificar(reparacion.Id);
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        // Sin uso
        private void dtpFichaReparacionesFecha_ValueChanged(object sender, EventArgs e)
        {
        }

    }
}
