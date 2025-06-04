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

namespace presentacion.choferes
{
    public partial class FrmFichaChofer : Form
    {
        Chofer chofer = new Chofer();
        public FrmFichaChofer(Chofer sChofer)
        {
            InitializeComponent();
            chofer = sChofer;
        }

        private void FrmFichaChofer_Load(object sender, EventArgs e)
        {
            configuracion();
        }

        private void configuracion()
        {
            cargarDatos();
            cargarEventos();
        }
        private void cargarDatos()
        {
            // DATOS DEL CHOFER
            string estado;
            tbxFichaChoferDNI.Text = chofer.Dni.ToString();
            tbxFichaChoferEmpresa.Text = chofer.Empresa;
            tbxFichaChoferTipo.Text = chofer.Puesto;
            tbxFichaChoferInterno.Text = chofer.Tractor.ToString();
            tbxFichaChoferViajes.Text = chofer.Viajes.ToString();
            tbxFichaChoferPromedio.Text = chofer.Promedio.ToString();
            if (chofer.Activo)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "INACTIVO";
            }
            tbxFichaChoferEstado.Text = estado;
            tbxFichaChoferObservaciones.Text = chofer.Detalle.ToString();
        }

        private void cargarEventos()
        {
            // EVENTOS DEL CHOFER
            EventoNegocio eventoNegocio = new EventoNegocio();
            dgvFichaChoferEvento.DataSource = eventoNegocio.listarPorPersona(chofer.Dni);

        }

        private void btbFichaChoferCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
