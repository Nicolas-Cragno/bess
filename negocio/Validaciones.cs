using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class Validaciones
    {
        public string cbxString(string txt)
        {
            string tValido;

            if (string.IsNullOrWhiteSpace(txt))
            {
                tValido = "SIN ASIGNAR";
            } else
            {
                tValido = txt;
            }
            
            return tValido;
        }

        public int cbxInt(string nro) // Recibe el numero como String
        {
            int nValido;

            if(!int.TryParse(nro.ToString(), out nValido))
            {
                nValido = 0;
            }
            else
            {
                nValido = int.Parse(nro);
            }

            return nValido;
        }

    }
}
