using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Chofer : Persona
    {
        public int Tractor {  get; set; }
        public int Viajes {  get; set; }
        public float Promedio { get; set; }
        public float Diferencias { get; set; }
    }
}
