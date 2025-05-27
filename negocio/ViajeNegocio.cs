using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ViajeNegocio
    {
        public List<Viaje> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Viaje> listadoViajes = new List<Viaje>();

            string campos = "SELECT idViaje, fecha, cliente, chofer, tractor, furgon, gasoilReal, gasoilSat, kilometraje, promedio, diferencia, detalle";
            string database = " FROM " + AccesoDatos.Tablas.Viajes + ";";
            string query = campos + database;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Viaje auxViaje = new Viaje();
                    auxViaje.Id = (int)datos.Lector["idViaje"];
                    auxViaje.Fecha = (DateTime)datos.Lector["fecha"];
                    auxViaje.Cliente = datos.buscarEmpresa((long)datos.Lector["cliente"]);
                    auxViaje.Persona = datos.buscarPersona((int)datos.Lector["chofer"]);
                    auxViaje.Tractor = (int)datos.Lector["tractor"];
                    auxViaje.Furgon = (int)datos.Lector["furgon"];
                    auxViaje.GasoilReal = (double)datos.Lector["gasoilReal"];
                    auxViaje.GasoilSat = (double)datos.Lector["gasoilSat"];
                    auxViaje.Kilometraje = (double)datos.Lector["kilometraje"];
                    auxViaje.Promedio = (double)datos.Lector["promedio"];
                    auxViaje.Diferencia = (double)datos.Lector["diferencia"];
                    auxViaje.Detalle = (string)datos.Lector["detalle"];

                    listadoViajes.Add(auxViaje);
                }

                return listadoViajes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
