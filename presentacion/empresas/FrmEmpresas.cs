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
    public partial class FrmEmpresas : Form
    {
        private List<Empresa> listadoEmpresas;
        public FrmEmpresas()
        {
            InitializeComponent();
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            string tipo = "PROPIA";
            EmpresaNegocio negocio = new EmpresaNegocio();
            listadoEmpresas = negocio.listar(tipo);
            dgvEmpresas.DataSource = listadoEmpresas;
            anchoColumnas();
        }

        private void anchoColumnas()
        {
            dgvEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmpresas.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgvEmpresas.Columns)
            {
                column.Width += 15;
            }
            dgvEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
    }
}
