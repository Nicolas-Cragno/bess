using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class FleteroNegocio
    {
        public List<Fletero> listar()
        {
            List<Fletero> listado = new List<Fletero>();
            AccesoDatos datos = new AccesoDatos();

            string campos = "SELECT dni, idPuesto, detalle, apellido, nombres, empresa, estado";
            string database = " FROM " + AccesoDatos.Tablas.Personas;
            string condicion = " WHERE  idPuesto=4;";
            string query = campos + database + condicion;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Fletero fletero = new Fletero();
                    Tractor tractor = datos.buscarTractorFletero((int)datos.Lector["dni"]);
                    Furgon furgon = datos.buscarFurgonFletero((int)datos.Lector["dni"]);

                    fletero.Dni = (int)datos.Lector["dni"];
                    fletero.Puesto = datos.buscarPuesto((int)datos.Lector["idPuesto"]);
                    fletero.Detalle = (string)datos.Lector["detalle"];
                    fletero.Apellido = (string)datos.Lector["apellido"];
                    fletero.Nombres = (string)datos.Lector["nombres"];
                    fletero.Empresa = datos.buscarEmpresaAbreviada((long)datos.Lector["empresa"]);
                    fletero.DominioTractor = tractor.Dominio;
                    fletero.MarcaTractor = tractor.Marca;
                    fletero.ModeloTractor = tractor.Modelo;
                    fletero.DetalleTractor = tractor.Detalle;
                    fletero.DominioFurgon = furgon.Dominio;
                    fletero.MarcaFurgon = furgon.Marca;
                    fletero.DetalleFurgon = furgon.Detalle;

                    listado.Add(fletero);
                }
                return listado.OrderBy(a => a.Apellido == "SIN ASIGNAR").ThenBy(a => a.Apellido).ThenBy(a => a.Nombres).ToList(); // listsa ordenada alfabeticamente
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public List<string> listarNombres()
        {
            List<Fletero> fleteros = new List<Fletero>();
            fleteros = listar();
            List<string> nombres = fleteros.Select(fl => fl.Apellido + ", " + fl.Nombres).ToList();

            return nombres;
        }
    }
}
