using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class UsoStock
    {
        public long Id { get; set; }
        public string Articulo { get; set; }
        public long Reparacion { get; set; }
        public double Cantidad { get; set; }
        public string Unidad {  get; set; }
    }
}
