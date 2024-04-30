using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud.clases
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "mydb";
        static string usuario = "root";
        static string password = "Eduardo1+";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection EstablecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
               // MessageBox.Show("La conexión es correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noooooooo!!" + ex.ToString());
            }
            return conex;

        }
        public void CerrarConexion()
        {
            conex.Close();
        }
    }
}