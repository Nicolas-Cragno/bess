using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Evento
    {
        public long Id {  get; set; }
        public string Tipo { get; set; }
        public int DniPersona { get; set; }
        public string Persona { get; set; }
        public int Tractor { get; set; }
        public int Furgon { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
       
    }
}
