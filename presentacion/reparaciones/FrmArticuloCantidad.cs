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
    public partial class FrmArticuloCantidad : Form
    {
        private Articulo articulo;
        float cantidad;
        public FrmArticuloCantidad(Articulo sArticulo)
        {
            InitializeComponent();
            articulo = sArticulo;
        }

        private void btnFichaReparacionesOK_Click(object sender, EventArgs e)
        {
            // ingreso
            if (string.IsNullOrWhiteSpace(tbxArticuloCantidad.Text))
            {
                // en caso de que deje la celda vacia
                MessageBox.Show("Ingrese un valor válido.");
            } else
            {
                cantidad = float.Parse(tbxArticuloCantidad.Text);   
            }

            // Validar
             if(cantidad > articulo.Stock)
             {
                MessageBox.Show("No alcanza el stock");
             }
             else if (cantidad > 0)
             {
                Close();
             } 
             else {
                MessageBox.Show("Ingrese un valor valido");
             }
        }

        private void FrmArticuloCantidad_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            this.ControlBox = false; // oculta la barra de control superior

            lblArticuloCantidadNombre.Text = articulo.Nombre;
            lblArticuloCantidadMarca.Text = articulo.Marca;
            lblArticuloCantidadCodigo.Text = articulo.CodigoProveedor.ToString();
            lblArticuloCantidadStock.Text = articulo.Stock.ToString() + " " + articulo.Unidad;
            cantidad = 1;
            tbxArticuloCantidad.Text = cantidad.ToString();
        }

        private void tbxArticuloCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string unidad = tbxArticuloCantidad.Text;

            if (e.KeyChar == '\b') // PERMITE BORRAR
                return;

            if (articulo.Unidad == "UN")
            {
                if (!char.IsDigit(e.KeyChar)) // PERMITE SOLO NUMEROS
                    e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                // PERMITE FLOAT SOLO CON PUNTO
                e.Handled = true;
            } else if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                // EVITA QUE SE INGRESE DE NUEVO UN PUNTO
                e.Handled = true;
            }
        }

        private void btnArticuloCantidadCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
