using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ReparacionNegocio
    {
        public List<Reparacion> listar(int sector, int estado)
        {
            List<Reparacion> listaReparaciones = new List<Reparacion>();
            AccesoDatos datos = new AccesoDatos();
            string campos = "SELECT idReparacion, idTipoReparacion, chofer, intTractor, intFurgon, detalle, fecha, mecanico, tipoVehiculo, fechaFin, estado";
            string database = " FROM " + AccesoDatos.Tablas.Reparaciones;
            string condicion = " WHERE estado=" + estado + " AND idSector=" + sector + ";";
            string query = campos + database + condicion;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Reparacion auxReparacion = new Reparacion();

                    auxReparacion.Id = (long)datos.Lector["idReparacion"];
                    auxReparacion.Tipo = datos.buscarTipoReparacion((int)datos.Lector["idTipoReparacion"]);
                    auxReparacion.Persona = datos.buscarPersona((int)datos.Lector["chofer"]);
                    auxReparacion.Tractor = (int)datos.Lector["intTractor"];
                    auxReparacion.Furgon = (int)datos.Lector["intFurgon"];
                    auxReparacion.Detalle = (string)datos.Lector["detalle"];
                    auxReparacion.Fecha = (DateTime)datos.Lector["fecha"];
                    auxReparacion.Mecanico = datos.buscarPersona((int)datos.Lector["mecanico"]);
                    auxReparacion.TipoVehiculo = datos.buscarTipoVehiculo((int)datos.Lector["tipoVehiculo"]);
                    auxReparacion.FechaFin = datos.Lector["fechaFin"] != DBNull.Value ? (DateTime)datos.Lector["fechaFin"] : DateTime.MinValue;
                    auxReparacion.Estado = (bool)datos.Lector["estado"];
                    switch ((int)datos.Lector["tipoVehiculo"])
                    {
                        case 1:
                            auxReparacion.InternoAfectado = auxReparacion.Tractor;
                            break;
                        case 2:
                            auxReparacion.InternoAfectado = auxReparacion.Furgon;
                            break;
                        default:
                            auxReparacion.InternoAfectado = 0;
                            break;
                    }
                    

                    listaReparaciones.Add(auxReparacion);
                }

                return listaReparaciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<string> listarTipos()
        {
            AccesoDatos datos = new AccesoDatos();
            List<string> lista = new List<string>();
            string query = "SELECT idTipoReparacion, nombre FROM " + AccesoDatos.Tablas.TiposReparaciones + ";";

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    string auxTipo = (string)datos.Lector["nombre"];

                    lista.Add(auxTipo);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
            ;
        }

        public void agregar(Reparacion nvRp, List<Articulo> nvAr, int idSector)
        {
            AccesoDatos datos = new AccesoDatos();
            int idTipo = datos.buscarIdTipoReparacion(nvRp.Tipo);
            int dniChofer = datos.buscarDniFull(nvRp.Persona);
            int dniMecanico = datos.buscarDniFull(nvRp.Mecanico);
            int tipoVehiculo = datos.buscarIdTipoVehiculo(nvRp.TipoVehiculo); 
            string database = "INSERT INTO " + AccesoDatos.Tablas.Reparaciones;
            string campos = "(idTipoReparacion, chofer, intTractor, intFurgon, detalle, fecha, mecanico, tipoVehiculo, idSector)";
            string parametros = " VALUES (" + idTipo + ", " + dniChofer + ", " + nvRp.Tractor + ", " + nvRp.Furgon + ", '" + nvRp.Detalle.ToUpper() + "', GETDATE(), " + dniMecanico + ", " + tipoVehiculo + ", " + idSector + ")";
            string query = database + campos + parametros + " SELECT SCOPE_IDENTITY();";
            try 
            {
                datos.setearConsulta(query);
                //datos.ejecutarAccion();
                int idReparacion = datos.ejecutarScalar();

                foreach(Articulo auxArticulo in nvAr)
                {
                    string queryArticulo = "INSERT INTO " + AccesoDatos.Tablas.UsoArticulos + "(idArticulo, idReparacion, cantidad) VALUES (" + auxArticulo.Id + ", " + idReparacion + ", " + auxArticulo.Cantidad.ToString(CultureInfo.InvariantCulture) + ");";
                    datos.setearConsulta(queryArticulo);
                    datos.ejecutarAccion();
                }
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion();  }
        }

        public void modificar(long idReparacion, Reparacion mdRp, List<Articulo> mdAr)
        {
            AccesoDatos datos = new AccesoDatos();
            int idTipo = datos.buscarIdTipoReparacion(mdRp.Tipo);
            int dniChofer = datos.buscarDniFull(mdRp.Persona);
            int dniMecanico = datos.buscarDniFull(mdRp.Mecanico);
            int tipoVehiculo = datos.buscarIdTipoVehiculo(mdRp.TipoVehiculo);
            string database = "UPDATE " + AccesoDatos.Tablas.Reparaciones;
            string campos = " SET idTipoReparacion=" + idTipo + ", chofer=" + dniChofer + ", intTractor=" + mdRp.Tractor + ", intFurgon=" + mdRp.Furgon + ", detalle='" + mdRp.Detalle.ToUpper() + "', mecanico=" + dniMecanico + ", tipoVehiculo=" + tipoVehiculo;
            string condicion = " WHERE idReparacion=" + idReparacion + ";";
            string query = database + campos + condicion;
            try
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();

                //UsoStockNegocio usoStockNegocio = new UsoStockNegocio();
                //usoStockNegocio.modificarDesdeArticulos(mdAr, mdRp.Id);

            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public void finalizar(long id)
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "UPDATE " + AccesoDatos.Tablas.Reparaciones + " SET fechaFin=GETDATE(), estado=1 WHERE idReparacion=" + id + ";";

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public bool verificarEstado(long id)
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT estado FROM " + AccesoDatos.Tablas.Reparaciones + " WHERE idReparacion=" + id + ";";
            bool estado;
            try 
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    estado = (bool)datos.Lector["estado"];
                } else
                {
                    estado = false;
                }

                return estado;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
    }
}
