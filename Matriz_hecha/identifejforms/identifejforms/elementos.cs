using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identifejforms
{
    class elementos
    {
        //public static string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        //public static string[] digitos = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        //public static string guion = "_";

        public static int EvaluarCaracter(string car)
        {
            if(Verificarguion(car))
            {
                return 3;
            }
            else
            {
                if(VerificarDigito(car))
                {
                return 2;
                }
                else
                if(VerificarLetra(car))
                {  
                return 1;
                }
                else
                    return -1;
            }
        }

        public static bool VerificarLetra(string car)
        {
            
            int ascii = Encoding.ASCII.GetBytes(car)[0];
            if ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <= 122))
                return true;
            else
                return false;
        }

        public static bool VerificarDigito(string car)
        {
            int ascii = Encoding.ASCII.GetBytes(car)[0];
            if ((ascii >= 48 && ascii <= 57))
                return true;
            else
                return false;
        }

        public static bool Verificarguion(string car)
        {
            if (car == "_")
                return true;
            else
                return false;
        }

        public static string ReporteEstado(int estado, char car)
        {
            
         return "Recibimos \"" + car + "\" en el estado " + estado;                
            
        }
        
        
    }
}
