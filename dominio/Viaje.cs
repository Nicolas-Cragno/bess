using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Viaje : Evento
    {
        public string Cliente { get; set; }
        public double GasoilReal { get; set; }
        public double GasoilSat {  get; set; }
        public double Kilometraje { get; set; }
        public double Promedio { get; set; }
        public double Diferencia {  get; set; }
    }
}
