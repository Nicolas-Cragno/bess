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

namespace presentacion.movimientos
{
    public partial class FrmFichaMovimiento : Form
    {
        private char modo;
        private Movimiento movimiento;
        int activo = 1, choferL = 1;
        public FrmFichaMovimiento(char mModo, Movimiento mMovimiento = null)
        {
            InitializeComponent();
            modo = mModo;
            movimiento = mMovimiento;
        }

        private void FrmFichaMovimiento_Load(object sender, EventArgs e)
        {
            configuracion(modo);
        }

        private void configuracion(char mSelect)
        {
            this.ControlBox = false;
            switch (mSelect)
            {
                case 'F':
                    formularioFicha();
                    btnFichaMovimientoOK.Text = "Editar";
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

        private void formularioAgregar() 
        {
            cargarListas();
        }
        private void formularioModificar()
        {
            cargarListas();
            cargarDatos();
            lblFichaMovimientoTitulo.Text = movimiento.Fecha.ToString();
            lblFichaMovimientoTitulo.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void formularioFicha() 
        {
            cargarDatos();
            bloquearDatos();
        }

        private void btnFichaMovimientoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFichaMovimientoOK_Click(object sender, EventArgs e)
        {
            ejecutar(modo);
            //agregar();
            Close();
        }

        private void cargarListas()
        {
            ChoferNegocio choferNegocio = new ChoferNegocio();
            TractorNegocio tractorNegocio = new TractorNegocio();
            FurgonNegocio furgonNegocio = new FurgonNegocio();
            MovimientoNegocio movimientoNegocio = new MovimientoNegocio();
            cbxFichaMovimientoInterno.DataSource = tractorNegocio.listarInternos(activo);
            cbxFichaMovimientoFurgon.DataSource = furgonNegocio.listarInternos(activo);
            cbxFichaMovimientoTipo.DataSource = movimientoNegocio.listarTipos();
            cbxFichaMovimientoChofer.DataSource = choferNegocio.listarNombres(activo, choferL);
            cbxFichaMovimientoInterno.SelectedIndex = -1;
            cbxFichaMovimientoFurgon.SelectedIndex = -1;
            cbxFichaMovimientoTipo.SelectedIndex = -1;
            cbxFichaMovimientoChofer.SelectedIndex = -1;
        }

        private void cargarDatos()
        {
            // listados
            cbxFichaMovimientoInterno.Text = movimiento.Tractor.ToString();
            cbxFichaMovimientoFurgon.Text = movimiento.Furgon.ToString();
            cbxFichaMovimientoTipo.Text = movimiento.Tipo;
            cbxFichaMovimientoChofer.Text = movimiento.Persona;
            // checks
            cbxFichaMovimientoPanico.Checked = movimiento.Panico;
            cbxFichaMovimientoReporte.Checked = movimiento.Reporte;
            cbxFichaMovimientoCabina.Checked = movimiento.Cabina;
            cbxFichaMovimientoCorte.Checked = movimiento.Corte;
            cbxFichaMovimientoDesenganche.Checked = movimiento.Desenganche;
            cbxFichaMovimientoAntivandalico.Checked = movimiento.Antivandalico;
            cbxFichaMovimientoOkfurgon.Checked = movimiento.Efurgon;
            // ingreso de texto
            tbxFichaMovimientoDetalle.Text = movimiento.Detalle;
        }

        private void bloquearDatos()
        {
            // listados
            cbxFichaMovimientoInterno.Enabled = false;
            cbxFichaMovimientoFurgon.Enabled = false;
            cbxFichaMovimientoTipo.Enabled = false;
            cbxFichaMovimientoChofer.Enabled = false;
            // checks
            cbxFichaMovimientoPanico.Enabled = false;
            cbxFichaMovimientoReporte.Enabled = false;
            cbxFichaMovimientoCabina.Enabled = false;
            cbxFichaMovimientoCorte.Enabled = false;
            cbxFichaMovimientoDesenganche.Enabled = false;
            cbxFichaMovimientoAntivandalico.Enabled = false;
            cbxFichaMovimientoOkfurgon.Enabled = false;
            // ingreso de texto
            tbxFichaMovimientoDetalle.ReadOnly = true;
        }

        private Movimiento capturarDatos()
        {
            Movimiento auxMovimiento = new Movimiento();
            Validaciones validar = new Validaciones();
            // listados
            auxMovimiento.Tractor = validar.cbxInt(cbxFichaMovimientoInterno.Text);
            auxMovimiento.Furgon = validar.cbxInt(cbxFichaMovimientoFurgon.Text);
            auxMovimiento.Tipo = validar.cbxString(cbxFichaMovimientoTipo.Text);
            auxMovimiento.Persona = validar.cbxString(cbxFichaMovimientoChofer.Text);
            // checks
            auxMovimiento.Panico = cbxFichaMovimientoPanico.Checked;
            auxMovimiento.Reporte = cbxFichaMovimientoReporte.Checked;
            auxMovimiento.Cabina = cbxFichaMovimientoCabina.Checked;
            auxMovimiento.Corte = cbxFichaMovimientoCorte.Checked;
            auxMovimiento.Desenganche = cbxFichaMovimientoDesenganche.Checked;
            auxMovimiento.Antivandalico = cbxFichaMovimientoAntivandalico.Checked;
            auxMovimiento.Efurgon = cbxFichaMovimientoOkfurgon.Checked;
            // ingreso de texto
            auxMovimiento.Detalle = tbxFichaMovimientoDetalle.Text;

            return auxMovimiento;
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
                    modificar(movimiento.Id);
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }
        
        private void editar()
        {
            char edit = 'M';
            FrmFichaMovimiento eMovimiento = new FrmFichaMovimiento(edit, movimiento);
            eMovimiento.ShowDialog();
            Close();
        }

        private void agregar()
        {
            AccesoDatos datos = new AccesoDatos();
            Movimiento nvMv = new Movimiento();
            nvMv = capturarDatos();
            int idTipo = datos.buscarIdTipoMovimiento(nvMv.Tipo);
            int dni = datos.buscarDniFull(nvMv.Persona);
            int corte = datos.numerarBool(nvMv.Corte), panico = datos.numerarBool(nvMv.Panico), reporte = datos.numerarBool(nvMv.Reporte), desenganche = datos.numerarBool(nvMv.Desenganche), cabina = datos.numerarBool(nvMv.Cabina), antivandalico = datos.numerarBool(nvMv.Antivandalico), efurgon = datos.numerarBool(nvMv.Efurgon), llave = datos.numerarBool(nvMv.Llave);


            string database = "INSERT INTO " + AccesoDatos.Tablas.Movimientos;
            string parametros = "(idTipoMovimiento, dni, intTractor, intFurgon, detalle, corte, panico, reporte, desenganche, cabina, antivandalico, furgon, llave)";
            string campos = " VALUES (" + idTipo + ", " + dni + ", " + nvMv.Tractor + ", " + nvMv.Furgon + ", '" + nvMv.Detalle.ToUpper() + "', " + corte + ", " + panico + ", " + reporte + ", " + desenganche + ", " + cabina + ", " + antivandalico + ", " + efurgon + ", " + llave + ");";
            string query = database + parametros + campos;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();

                MessageBox.Show("Movimiento agregado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { datos.cerrarConexion(); }
        }

        private void modificar(long id)
        {
            AccesoDatos datos = new AccesoDatos();
            Movimiento mdMv = new Movimiento();
            mdMv = capturarDatos();
            int idTipo = datos.buscarIdTipoMovimiento(mdMv.Tipo);
            int dni = datos.buscarDniFull(mdMv.Persona);
            int corte = datos.numerarBool(mdMv.Corte), panico = datos.numerarBool(mdMv.Panico), reporte = datos.numerarBool(mdMv.Reporte), desenganche = datos.numerarBool(mdMv.Desenganche), cabina = datos.numerarBool(mdMv.Cabina), antivandalico = datos.numerarBool(mdMv.Antivandalico), efurgon = datos.numerarBool(mdMv.Efurgon), llave = datos.numerarBool(mdMv.Llave);


            string database = "UPDATE " + AccesoDatos.Tablas.Movimientos;
            string campos = " SET idTipoMovimiento=" + idTipo + ", dni=" + dni + ", intTractor=" + mdMv.Tractor + ", intFurgon=" + mdMv.Furgon + ", detalle='" + mdMv.Detalle.ToUpper() + "', corte=" + corte + ", panico=" + panico + ", reporte=" + reporte + ", desenganche=" + desenganche + ", cabina=" + cabina + ", antivandalico=" + antivandalico + ", furgon=" + efurgon + ", llave=" + llave;
            string condicion = " WHERE idMovimiento=" + id + ";";
            string query = database + campos + condicion;

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
    }
}
