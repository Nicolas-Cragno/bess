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
    public partial class FrmFinalizar : Form
    {
        long reparacion;
        public FrmFinalizar(long idReparacion)
        {
            InitializeComponent();
            reparacion = idReparacion;
        }

        private void btnFinalizarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFinalizarOK_Click(object sender, EventArgs e)
        {
            ReparacionNegocio negocio = new ReparacionNegocio();
            negocio.finalizar(reparacion);
            MessageBox.Show("Trabajo finalizado.");
            Close();
        }

        private void FrmFinalizar_Load(object sender, EventArgs e)
        {

        }
    }
}
