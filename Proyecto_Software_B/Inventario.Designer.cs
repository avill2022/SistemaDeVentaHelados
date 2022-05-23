namespace Proyecto_Software_B
{
    partial class Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._Usuarios = new System.Windows.Forms.GroupBox();
            this.BProvedores = new System.Windows.Forms.Button();
            this.txProveedor = new System.Windows.Forms.TextBox();
            this.txTipoProducto = new System.Windows.Forms.ComboBox();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.AgregaImage = new System.Windows.Forms.Button();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.txExistencias = new System.Windows.Forms.TextBox();
            this.txCodigoP = new System.Windows.Forms.TextBox();
            this.txNombreP = new System.Windows.Forms.TextBox();
            this.lTipoP = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lProveedor = new System.Windows.Forms.Label();
            this.lExistencias = new System.Windows.Forms.Label();
            this.lCodigoP = new System.Windows.Forms.Label();
            this.lNombreP = new System.Windows.Forms.Label();
            this.opcInventa = new System.Windows.Forms.GroupBox();
            this.prodnew = new System.Windows.Forms.Button();
            this.updatprod = new System.Windows.Forms.Button();
            this.deletprod = new System.Windows.Forms.Button();
            this.ImagenProducto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.opcInventa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // _Usuarios
            // 
            this._Usuarios.Controls.Add(this.BProvedores);
            this._Usuarios.Controls.Add(this.txProveedor);
            this._Usuarios.Controls.Add(this.txTipoProducto);
            this._Usuarios.Controls.Add(this.dataGridProductos);
            this._Usuarios.Controls.Add(this.AgregaImage);
            this._Usuarios.Controls.Add(this.txPrecio);
            this._Usuarios.Controls.Add(this.txExistencias);
            this._Usuarios.Controls.Add(this.txCodigoP);
            this._Usuarios.Controls.Add(this.txNombreP);
            this._Usuarios.Controls.Add(this.lTipoP);
            this._Usuarios.Controls.Add(this.lPrecio);
            this._Usuarios.Controls.Add(this.lProveedor);
            this._Usuarios.Controls.Add(this.lExistencias);
            this._Usuarios.Controls.Add(this.lCodigoP);
            this._Usuarios.Controls.Add(this.lNombreP);
            this._Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._Usuarios.Location = new System.Drawing.Point(203, 12);
            this._Usuarios.Name = "_Usuarios";
            this._Usuarios.Size = new System.Drawing.Size(680, 442);
            this._Usuarios.TabIndex = 9;
            this._Usuarios.TabStop = false;
            this._Usuarios.Text = "Inventario De Productos";
            this._Usuarios.Enter += new System.EventHandler(this._Usuarios_Enter);
            // 
            // BProvedores
            // 
            this.BProvedores.Location = new System.Drawing.Point(405, 105);
            this.BProvedores.Name = "BProvedores";
            this.BProvedores.Size = new System.Drawing.Size(36, 20);
            this.BProvedores.TabIndex = 16;
            this.BProvedores.Text = "...";
            this.BProvedores.UseVisualStyleBackColor = true;
            this.BProvedores.Click += new System.EventHandler(this.BProvedores_Click);
            // 
            // txProveedor
            // 
            this.txProveedor.Location = new System.Drawing.Point(139, 105);
            this.txProveedor.Name = "txProveedor";
            this.txProveedor.ReadOnly = true;
            this.txProveedor.Size = new System.Drawing.Size(247, 20);
            this.txProveedor.TabIndex = 15;
            // 
            // txTipoProducto
            // 
            this.txTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txTipoProducto.FormattingEnabled = true;
            this.txTipoProducto.Items.AddRange(new object[] {
            "Paleta",
            "Helado",
            "Bebida",
            "Botana"});
            this.txTipoProducto.Location = new System.Drawing.Point(139, 157);
            this.txTipoProducto.Name = "txTipoProducto";
            this.txTipoProducto.Size = new System.Drawing.Size(302, 21);
            this.txTipoProducto.TabIndex = 14;
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToAddRows = false;
            this.dataGridProductos.AllowUserToDeleteRows = false;
            this.dataGridProductos.AllowUserToResizeColumns = false;
            this.dataGridProductos.AllowUserToResizeRows = false;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProductos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridProductos.Location = new System.Drawing.Point(23, 200);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.ReadOnly = true;
            this.dataGridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProductos.Size = new System.Drawing.Size(643, 227);
            this.dataGridProductos.TabIndex = 13;
            this.dataGridProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductos_CellClick);
            // 
            // AgregaImage
            // 
            this.AgregaImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AgregaImage.Location = new System.Drawing.Point(510, 25);
            this.AgregaImage.Name = "AgregaImage";
            this.AgregaImage.Size = new System.Drawing.Size(156, 55);
            this.AgregaImage.TabIndex = 12;
            this.AgregaImage.Text = "Agrega Imagen";
            this.AgregaImage.UseVisualStyleBackColor = true;
            this.AgregaImage.Click += new System.EventHandler(this.AgregaImage_Click);
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(139, 131);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(302, 20);
            this.txPrecio.TabIndex = 10;
            this.txPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txExistencias
            // 
            this.txExistencias.Location = new System.Drawing.Point(139, 79);
            this.txExistencias.Name = "txExistencias";
            this.txExistencias.Size = new System.Drawing.Size(302, 20);
            this.txExistencias.TabIndex = 8;
            this.txExistencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txCodigoP
            // 
            this.txCodigoP.Location = new System.Drawing.Point(139, 51);
            this.txCodigoP.MaxLength = 10;
            this.txCodigoP.Name = "txCodigoP";
            this.txCodigoP.Size = new System.Drawing.Size(302, 20);
            this.txCodigoP.TabIndex = 7;
            this.txCodigoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txNombreP
            // 
            this.txNombreP.Location = new System.Drawing.Point(139, 25);
            this.txNombreP.Name = "txNombreP";
            this.txNombreP.Size = new System.Drawing.Size(302, 20);
            this.txNombreP.TabIndex = 6;
            // 
            // lTipoP
            // 
            this.lTipoP.AutoSize = true;
            this.lTipoP.Location = new System.Drawing.Point(30, 156);
            this.lTipoP.Name = "lTipoP";
            this.lTipoP.Size = new System.Drawing.Size(91, 13);
            this.lTipoP.TabIndex = 5;
            this.lTipoP.Text = "Tipo De Producto";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(31, 131);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(37, 13);
            this.lPrecio.TabIndex = 4;
            this.lPrecio.Text = "Precio";
            // 
            // lProveedor
            // 
            this.lProveedor.AutoSize = true;
            this.lProveedor.Location = new System.Drawing.Point(30, 105);
            this.lProveedor.Name = "lProveedor";
            this.lProveedor.Size = new System.Drawing.Size(56, 13);
            this.lProveedor.TabIndex = 3;
            this.lProveedor.Text = "Proveedor";
            // 
            // lExistencias
            // 
            this.lExistencias.AutoSize = true;
            this.lExistencias.Location = new System.Drawing.Point(30, 79);
            this.lExistencias.Name = "lExistencias";
            this.lExistencias.Size = new System.Drawing.Size(60, 13);
            this.lExistencias.TabIndex = 2;
            this.lExistencias.Text = "Existencias";
            // 
            // lCodigoP
            // 
            this.lCodigoP.AutoSize = true;
            this.lCodigoP.Location = new System.Drawing.Point(31, 51);
            this.lCodigoP.Name = "lCodigoP";
            this.lCodigoP.Size = new System.Drawing.Size(86, 13);
            this.lCodigoP.TabIndex = 1;
            this.lCodigoP.Text = "Codigo Producto";
            // 
            // lNombreP
            // 
            this.lNombreP.AutoSize = true;
            this.lNombreP.Location = new System.Drawing.Point(31, 25);
            this.lNombreP.Name = "lNombreP";
            this.lNombreP.Size = new System.Drawing.Size(90, 13);
            this.lNombreP.TabIndex = 0;
            this.lNombreP.Text = "Nombre Producto";
            // 
            // opcInventa
            // 
            this.opcInventa.Controls.Add(this.prodnew);
            this.opcInventa.Controls.Add(this.updatprod);
            this.opcInventa.Controls.Add(this.deletprod);
            this.opcInventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.opcInventa.Location = new System.Drawing.Point(12, 168);
            this.opcInventa.Name = "opcInventa";
            this.opcInventa.Size = new System.Drawing.Size(185, 141);
            this.opcInventa.TabIndex = 24;
            this.opcInventa.TabStop = false;
            this.opcInventa.Text = "Opciones";
            // 
            // prodnew
            // 
            this.prodnew.Location = new System.Drawing.Point(20, 25);
            this.prodnew.Name = "prodnew";
            this.prodnew.Size = new System.Drawing.Size(150, 30);
            this.prodnew.TabIndex = 19;
            this.prodnew.Text = "Producto Nuevo";
            this.prodnew.UseVisualStyleBackColor = true;
            this.prodnew.Click += new System.EventHandler(this.prodnew_Click);
            // 
            // updatprod
            // 
            this.updatprod.Location = new System.Drawing.Point(20, 97);
            this.updatprod.Name = "updatprod";
            this.updatprod.Size = new System.Drawing.Size(150, 30);
            this.updatprod.TabIndex = 21;
            this.updatprod.Text = "Actualizar Producto";
            this.updatprod.UseVisualStyleBackColor = true;
            this.updatprod.Click += new System.EventHandler(this.updatprod_Click);
            // 
            // deletprod
            // 
            this.deletprod.Location = new System.Drawing.Point(20, 61);
            this.deletprod.Name = "deletprod";
            this.deletprod.Size = new System.Drawing.Size(150, 30);
            this.deletprod.TabIndex = 20;
            this.deletprod.Text = "Eliminar Producto";
            this.deletprod.UseVisualStyleBackColor = true;
            this.deletprod.Click += new System.EventHandler(this.deletprod_Click);
            // 
            // ImagenProducto
            // 
            this.ImagenProducto.Location = new System.Drawing.Point(32, 12);
            this.ImagenProducto.Name = "ImagenProducto";
            this.ImagenProducto.Size = new System.Drawing.Size(150, 150);
            this.ImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenProducto.TabIndex = 23;
            this.ImagenProducto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 466);
            this.Controls.Add(this.opcInventa);
            this.Controls.Add(this.ImagenProducto);
            this.Controls.Add(this._Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this._Usuarios.ResumeLayout(false);
            this._Usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.opcInventa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _Usuarios;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.Button AgregaImage;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.TextBox txExistencias;
        private System.Windows.Forms.TextBox txCodigoP;
        private System.Windows.Forms.TextBox txNombreP;
        private System.Windows.Forms.Label lTipoP;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label lProveedor;
        private System.Windows.Forms.Label lExistencias;
        private System.Windows.Forms.Label lCodigoP;
        private System.Windows.Forms.Label lNombreP;
        private System.Windows.Forms.GroupBox opcInventa;
        private System.Windows.Forms.Button prodnew;
        private System.Windows.Forms.Button updatprod;
        private System.Windows.Forms.Button deletprod;
        private System.Windows.Forms.PictureBox ImagenProducto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox txTipoProducto;
        private System.Windows.Forms.Button BProvedores;
        private System.Windows.Forms.TextBox txProveedor;
    }
}