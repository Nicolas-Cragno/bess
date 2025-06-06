using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Fletero : Persona
    {
        public string DominioTractor {  get; set; }
        public string MarcaTractor { get; set; }
        public int ModeloTractor { get; set; }
        public string DetalleTractor {  get; set; }
        public string DominioFurgon { get; set; }
        public string MarcaFurgon { get; set; }
        public string DetalleFurgon { get; set; }
    }
}
