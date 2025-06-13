using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class TractorNegocio
    {
        public List<Tractor> listar(int activo)
        {
            List<Tractor> listaTractores = new List<Tractor>();

            // Consultas a tabla de tractores
            AccesoDatos datos = new AccesoDatos();
            string campos = "SELECT intTractor, empresa, dominio, marca, modelo, detalle, okTaller, okDocumentacion, activo";
            string database = " FROM " + AccesoDatos.Tablas.Tractores + " WHERE activo=" + activo + ";";
            string query = campos + database;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Tractor auxTractor = new Tractor();

                    auxTractor.Interno = (int)datos.Lector["intTractor"];
                    auxTractor.Empresa = datos.buscarEmpresa((long)datos.Lector["empresa"]);
                    auxTractor.Dominio = (string)datos.Lector["dominio"];
                    auxTractor.Marca = (string)datos.Lector["marca"];
                    auxTractor.Modelo = (int)datos.Lector["modelo"];
                    auxTractor.Detalle = (string)datos.Lector["detalle"];
                    auxTractor.OkTaller = (bool)datos.Lector["okTaller"];
                    auxTractor.OkDocumentacion = (bool)datos.Lector["okDocumentacion"];
                    auxTractor.Activo = (bool)datos.Lector["activo"];

                    listaTractores.Add(auxTractor);
                }

                return listaTractores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }
        }
        public List<int> listarInternos(int activo)
        {
            List<Tractor> tractores = new List<Tractor>();
            tractores = listar(activo);
            List<int> internos = tractores.Select(tr => tr.Interno).ToList();

            return internos;
        }
        public void agregar(Tractor tractor)
        {
            AccesoDatos datos = new AccesoDatos();
            long cuitEmpresa = datos.buscarCuitEmpresa(tractor.Empresa);
            string database = "INSERT INTO " + AccesoDatos.Tablas.Tractores;
            string campos = " (intTractor, empresa, dominio, marca, modelo, detalle, activo)";
            string valores = " VALUES (" + tractor.Interno + ", " + cuitEmpresa + ", '" + tractor.Dominio.ToUpper() + "', '" + tractor.Marca.ToUpper() + "', " + tractor.Modelo + ", '" + tractor.Detalle.ToUpper() + "', 1);";
            string query = database + campos + valores;

            try 
            {
                datos.setearConsulta(query);
                datos.ejecutarAccion();
            }
            catch (Exception) 
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }
        public void modificar(Tractor tractor)
        {
            AccesoDatos datos = new AccesoDatos();
            long cuitEmpresa = datos.buscarCuitEmpresa(tractor.Empresa);
            int okTaller = datos.numerarBool(tractor.OkTaller);
            int okDocu = datos.numerarBool(tractor.OkDocumentacion);
            string database = "UPDATE " + AccesoDatos.Tablas.Tractores;
            string campos = " SET empresa=" + cuitEmpresa + ", dominio='" + tractor.Dominio.ToUpper() + "', marca='" + tractor.Marca.ToUpper() + "', modelo=" + tractor.Modelo + ", detalle='" + tractor.Detalle.ToUpper() + "', okTaller=" + okTaller + ", okDocumentacion=" + okDocu;
            string condicion = " WHERE intTractor=" + tractor.Interno + ";";
            string query = database + campos + condicion;

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
            }
            else
            {
                intEstado = 1;
            }
            string query = "UPDATE " + AccesoDatos.Tablas.Tractores + " SET activo=" + intEstado + " WHERE intTractor=" + interno + ";";
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
