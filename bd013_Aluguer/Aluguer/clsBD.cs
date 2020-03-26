using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Aluguer
{
    public class clsBD
    {
        OleDbConnection conexion;

         public clsBD(string nomeBD)
        {
            string cadenaConexion=string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}'", nomeBD);
            conexion = new OleDbConnection(cadenaConexion);
        }
        
        public void abrirBD()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                    System.Windows.Forms.MessageBox.Show("bd abierta");
                }
            }
            catch (OleDbException erroBD)
            {
                System.Windows.Forms.MessageBox.Show(erroBD.Message, "error intentando abrir B.D.");                
            }
        }

        public void cerrarBD()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                    System.Windows.Forms.MessageBox.Show("bd cerrada");
                }
            }
            catch (OleDbException erroBD)
            {
                System.Windows.Forms.MessageBox.Show(erroBD.Message, "error intentando pechar B.D.");
            }
        }

        public void operacionsNonSelect(string cadenaSQL)
        {
            try
            {
                OleDbCommand comando = new OleDbCommand(cadenaSQL, conexion);
                comando.ExecuteNonQuery();
            }
            catch (OleDbException erroBD)
            {
                System.Windows.Forms.MessageBox.Show(erroBD.Message, "error intentando operacion nonSelect B.D.");
            }
        }

        public System.Data.DataSet operacionsSelect(string cadenaSQL)
        {
            System.Data.DataSet DS = new System.Data.DataSet();

            try
            {
                OleDbDataAdapter DA = new OleDbDataAdapter(cadenaSQL, conexion);
                DA.Fill(DS);
            }
            catch (OleDbException erroBD)
            {
                System.Windows.Forms.MessageBox.Show(erroBD.Message, "error intentando operacion Select B.D.");
            }

            return DS;
        }
        public int operacionsScalar(string cadenaSQL)
        {
            int resultado=0;
            try
            {
                OleDbCommand comando = new OleDbCommand(cadenaSQL, conexion);
                resultado = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (OleDbException erroBD)
            {
                System.Windows.Forms.MessageBox.Show(erroBD.Message, "error intentando operacion scalar B.D.");
            }
            return resultado;
        }
    }
}
