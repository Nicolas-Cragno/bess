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
    public partial class FrmFichaReparaciones : Form
    {
        // Carga del Form
        private char modo;
        private Reparacion reparacion;
        private List<Articulo> listadoRepuestos;
        private List<Articulo> listadoRepuestosAgregados;
        private List<Articulo> listadoRepuestosFinal;
        int activo = 1, choferL = 1, mecanico = 3, idTallerCamiones = 4;
        string tallerCamiones = "TALLER CAMIONES";
        public FrmFichaReparaciones(char rModo, Reparacion rReparacion = null)
        {
            InitializeComponent();
            modo = rModo;
            reparacion = rReparacion;
        }
        private void FrmFichaReparaciones_Load(object sender, EventArgs e)
        {
            configuracion(modo);
        }


        private void cargarListas()
        {
            VehiculoNegocio vehiculoNegocio = new VehiculoNegocio();
            ChoferNegocio choferNegocio = new ChoferNegocio();
            TractorNegocio tractorNegocio = new TractorNegocio();
            ReparacionNegocio reparacionNegocio = new ReparacionNegocio();
            MecanicoNegocio mecanicoNegocio = new MecanicoNegocio();
            AccesoDatos datos = new AccesoDatos();
            cbxFichaReparacionesTipo.DataSource = vehiculoNegocio.listarTipos();
            cbxFichaReparacionesTipo.SelectedIndexChanged += cbxFichaReparacionesTipo_SelectedIndexChanged; // depende la selección se captura el tipo y se listan los internos en la funcion de abajo
            cbxFichaReparacionesTipoTrabajo.DataSource = reparacionNegocio.listarTipos() ;
            cbxFichaReparacionesChofer.DataSource = choferNegocio.listarNombres(activo, choferL);
            cbxFichaReparacionesMecanico.DataSource = mecanicoNegocio.listarNombres(activo, mecanico);
            cbxFichaReparacionesChofer.SelectedIndex = -1;
            cbxFichaReparacionesMecanico.SelectedIndex = -1;
        }
        private void cbxFichaReparacionesTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehiculoNegocio vehiculoNegocio = new VehiculoNegocio();
            string tipo = cbxFichaReparacionesTipo.SelectedItem.ToString();
            cbxFichaReparacionesInt.DataSource = vehiculoNegocio.listarInternos(tipo);
        }

        // Funciones particulares segun MODO
        private void configuracion (char rSelect)
        {
            this.ControlBox = false; // oculta la barra de control superior

            switch (rSelect)
            {
                case 'F':
                    formularioFicha();
                    btnFichaReparacionesOK.Text = "Editar";
                    break;
                case 'A':
                    formularioAgregar();
                    cargarRepuestos(dgvFichaReparacionesArticulos);
                    
                    break;
                case 'M':
                    formularioModificar();
                    cargarRepuestos(dgvFichaReparacionesArticulos);
                    break;
                default:
                    formularioAgregar();
                    break;
            }
        }
        private void cargarRepuestos(DataGridView dgv)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            listadoRepuestos = articuloNegocio.listar(tallerCamiones);
            dgv.DataSource = listadoRepuestos;
            btnAgregar(dgv);
            formatoColumnas(dgv);
        }

        private void cargarRepuestosReparacion(DataGridView dgv)
        {
            

        }

        private void btnAgregar(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("AgregarArticulo"))
            {
                DataGridViewButtonColumn btnAgregar = new DataGridViewButtonColumn();
                btnAgregar.Name = "AgregarArticulo";
                btnAgregar.HeaderText = "";
                btnAgregar.Text = "+";
                btnAgregar.UseColumnTextForButtonValue = true;
                dgv.Columns.Add(btnAgregar);
                formatoColumnas(dgv);
            }
        }

        private void btnEliminar(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "";
                btnEliminar.Text = "x";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgv.Columns.Add(btnEliminar);
                formatoColumnas(dgv);
            }
        }
        private void formularioFicha() 
        {
            bloquearDatos();
            cargarDatos(reparacion.Id);
        }
        private void formularioAgregar() 
        {
            cargarListas();
        }
        private void formularioModificar() 
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            listadoRepuestosAgregados = articuloNegocio.listarPorReparacion(reparacion.Id, tallerCamiones);
            cargarListas();
            cargarDatos(reparacion.Id);
            lblFichaReparacionTitulo.Text = reparacion.Fecha.ToString("dd/MM/yyyy");
            lblFichaReparacionTitulo.TextAlign = ContentAlignment.MiddleCenter;
            dgvFichaReparacionesRepuestos.DataSource = listadoRepuestosAgregados;
            formatoColumnas(dgvFichaReparacionesRepuestos);
        }

        private void cargarDatos(long idReparacion) 
        {
            UsoStockNegocio usoStockNegocio = new UsoStockNegocio();
            cbxFichaReparacionesTipo.Text = reparacion.TipoVehiculo.ToString();

            // listados
            cbxFichaReparacionesTipoTrabajo.Text = reparacion.Tipo.ToString();
            cbxFichaReparacionesChofer.Text = reparacion.Persona.ToString();
            cbxFichaReparacionesMecanico.Text = reparacion.Mecanico.ToString();
            cbxFichaReparacionesInt.Text = reparacion.Tractor.ToString();

            // ingreso datos
            tbxFichaReparacionesDetalle.Text = reparacion.Detalle.ToString();

            // repuestos
            dgvFichaReparacionesRepuestos.DataSource = usoStockNegocio.listar(idReparacion);
        }


        private void bloquearDatos() 
        {
            // listados
            cbxFichaReparacionesTipo.Enabled = false;
            cbxFichaReparacionesInt.Enabled = false;
            cbxFichaReparacionesTipoTrabajo.Enabled = false;
            cbxFichaReparacionesChofer.Enabled = false;
            cbxFichaReparacionesMecanico.Enabled = false;

            // ingreso datos
            tbxFichaReparacionesDetalle.ReadOnly = true;
        }    

        // Hacia otros Forms / cerrar
        private void btnFichaReparacionesCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Acciones contra DB

        private Reparacion capturarReparacion() 
        {
            Reparacion auxReparacion = new Reparacion();
            Validaciones validar =  new Validaciones();
            AccesoDatos datos = new AccesoDatos();

            auxReparacion.Tipo = validar.cbxString(cbxFichaReparacionesTipoTrabajo.Text);
            auxReparacion.Persona = validar.cbxString(cbxFichaReparacionesChofer.Text);
            auxReparacion.TipoVehiculo = validar.cbxString(cbxFichaReparacionesTipo.Text);
            int tipo = datos.buscarIdTipoVehiculo(auxReparacion.TipoVehiculo);
            switch (tipo)
            {
                case 1:
                    auxReparacion.Tractor = validar.cbxInt(cbxFichaReparacionesInt.Text);
                    auxReparacion.Furgon = 0;
                    break;
                case 2:
                    auxReparacion.Tractor = 0;
                    auxReparacion.Furgon = validar.cbxInt(cbxFichaReparacionesInt.Text);
                    break;
                default:
                    auxReparacion.Tractor = 0;
                    auxReparacion.Furgon = 0;
                    break;
            }
            auxReparacion.Mecanico = validar.cbxString(cbxFichaReparacionesMecanico.Text);
            auxReparacion.Detalle = tbxFichaReparacionesDetalle.Text;


            return auxReparacion;
        }

        private List<Articulo> capturarUsoArticulos()
        {
            List<Articulo> listado = new List<Articulo>();
            foreach(DataGridViewRow fila in dgvFichaReparacionesRepuestos.Rows)
            {
                if(fila.DataBoundItem == null) continue;

                Articulo auxArticulo = (Articulo)fila.DataBoundItem;

                listado.Add(auxArticulo);
            }

            return listado;
        }

        private void agregar() 
        {
            ReparacionNegocio reparacionNegocio = new ReparacionNegocio();
            Reparacion nuevaReparacion = capturarReparacion();
            List<Articulo> repuestos = capturarUsoArticulos();
            reparacionNegocio.agregar(nuevaReparacion, repuestos, idTallerCamiones);
        }
        private void modificar() 
        {
            ReparacionNegocio reparacionNegocio = new ReparacionNegocio();
            Reparacion mReparacion = capturarReparacion();
            List<Articulo> mRepuestos = capturarUsoArticulos();

            reparacionNegocio.modificar(reparacion.Id, mReparacion, mRepuestos);
        }
        private void editar() { }

        private void btnFichaReparacionesOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(reparacion.Id.ToString());
            ejecutar(modo);
            Close();
        }

        private void ejecutar(char tmodo) 
        {
            switch (tmodo)
            {
                case 'F':
                    editar();
                    break;
                case 'A':
                    agregar();
                    break;
                case 'M':
                    modificar();
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        // DGV TABLAS

        private void formatoColumnas(DataGridView dgv)
        {
            ocultarColumnas(dgv);
            nombrarColumnas(dgv);
            anchoColumnas(dgv);
            ordenarColumnas(dgv);
        }

        private void ocultarColumnas(DataGridView dgv)
        {
            // grilla articulos
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["Detalle"].Visible = false;
            if(dgv == dgvFichaReparacionesArticulos)
            {
                dgv.Columns["Cantidad"].Visible = false;
            }
        }
        private void anchoColumnas(DataGridView dgv)
        {
            // grilla articulos
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoResizeColumns();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Width += 5;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        private void ordenarColumnas(DataGridView dgv)
        {
            // grilla articulos
            dgv.Columns["Nombre"].DisplayIndex = 0;
            dgv.Columns["CodigoProveedor"].DisplayIndex = 1;
            dgv.Columns["Marca"].DisplayIndex = 2;
            dgv.Columns["Stock"].DisplayIndex = 3;
            dgv.Columns["Unidad"].DisplayIndex = 4;
            dgv.Columns["Cantidad"].DisplayIndex = 5;
        }
        private void nombrarColumnas(DataGridView dgv)
        {
            // grilla articulos
            dgv.Columns["Nombre"].HeaderText = "REPUESTO";
            dgv.Columns["CodigoProveedor"].HeaderText = "CODIGO";
            dgv.Columns["Marca"].HeaderText = "MARCA";
            dgv.Columns["Stock"].HeaderText = "STOCK";
            dgv.Columns["Unidad"].HeaderText = "";
            dgv.Columns["Cantidad"].HeaderText = "CANT.";
        }

        // ACCIONES DE AGREGAR ELIMINAR ARTICULOS/REPUESTOS
        private void dgvFichaReparacionesArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // BOTON + DE ARTICULOS QUE SUMA EL ARTICULO A LOS REPUESTOS AGREGADOS.
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvFichaReparacionesArticulos.Columns[e.ColumnIndex].Name == "AgregarArticulo")
            {
                if (listadoRepuestosAgregados == null)
                    listadoRepuestosAgregados = new List<Articulo>();

                Articulo repuesto = listadoRepuestos[e.RowIndex];
                repuesto.Cantidad = 1; // por defecto se selecciona 1 unidad, lt o lo que corresponda

                if (repuesto.Stock > 0)
                {
                    if (!listadoRepuestosAgregados.Any(r => r.Id == repuesto.Id))
                    {
                        listadoRepuestosAgregados.Add(repuesto);
                        dgvFichaReparacionesRepuestos.DataSource = null;
                        dgvFichaReparacionesRepuestos.DataSource = listadoRepuestosAgregados;
                        formatoColumnas(dgvFichaReparacionesRepuestos);
                        btnEliminar(dgvFichaReparacionesRepuestos); // se agrega el boton de eliminar
                    }
                    else
                    {
                        MessageBox.Show("Este repuesto ya fue agregado.");
                    }
                }
                else
                {
                    MessageBox.Show("Repuesto sin Stock");
                }

            }

            
        }

        private void dgvFichaReparacionesRepuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // BOTON Eliminar DE ARTICULOS QUE SUMA EL ARTICULO A LOS REPUESTOS AGREGADOS.
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvFichaReparacionesRepuestos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = (int)dgvFichaReparacionesRepuestos.Rows[e.RowIndex].Cells["Id"].Value;
                var item = listadoRepuestosAgregados.FirstOrDefault(r => r.Id == id);
                if (item != null)
                {
                    listadoRepuestosAgregados.Remove(item);
                    dgvFichaReparacionesRepuestos.DataSource = null;
                    dgvFichaReparacionesRepuestos.DataSource = listadoRepuestosAgregados;
                    formatoColumnas(dgvFichaReparacionesRepuestos);
                    btnEliminar(dgvFichaReparacionesRepuestos);
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvFichaReparacionesRepuestos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                Articulo repuesto = listadoRepuestosAgregados[e.RowIndex];

                FrmArticuloCantidad ventana = new FrmArticuloCantidad(repuesto);
                ventana.ShowDialog();
                repuesto.Cantidad = ventana.CantidadSeleccionada;
            }
        }

        private void dgvFichaReparacionesRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        // Sin uso
        private void dtpFichaReparacionesFecha_ValueChanged(object sender, EventArgs e)
        {
        }

    }
}
