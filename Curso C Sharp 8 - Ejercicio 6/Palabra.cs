using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_8___Ejercicio_6
{
    public class Palabra
    {
        public Palabra() { }

        public string dimeVocales(string cadena)
        {
            string resultado = string.Empty;

            if (cadena.Contains('a'))
                resultado += " a ";
            if (cadena.Contains('e'))
                resultado += " e ";
            if (cadena.Contains('i'))
                resultado += " i ";
            if (cadena.Contains('o'))
                resultado += " o ";
            if (cadena.Contains('u'))
                resultado += " u ";

            return resultado;
        }

        public Boolean palabrasPalindromo(string cadena)
        {
            Boolean esPalindromo = false;
            string primeraMitad = cadena.Substring(0, cadena.Length / 2);

            char[] arr = cadena.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);

            string segundaMitad = temp.Substring(0, temp.Length / 2);

            if (primeraMitad.Equals(segundaMitad))
                esPalindromo = true;

            return esPalindromo;
        }
    }
}
