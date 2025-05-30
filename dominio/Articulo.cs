using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public long CodigoProveedor { get; set; }
        public string Nombre { get; set; }
        public string Detalle {  get; set; }
        public string Marca { get; set; }
        public double Stock { get; set; }
        public string Unidad { get; set; }
        public double Cantidad { get; set; }
    }
}
