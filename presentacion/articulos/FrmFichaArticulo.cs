using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion.articulos
{
    public partial class FrmFichaArticulo : Form
    {
        private Form formularioPadre;
        private Articulo articulo = new Articulo();
        private int anchoMaximoDgv = 0;
        private char modo;
        private int sector;
        public FrmFichaArticulo(char sModo, int sSector, Articulo sArticulo=null, Form padre=null)
        {
            InitializeComponent();
            articulo = sArticulo;
            formularioPadre = padre;
            modo = sModo;
            sector = sSector;
        }

        private void FrmFichaArticulo_Load(object sender, EventArgs e)
        {
            configuracion();
        }

        private void configuracion()
        {
            this.ControlBox = false;
            colgarDerecha();

            
            lblFichaArticuloData1.Text = "codigo proveedor";
            lblFichaArticuloData2.Text = "marca";
            lblFichaArticuloData3.Text = "cantidad en stock";
            lblFichaArticuloData4.Text = "unidad de medida";

            if (articulo != null)
            {
                cargarFicha();
            } else
            {
                cargarNuevo();
            }

            switch (modo)
            {
                case 'F':
                    cargarFicha(1);
                    btnFichaArticuloEditar.Text = "Editar";
                    break;
                case 'M':
                    cargarFicha(0);
                    btnFichaArticuloEditar.Text = "Guardar";
                    break;
                case 'N':
                    cargarNuevo();
                    break;
                default: // nuevo
                    cargarNuevo();
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
        private void cargarFicha(int tipo=1) 
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<string> listaUnidades = articuloNegocio.listarUnidades();
            lblFichaArticuloTitulo.Text = "Articulo n° " + articulo.Id.ToString();
            tbxFichaArticuloNombre.Text = articulo.Nombre.ToString();
            tbxFichaArticuloData1.Text = articulo.CodigoProveedor.ToString();
            tbxFichaArticuloData2.Text = articulo.Marca.ToString();
            tbxFichaArticuloData3.Text = articulo.Stock.ToString();
            cbxFichaArticuloData4.DataSource = listaUnidades;
            cbxFichaArticuloData4.SelectedIndex = 0;
            cbxFichaArticuloData4.Text = articulo.Unidad.ToString();
            tbxFichaArticuloDetalle.Text = articulo.Detalle.ToString();

            if (tipo == 1)
            {
                tbxFichaArticuloNombre.ReadOnly = true;
                tbxFichaArticuloData1.ReadOnly = true;
                tbxFichaArticuloData2.ReadOnly = true;
                tbxFichaArticuloData3.ReadOnly = true;
                cbxFichaArticuloData4.Enabled = false;
                tbxFichaArticuloDetalle.ReadOnly = true;
            } else
            {
                tbxFichaArticuloNombre.ReadOnly = false;
                tbxFichaArticuloData1.ReadOnly = false;
                tbxFichaArticuloData2.ReadOnly = false;
                tbxFichaArticuloData3.ReadOnly = false;
                cbxFichaArticuloData4.Enabled = true;
                tbxFichaArticuloDetalle.ReadOnly = false;
            }
        }
        private void cargarNuevo()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<string> listaUnidades = articuloNegocio.listarUnidades();
            lblFichaArticuloTitulo.Text = "Nuevo articulo";
            tbxFichaArticuloNombre.ReadOnly = false;
            tbxFichaArticuloData1.ReadOnly = false;
            tbxFichaArticuloData2.ReadOnly = false;
            tbxFichaArticuloData3.ReadOnly = false;
            cbxFichaArticuloData4.Enabled = true;
            cbxFichaArticuloData4.DataSource = listaUnidades;
            cbxFichaArticuloData4.SelectedIndex = 0;
            tbxFichaArticuloDetalle.ReadOnly = false;

            btnFichaArticuloEditar.Text = "Guardar";
        }

        private void btnFichaArticuloCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnFichaArticuloEditar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            switch (modo)
            {
                case 'F':
                    FrmFichaArticulo ficha = new FrmFichaArticulo('M', sector, articulo, formularioPadre);
                    ficha.ShowDialog();
                    Close();
                    break;
                case 'M':
                    articuloNegocio.modificar(capturarArticulo(), sector);
                    MessageBox.Show("Cambios Guardados.");
                    Close();
                    break;
                case 'N':
                    articuloNegocio.agregar(capturarArticulo(), sector);
                    MessageBox.Show("Repuesto agregado.");
                    Close();
                    break;
                default: // nuevo
                    
                    break;
            }
        }
        private Articulo capturarArticulo()
        {
            Validaciones validar = new Validaciones();
            Articulo nArticulo = new Articulo();
            nArticulo.Nombre = validar.validarTexto(tbxFichaArticuloNombre.Text);
            nArticulo.CodigoProveedor = validar.validarTexto(tbxFichaArticuloData1.Text);
            nArticulo.Marca = validar.validarTexto(tbxFichaArticuloData2.Text);
            nArticulo.Stock = validar.validarFloat(tbxFichaArticuloData3.Text);
            nArticulo.Unidad = validar.validarTexto(cbxFichaArticuloData4.Text);
            nArticulo.Detalle = validar.validarTexto(tbxFichaArticuloDetalle.Text);

            if (modo != 'N')
            {
                nArticulo.Id = articulo.Id;
            }

            return nArticulo;
        }
    }
}
