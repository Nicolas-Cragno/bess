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

            string campos = "SELECT idArticulo, codigoProveedor, nombre, marca, detalle, stock";
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
                    auxArticulo.Stock = (int)datos.Lector["stock"];

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
    }
}
