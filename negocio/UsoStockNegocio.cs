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

        public void modificar(UsoStock mdSt)
        {
            AccesoDatos datos = new AccesoDatos();
            int idArticulo = datos.buscarIdArticulo(mdSt.Articulo);
            string database = "UPDATE " + AccesoDatos.Tablas.UsoArticulos + " SET ";
            string campos = "cantidad=" + mdSt.Cantidad;
            string condicion = " WHERE idUso=" + mdSt.Id + " AND idArticulo=" + idArticulo + " AND idReparacion=" + mdSt.Reparacion + ";";
            string query = database+ campos+ condicion;
            try
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public void modificarDesdeArticulos(List<Articulo> listaArticulos, long idReparacion)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                foreach (Articulo articulo in listaArticulos)
                {
                    string database = "UPDATE" + AccesoDatos.Tablas.UsoArticulos;
                    string campos = " SET cantidad=" + articulo.Cantidad;
                    string condicion = " WHERE idArticulo=" + articulo.Id + " AND idReparacion=" + idReparacion + ";";
                    string query = database + campos+ condicion;

                    datos.setearConsulta(query);
                    datos.ejecutarAccion();
                }
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public int buscarCantidad(long idReparacion, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT cantidad FROM " + AccesoDatos.Tablas.UsoArticulos + " WHERE idReparacion=" + idReparacion + " AND idArticulo=" + idArticulo + ";";
            int cantidad;

            try 
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    cantidad = (int)datos.Lector["cantidad"];
                } else
                {
                    cantidad = 0;   
                }
                return cantidad;
            }
            catch (Exception ex) { throw ex; }
            finally{ datos.cerrarConexion(); };
        }
    }
}
