using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using presentacion.eventos;
using presentacion.movimientos;
using presentacion.vehiculos;
using presentacion.viajes;
using presentacion.empresas;
using presentacion.reparaciones;
using presentacion.articulos;
using negocio;
using presentacion.personas;
using System.Diagnostics;

namespace presentacion
{
    public partial class FrmPrincipal : Form
    {
        int sector;

        // Cargas
        public FrmPrincipal()
        {
            InitializeComponent();

            tsmViajes.Visible = false; // todavia no lo defini
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Inicializarlo maximizado
            this.Bounds = Screen.FromControl(this).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            funcionesDeshabilitadas();
            fondo();
        }

        private void fondo()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient client)
                {
                    // Redimensionar la imagen al tamaño del MdiClient
                    Bitmap imagenRedimensionada = new Bitmap(pictureBox1.Image, client.Size);

                    // Asignar la imagen redimensionada como fondo
                    client.BackgroundImage = imagenRedimensionada;
                    client.BackgroundImageLayout = ImageLayout.None; // No aplicar layout adicional

                    // Ocultar el PictureBox original
                    pictureBox1.Visible = false;

                    break;
                }
            }
        }

        // Opciones del menu
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmRepuestos>();
        }
        private void tsmMovimientos_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmMovimientos>();
        }
        private void tsmEventos_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmEvento>();
        }
        private void tsmReparacionesCamiones_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmReparaciones>(sector);
        }
        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmPersonas>(1);
        }
        private void fleterosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmPersonas>(4);
        }
        private void mecanicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmPersonas>(3);
        }
        private void tsmVehiculos_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmVehiculos>('T');
        }
        private void tsmFurgones_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmVehiculos>('F');
        }


        // Opciones del menu OCULTAS
        private void tsmViajes_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmViajes>();
        }
        private void tsmEmpresas_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmEmpresas>();
        }
        private void tsmClientes_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmClientes>();
        }
        private void tsmReparacionesFurgones_Click(object sender, EventArgs e)
        {
            abrirVentanaUnica<FrmReparaciones>(sector);
        }

        // Funciones
        private void cerrarVentanas() // cerrar ventanas al abrir otras para navegar.
        {
            foreach(Form v in this.MdiChildren)
            {
                v.Close();
                this.DoubleBuffered = true; // evitar parpaderos
            }
        }
        private void funcionesDeshabilitadas()
        {
            tsmOtros.Visible = false;
            tsmEmpresas.Visible = false;
            tsmClientes.Visible = false;
            tsmTallerCamionesFurgones.Visible = false;
        }

        private void abrirVentanaUnica<T>(params object[] args) where T : Form
        {
            // Si es FrmPersonas y tiene parámetro, buscamos si ya está abierto con ese mismo tipo
            if (typeof(T) == typeof(FrmPersonas) && args.Length > 0 && args[0] is int tipoBuscado)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f is FrmPersonas fp)
                    {
                        if (fp.TipoPersona == tipoBuscado)
                        {
                            // Ya está abierto con el mismo tipo => lo cierro y no abro otro
                            fp.Close();
                            return;
                        }
                    }
                }
            }
            else
            {
                // Para formularios sin parámetros o sin comparación especial
                foreach (Form f in this.MdiChildren)
                {
                    if (f is T)
                    {
                        f.Close(); // Si ya hay uno, lo cierro
                        return;
                    }
                }
            }

            // Cierro TODOS los demás formularios hijos abiertos antes de abrir el nuevo
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            // Creo nueva instancia con o sin argumentos
            Form nuevaVentana = (Form)(args.Length == 0
                ? Activator.CreateInstance(typeof(T))
                : Activator.CreateInstance(typeof(T), args));

            nuevaVentana.MdiParent = this;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();
        }



        // Opciones del menu ocultas

        // SIN USO
        private void reparacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        private void tsmRepuestos_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmRepuestosCamiones_Click(object sender, EventArgs e)
        {
            
        }
    }
}
