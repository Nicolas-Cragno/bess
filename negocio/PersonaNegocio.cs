using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public List<string> listarNombres(int estado)
        {
            List<Persona> personas = new List<Persona>();
            personas = listar(estado);
            List<string> nombres = personas.Select(p => p.Apellido + ", " + p.Nombres).OrderBy(nombre => nombre).ToList();

            return nombres;
        }

        public void agregar(Persona nvPersona)
        {
            AccesoDatos datos = new AccesoDatos();
            long idEmpresa = datos.buscarCuitEmpresa(nvPersona.Empresa);
            int idPuesto = datos.buscarIdPuesto(nvPersona.Puesto);
            string database = "INSERT INTO " + AccesoDatos.Tablas.Personas + "(dni, idPuesto, detalle, apellido, nombres, empresa)";
            string values = "VALUES (" + nvPersona.Dni + ", " + idPuesto + ", '" + nvPersona.Detalle.ToUpper() + "', '" + nvPersona.Apellido.ToUpper() + "', '" + nvPersona.Nombres.ToUpper() + "', " + idEmpresa + ");";
            string query = database + values;

            try 
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();
            }
            catch(Exception ex) 
            {
                throw;
            }
            finally {
                datos.cerrarConexion(); 
            }
        }
    }
}
