namespace Proyecto_Final_BBDD_23_24
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultaLibros = new System.Windows.Forms.Button();
            this.txtLibroTitulo = new System.Windows.Forms.TextBox();
            this.txtLibroId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIdLibro = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAlquilerTrabajador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerarAlquiler = new System.Windows.Forms.Button();
            this.txtAlquilerIdUsuario = new System.Windows.Forms.TextBox();
            this.txtAlquilerIdLibro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.btnConsultaUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.txtConsultaDireccion = new System.Windows.Forms.TextBox();
            this.txtConsultaDni = new System.Windows.Forms.TextBox();
            this.txtConsultaEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtConsultaId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtConsultaTelefono = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtConsultaApellido = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtConsultaNombre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBoxBBDD = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxAlta = new System.Windows.Forms.GroupBox();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.txtAltaDni = new System.Windows.Forms.TextBox();
            this.txtAltaDireccion = new System.Windows.Forms.TextBox();
            this.txtAltaEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAltaTelefono = new System.Windows.Forms.TextBox();
            this.txtAltaApellido = new System.Windows.Forms.TextBox();
            this.txtAltaNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMostrarLibros = new System.Windows.Forms.Button();
            this.btnMostrarAlquiler = new System.Windows.Forms.Button();
            this.btnMostrarUsuarios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxUsuario.SuspendLayout();
            this.groupBoxBBDD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultaLibros);
            this.groupBox1.Controls.Add(this.txtLibroTitulo);
            this.groupBox1.Controls.Add(this.txtLibroId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelIdLibro);
            this.groupBox1.Location = new System.Drawing.Point(1, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Libros";
            // 
            // btnConsultaLibros
            // 
            this.btnConsultaLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaLibros.Location = new System.Drawing.Point(151, 181);
            this.btnConsultaLibros.Name = "btnConsultaLibros";
            this.btnConsultaLibros.Size = new System.Drawing.Size(168, 60);
            this.btnConsultaLibros.TabIndex = 33;
            this.btnConsultaLibros.Text = "Consultar";
            this.btnConsultaLibros.UseVisualStyleBackColor = true;
            this.btnConsultaLibros.Click += new System.EventHandler(this.btnConsultaLibros_Click);
            // 
            // txtLibroTitulo
            // 
            this.txtLibroTitulo.Location = new System.Drawing.Point(117, 54);
            this.txtLibroTitulo.Name = "txtLibroTitulo";
            this.txtLibroTitulo.ReadOnly = true;
            this.txtLibroTitulo.Size = new System.Drawing.Size(250, 22);
            this.txtLibroTitulo.TabIndex = 4;
            this.txtLibroTitulo.TabStop = false;
            // 
            // txtLibroId
            // 
            this.txtLibroId.Location = new System.Drawing.Point(117, 21);
            this.txtLibroId.Name = "txtLibroId";
            this.txtLibroId.Size = new System.Drawing.Size(250, 22);
            this.txtLibroId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // labelIdLibro
            // 
            this.labelIdLibro.AutoSize = true;
            this.labelIdLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdLibro.Location = new System.Drawing.Point(1, 21);
            this.labelIdLibro.Name = "labelIdLibro";
            this.labelIdLibro.Size = new System.Drawing.Size(72, 22);
            this.labelIdLibro.TabIndex = 0;
            this.labelIdLibro.Text = "ID Libro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAlquilerTrabajador);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnGenerarAlquiler);
            this.groupBox2.Controls.Add(this.txtAlquilerIdUsuario);
            this.groupBox2.Controls.Add(this.txtAlquilerIdLibro);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(454, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alquiler";
            // 
            // cbAlquilerTrabajador
            // 
            this.cbAlquilerTrabajador.FormattingEnabled = true;
            this.cbAlquilerTrabajador.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbAlquilerTrabajador.Location = new System.Drawing.Point(118, 86);
            this.cbAlquilerTrabajador.Name = "cbAlquilerTrabajador";
            this.cbAlquilerTrabajador.Size = new System.Drawing.Size(250, 24);
            this.cbAlquilerTrabajador.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Trabajador";
            // 
            // btnGenerarAlquiler
            // 
            this.btnGenerarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAlquiler.Location = new System.Drawing.Point(118, 181);
            this.btnGenerarAlquiler.Name = "btnGenerarAlquiler";
            this.btnGenerarAlquiler.Size = new System.Drawing.Size(168, 60);
            this.btnGenerarAlquiler.TabIndex = 34;
            this.btnGenerarAlquiler.Text = "Alquilar";
            this.btnGenerarAlquiler.UseVisualStyleBackColor = true;
            this.btnGenerarAlquiler.Click += new System.EventHandler(this.btnGenerarAlquiler_Click);
            // 
            // txtAlquilerIdUsuario
            // 
            this.txtAlquilerIdUsuario.Location = new System.Drawing.Point(118, 54);
            this.txtAlquilerIdUsuario.Name = "txtAlquilerIdUsuario";
            this.txtAlquilerIdUsuario.Size = new System.Drawing.Size(250, 22);
            this.txtAlquilerIdUsuario.TabIndex = 10;
            // 
            // txtAlquilerIdLibro
            // 
            this.txtAlquilerIdLibro.Location = new System.Drawing.Point(118, 21);
            this.txtAlquilerIdLibro.Name = "txtAlquilerIdLibro";
            this.txtAlquilerIdLibro.Size = new System.Drawing.Size(250, 22);
            this.txtAlquilerIdLibro.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Libro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Usuario";
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(this.btnConsultaUsuario);
            this.groupBoxUsuario.Controls.Add(this.btnEliminarUsuario);
            this.groupBoxUsuario.Controls.Add(this.txtConsultaDireccion);
            this.groupBoxUsuario.Controls.Add(this.txtConsultaDni);
            this.groupBoxUsuario.Controls.Add(this.txtConsultaEmail);
            this.groupBoxUsuario.Controls.Add(this.label13);
            this.groupBoxUsuario.Controls.Add(this.label14);
            this.groupBoxUsuario.Controls.Add(this.txtConsultaId);
            this.groupBoxUsuario.Controls.Add(this.label15);
            this.groupBoxUsuario.Controls.Add(this.label19);
            this.groupBoxUsuario.Controls.Add(this.txtConsultaTelefono);
            this.groupBoxUsuario.Controls.Add(this.label18);
            this.groupBoxUsuario.Controls.Add(this.txtConsultaApellido);
            this.groupBoxUsuario.Controls.Add(this.label17);
            this.groupBoxUsuario.Controls.Add(this.txtConsultaNombre);
            this.groupBoxUsuario.Controls.Add(this.label16);
            this.groupBoxUsuario.Location = new System.Drawing.Point(454, 12);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(408, 322);
            this.groupBoxUsuario.TabIndex = 2;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Consulta Usuario";
            // 
            // btnConsultaUsuario
            // 
            this.btnConsultaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaUsuario.Location = new System.Drawing.Point(44, 256);
            this.btnConsultaUsuario.Name = "btnConsultaUsuario";
            this.btnConsultaUsuario.Size = new System.Drawing.Size(168, 60);
            this.btnConsultaUsuario.TabIndex = 21;
            this.btnConsultaUsuario.Text = "Consultar";
            this.btnConsultaUsuario.UseVisualStyleBackColor = true;
            this.btnConsultaUsuario.Click += new System.EventHandler(this.btnConsultaUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(218, 256);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(168, 60);
            this.btnEliminarUsuario.TabIndex = 22;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // txtConsultaDireccion
            // 
            this.txtConsultaDireccion.Location = new System.Drawing.Point(109, 214);
            this.txtConsultaDireccion.Name = "txtConsultaDireccion";
            this.txtConsultaDireccion.ReadOnly = true;
            this.txtConsultaDireccion.Size = new System.Drawing.Size(250, 22);
            this.txtConsultaDireccion.TabIndex = 32;
            // 
            // txtConsultaDni
            // 
            this.txtConsultaDni.Location = new System.Drawing.Point(109, 23);
            this.txtConsultaDni.Name = "txtConsultaDni";
            this.txtConsultaDni.Size = new System.Drawing.Size(250, 22);
            this.txtConsultaDni.TabIndex = 22;
            // 
            // txtConsultaEmail
            // 
            this.txtConsultaEmail.Location = new System.Drawing.Point(109, 182);
            this.txtConsultaEmail.Name = "txtConsultaEmail";
            this.txtConsultaEmail.ReadOnly = true;
            this.txtConsultaEmail.Size = new System.Drawing.Size(250, 22);
            this.txtConsultaEmail.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 22);
            this.label13.TabIndex = 21;
            this.label13.Text = "DNI";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 22);
            this.label14.TabIndex = 30;
            this.label14.Text = "Dirección";
            // 
            // txtConsultaId
            // 
            this.txtConsultaId.Location = new System.Drawing.Point(109, 54);
            this.txtConsultaId.Name = "txtConsultaId";
            this.txtConsultaId.ReadOnly = true;
            this.txtConsultaId.Size = new System.Drawing.Size(250, 22);
            this.txtConsultaId.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 22);
            this.label15.TabIndex = 29;
            this.label15.Text = "Email";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 22);
            this.label19.TabIndex = 22;
            this.label19.Text = "ID Usuario";
            // 
            // txtConsultaTelefono
            // 
            this.txtConsultaTelefono.Location = new System.Drawing.Point(109, 150);
            this.txtConsultaTelefono.Name = "txtConsultaTelefono";
            this.txtConsultaTelefono.ReadOnly = true;
            this.txtConsultaTelefono.Size = new System.Drawing.Size(250, 22);
            this.txtConsultaTelefono.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 22);
            this.label18.TabIndex = 23;
            this.label18.Text = "Nombre";
            // 
            // txtConsultaApellido
            // 
            this.txtConsultaApellido.Location = new System.Drawing.Point(109, 118);
            this.txtConsultaApellido.Name = "txtConsultaApellido";
            this.txtConsultaApellido.ReadOnly = true;
            this.txtConsultaApellido.Size = new System.Drawing.Size(250, 22);
            this.txtConsultaApellido.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 22);
            this.label17.TabIndex = 24;
            this.label17.Text = "Apellido";
            // 
            // txtConsultaNombre
            // 
            this.txtConsultaNombre.Location = new System.Drawing.Point(109, 86);
            this.txtConsultaNombre.Name = "txtConsultaNombre";
            this.txtConsultaNombre.ReadOnly = true;
            this.txtConsultaNombre.Size = new System.Drawing.Size(250, 22);
            this.txtConsultaNombre.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 22);
            this.label16.TabIndex = 25;
            this.label16.Text = "Teléfono";
            // 
            // groupBoxBBDD
            // 
            this.groupBoxBBDD.Controls.Add(this.dataGridView1);
            this.groupBoxBBDD.Location = new System.Drawing.Point(881, 12);
            this.groupBoxBBDD.Name = "groupBoxBBDD";
            this.groupBoxBBDD.Size = new System.Drawing.Size(606, 507);
            this.groupBoxBBDD.TabIndex = 3;
            this.groupBoxBBDD.TabStop = false;
            this.groupBoxBBDD.Text = "BBDD Libros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxAlta
            // 
            this.groupBoxAlta.Controls.Add(this.btnDarAlta);
            this.groupBoxAlta.Controls.Add(this.txtAltaDni);
            this.groupBoxAlta.Controls.Add(this.txtAltaDireccion);
            this.groupBoxAlta.Controls.Add(this.txtAltaEmail);
            this.groupBoxAlta.Controls.Add(this.label10);
            this.groupBoxAlta.Controls.Add(this.label11);
            this.groupBoxAlta.Controls.Add(this.label12);
            this.groupBoxAlta.Controls.Add(this.txtAltaTelefono);
            this.groupBoxAlta.Controls.Add(this.txtAltaApellido);
            this.groupBoxAlta.Controls.Add(this.txtAltaNombre);
            this.groupBoxAlta.Controls.Add(this.label6);
            this.groupBoxAlta.Controls.Add(this.label7);
            this.groupBoxAlta.Controls.Add(this.label8);
            this.groupBoxAlta.Location = new System.Drawing.Point(1, 12);
            this.groupBoxAlta.Name = "groupBoxAlta";
            this.groupBoxAlta.Size = new System.Drawing.Size(447, 322);
            this.groupBoxAlta.TabIndex = 3;
            this.groupBoxAlta.TabStop = false;
            this.groupBoxAlta.Text = "Dar de Alta";
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarAlta.Location = new System.Drawing.Point(151, 256);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(168, 60);
            this.btnDarAlta.TabIndex = 7;
            this.btnDarAlta.Text = "Dar de Alta";
            this.btnDarAlta.UseVisualStyleBackColor = true;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // txtAltaDni
            // 
            this.txtAltaDni.Location = new System.Drawing.Point(117, 186);
            this.txtAltaDni.Name = "txtAltaDni";
            this.txtAltaDni.Size = new System.Drawing.Size(250, 22);
            this.txtAltaDni.TabIndex = 20;
            // 
            // txtAltaDireccion
            // 
            this.txtAltaDireccion.Location = new System.Drawing.Point(117, 154);
            this.txtAltaDireccion.Name = "txtAltaDireccion";
            this.txtAltaDireccion.Size = new System.Drawing.Size(250, 22);
            this.txtAltaDireccion.TabIndex = 19;
            // 
            // txtAltaEmail
            // 
            this.txtAltaEmail.Location = new System.Drawing.Point(117, 122);
            this.txtAltaEmail.Name = "txtAltaEmail";
            this.txtAltaEmail.Size = new System.Drawing.Size(250, 22);
            this.txtAltaEmail.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "DNI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Dirección";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 22);
            this.label12.TabIndex = 15;
            this.label12.Text = "Email";
            // 
            // txtAltaTelefono
            // 
            this.txtAltaTelefono.Location = new System.Drawing.Point(117, 90);
            this.txtAltaTelefono.Name = "txtAltaTelefono";
            this.txtAltaTelefono.Size = new System.Drawing.Size(250, 22);
            this.txtAltaTelefono.TabIndex = 14;
            // 
            // txtAltaApellido
            // 
            this.txtAltaApellido.Location = new System.Drawing.Point(117, 58);
            this.txtAltaApellido.Name = "txtAltaApellido";
            this.txtAltaApellido.Size = new System.Drawing.Size(250, 22);
            this.txtAltaApellido.TabIndex = 13;
            // 
            // txtAltaNombre
            // 
            this.txtAltaNombre.Location = new System.Drawing.Point(117, 26);
            this.txtAltaNombre.Name = "txtAltaNombre";
            this.txtAltaNombre.Size = new System.Drawing.Size(250, 22);
            this.txtAltaNombre.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre";
            // 
            // btnMostrarLibros
            // 
            this.btnMostrarLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarLibros.Location = new System.Drawing.Point(1104, 521);
            this.btnMostrarLibros.Name = "btnMostrarLibros";
            this.btnMostrarLibros.Size = new System.Drawing.Size(168, 60);
            this.btnMostrarLibros.TabIndex = 34;
            this.btnMostrarLibros.Text = "Mostrar Libros";
            this.btnMostrarLibros.UseVisualStyleBackColor = true;
            this.btnMostrarLibros.Click += new System.EventHandler(this.btnMostrarLibros_Click);
            // 
            // btnMostrarAlquiler
            // 
            this.btnMostrarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAlquiler.Location = new System.Drawing.Point(881, 521);
            this.btnMostrarAlquiler.Name = "btnMostrarAlquiler";
            this.btnMostrarAlquiler.Size = new System.Drawing.Size(168, 60);
            this.btnMostrarAlquiler.TabIndex = 35;
            this.btnMostrarAlquiler.Text = "Mostrar Alquiler";
            this.btnMostrarAlquiler.UseVisualStyleBackColor = true;
            this.btnMostrarAlquiler.Click += new System.EventHandler(this.btnMostrarAlquiler_Click);
            // 
            // btnMostrarUsuarios
            // 
            this.btnMostrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarUsuarios.Location = new System.Drawing.Point(1319, 521);
            this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            this.btnMostrarUsuarios.Size = new System.Drawing.Size(168, 60);
            this.btnMostrarUsuarios.TabIndex = 36;
            this.btnMostrarUsuarios.Text = "Mostrar Usuarios";
            this.btnMostrarUsuarios.UseVisualStyleBackColor = true;
            this.btnMostrarUsuarios.Click += new System.EventHandler(this.btnMostrarUsuarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 593);
            this.Controls.Add(this.btnMostrarUsuarios);
            this.Controls.Add(this.btnMostrarAlquiler);
            this.Controls.Add(this.btnMostrarLibros);
            this.Controls.Add(this.groupBoxAlta);
            this.Controls.Add(this.groupBoxBBDD);
            this.Controls.Add(this.groupBoxUsuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Biblioteca Progresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            this.groupBoxBBDD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAlta.ResumeLayout(false);
            this.groupBoxAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.GroupBox groupBoxBBDD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxAlta;
        private System.Windows.Forms.TextBox txtLibroTitulo;
        private System.Windows.Forms.TextBox txtLibroId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIdLibro;
        private System.Windows.Forms.TextBox txtAlquilerIdUsuario;
        private System.Windows.Forms.TextBox txtAlquilerIdLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultaDireccion;
        private System.Windows.Forms.TextBox txtConsultaDni;
        private System.Windows.Forms.TextBox txtConsultaEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtConsultaId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtConsultaTelefono;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtConsultaApellido;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtConsultaNombre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAltaDni;
        private System.Windows.Forms.TextBox txtAltaDireccion;
        private System.Windows.Forms.TextBox txtAltaEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAltaTelefono;
        private System.Windows.Forms.TextBox txtAltaApellido;
        private System.Windows.Forms.TextBox txtAltaNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConsultaLibros;
        private System.Windows.Forms.Button btnGenerarAlquiler;
        private System.Windows.Forms.Button btnConsultaUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.Button btnMostrarLibros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAlquilerTrabajador;
        private System.Windows.Forms.Button btnMostrarAlquiler;
        private System.Windows.Forms.Button btnMostrarUsuarios;
    }
}

