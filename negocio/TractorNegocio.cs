using System;
using System.Collections.Generic;
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
            AccesoDatos datos  = new AccesoDatos();
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
    }
}
