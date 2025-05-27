using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Vehiculo
    {
        public string Dominio {  get; set; }
        public string Empresa {  get; set; }
        public string Marca { get; set; }
        public int Modelo {  set; get; }
        public string Detalle {  set; get; }
        public bool OkDocumentacion { set; get; }
        public bool Activo {  set; get; }
    }
}
