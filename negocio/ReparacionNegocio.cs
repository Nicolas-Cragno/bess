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
        public List<Reparacion> listar()
        {
            List<Reparacion> listaReparaciones = new List<Reparacion>();
            AccesoDatos datos = new AccesoDatos();
            string campos = "SELECT idReparacion, idTipoReparacion, chofer, intTractor, intFurgon, detalle, fecha, mecanico";
            string database = " FROM " + AccesoDatos.Tablas.Reparaciones + ";";
            string query = campos + database;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Reparacion auxReparacion = new Reparacion();

                    auxReparacion.Id = (int)datos.Lector["idReparacion"];
                    auxReparacion.Tipo = datos.buscarTipoReparacion((int)datos.Lector["idTipoReparacion"]);
                    auxReparacion.Persona = datos.buscarPersona((int)datos.Lector["chofer"]);
                    auxReparacion.Tractor = (int)datos.Lector["intTractor"];
                    auxReparacion.Furgon = (int)datos.Lector["intFurgon"];
                    auxReparacion.Detalle = (string)datos.Lector["detalle"];
                    auxReparacion.Fecha = (DateTime)datos.Lector["fecha"];
                    auxReparacion.Mecanico = datos.buscarPersona((int)datos.Lector["mecanico"]);

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
    }
}
