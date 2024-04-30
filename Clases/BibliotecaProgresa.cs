using crud.clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_Final_BBDD_23_24.Clases
{
    internal class BibliotecaProgresa
    {
        public void mostrarLibros(DataGridView tablaLibros)
        {
            try 
            {
                CConexion objetoConexion = new CConexion();
                string query = "select * from libro;";
                tablaLibros.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.EstablecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaLibros.DataSource = dt;
                objetoConexion.CerrarConexion();

            }
            catch (Exception e) 
            {
                MessageBox.Show("No se pudierón mostrar los datos consulta al administrador de la base de datos" + e.ToString());

            }
        }
        
 public void altaUsuario(TextBox txtAltaNombre, TextBox txtAltaApellido, TextBox txtAltaTelefono, 
    TextBox txtAltaEmail, TextBox txtAltaDireccion, TextBox txtAltaDni){
    try
            {
                CConexion objetoConexion = new CConexion();

                usuarioExiste(txtAltaDni, objetoConexion);

               
                string query = "insert into usuario(nombre,apellido,telefono,email,direccion,dni) " + "values('" + txtAltaNombre.Text +
                    "','" + txtAltaApellido.Text + "','" + txtAltaTelefono.Text + "','" + txtAltaEmail.Text + "','" + txtAltaDireccion.Text + "','" + txtAltaDni.Text + "');";

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Los registros se guardaron de forma correcta");

                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
    {
        MessageBox.Show("No se pudieron mostrar los datos, consulta al administrador de la base de datos" + ex.ToString());
    }
}

        private static void usuarioExiste(TextBox txtAltaDni, CConexion objetoConexion)
        {
            try {

                CConexion objeConexion = new CConexion();
                
                string queryCheck = "SELECT COUNT(*) FROM usuario WHERE dni ='" + txtAltaDni.Text + "';";
                MySqlCommand myCommandCheck = new MySqlCommand(queryCheck, objeConexion.EstablecerConexion());
                int count = Convert.ToInt32(myCommandCheck.ExecuteScalar());

                if (count > 0)
                {
                   
                    MessageBox.Show("Ya existe un usuario con el DNI proporcionado.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los datos, consulta al administrador de la base de datos" + ex.ToString());
            }

        }

        public void consultarUsuario(TextBox txtConsultaDni, TextBox txtConsultaId, 
            TextBox txtConsultaNombre, TextBox txtConsultaApellido, TextBox txtConsultaTelefono, 
            TextBox txtConsultaEmail, TextBox txtConsultaDireccion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "select * from usuario where dni ='" + txtConsultaDni.Text + "';";

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.Read())
                {
                    txtConsultaId.Text = reader["id_usuario"].ToString();
                    txtConsultaNombre.Text = reader["nombre"].ToString();
                    txtConsultaApellido.Text = reader["apellido"].ToString();
                    txtConsultaTelefono.Text = reader["telefono"].ToString();
                    txtConsultaEmail.Text = reader["email"].ToString();
                    txtConsultaDireccion.Text = reader["direccion"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró un usuario con el DNI proporcionado.");
                }

                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los datos, consulta al administrador de la base de datos" + ex.ToString());
            }
        }

        public void eliminarUsuario(TextBox txtConsultaDni, TextBox txtConsultaId, TextBox txtConsultaNombre, TextBox txtConsultaApellido, TextBox txtConsultaTelefono, TextBox txtConsultaEmail, TextBox txtConsultaDireccion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "DELETE FROM usuario WHERE dni ='" + txtConsultaDni.Text + "';";
                

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                int rowsAffected = myCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("El usuario ha sido eliminado correctamente.");

                    txtConsultaDni.Text = "";
                    txtConsultaId.Text = "";
                    txtConsultaNombre.Text = "";
                    txtConsultaApellido.Text = "";
                    txtConsultaTelefono.Text = "";
                    txtConsultaEmail.Text = "";
                    txtConsultaDireccion.Text = "";
                }
                else
                {
                    MessageBox.Show("No se encontró un usuario con el DNI proporcionado.");
                }

                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el usuario, consulta al administrador de la base de datos" + ex.ToString());
            }
        }

        public void consultarLibro(TextBox txtLibroId, TextBox txtLibroTitulo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "select titulo from libro where id_libro ='" + txtLibroId.Text + "';";

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.Read())
                {
                   
                    txtLibroTitulo.Text = reader["titulo"].ToString();
                  
                }
                else
                {
                    MessageBox.Show("No se encontró un libro con el id proporcionado.");
                }

                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los datos, consulta al administrador de la base de datos" + ex.ToString());
            }
        }

        public void alquilar(TextBox txtAlquilerIdLibro, TextBox txtAlquilerIdUsuario, ComboBox cbAlquilerTrabajador)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "insert into alquiler(fecha_alquiler,fecha_devolucion,trabajador_id_trabajador,usuario_id_usuario,libro_id_libro)  values( curdate(), date_add(curdate(), interval 15 day)," 
                    + cbAlquilerTrabajador.Text + "," + txtAlquilerIdUsuario.Text + "," + txtAlquilerIdLibro.Text + ");";

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Alquiler generado con éxito!!");

                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los datos, consulta al administrador de la base de datos" + ex.ToString());
            }
        }

        public void mostrarAlquiler(DataGridView tablaAlquiler)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                string query = "select * from alquiler;";
                tablaAlquiler.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.EstablecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlquiler.DataSource = dt;
                objetoConexion.CerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudierón mostrar los datos consulta al administrador de la base de datos" + e.ToString());

            }

        }

        public void mostrarUsuarios(DataGridView tablaAlquiler)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                string query = "select * from usuario;";
                tablaAlquiler.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.EstablecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlquiler.DataSource = dt;
                objetoConexion.CerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudierón mostrar los datos consulta al administrador de la base de datos" + e.ToString());

            }

        }


    }
}


