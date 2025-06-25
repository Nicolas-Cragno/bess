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
        public DateTime dtpFecha(DateTime fecha, TimeSpan hora)
        {
            DateTime fechaHora;

            fechaHora = fecha.Add(hora);

            return fechaHora;
        }
        public bool validarCampos(int cant, int validos)
        {
            if(cant == validos)
            {
                return true;
            } else {
                return false;
            }
        }
        public string validarTexto(string texto)
        {
            string txt;

            if(texto == "" || texto is null)
            {
                txt = "";
            } else
            {
                txt = texto;
            }

            return txt;
        }
        public int validarInt(string numero)
        {
            int nro;

            if (string.IsNullOrWhiteSpace(numero))
            {
                nro = 0;
            } else if(!int.TryParse(numero, out nro)) // verifico que no hayan ingresado letras
            {
                nro = int.Parse(numero);
            }

            if (nro < 0)
                nro = 0;

            return nro;
        }

        public float validarFloat(string numero)
        {
            float nro;

            if (string.IsNullOrWhiteSpace(numero))
            {
                nro = 0;
            }
            else if (!float.TryParse(numero, out nro)) // verifico que no hayan ingresado letras
            {
                nro = float.Parse(numero);
            }

            if (nro < 0)
                nro = 0;

            return nro;
        }
    }
}
