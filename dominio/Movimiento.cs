using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Movimiento : Evento
    {
        public string Registro { get; set; }
        public bool Panico { get; set; }
        public bool Corte { get; set; }
        public bool Reporte {  get; set; }
        public bool Desenganche { get; set; }
        public bool Cabina { get; set; }
        public bool Antivandalico {  get; set; }
        public bool Efurgon {  get; set; }
        public bool Llave {  get; set; }
    }
}
