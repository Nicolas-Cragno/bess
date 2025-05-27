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


namespace presentacion.empresas
{
    public partial class FrmClientes : Form
    {
        private List<Empresa> listadoEmpresas;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            string tipo = "CLIENTE";
            EmpresaNegocio negocio = new EmpresaNegocio();
            listadoEmpresas = negocio.listar(tipo);
            dgvClientes.DataSource = listadoEmpresas;
            ocultarColumnas();
            anchoColumnas();
        }

        private void ocultarColumnas()
        {
            dgvClientes.Columns["Abreviatura"].Visible = false;      
        }

        private void anchoColumnas()
        {
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClientes.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvClientes.Columns )
            {
                column.Width += 15;
            }
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
    }
}
