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

namespace presentacion
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingreso();
        }

        private void ingreso()
        {
            AccesoDatos datos = new AccesoDatos();
            string usuario = tbxUsuario.Text;
            string contraseña = tbxClave.Text;
            bool ingreso;

            ingreso = datos.verificarIngreso(usuario, contraseña);

            if(ingreso)
            {
                FrmPrincipal aplicacion = new FrmPrincipal();
                aplicacion.Show();
            } else
            {
                MessageBox.Show("Usuario y/o contraseña invalido/s.");
            }
        }
    }
}
