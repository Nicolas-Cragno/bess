using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        string cadenaConexion = "server=.\\SQLEXPRESS; database=cantarini; integrated security=true";


        // funciones de acceso a datos
        public static class Tablas
        {
            private const string db = "cantarini.dbo";

            // EMPLEADOS / PERSONAS
            public static readonly string Personas = db + ".personas";
            public static readonly string Puestos = db + ".puestos";
            public static readonly string AsignacionesTractores = ".asignaciones_tractores";
            public static readonly string Sectores = db + ".sectores";

            //  VEHICULOS
            public static readonly string Tractores = db + ".tractores";
            public static readonly string EstadosTracotres = db + ".estados_tractores";
            public static readonly string AsignacionesSatelitales = ".asignaciones_satelitales";
            public static readonly string Furgones = db + ".furgones";
            public static readonly string EstadosFurgones = db + ".estados_furgones";
            public static readonly string Utilitarios = db + ".utilitarios";
            public static readonly string TiposVehiculos = db + ".tipos_vehiculos";

            // EMPRESAS / CLIENTES
            public static readonly string Empresas = db + ".empresas";
            public static readonly string TiposEmpresas = db + ".tipos_empresas";
            public static readonly string Satelitales = db + ".satelitales";

            // EVENTOS, ETC
            public static readonly string Eventos = db + ".eventos";
            public static readonly string TiposEventos = db + ".tipos_eventos";
            public static readonly string Movimientos = db + ".movimientos";
            public static readonly string TiposMovimientos = db + ".tipos_movimientos";
            public static readonly string Reparaciones = db + ".reparaciones";
            public static readonly string TiposReparaciones = db + ".tipos_reparaciones";
            public static readonly string Viajes = db + ".viajes";
            public static readonly string Cargas = db + ".cargas";

            // ARTICULOS STOCK
            public static readonly string Articulos = db + ".articulos";
            public static readonly string UsoArticulos = db + ".uso_articulos";
            public static readonly string Unidades = db + ".unidades";
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
        }

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void abrirConexion()
        {
            comando.Connection = conexion;

            try
            {
                if(conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarLectura()
        {
            try
            {
                abrirConexion();

                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion() 
        {
            comando.Connection = conexion;

            try
            {
                abrirConexion();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void cerrarConexion()
        {
            if(lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }

        // funciones para empleados
        public Chofer buscarDatosChofer(int dni)
        {
            Chofer auxChofer = new Chofer();
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT idPuesto, detalle, apellido, nombres, empresa FROM " + Tablas.Personas + " WHERE dni=" + dni + ";";
            
            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();
                
                if (datos.Lector.Read())
                {
                    auxChofer.Dni = (int)datos.Lector["dni"];
                    auxChofer.Puesto = buscarPuesto((int)datos.Lector["idPuesto"]);
                    auxChofer.Apellido = (string)datos.Lector["apellido"];
                    auxChofer.Nombres = (string)datos.Lector["nombres"];
                    auxChofer.Empresa = buscarEmpresa((int)datos.Lector["empresa"]);
                    auxChofer.Detalle = (string)datos.Lector["detalle"];
                    auxChofer.Tractor = buscarTractorAsignado(auxChofer.Dni);
                    //auxChofer.Viajes = contarViajes(auxChofer.Dni);
                    //auxChofer.Promedio = calcularPromedio(auxChofer.Dni);
                    //auxChofer.Diferencias = contarDiferencias(auxChofer.Dni);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { datos.abrirConexion(); }
            return auxChofer;
        }
        public string buscarPersona(int dni) 
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT apellido, nombres FROM " + Tablas.Personas +" WHERE dni = " + dni + ";";
            string nombre;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    nombre = (string)datos.Lector["apellido"] + ", " + (string)datos.Lector["nombres"];
                }
                else
                {
                    nombre = "SIN CHOFER ASIGNADO";
                }

                return nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }


        public int buscarDniFull(string nombreCompleto) 
        {
            int dni;
            if (nombreCompleto == "SIN ASIGNAR")
            {
                dni = 0;
            } else
            {
                var division = nombreCompleto.Split(',');
                string apellido = division[0];
                string auxNombre = division[1];
                int largo = auxNombre.Length;
                string nombres = "";

                for (int i = 0; i < largo; i++)
                {
                    if (i > 0)
                    {
                        nombres = nombres + auxNombre[i];
                    }
                }

                try
                {
                    dni = buscarDni(apellido.ToUpper(), nombres.ToUpper());
                }
                catch (Exception)
                {
                    dni = 0;
                }
            }

                return dni;
        }
        public int buscarDni(string apellido, string nombres) 
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT dni FROM " + Tablas.Personas + " WHERE apellido = '" + apellido + "' AND nombres='" + nombres + "';";
            int dni;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    dni = (int)datos.Lector["dni"];
                }
                else
                {
                    dni = 0;
                }

                return dni;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public int buscarTractorAsignado(int dni)
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT intTractor FROM " + Tablas.AsignacionesTractores + " WHERE dni=" + dni + ";";
            int tractor;

            try 
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    tractor = (int)datos.Lector["intTractor"];
                }
                else
                {
                    tractor = 0;
                }
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); };

            return tractor;
        }
        public string buscarPuesto(int id) 
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT nombre FROM " + Tablas.Puestos + " WHERE idPuesto=" + id + ";";
            string query2 = "SELECT nombre FROM " + Tablas.Puestos + " WHERE idPuesto=0;";
            string puesto;
            try 
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    puesto = (string)datos.Lector["nombre"];
                }
                else
                {
                    datos.setearConsulta(query2);
                    datos.ejecutarLectura();
                    if (datos.Lector.Read())
                        puesto = (string)datos.Lector["nombre"];
                    else
                        puesto = "NO ASIGNADO";
                }
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }

            return puesto;
        }
        public int buscarIdPuesto(string puesto)
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT idPuesto FROM " + Tablas.Puestos + " WHERE nombre = " + puesto + ";";
            int idPuesto;
            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    idPuesto = (int)datos.Lector["idPuesto"];
                }
                else
                {
                    idPuesto = 0;
                }
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }

            return idPuesto;
        }
        
        public int buscarIdTipoEmpresa(string empresa)
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT idTipo FROM " + Tablas.TiposEmpresas + " WHERE nombre='" + empresa + "';";
            int idTipoEmpresa;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    idTipoEmpresa = (int)datos.Lector["idTipo"];
                }
                else
                {
                    idTipoEmpresa = 0;
                }
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }

            return idTipoEmpresa;
        }

        // funciones para stock / articulos / repuestos

        public string buscarArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            string articulo;
            string query = "SELECT nombre FROM " + Tablas.Articulos + " WHERE idArticulo=" + id + ";";
            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    articulo = (string)datos.Lector["nombre"];
                }
                else
                {
                    articulo = "SIN ASIGNAR";
                }

                return articulo;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public int buscarIdUnidadMedidaArticulo(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos ();
            string query = "SELECT idUnidad FROM " + Tablas.Articulos + " WHERE idArticulo=" + idArticulo + ";";
            int id;

            try
            {
                datos.setearConsulta (query);
                datos.ejecutarLectura ();

                if (datos.Lector.Read())
                {
                    id = (int)datos.Lector["idUnidad"];
                } else
                {
                    id = 1;
                }

                return id;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
            
        }

        public string buscarUnidadMedida(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            int idUnidad = datos.buscarIdUnidadMedidaArticulo(idArticulo);
            string query = "SELECT nombre FROM " + Tablas.Unidades + " WHERE id=" + idUnidad + ";";
            string unidad;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    unidad = (string)datos.Lector["nombre"];
                }
                else
                {
                    unidad = "#N";
                }

                return unidad;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public string buscarUnidadMedidaDetalle(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            int idUnidad = datos.buscarIdUnidadMedidaArticulo(idArticulo);
            string query = "SELECT detalle FROM " + Tablas.Unidades + " WHERE id=" + idUnidad + ";";
            string detalle;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    detalle = (string)datos.Lector["detalle"];
                }
                else
                {
                    detalle = "NO ASIGNADO";
                }

                return detalle;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
        
            
            // funciones para vehiculos
        public string buscarSatelital(int id) 
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT nombre FROM " + Tablas.Satelitales + " WHERE idSatelital = " + id + ";";
            string query2 = "SELECT nombre FROM " + Tablas.Satelitales + " WHERE idSatelital=0;";
            string satelital;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    satelital = (string)datos.Lector["nombre"];
                }
                else
                {
                    datos.setearConsulta(query2);
                    datos.ejecutarAccion();
                    satelital = (string)datos.Lector["nombre"];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return satelital;
        }
        public int buscarIdSatelital(string satelital) 
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT idSatelital FROM " + Tablas.Satelitales + " WHERE nombre = " + satelital + ";";
            int idSatelital;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    idSatelital = (int)datos.Lector["idSatelital"];
                }
                else
                {
                    idSatelital = 0;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return idSatelital;
        }
        public int buscarIdTipoVehiculo(string tipo) 
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT idVehiculo FROM " + Tablas.TiposVehiculos + " WHERE nombre='" + tipo + "';";
            int idTipo;
            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (Lector.Read())
                {
                    idTipo = (int)datos.Lector["idVehiculo"];
                }
                else
                {
                    idTipo = 0;
                }

                return idTipo;
            }
            catch (Exception e) { throw e; }
            finally { datos.cerrarConexion(); }
        }
        public string buscarTipoVehiculo(int tipo)
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT nombre FROM " + Tablas.TiposVehiculos + " WHERE idVehiculo=" + tipo + ";";
            string vehiculo;
            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    vehiculo = (string)datos.Lector["nombre"];
                } else
                {
                    vehiculo = "SIN ASIGNAR";
                }

                return vehiculo;
            }
            catch(Exception e) { throw e; }
            finally { datos.cerrarConexion();}
        }

        // funciones para eventos
        public int buscarIdTipoMovimiento(string movimiento) 
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT idTipoMovimiento FROM " + Tablas.TiposMovimientos + " WHERE nombre='" + movimiento + "';";
            int id;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.lector.Read())
                {
                    id = (int)datos.lector["idTipoMovimiento"];
                }
                else
                {
                    id = 0;
                }

                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public string buscarTipoMovimiento(int id) 
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT nombre FROM " + Tablas.TiposMovimientos + " WHERE idTipoMovimiento=" + id + ";";
            string movimiento;

            try
            {
                if (datos.lector.Read())
                {
                    movimiento = (string)datos.lector["nombre"];
                }
                else
                {
                    movimiento = "";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }

            return movimiento;
        }

        public string buscarTipoReparacion(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT nombre FROM " + Tablas.TiposReparaciones + " WHERE idTipoReparacion=" + id + ";";
            string tipo;
            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    tipo = (string)datos.Lector["nombre"];
                } else
                {
                    tipo = "SIN ASIGNAR";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }

            return tipo;
        }

        public int buscarIdTipoEvento(string evento)
        {
            AccesoDatos datos = new AccesoDatos ();
            string query = "SELECT idTipoEvento FROM " + AccesoDatos.Tablas.TiposEventos + " WHERE nombre='" + evento + "';";
            int tipo;
            try
            {
                datos.setearConsulta (query);
                datos.ejecutarLectura ();

                if (datos.Lector.Read())
                {
                    tipo = (int)datos.Lector["idTipoEvento"];
                }
                else
                {
                    tipo = 0;
                }

                return tipo;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
        public string buscarTipoEvento(int id)
        {
            AccesoDatos datos =new AccesoDatos();
            string query = "SELECT nombre FROM " + Tablas.TiposEventos + " WHERE idTipoEvento=" + id + ";";
            string evento;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    evento = (string)datos.Lector["nombre"];
                }
                else
                {
                    evento = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {  datos.cerrarConexion(); }

            return evento;
        }

        // funciones generales sin acceso a DB.


        public int numerarBool(bool estado)
        {
            int nro;
            if (estado)
            {
                nro = 1;
            }
            else
            {
                nro = 0;
            }

            return nro;
        }
        public bool convertirBool(int nro) 
        {
            bool estado;
            if (nro == 1)
            {
                estado = true;
            } else
            {
                estado = false;
            }

            return estado;
        }

        public List<string> horarios(int i, int f)
        {
            List<string> hs = new List<string>();

            DateTime inicio = DateTime.Today.AddHours(i);
            DateTime fin = DateTime.Today.AddHours(f);

            while(inicio <= fin){
                hs.Add(inicio.ToString("HH:mm"));
                inicio = inicio.AddMinutes(30);
            }

            return hs;
        }

        public List<string> unidadesHs()
        {
            return new List<string>
            {
                "MINUTOS",
                "HORAS",
                "DIAS"
            };
        }

        // funciones para empresas y relacionadas

        public string buscarEmpresa(long? id)
        {
            string empresa;
            switch (id)
            {
                case 30610890403:
                    empresa = "TRANSPORTES CANTARINI";
                    break;
                case 30644511304:
                    empresa = "EXPRESO CANTARINI";
                    break;
                case 30683612916:
                    empresa = "TRANS AMERICA TRANSPORTES";
                    break;
                case 30708633174:
                    empresa = "INVERSIONES FUEGUINAS";
                    break;
                default:
                    empresa = "SIN ASIGNAR";
                    break;
            }

            return empresa;
        }
        public string buscarEmpresaAbreviada(long? id) 
        {
            string empresa;

            switch (id)
            {
                case 30610890403:
                    empresa = "TC";
                    break;
                case 30644511304:
                    empresa = "EX";
                    break;
                case 30683612916:
                    empresa = "TA";
                    break;
                case 30708633174:
                    empresa = "IF";
                    break;
                default:
                    empresa = "#N";
                    break;
            }

            return empresa;
        }
        public long buscarCuitEmpresa(string empresa) 
        {
            long cuit;

            switch (empresa)
            {
                case "TRANSPORTES CANTARINI":
                    cuit = 30610890403;
                    break;
                case "TRANS AMERICA TRANSPORTES":
                    cuit = 30644511304;
                    break;
                case "EXPRESO CANTARINI":
                    cuit = 30683612916;
                    break;
                case "INVERSIONES FUEGUINAS":
                    cuit = 30708633174;
                    break;
                default:
                    cuit = 0;
                    break;
            }


            return cuit;
        }

        public int buscarIdSector(string sector)
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT idSector FROM " + Tablas.Sectores + " WHERE nombre='" + sector + "';";
            int idSector;
            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    idSector = (int)datos.Lector["idSector"];
                }
                else
                {
                    idSector = 0;
                }

                return idSector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); } 
        }
    }
}
