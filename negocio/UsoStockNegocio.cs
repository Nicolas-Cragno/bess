using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class UsoStockNegocio
    {
        public List<UsoStock> listar(long id = 0)
        {
            AccesoDatos datos = new AccesoDatos();
            List<UsoStock> listaStock = new List<UsoStock>();

            string campos = "SELECT idUso, idArticulo, idReparacion, Cantidad FROM " + AccesoDatos.Tablas.UsoArticulos;
            string condicion;
            if (id > 0)
                condicion = " WHERE idReparacion=" + id + ";";
            else
                condicion = ";";
            string query = campos + condicion;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    UsoStock auxUso = new UsoStock();

                    auxUso.Id = (long)datos.Lector["idUso"];
                    auxUso.Articulo = datos.buscarArticulo((int)datos.Lector["idArticulo"]);
                    auxUso.Reparacion = (int)datos.Lector["idReparacion"];
                    auxUso.Cantidad = (double)datos.Lector["cantidad"];
                    auxUso.Unidad = datos.buscarUnidadMedida((int)datos.Lector["idArticulo"]);

                    listaStock.Add(auxUso);
                }

                return listaStock;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
    }
}
