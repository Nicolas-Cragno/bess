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
    public partial class FrmAgregarMovimiento : Form
    {
        public FrmAgregarMovimiento()
        {
            InitializeComponent();
        }

        private void FrmAgregarMovimiento_Load(object sender, EventArgs e)
        {
            ChoferNegocio choferNegocio = new ChoferNegocio();
            TractorNegocio tractorNegocio = new TractorNegocio();
            FurgonNegocio furgonNegocio = new FurgonNegocio();
            MovimientoNegocio movimientoNegocio = new MovimientoNegocio();
            int activo = 1, puesto = 1;

            try
            {
                cbxAgregarMovimientoChofer.DataSource = choferNegocio.listarNombres(activo, puesto);
                cbxAgregarMovimientoChofer.SelectedIndex = 0; 

                cbxAgregarMovimientoInterno.DataSource = tractorNegocio.listarInternos(activo);
                cbxAgregarMovimientoInterno.SelectedIndex = 0;

                cbxAgregarMovimientoFurgon.DataSource = furgonNegocio.listarInternos(activo);
                cbxAgregarMovimientoFurgon.SelectedIndex = 0;

                cbxAgregarMovimientoTipo.DataSource = movimientoNegocio.listarTipos();
                cbxAgregarMovimientoTipo.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnAgregarMovimientoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            Movimiento movimiento = new Movimiento();
            MovimientoNegocio movimientoNegocio = new MovimientoNegocio();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                movimiento.Persona = (string)cbxAgregarMovimientoChofer.Text.ToUpper();
                movimiento.Tractor = int.Parse(cbxAgregarMovimientoInterno.Text);
                movimiento.Furgon = int.Parse(cbxAgregarMovimientoFurgon.Text);
                movimiento.Tipo = (string)cbxAgregarMovimientoTipo.Text.ToUpper();
                movimiento.Panico = (bool)cbxAgregarMovimientoPanico.Checked;
                movimiento.Corte = (bool)cbxAgregarMovimientoCorte.Checked;
                movimiento.Efurgon = (bool)cbxAgregarMovimientoOkfurgon.Checked;
                movimiento.Reporte = (bool)cbxAgregarMovimientoReporte.Checked;
                movimiento.Desenganche = (bool)cbxAgregarMovimientoDesenganche.Checked;
                movimiento.Cabina = (bool)cbxAgregarMovimientoCabina.Checked;
                movimiento.Antivandalico = (bool)cbxAgregarMovimientoAntivandalico.Checked;
                movimiento.Detalle = (string)tbxAgregarMovimientoDetalle.Text.ToUpper();
                
                
                movimientoNegocio.agregar(movimiento);
                
                MessageBox.Show("Movimiento agregado.");
            }
            catch(Exception ex) 
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
            
        }
    }
}
