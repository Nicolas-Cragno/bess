using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class FurgonNegocio
    {
        public List<Furgon> listar(int activo) 
        {
            List<Furgon> listaFurgones = new List<Furgon>();
            AccesoDatos datos = new AccesoDatos();

            string campos = "SELECT intFurgon, cuitEmpresa, dominio, activo";
            string database = " FROM " + AccesoDatos.Tablas.Furgones + " WHERE activo=" + activo + ";";
            string query = campos + database;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Furgon auxFurgon = new Furgon();

                    auxFurgon.Interno = (int)datos.Lector["intFurgon"];
                    auxFurgon.Empresa = datos.buscarEmpresa((long)datos.Lector["cuitEmpresa"]);
                    auxFurgon.Dominio = (string)datos.Lector["dominio"];
                    auxFurgon.Activo = (bool)datos.Lector["activo"];

                    listaFurgones.Add(auxFurgon);
                }

                return listaFurgones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); } 
        }

        public List<int> listarInternos(int estado)
        {
            List<Furgon> furgones = listar(estado);
            List<int> internos = furgones.Select(f => f.Interno).ToList();
            return internos;
        }

    }
}
