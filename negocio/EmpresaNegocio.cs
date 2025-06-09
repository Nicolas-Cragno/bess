using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class EmpresaNegocio
    {
        public List<Empresa> listar(string tipo)
        {
            List<Empresa> listaEmpresas = new List<Empresa>();

            AccesoDatos datos = new AccesoDatos();
            int idTipo = datos.buscarIdTipoEmpresa(tipo);
            string campos = "SELECT cuit, idTipo, nombre, abreviatura";
            string database = " FROM " + AccesoDatos.Tablas.Empresas + " WHERE idTipo=" + idTipo + " OR idTipo=4;" ;
            string query = campos + database;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Empresa auxEmpresa = new Empresa();

                    auxEmpresa.Cuit = (long)datos.Lector["cuit"];
                    auxEmpresa.Tipo = tipo; // ya llega como parametro a la funcion
                    auxEmpresa.Nombre = (string)datos.Lector["nombre"];
                    auxEmpresa.Abreviatura = (string)datos.Lector["abreviatura"];

                    listaEmpresas.Add(auxEmpresa);
                }

                return listaEmpresas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<string> listaNombres(string tipo)
        {
            List<Empresa> empresas = new List<Empresa>();
            empresas = listar(tipo);
            List<string> nombres = empresas.Select(em => em.Nombre).ToList();

            return nombres;
        }
    }
}
