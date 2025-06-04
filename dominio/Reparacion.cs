using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Reparacion : Evento
    {
        public string Mecanico {  get; set; }
        public string TipoVehiculo { get; set; }
        public int InternoAfectado { get; set; }
        public DateTime? FechaFin {  get; set; } // puede ser NULL
        public bool Estado {  get; set; }
    }
}
