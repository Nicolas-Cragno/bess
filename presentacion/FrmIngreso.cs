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
        bool claveVisible = false;
        public FrmIngreso()
        {
            InitializeComponent();
            lblRecuperar.Visible = false; // todavia no lo configure
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingreso();
        }


        private void ingreso()
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                string usuario = tbxUsuario.Text;
                string contraseña = tbxClave.Text;
                bool ingreso;

                ingreso = datos.verificarIngreso(usuario, contraseña);

                if (ingreso)
                {
                    FrmPrincipal aplicacion = new FrmPrincipal();
                    aplicacion.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("❌ Usuario y/o contraseña inválido/s.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error de conexión: " + ex.Message);
            }
        }


        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            tbxClave.UseSystemPasswordChar = true;
        }

        private void btnClave_Click(object sender, EventArgs e)
        {
            if (claveVisible)
            {
                tbxClave.UseSystemPasswordChar = true;
                btnClave.Text = "👁";
                claveVisible = false;
            }
            else
            {
                tbxClave.UseSystemPasswordChar = false;
                btnClave.Text = "❌";
                claveVisible = true;
            }
            
        }
        private void tbxClave_KeyDown(object sender, KeyEventArgs e) // ingreso al apretar ENTER sobre la contraseña
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ingreso();
            }
        }

        // Sin uso
        private void FrmIngreso_Enter(object sender, EventArgs e)
        {
            
        }
        private void tbxClave_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
