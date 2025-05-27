using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MovimientoNegocio
    {
        public List<Movimiento> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Movimiento> listaMovimientos = new List<Movimiento>();

            string campos = "SELECT idMovimiento, idTipoMovimiento, dni, intTractor, intFurgon, fecha, detalle, corte, panico, reporte, desenganche, cabina, antivandalico, furgon, llave";
            string database = " FROM " + AccesoDatos.Tablas.Movimientos + ";";
            string query = campos + database;

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Movimiento auxMovimiento = new Movimiento();

                    auxMovimiento.Id = (long)datos.Lector["idMovimiento"];
                    auxMovimiento.Tipo = datos.buscarTipoEvento((int)datos.Lector["idTipoMovimiento"]);
                    auxMovimiento.Persona = datos.buscarPersona((int)datos.Lector["dni"]);
                    auxMovimiento.Tractor = (int)datos.Lector["intTractor"];
                    auxMovimiento.Furgon = (int)datos.Lector["intFurgon"];
                    auxMovimiento.Fecha = (DateTime)datos.Lector["fecha"];
                    auxMovimiento.Detalle = (string)datos.Lector["detalle"];
                    auxMovimiento.Panico = (bool)datos.Lector["panico"];
                    auxMovimiento.Corte = (bool)datos.Lector["corte"];
                    auxMovimiento.Reporte = (bool)datos.Lector["reporte"];
                    auxMovimiento.Desenganche = (bool)datos.Lector["desenganche"];
                    auxMovimiento.Cabina = (bool)datos.Lector["cabina"];
                    auxMovimiento.Antivandalico = (bool)datos.Lector["antivandalico"];
                    auxMovimiento.Efurgon = (bool)datos.Lector["furgon"];
                    auxMovimiento.Llave = (bool)datos.Lector["llave"];

                    listaMovimientos.Add(auxMovimiento);
                }

                return listaMovimientos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void agregar(Movimiento movimiento) {}
        public void modificar(Movimiento movimiento) {}

        public List<string> listarTipos()
        {
            List<Movimiento> movimientos = listar();
            List<string> tipos = movimientos.Select(f => f.Tipo).ToList();
            return tipos;
        }
    }
}
