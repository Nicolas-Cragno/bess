using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Mecanico : Persona
    {
        public string Sede { get; set; }
        public string Vehiculo { get; set; }
        public int Arreglos { get; set; }
    }
}
