using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MecanicoNegocio
    {
        public List<Mecanico> listar(int activo, int puesto)
        {
            List<Mecanico> listaMecanicos = new List<Mecanico>();
            AccesoDatos datos = new AccesoDatos();

            string campos = "SELECT dni, idPuesto, detalle, apellido, nombres, empresa, estado";
            string database = " FROM " + AccesoDatos.Tablas.Personas;
            string condicion = " WHERE estado=" + activo + " AND idPuesto=" + puesto + ";";
            string query = campos + database + condicion;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Mecanico mecanico = new Mecanico();
                    mecanico.Dni = (int)datos.Lector["dni"];
                    mecanico.Puesto = datos.buscarPuesto((int)datos.Lector["idPuesto"]);
                    mecanico.Detalle = (string)datos.Lector["detalle"];
                    mecanico.Apellido = (string)datos.Lector["apellido"];
                    mecanico.Nombres = (string)datos.Lector["nombres"];
                    mecanico.Empresa = datos.buscarEmpresaAbreviada((long)datos.Lector["empresa"]);
                    //mecanico.Sede = datos.buscarSede(mecanico.Dni);
                    //mecanico.Vehiculo = datos.buscarVehiculo(mecanico.Dni);
                    //mecanico.Arreglos = datos.contarArreglos(mecanico.Dni);

                    listaMecanicos.Add(mecanico);
                }

                return listaMecanicos.OrderBy(me => me.Apellido).ThenBy(me => me.Nombres).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
