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
        

          string[,] M = {
                         {"1","2", "Error","Error","Error"," "},
                         {"2","2", "2","2","3"," "},
                         {"3","Error", "Error","Error","Acepta", "Identificador"}
                        };

        private void identif_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                dgvmatrizt.Rows.Add(M[i,0],M[i, 1], M[i,2], M[i,3], M[i,4], M[i,5]);
            }
            
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
                bool errsintax=false;
                int longitud = cadena.Length;
                char[] caracteres = cadena.ToCharArray();
                int estado = 0, apc= 4;
                Colorini(dgvmatrizt, 0, 0, Color.Gainsboro);

                if (cadena == "")
                    errsintax = true;

                foreach (char c in caracteres)
                {
                    //inicia en estado 1
                    //if (errsintax == false)
                    //{
                        //devuelve 0 si es una letra, 1 si es digito, 2 si es un guión bajo
                        apc = elementos.EvaluarCaracter(c.ToString());
                        Restaurarcolor();

                        if (apc == 1)
                        {

                            if (estado == 0)
                            {
                                Colorini(dgvmatrizt, estado, apc, Color.Yellow);
                                MessageBox.Show(elementos.ReporteEstado(estado+1, c));
                                estado++;

                            }
                            else
                            {
                                Colorini(dgvmatrizt, estado, apc, Color.Yellow);
                                MessageBox.Show(elementos.ReporteEstado(estado+1, c));
                            }
                        }
                        else
                        {
                            if (estado == 1)
                            {
                                if (apc == -1)
                                {
                                    errsintax = true;
                                    MessageBox.Show("Error en caracter " + c);
                                }
                                else
                                {
                                    Colorini(dgvmatrizt, estado, apc, Color.Yellow);
                                    MessageBox.Show(elementos.ReporteEstado(estado + 1, c));
                                }
                            }
                            else
                            {
                                errsintax = true;
                                MessageBox.Show("Error en caracter " + c);
                            }  
                        }
                    //}
                    //else
                    //{
                    //    continue;
                    //}

                }
                //entra al estado 3 si no hay un errror de sintaxis

                if (errsintax)
                {
                    MessageBox.Show("identificador rechazado e.e , caracter erroneo o mal posicionado");
                    if(apc!=-1)
                    Colorini(dgvmatrizt, estado, apc, Color.Lime);                    
                }
                else
                {
                    Restaurarcolor();
                    apc = 4;
                    Colorini(dgvmatrizt, estado, apc, Color.Yellow);
                    MessageBox.Show("Recibimos fin de cadena en el estado " + (estado + 1));
                    estado++;
                    Restaurarcolor();
                    Colorini(dgvmatrizt, estado, apc, Color.Yellow);
                    Colorini(dgvmatrizt, estado, apc + 1, Color.Yellow);
                    MessageBox.Show("identificador: " + cadena + " aceptado");

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
