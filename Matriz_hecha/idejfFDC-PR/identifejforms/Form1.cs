using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace identifejforms
{
    public partial class identif : Form
    {
        public identif()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataGridView aux;
        private void identif_Load(object sender, EventArgs e)
        {
            dgvmatrizt.Rows.Add("1", "2", "Error", "Error", "Error", " ");
            dgvmatrizt.Rows.Add("2", "2", "2", "2", "3", "");
            dgvmatrizt.Rows.Add("3", "Error", "Error","Error","Acepta", "Identificador");
            aux = dgvmatrizt;
                
            //si es letra, digito o guion bajo pasa al estado 2
            //si es fin de cadena pasa al estado de aceptacion (3)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncapturar_Click(object sender, EventArgs e)
        {
            //inicia el programa
            try
            {
                Restaurarcolor();
                string cadena = txtcadena.Text;
                int iterador = 0;
                bool fincadena = false, estado2=false, errsintax=false;

                //se evalua la longitud de la cadena
                int largo = cadena.Length;

                //entramos al estado 1, hacemos las verificaciones correspondientes
                //Colorini(dgvmatrizt, 0, 0, Color.Gainsboro);
                //si el primer caracter es letra pasa al estado 2
                string caracter = cadena.Substring(iterador, 1);
                //verificamos que el primer carácter sea letra
                if (elementos.VerificarLetra(caracter))
                {
                    MessageBox.Show("Recibimos letra: \"" + caracter + "\"  en el ESTADO 1");
                   Colorini(dgvmatrizt, 0, 1, Color.Yellow); 
                    //revisamos si es fin de cadena
                    if (largo == 1)
                    {
                        MessageBox.Show("Pasamos al ESTADO 2");                        
                        //si el primer caracter es letra pasa al estado 2
                        MessageBox.Show("Recibimos Fin de cadena, pasamos al ESTADO 3 de aceptacion");                        
                        Colorini(dgvmatrizt, 1, 4, Color.Yellow);
                        MessageBox.Show("Aceptamos el identificador: " + cadena + " como valido");
                        Colorini(dgvmatrizt, 2, 4, Color.Yellow);
                        Colorini(dgvmatrizt, 2, 5, Color.Yellow);
                        

                    }
                    else
                    {
                        MessageBox.Show("Pasamos al ESTADO 2");
                        Colorini(dgvmatrizt, 0, 1, Color.Yellow);
                        estado2 = true;
                        iterador++;
                        caracter = cadena.Substring(iterador, 1);
                    }
                }//capturamos posibles errores
                else
                {
                    MessageBox.Show("Error de síntaxis para el identificador en el CARACTER no. 1 dentro del ESTADO 1");
                    errsintax = true;
                    if(elementos.VerificarDigito(caracter))
                    {
                        Colorini(dgvmatrizt, 0, 2, Color.Lime);
                        MessageBox.Show("Error por digito");
                    }
                    else
                        if (elementos.Verificarguion(caracter))
                        {
                            Colorini(dgvmatrizt, 0, 3, Color.Lime);
                            MessageBox.Show("Error por guión bajo");
                        }
                        else
                        {
                            MessageBox.Show("Error por carácter incorrecto: \""+caracter+"\"");
                        }
                }

                
                //entramos al estado 2, verificamos sus especificaciones correspondientes
                if (estado2)
                {
                    do
                    {                    
                        //evitamos problemas de desbordamiento
                        caracter = cadena.Substring(iterador, 1);
                        
                        
                        //revisamos si el caracter es una letra 
                        if (elementos.VerificarLetra(caracter))
                        {
                            MessageBox.Show("Recibimos letra: \"" + caracter + "\" en el ESTADO 2");
                            Colorini(dgvmatrizt, 1, 1, Color.Yellow);
                            //verificamos si ya llegamos a fin de cadena
                            if (errsintax==false)
                            {
                                MessageBox.Show("Regresamos al ESTADO 2");

                            }
                        }
                        else
                        {
                            //revisamos si el caracter es un digito
                            if (elementos.VerificarDigito(caracter))
                            {
                                MessageBox.Show("Recibimos digito: \"" + caracter + "\" en el ESTADO 2");
                                Colorini(dgvmatrizt, 1, 2, Color.Yellow);
                                 //verificamos si estamos en fin de cadena                               
                                if (errsintax==false)
                                {
                                    MessageBox.Show("Regresamos al ESTADO 2");
                                }
                            }
                            else
                            {
                                //revisamos si el caracter es un guión bajo
                                if (elementos.Verificarguion(caracter))
                                {
                                    MessageBox.Show("Recibimos guión bajo: \"" + caracter + "\" en el ESTADO 2");
                                    Colorini(dgvmatrizt, 1, 3, Color.Yellow);
                                    //revisamos si estamos en fin de cadena
                                    if (errsintax==false)
                                    {
                                        MessageBox.Show("Regresamos al ESTADO 2");
                                    }
                                }
                                else
                                {
                                    //capturamos posibles errores
                                    MessageBox.Show("Error de síntaxis para el identificador en el CARACTER no. "+ (iterador + 1) + " dentro del ESTADO 2");
                                    errsintax = true;
                                    MessageBox.Show("Error por carácter incorrecto: \"" + caracter + "\"");
                                }
                            }
                        }
                        if (iterador == largo - 1 && errsintax==false)
                        {
                            fincadena = true;
                            MessageBox.Show("Recibimos Fin de cadena, pasamos al ESTADO 3 de aceptacion");
                            
                            Colorini(dgvmatrizt, 1, 4, Color.Yellow);
                            MessageBox.Show("Aceptamos el identificador: " + cadena + " como valido");
                            Colorini(dgvmatrizt, 2, 4, Color.Yellow);
                            Colorini(dgvmatrizt, 2, 5, Color.Yellow);
                            
                        }
                        //posicionamos el indice del iterador al siguiente digito
                        iterador++;
                        //verificamos si es el ultimo caracter, osea, si es final de cadena
                        
                    }
                    while (fincadena==false && errsintax==false);
                }

                
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No dejar espacios vacios e.e");               
                
            }
        }

        private void Colorini(DataGridView tabla, int estado,int columna, Color c)
        {
            tabla.Rows[estado].Cells[columna].Style.BackColor = c;
           
        }

        private void Restaurarcolor()
        {
            dgvmatrizt = new DataGridView();
            dgvmatrizt= aux;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    Colorini(dgvmatrizt, x, y, Color.White);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurarcolor();
        }

       
    }
}
