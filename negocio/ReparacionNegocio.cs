using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ReparacionNegocio
    {
        public List<Reparacion> listar(int estado)
        {
            List<Reparacion> listaReparaciones = new List<Reparacion>();
            AccesoDatos datos = new AccesoDatos();
            string campos = "SELECT idReparacion, idTipoReparacion, chofer, intTractor, intFurgon, detalle, fecha, mecanico, tipoVehiculo, fechaFin, estado";
            string database = " FROM " + AccesoDatos.Tablas.Reparaciones;
            string condicion = " WHERE estado=" + estado + ";";
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
                    auxReparacion.FechaFin = (DateTime)datos.Lector["fechaFin"];
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
    }
}
