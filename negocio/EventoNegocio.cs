using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class EventoNegocio
    {
        public List<Evento> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Evento> listaEventos = new List<Evento>();

            string campos = "SELECT idEvento, idTipoEvento, dni, intTractor, intFurgon, fecha, detalle";
            string database = " FROM " + AccesoDatos.Tablas.Eventos + ";";
            string query = campos + database;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Evento auxEvento = new Evento();

                    auxEvento.Id = (long)datos.Lector["idEvento"];
                    auxEvento.Tipo = datos.buscarTipoEvento((int)datos.Lector["idTipoEvento"]);
                    auxEvento.Persona = datos.buscarPersona((int)datos.Lector["dni"]);
                    auxEvento.Tractor = (int)datos.Lector["intTractor"];
                    auxEvento.Furgon = (int)datos.Lector["intFurgon"];
                    auxEvento.Fecha = (DateTime)datos.Lector["fecha"];
                    auxEvento.Detalle = (string)datos.Lector["detalle"];
                    /*
                     */

                    listaEventos.Add(auxEvento);
                }

                return listaEventos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Evento> listarEventos(char tipo, int parametro) 
        {
            AccesoDatos datos = new AccesoDatos();
            List<Evento> listaEventos = new List<Evento>();
            string filtro;

            switch (tipo)
            {
                case 'P': filtro = " WHERE dni=" + parametro + ";";
                    break;
                case 'T': filtro = " WHERE intTractor=" + parametro + ";";
                    break;
                case 'F': filtro = " WHERE intFurgon=" + parametro + ";";
                    break;
                default: filtro = ";";
                    break;
            }

            string campos = "SELECT idEvento, idTipoEvento, dni, intTractor, intFurgon, fecha, detalle";
            string database = "FROM " + AccesoDatos.Tablas.Eventos + filtro;
            string query = campos + database;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Evento auxEvento = new Evento();

                    auxEvento.Id = (long)datos.Lector["idEvento"];
                    auxEvento.Tipo = datos.buscarTipoEvento((int)datos.Lector["idTipoEvento"]);
                    auxEvento.Persona = datos.buscarPersona((int)datos.Lector["dni"]);
                    auxEvento.Tractor = (int)datos.Lector["intTractor"];
                    auxEvento.Furgon = (int)datos.Lector["intFurgon"];
                    auxEvento.Fecha = (DateTime)datos.Lector["fecha"];
                    auxEvento.Detalle = (string)datos.Lector["detalle"];

                    listaEventos.Add(auxEvento);
                }

                return listaEventos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        } // lista dependiendo si es persona, tractor o furgon

        public void agregar(Evento evento)
        {
            AccesoDatos datos = new AccesoDatos();
            string database = "INSERT INTO " + AccesoDatos.Tablas.Eventos;
            int dni = datos.buscarDniFull(evento.Persona); // Buscamos el nro de dni para relacionar con DB
            int tipo = datos.buscarIdTipoMovimiento(evento.Tipo); // la aplicacion maneja el tipo como string y la DB como int
            string campos = "(idTipoEvento, dni, intTractor, intFurgon, detalle) VALUES (" + tipo + ", " + dni + ", " + evento.Tractor + ", " + evento.Furgon + ", '" + evento.Detalle.ToUpper() + "');";
              
            try
            {
                datos.setearConsulta(database + campos);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void modificar(Evento evento)
        {
            AccesoDatos datos = new AccesoDatos();
            int dni = datos.buscarDniFull(evento.Persona); // Buscamos el nro de dni para relacionar con DB
            int tipo = datos.buscarIdTipoMovimiento(evento.Tipo); // la aplicacion maneja el tipo como string y la DB como int
            string database = "UPDATE " + AccesoDatos.Tablas.Eventos;
            string campos = " SET idTipoEvento=" + tipo + ", dni=" + dni + ", intTractor=" + evento.Tractor + ", intFurgon=" + evento.Furgon + ", detalle='" + evento.Detalle + "'";
            string condicion = " WHERE idEvento=" + evento.Id + ";";
            try
            {
                datos.setearConsulta(database + campos + condicion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {  datos.cerrarConexion(); }
        }
    }
}
