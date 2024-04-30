using Proyecto_Final_BBDD_23_24.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_BBDD_23_24
{
    public partial class Form1 : Form
    {
        public Form1()                  
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.LightBlue;

        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            BibliotecaProgresa biblioteca = new BibliotecaProgresa();
            biblioteca.altaUsuario(txtAltaNombre, txtAltaApellido, txtAltaTelefono, txtAltaEmail, txtAltaDireccion, txtAltaDni);
        }

        private void btnConsultaUsuario_Click(object sender, EventArgs e)
        {
            BibliotecaProgresa biblioteca = new BibliotecaProgresa();
            biblioteca.consultarUsuario(txtConsultaDni, txtConsultaId, txtConsultaNombre, txtConsultaApellido, txtConsultaTelefono, txtConsultaEmail, txtConsultaDireccion);

        }

        private void btnMostrarLibros_Click(object sender, EventArgs e)
        {
            BibliotecaProgresa biblioteca = new BibliotecaProgresa();
            biblioteca.mostrarLibros(dataGridView1);
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            BibliotecaProgresa biblioteca = new BibliotecaProgresa();
            biblioteca.eliminarUsuario(txtConsultaDni, txtConsultaId, txtConsultaNombre, txtConsultaApellido, txtConsultaTelefono, txtConsultaEmail, txtConsultaDireccion);
        }

        private void btnConsultaLibros_Click(object sender, EventArgs e)
        {
            BibliotecaProgresa biblioteca = new BibliotecaProgresa();
            biblioteca.consultarLibro(txtLibroId, txtLibroTitulo);
        }

        private void btnGenerarAlquiler_Click(object sender, EventArgs e)
        {
            BibliotecaProgresa biblioteca = new BibliotecaProgresa();
            biblioteca.alquilar(txtAlquilerIdLibro, txtAlquilerIdUsuario, cbAlquilerTrabajador);
        }

        private void btnMostrarAlquiler_Click(object sender, EventArgs e)
        {
            BibliotecaProgresa biblioteca = new BibliotecaProgresa();
            biblioteca.mostrarAlquiler(dataGridView1);
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            BibliotecaProgresa biblioteca = new BibliotecaProgresa();
            biblioteca.mostrarUsuarios(dataGridView1);
        }
    }
}


