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

namespace presentacion.personas
{
    public partial class FrmFichaPersona : Form
    {
        List<Evento> eventos = new List<Evento>();
        Persona persona = new Persona();
        Chofer chofer = new Chofer();
        Mecanico mecanico = new Mecanico();
        Fletero fletero = new Fletero();
        int puesto;
        public FrmFichaPersona(int oPuesto, object oPersona)
        {
            InitializeComponent();
            puesto = oPuesto;
            switch (puesto)
            {
                case 1: // choferes
                    chofer = oPersona as Chofer;
                    break;
                case 3: // mecanicos 
                    mecanico = oPersona as Mecanico;
                    break;
                case 4: // fleteros
                    fletero = oPersona as Fletero;
                    break;
                default: // otros
                    persona = oPersona as Persona;
                    break;
            }
        }
        private void FrmFichaPersona_Load(object sender, EventArgs e)
        {
            configuracion();
        }
        private void configuracion()
        {
            this.ControlBox = false; // oculta el manejo de la ventana superior
            cargarDatos();
            cargarEventos();
        }
        private void cargarDatos()
        {
            switch (puesto)
            {
                case 1: // choferes
                    lblFichaPersonaTitulo.Text = chofer.Apellido + ", " + chofer.Nombres;
                    tbxFichaPersonaDNI.Text = chofer.Dni.ToString();
                    tbxFichaPersonaEmpresa.Text = chofer.Empresa;
                    tbxFichaPersonaPuesto.Text = chofer.Puesto;
                    tbxFichaPersonaDetalle.Text = chofer.Detalle;
                    // variables segun puesto
                    lblFichaPersonaData1.Text = "tractor";
                    tbxFichaPersonaData1.Text = chofer.Tractor.ToString();
                    lblFichaPersonaData2.Text = "viajes";
                    tbxFichaPersonaData2.Text = chofer.Viajes.ToString();
                    lblFichaPersonaData3.Text = "promedio";
                    tbxFichaPersonaData3.Text = chofer.Promedio.ToString();
                    lblFichaPersonaData4.Text = "estado";
                    tbxFichaPersonaData4.Text = estado(chofer.Activo);
                    break;
                case 3: // mecanicos 
                    lblFichaPersonaTitulo.Text = mecanico.Apellido + ", " + mecanico.Nombres;
                    tbxFichaPersonaDNI.Text = mecanico.Dni.ToString();
                    tbxFichaPersonaEmpresa.Text = mecanico.Empresa;
                    tbxFichaPersonaPuesto.Text = mecanico.Puesto;
                    tbxFichaPersonaDetalle.Text = mecanico.Detalle;
                    // variables segun puesto
                    lblFichaPersonaData2.Text = "arreglos";
                    tbxFichaPersonaData2.Text = mecanico.Arreglos.ToString();
                    // oculto
                    lblFichaPersonaData1.Visible = false;
                    tbxFichaPersonaData1.Visible = false;
                    lblFichaPersonaData3.Visible = false;
                    tbxFichaPersonaData3.Visible = false;
                    lblFichaPersonaData4.Visible = false;
                    tbxFichaPersonaData4.Visible = false;
                    break;
                case 4: // fleteros
                    lblFichaPersonaTitulo.Text = fletero.Apellido + ", " + fletero.Nombres;
                    tbxFichaPersonaDNI.Text = fletero.Dni.ToString();
                    tbxFichaPersonaEmpresa.Text = fletero.Empresa;
                    tbxFichaPersonaPuesto.Text = fletero.Puesto;
                    tbxFichaPersonaDetalle.Text = fletero.Detalle;
                    // variables segun puesto
                    lblFichaPersonaData2.Text = "tractor";
                    tbxFichaPersonaData2.Text = fletero.MarcaTractor + " - " + fletero.ModeloTractor;
                    lblFichaPersonaData3.Text = "furgon";
                    tbxFichaPersonaData3.Text = fletero.MarcaFurgon;
                    // oculto
                    lblFichaPersonaData1.Visible = false;
                    tbxFichaPersonaData1.Visible = false;
                    lblFichaPersonaData4.Visible = false;
                    tbxFichaPersonaData4.Visible = false;
                    break;
                default: // otros

                    break;
            }
        }
        private void cargarEventos()
        {
            switch (puesto)
            {
                case 1: // choferes

                    break;
                case 3: // mecanicos 

                    break;
                case 4: // fleteros

                    break;
                default: // otros

                    break;
            }
        }

        private string estado(bool activo)
        {
            string estado;
            if (activo)
            {
                estado = "ACTIVO";
            } else
            {
                estado = "INACTIVO";
            }
            return estado;
        }

        private void btnFichaPersonaCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
