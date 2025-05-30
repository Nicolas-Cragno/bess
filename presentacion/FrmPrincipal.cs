using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using presentacion.choferes;
using presentacion.eventos;
using presentacion.movimientos;
using presentacion.utilitarios;
using presentacion.vehiculos;
using presentacion.viajes;
using presentacion.empresas;
using presentacion.mecanicos;
using presentacion.reparaciones;
using presentacion.articulos;

namespace presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cerrarVentanas() // cerrar ventanas al abrir otras para navegar.
        {
            foreach(Form v in this.MdiChildren)
            {
                v.Close();
            }
        }

        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            FrmChoferes ventana = new FrmChoferes();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void tsmMovimientos_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            FrmMovimientos ventana = new FrmMovimientos();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void tsmEventos_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            FrmEvento ventana = new FrmEvento();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void tsmViajes_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            FrmViajes ventana = new FrmViajes();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void otrosVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            FrmUtilitarios ventana = new FrmUtilitarios();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }
        

        private void tsmVehiculos_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            FrmVehiculos ventana = new FrmVehiculos();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void tsmEmpresas_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            FrmEmpresas ventana = new FrmEmpresas();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void tsmClientes_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            FrmClientes ventana = new FrmClientes();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void mecanicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            FrmMecanicos ventana = new FrmMecanicos();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void reparacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            FrmReparaciones ventana = new FrmReparaciones();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void tsmRepuestos_Click(object sender, EventArgs e)
        {
            FrmRepuestos ventana = new FrmRepuestos();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }
    }
}
