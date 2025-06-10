using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ChoferNegocio
    {
        public List<Chofer> listar(int activo, int puesto) // por parametro si esta activo y si es larga dist o movs
        { 
            List<Chofer> listaChoferes = new List<Chofer>();
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
                    Chofer chofer = new Chofer();
                    chofer.Dni = (int)datos.Lector["dni"];
                    chofer.Puesto = datos.buscarPuesto((int)datos.Lector["idPuesto"]);
                    chofer.Detalle = (string)datos.Lector["detalle"];
                    chofer.Apellido = (string)datos.Lector["apellido"];
                    chofer.Nombres = (string)datos.Lector["nombres"];
                    chofer.Empresa = datos.buscarEmpresa((long)datos.Lector["empresa"]);
                    chofer.EmpresaAbreviada = datos.buscarEmpresaAbreviada((long)datos.Lector["empresa"]);
                    chofer.Tractor = datos.buscarTractorAsignado(chofer.Dni);
                    chofer.Viajes = 0 ;
                    chofer.Promedio = 0 ;
                    chofer.Diferencias = 0 ;

                   listaChoferes.Add(chofer);
                }
                return listaChoferes.OrderBy(a => a.Apellido == "SIN ASIGNAR").ThenBy(a => a.Apellido).ThenBy(a => a.Nombres).ToList(); // listsa ordenada alfabeticamente
            }
            catch(Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public List<Chofer> listarInactivos() {
            List<Chofer> choferes = new List<Chofer>();

            return choferes;
        }
        public List<string> listarNombres(int activo, int puesto) 
        {
            List<Chofer> choferes = new List<Chofer>();
            choferes = listar(activo, puesto);
            List<string> nombres = choferes.Select(ch => ch.Apellido + ", " + ch.Nombres).ToList();

            return nombres;
        }
        public void agregar() { }
        public void modificar() { }
    }
}
