namespace Proyecto_Software_B
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this._RegistroPersonal = new System.Windows.Forms.GroupBox();
            this.TipoUsuario = new System.Windows.Forms.ComboBox();
            this.CorreoElectrico = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.ApMatUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ApPaternoUsuario = new System.Windows.Forms.TextBox();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ImagenEmpleado = new System.Windows.Forms.PictureBox();
            this.opcInventa = new System.Windows.Forms.GroupBox();
            this.BNuevoUsuario = new System.Windows.Forms.Button();
            this.BActualizaUsuario = new System.Windows.Forms.Button();
            this.BEliminaUsuario = new System.Windows.Forms.Button();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._RegistroPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEmpleado)).BeginInit();
            this.opcInventa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // _RegistroPersonal
            // 
            this._RegistroPersonal.BackColor = System.Drawing.SystemColors.Control;
            this._RegistroPersonal.Controls.Add(this.TipoUsuario);
            this._RegistroPersonal.Controls.Add(this.CorreoElectrico);
            this._RegistroPersonal.Controls.Add(this.textBox6);
            this._RegistroPersonal.Controls.Add(this.Contrasena);
            this._RegistroPersonal.Controls.Add(this.UserName);
            this._RegistroPersonal.Controls.Add(this.ApMatUsuario);
            this._RegistroPersonal.Controls.Add(this.label8);
            this._RegistroPersonal.Controls.Add(this.label7);
            this._RegistroPersonal.Controls.Add(this.label6);
            this._RegistroPersonal.Controls.Add(this.label5);
            this._RegistroPersonal.Controls.Add(this.label4);
            this._RegistroPersonal.Controls.Add(this.label3);
            this._RegistroPersonal.Controls.Add(this.ApPaternoUsuario);
            this._RegistroPersonal.Controls.Add(this.NombreUsuario);
            this._RegistroPersonal.Controls.Add(this.label9);
            this._RegistroPersonal.Controls.Add(this.label10);
            this._RegistroPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._RegistroPersonal.Location = new System.Drawing.Point(239, 12);
            this._RegistroPersonal.Name = "_RegistroPersonal";
            this._RegistroPersonal.Size = new System.Drawing.Size(510, 256);
            this._RegistroPersonal.TabIndex = 4;
            this._RegistroPersonal.TabStop = false;
            this._RegistroPersonal.Text = "Registro de Personal";
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.FormattingEnabled = true;
            this.TipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.TipoUsuario.Location = new System.Drawing.Point(138, 189);
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Size = new System.Drawing.Size(337, 21);
            this.TipoUsuario.TabIndex = 7;
            // 
            // CorreoElectrico
            // 
            this.CorreoElectrico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CorreoElectrico.Location = new System.Drawing.Point(138, 218);
            this.CorreoElectrico.Name = "CorreoElectrico";
            this.CorreoElectrico.Size = new System.Drawing.Size(337, 20);
            this.CorreoElectrico.TabIndex = 4;
            this.CorreoElectrico.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox6.Location = new System.Drawing.Point(137, 161);
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '°';
            this.textBox6.Size = new System.Drawing.Size(337, 20);
            this.textBox6.TabIndex = 3;
            // 
            // Contrasena
            // 
            this.Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Contrasena.Location = new System.Drawing.Point(137, 135);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.PasswordChar = '°';
            this.Contrasena.Size = new System.Drawing.Size(337, 20);
            this.Contrasena.TabIndex = 3;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UserName.Location = new System.Drawing.Point(138, 109);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(337, 20);
            this.UserName.TabIndex = 3;
            // 
            // ApMatUsuario
            // 
            this.ApMatUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ApMatUsuario.Location = new System.Drawing.Point(138, 83);
            this.ApMatUsuario.Name = "ApMatUsuario";
            this.ApMatUsuario.Size = new System.Drawing.Size(337, 20);
            this.ApMatUsuario.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(24, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Correo Electronico";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(22, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tipo de Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(24, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Confirmar Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(24, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre De Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno";
            // 
            // ApPaternoUsuario
            // 
            this.ApPaternoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ApPaternoUsuario.Location = new System.Drawing.Point(138, 54);
            this.ApPaternoUsuario.Name = "ApPaternoUsuario";
            this.ApPaternoUsuario.Size = new System.Drawing.Size(337, 20);
            this.ApPaternoUsuario.TabIndex = 1;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NombreUsuario.Location = new System.Drawing.Point(141, 26);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(302, 20);
            this.NombreUsuario.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(22, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Apellido Paterno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(24, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre";
            // 
            // ImagenEmpleado
            // 
            this.ImagenEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("ImagenEmpleado.Image")));
            this.ImagenEmpleado.Location = new System.Drawing.Point(26, 12);
            this.ImagenEmpleado.Name = "ImagenEmpleado";
            this.ImagenEmpleado.Size = new System.Drawing.Size(156, 139);
            this.ImagenEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenEmpleado.TabIndex = 6;
            this.ImagenEmpleado.TabStop = false;
            this.ImagenEmpleado.Click += new System.EventHandler(this.ImagenEmpleado_Click);
            // 
            // opcInventa
            // 
            this.opcInventa.Controls.Add(this.BNuevoUsuario);
            this.opcInventa.Controls.Add(this.BActualizaUsuario);
            this.opcInventa.Controls.Add(this.BEliminaUsuario);
            this.opcInventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.opcInventa.Location = new System.Drawing.Point(12, 177);
            this.opcInventa.Name = "opcInventa";
            this.opcInventa.Size = new System.Drawing.Size(185, 141);
            this.opcInventa.TabIndex = 28;
            this.opcInventa.TabStop = false;
            this.opcInventa.Text = "Opciones";
            // 
            // BNuevoUsuario
            // 
            this.BNuevoUsuario.Location = new System.Drawing.Point(20, 25);
            this.BNuevoUsuario.Name = "BNuevoUsuario";
            this.BNuevoUsuario.Size = new System.Drawing.Size(150, 30);
            this.BNuevoUsuario.TabIndex = 19;
            this.BNuevoUsuario.Text = "Nuevo Usuario";
            this.BNuevoUsuario.UseVisualStyleBackColor = true;
            this.BNuevoUsuario.Click += new System.EventHandler(this.BNuevoUsuario_Click);
            // 
            // BActualizaUsuario
            // 
            this.BActualizaUsuario.Location = new System.Drawing.Point(20, 97);
            this.BActualizaUsuario.Name = "BActualizaUsuario";
            this.BActualizaUsuario.Size = new System.Drawing.Size(150, 30);
            this.BActualizaUsuario.TabIndex = 21;
            this.BActualizaUsuario.Text = "Actualizar Usuario";
            this.BActualizaUsuario.UseVisualStyleBackColor = true;
            this.BActualizaUsuario.Click += new System.EventHandler(this.BActualizaUsuario_Click);
            // 
            // BEliminaUsuario
            // 
            this.BEliminaUsuario.Location = new System.Drawing.Point(20, 61);
            this.BEliminaUsuario.Name = "BEliminaUsuario";
            this.BEliminaUsuario.Size = new System.Drawing.Size(150, 30);
            this.BEliminaUsuario.TabIndex = 20;
            this.BEliminaUsuario.Text = "Eliminar Usuario";
            this.BEliminaUsuario.UseVisualStyleBackColor = true;
            this.BEliminaUsuario.Click += new System.EventHandler(this.BEliminaUsuario_Click);
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridUsuarios.Location = new System.Drawing.Point(239, 290);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.RowHeadersVisible = false;
            this.dataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuarios.Size = new System.Drawing.Size(639, 146);
            this.dataGridUsuarios.TabIndex = 29;
            this.dataGridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 466);
            this.Controls.Add(this.dataGridUsuarios);
            this.Controls.Add(this.opcInventa);
            this.Controls.Add(this._RegistroPersonal);
            this.Controls.Add(this.ImagenEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this._RegistroPersonal.ResumeLayout(false);
            this._RegistroPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEmpleado)).EndInit();
            this.opcInventa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _RegistroPersonal;
        private System.Windows.Forms.ComboBox TipoUsuario;
        private System.Windows.Forms.PictureBox ImagenEmpleado;
        private System.Windows.Forms.TextBox CorreoElectrico;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox Contrasena;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox ApMatUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ApPaternoUsuario;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox opcInventa;
        private System.Windows.Forms.Button BNuevoUsuario;
        private System.Windows.Forms.Button BActualizaUsuario;
        private System.Windows.Forms.Button BEliminaUsuario;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}