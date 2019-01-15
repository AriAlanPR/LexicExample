using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identifejforms
{
    class elementos
    {
        public static string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public static string[] digitos = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public static string guion = "_";

        public static bool VerificarLetra(string car)
        {
            bool res = false;
            for (int l = 0; l < letras.Length; l++)
            {
                if (letras[l] == car)
                { res = true; }
            }
            return res;
        }

        public static bool VerificarDigito(string car)
        {
            bool res = false;
            for (int d = 0; d < digitos.Length; d++)
            {
                if (digitos[d] == car)
                { res = true; }
            }
            return res;
        }

        public static bool Verificarguion(string car)
        {
            if (car == "_")
                return true;
            else
                return false;
        }

        
    }
}
