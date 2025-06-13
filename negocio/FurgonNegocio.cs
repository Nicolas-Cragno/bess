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
        public void agregar (Furgon furgon) 
        {
            AccesoDatos datos = new AccesoDatos();
            long cuitEmpresa = datos.buscarCuitEmpresa(furgon.Empresa);
            string database = "INSERT INTO " + AccesoDatos.Tablas.Furgones;
            string campos = "(intFurgon, cuitEmpresa, dominio)";
            string valores = " VALUES (" + furgon.Interno + ", " + cuitEmpresa + ", '" + furgon.Dominio.ToUpper() + "');";
            string query = database + campos + valores;

            try 
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
        public void modificar (Furgon furgon) 
        {
            AccesoDatos datos = new AccesoDatos ();
            long cuitEmpresa = datos.buscarCuitEmpresa(furgon.Empresa);
            string database = "UPDATE " + AccesoDatos.Tablas.Furgones;
            string valores = " SET cuitEmpresa=" + cuitEmpresa + ", dominio='" + furgon.Dominio.ToUpper() + "', detalle='" + furgon.Detalle.ToUpper() + "'";
            string condicion = " WHERE intFurgon=" + furgon.Interno + ";";
            string query = database + valores + condicion;

            try 
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
        public void cambiarEstado(int interno, bool estado)
        {
            AccesoDatos datos = new AccesoDatos();
            int intEstado;
            if (estado)
            {
                intEstado = 0;
            } else
            {
                intEstado = 1;
            }
                string query = "UPDATE " + AccesoDatos.Tablas.Furgones + " SET activo=" + intEstado + " WHERE intFurgon=" + interno + ";";
            try
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
    }
}
