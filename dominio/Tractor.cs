using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Tractor : Vehiculo
    {
        public int Interno { get; set; }
        public string Color { get; set; }
        public bool OkTaller { get; set; }
    }
}
