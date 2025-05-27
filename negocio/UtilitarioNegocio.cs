using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class UtilitarioNegocio
    {
        public List<Vehiculo> listar(int activo)
        {
            List<Vehiculo> listaUtilitarios = new List<Vehiculo>();

            AccesoDatos datos = new AccesoDatos();
            string campos = "SELECT dominio, marca, modelo, detalles, activo, empresa";
            string database = " FROM " + AccesoDatos.Tablas.Utilitarios + " WHERE activo=" + activo + ";";
            string query = campos + database;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Vehiculo auxUtilitario = new Vehiculo();

                    auxUtilitario.Dominio = (string)datos.Lector["dominio"];
                    auxUtilitario.Marca = (string)datos.Lector["marca"];
                    auxUtilitario.Modelo = (int)datos.Lector["modelo"];
                    auxUtilitario.Detalle = (string)datos.Lector["detalles"];
                    auxUtilitario.Activo = (bool)datos.Lector["activo"];
                    auxUtilitario.Empresa = datos.buscarEmpresaAbreviada((long)datos.Lector["empresa"]);

                    listaUtilitarios.Add(auxUtilitario);
                }
      
                return listaUtilitarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }

        public List<string> listarDominios(int activo)
        {
            List<Vehiculo> utilitarios = new List<Vehiculo>();
            utilitarios = listar(activo);
            List<string> dominios = utilitarios.Select(ut => ut.Dominio).ToList();

            return dominios;
        }
    }
}
