using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace identifejforms
{
    class BaseDatos
    {
        string CC;
        OleDbConnection cn;
        //result set
        OleDbDataAdapter Adaptador;
        //preparedstatement
        OleDbCommandBuilder Constructor;
        DataTable Tabla;
        BindingSource Fuente;
        public BaseDatos(string s)
        {
            CC = @"Provider=Microsoft.ACE.OLEDB.12.0;" + s;
            cn = new OleDbConnection(CC);
        }

        public BindingSource Source
        {
            get { return Fuente; }
        }

        public void CrearConexion()
        {
            cn.Open();

        }

        public bool Compcon()
        {
            if (cn == null)
                return false;
            else
                return true;
        }


        public void CerrarConexion()
        {
            cn.Close();
        }        
        
        public void Listar()
        {

            string Consulta = "SELECT * FROM matriz";
            Adaptador = new OleDbDataAdapter(Consulta, cn);
            Constructor = new OleDbCommandBuilder(Adaptador);
            Tabla = new DataTable("MatrizTrans");
            Adaptador.Fill(Tabla);
            Fuente = new BindingSource();
            Fuente.DataSource = Tabla;
        }    
                

        public void forzarcierre()
        {
            if (cn == null)
            {

            }
            else
                cn.Close();
        }
    }
}
