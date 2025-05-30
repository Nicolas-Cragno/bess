using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace negocio
{
    public class VehiculoNegocio
    {
        int activo = 1;
        public List<string> listarTipos()
        {
            AccesoDatos datos = new AccesoDatos();
            List<string> lista = new List<string>();
            string query="SELECT nombre FROM " + AccesoDatos.Tablas.TiposVehiculos + ";";

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    string auxTipo = (string)datos.Lector["nombre"];

                    lista.Add(auxTipo);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); } 
        }

        public List<int> listarInternos(string tipo)
        {
            List<int> lista = new List<int>();
            TractorNegocio tractorNegocio = new TractorNegocio();
            FurgonNegocio furgonNegocio = new FurgonNegocio();
            switch (tipo)
            {
                case "TRACTOR":
                    lista = tractorNegocio.listarInternos(activo);
                    break;
                case "FURGON":
                    lista = furgonNegocio.listarInternos(activo);
                    break;
                default:
                    lista = null;
                    break;
            }

            return lista;
        }
    }
}
