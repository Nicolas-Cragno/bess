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
    public partial class FrmFichaEvento : Form
    {
        private Form formularioPadre;
        private char modo;
        private Evento evento;
        int activo = 1, choferL = 1;

        // Cargas
        public FrmFichaEvento(char eModo, Evento eEvento = null, Form padre = null)
        {
            InitializeComponent();
            modo = eModo;
            evento = eEvento;
            formularioPadre = padre;
        }
        private void FrmFichaEvento_Load(object sender, EventArgs e)
        {
            configuracion(modo);
        }
        private void configuracion(char eSelect)
        {
            this.ControlBox = false;
            tabulaciones();
            if (formularioPadre != null)
            {
                Screen pantalla = Screen.FromControl(formularioPadre);
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(
                    pantalla.WorkingArea.Right - this.Width,
                    pantalla.WorkingArea.Top
                );
            }
            switch (eSelect)
            {
                case 'F':
                    formularioFicha();
                    btnFichaEventoOK.Text = "Editar";
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
        private void tabulaciones() 
        {
            cbxFichaEventoChofer.TabIndex = 0;
            cbxFichaEventoInterno.TabIndex = 1;
            cbxFichaEventoFurgon.TabIndex = 2;
            cbxFichaEventoTipo.TabIndex = 3;
            tbxFichaEventoDetalle.TabIndex = 4;
            btnFichaEventoOK.TabIndex = 5;
            btnFichaEventoCerrar.TabIndex = 6;
        }
        private void formularioAgregar()
        {
            cargarListas();
        }
        private void formularioModificar()
        {
            cargarListas();
            cargarDatos();
            lblFichaEventoTitulo.Text = evento.Fecha.ToString("dd/MM/yyyy");
            lblFichaEventoTitulo.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void formularioFicha()
        {
            cargarDatos();
            bloquearDatos();
        }
        private void cargarListas() 
        {
            ChoferNegocio choferNegocio = new ChoferNegocio();
            TractorNegocio tractorNegocio = new TractorNegocio();
            FurgonNegocio furgonNegocio = new FurgonNegocio();
            EventoNegocio eventoNegocio = new EventoNegocio();
            cbxFichaEventoInterno.DataSource = tractorNegocio.listarInternos(activo);
            cbxFichaEventoFurgon.DataSource = furgonNegocio.listarInternos(activo);
            cbxFichaEventoChofer.DataSource = choferNegocio.listarNombres(activo, choferL);
            cbxFichaEventoTipo.DataSource = eventoNegocio.listarTipos();
            cbxFichaEventoInterno.SelectedIndex = -1;
            cbxFichaEventoFurgon.SelectedIndex = -1;
            cbxFichaEventoChofer.SelectedIndex = -1;
            cbxFichaEventoTipo.SelectedIndex = -1;
        }
        private void cargarDatos() 
        {
            // listados
            cbxFichaEventoInterno.Text = evento.Tractor.ToString();
            cbxFichaEventoFurgon.Text = evento.Furgon.ToString();
            cbxFichaEventoChofer.Text = evento.Persona;
            cbxFichaEventoTipo.Text = evento.Tipo;

            // ingreso de texto
            tbxFichaEventoDetalle.Text = evento.Detalle;
        }
        private void bloquearDatos() 
        {
            // listados
            cbxFichaEventoInterno.Enabled = false;
            cbxFichaEventoFurgon.Enabled = false;
            cbxFichaEventoChofer.Enabled = false;
            cbxFichaEventoTipo.Enabled = false;

            // ingreso de texto
            tbxFichaEventoDetalle.ReadOnly = true;
        }

        // Acciones
        private Evento capturarDatos() 
        {
            Evento auxEvento = new Evento();
            Validaciones validar = new Validaciones();
            // listados
            auxEvento.Tractor = validar.cbxInt(cbxFichaEventoInterno.Text);
            auxEvento.Furgon = validar.cbxInt(cbxFichaEventoFurgon.Text);
            auxEvento.Persona = validar.cbxString(cbxFichaEventoChofer.Text);
            auxEvento.Tipo = validar.cbxString(cbxFichaEventoTipo.Text);

            // ingreso de texto
            auxEvento.Detalle = tbxFichaEventoDetalle.Text;

            return auxEvento;
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
                    modificar(evento.Id);
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }
        private void agregar()
        {
            AccesoDatos datos = new AccesoDatos();
            Evento nvEv = new Evento();
            nvEv = capturarDatos();
            int idTipo = datos.buscarIdTipoEvento(nvEv.Tipo);
            int dni = datos.buscarDniFull(nvEv.Persona);

            string database = "INSERT INTO " + AccesoDatos.Tablas.Eventos;
            string parametros = "(idTipoEvento, dni, intTractor, intFurgon, detalle)";
            string campos = " VALUES (" + idTipo + ", " + dni + ", " + nvEv.Tractor + ", " + nvEv.Furgon + ", '" + nvEv.Detalle.ToUpper() + "');";
            string query = database + parametros + campos;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();

                MessageBox.Show("Evento agregado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { datos.cerrarConexion(); }
        }
        private void editar()
        {
            char edit = 'M';
            FrmFichaEvento edEvento = new FrmFichaEvento(edit, evento);
            edEvento.ShowDialog();
            Close();
        }
        private void modificar(long id)
        {
            AccesoDatos datos = new AccesoDatos();
            Evento mdEv = new Evento();
            mdEv = capturarDatos();
            int idTipo = datos.buscarIdTipoMovimiento(mdEv.Tipo);
            int dni = datos.buscarDniFull(mdEv.Persona);

            string database = "UPDATE " + AccesoDatos.Tablas.Eventos;
            string campos = " SET idTipoEvento=" + idTipo + ", dni=" + dni + ", intTractor=" + mdEv.Tractor + ", intFurgon=" + mdEv.Furgon + ", detalle='" + mdEv.Detalle.ToUpper() + "'";
            string condicion = " WHERE idEvento=" + id + ";";
            string query = database+ campos + condicion;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();

                MessageBox.Show("Cambios guardados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { datos.cerrarConexion(); }
        }
        
        // Botones - clicks
        private void btnFichaEventoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnFichaEventoOK_Click(object sender, EventArgs e)
        {
            ejecutar(modo);
            Close();
        }
    }
}
