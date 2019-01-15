using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace identifejforms
{
    class Matriz
    {
        string[,] mat;
        public Matriz(int fila, int columna)
        {
             mat= new string[fila, columna];
        }
        private void guardarenMatriz( int f, int c, string campo)
        {
            mat[f,c]= campo;            
            

        }
    }
}
