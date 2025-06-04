using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class PersonaNegocio
    {
        public List<Persona> listar(int estado)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Persona> listado = new List<Persona>();

            string campos = "SELECT dni, idPuesto, detalle, apellido, nombres, empresa, estado, ingreso";
            string database = " FROM " + AccesoDatos.Tablas.Personas + " WHERE estado=" + estado + ";";
            string query = campos + database;

            try 
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Persona auxPersona = new Persona();

                    auxPersona.Dni = (int)datos.Lector["dni"];
                    auxPersona.Puesto = datos.buscarPuesto((int)datos.Lector["idPuesto"]);
                    auxPersona.Detalle = (string)datos.Lector["detalle"];
                    auxPersona.Apellido = (string)datos.Lector["apellido"];
                    auxPersona.Nombres = (string)datos.Lector["nombres"];
                    auxPersona.Empresa = datos.buscarEmpresa((long)datos.Lector["empresa"]);
                    auxPersona.Activo = (bool)datos.Lector["estado"];
                    auxPersona.Ingreso = (DateTime)datos.Lector["ingreso"];

                    listado.Add(auxPersona);
                }

                return listado;
            }
            catch(Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
    }
}
