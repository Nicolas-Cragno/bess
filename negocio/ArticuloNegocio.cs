using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar(string sector)
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            int idSector = datos.buscarIdSector(sector);

            string campos = "SELECT idArticulo, codigoProveedor, nombre, marca, detalle, stock, idUnidad";
            string database = " FROM " + AccesoDatos.Tablas.Articulos;
            string condicion = " WHERE idSector =" + idSector + ";";
            string query = campos + database + condicion;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo auxArticulo = new Articulo();

                    auxArticulo.Id = (int)datos.Lector["idArticulo"];
                    auxArticulo.CodigoProveedor = (long)datos.Lector["codigoProveedor"];
                    auxArticulo.Nombre = (string)datos.Lector["nombre"];
                    auxArticulo.Marca = (string)datos.Lector["marca"];
                    auxArticulo.Detalle = (string)datos.Lector["detalle"];
                    auxArticulo.Stock = (double)datos.Lector["stock"];
                    auxArticulo.Unidad = datos.buscarUnidadMedida((int)datos.Lector["idArticulo"]);

                    listaArticulos.Add(auxArticulo);    
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public Articulo buscar(int id, string sector)
        {
            List<Articulo> listado = listar(sector);
            Articulo articulo = listado.FirstOrDefault(a => a.Id == id);

            return articulo;
        }
        public List<Articulo> listarPorReparacion(long idReparacion, string sector)
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT idArticulo, cantidad FROM " + AccesoDatos.Tablas.UsoArticulos + " WHERE idReparacion=" + idReparacion + ";";
            List<Articulo> lista = new List<Articulo>();
            try 
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo auxArticulo;

                    auxArticulo = buscar((int)datos.Lector["idArticulo"], sector);

                
                   auxArticulo.Cantidad = (double)datos.Lector["cantidad"];
                   
                    lista.Add(auxArticulo);
                }
                return lista;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); };
        }
    }
}
