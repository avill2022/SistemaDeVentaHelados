namespace Proyecto_Software_B
{
    partial class Proveedores
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
            this.opcInventa = new System.Windows.Forms.GroupBox();
            this.BNuevoProv = new System.Windows.Forms.Button();
            this.BActualizaProv = new System.Windows.Forms.Button();
            this.BEliminaProv = new System.Windows.Forms.Button();
            this.LogoEmpresa = new System.Windows.Forms.PictureBox();
            this._Proveedores = new System.Windows.Forms.GroupBox();
            this.txPaginaWeb = new System.Windows.Forms.TextBox();
            this.txTipoProducto = new System.Windows.Forms.ComboBox();
            this.dataGridProveedores = new System.Windows.Forms.DataGridView();
            this.ImgLogo = new System.Windows.Forms.Button();
            this.txRUC = new System.Windows.Forms.TextBox();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.txCalleProv = new System.Windows.Forms.TextBox();
            this.txNombreProv = new System.Windows.Forms.TextBox();
            this.lTipoMercancia = new System.Windows.Forms.Label();
            this.lRUC = new System.Windows.Forms.Label();
            this.IPaginaWeb = new System.Windows.Forms.Label();
            this.lExistencias = new System.Windows.Forms.Label();
            this.IDireccionProv = new System.Windows.Forms.Label();
            this.lNombreP = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.opcInventa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEmpresa)).BeginInit();
            this._Proveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // opcInventa
            // 
            this.opcInventa.Controls.Add(this.BNuevoProv);
            this.opcInventa.Controls.Add(this.BActualizaProv);
            this.opcInventa.Controls.Add(this.BEliminaProv);
            this.opcInventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.opcInventa.Location = new System.Drawing.Point(10, 168);
            this.opcInventa.Name = "opcInventa";
            this.opcInventa.Size = new System.Drawing.Size(185, 141);
            this.opcInventa.TabIndex = 27;
            this.opcInventa.TabStop = false;
            this.opcInventa.Text = "Opciones";
            // 
            // BNuevoProv
            // 
            this.BNuevoProv.Location = new System.Drawing.Point(20, 25);
            this.BNuevoProv.Name = "BNuevoProv";
            this.BNuevoProv.Size = new System.Drawing.Size(150, 30);
            this.BNuevoProv.TabIndex = 19;
            this.BNuevoProv.Text = "Nuevo Proveedor";
            this.BNuevoProv.UseVisualStyleBackColor = true;
            this.BNuevoProv.Click += new System.EventHandler(this.BNuevoProv_Click);
            // 
            // BActualizaProv
            // 
            this.BActualizaProv.Enabled = false;
            this.BActualizaProv.Location = new System.Drawing.Point(20, 97);
            this.BActualizaProv.Name = "BActualizaProv";
            this.BActualizaProv.Size = new System.Drawing.Size(150, 30);
            this.BActualizaProv.TabIndex = 21;
            this.BActualizaProv.Text = "Actualizar Proveedor";
            this.BActualizaProv.UseVisualStyleBackColor = true;
            this.BActualizaProv.Visible = false;
            this.BActualizaProv.Click += new System.EventHandler(this.BActualizaProv_Click);
            // 
            // BEliminaProv
            // 
            this.BEliminaProv.Location = new System.Drawing.Point(20, 61);
            this.BEliminaProv.Name = "BEliminaProv";
            this.BEliminaProv.Size = new System.Drawing.Size(150, 30);
            this.BEliminaProv.TabIndex = 20;
            this.BEliminaProv.Text = "Eliminar Proveedor";
            this.BEliminaProv.UseVisualStyleBackColor = true;
            this.BEliminaProv.Click += new System.EventHandler(this.BEliminaProv_Click);
            // 
            // LogoEmpresa
            // 
            this.LogoEmpresa.Location = new System.Drawing.Point(30, 12);
            this.LogoEmpresa.Name = "LogoEmpresa";
            this.LogoEmpresa.Size = new System.Drawing.Size(150, 150);
            this.LogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoEmpresa.TabIndex = 26;
            this.LogoEmpresa.TabStop = false;
            // 
            // _Proveedores
            // 
            this._Proveedores.Controls.Add(this.txPaginaWeb);
            this._Proveedores.Controls.Add(this.txTipoProducto);
            this._Proveedores.Controls.Add(this.dataGridProveedores);
            this._Proveedores.Controls.Add(this.ImgLogo);
            this._Proveedores.Controls.Add(this.txRUC);
            this._Proveedores.Controls.Add(this.txTelefono);
            this._Proveedores.Controls.Add(this.txCalleProv);
            this._Proveedores.Controls.Add(this.txNombreProv);
            this._Proveedores.Controls.Add(this.lTipoMercancia);
            this._Proveedores.Controls.Add(this.lRUC);
            this._Proveedores.Controls.Add(this.IPaginaWeb);
            this._Proveedores.Controls.Add(this.lExistencias);
            this._Proveedores.Controls.Add(this.IDireccionProv);
            this._Proveedores.Controls.Add(this.lNombreP);
            this._Proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._Proveedores.Location = new System.Drawing.Point(201, 12);
            this._Proveedores.Name = "_Proveedores";
            this._Proveedores.Size = new System.Drawing.Size(680, 442);
            this._Proveedores.TabIndex = 25;
            this._Proveedores.TabStop = false;
            this._Proveedores.Text = "Proveedores";
            this._Proveedores.Enter += new System.EventHandler(this._Proveedores_Enter);
            // 
            // txPaginaWeb
            // 
            this.txPaginaWeb.Location = new System.Drawing.Point(151, 105);
            this.txPaginaWeb.Name = "txPaginaWeb";
            this.txPaginaWeb.Size = new System.Drawing.Size(302, 20);
            this.txPaginaWeb.TabIndex = 15;
            this.txPaginaWeb.Visible = false;
            this.txPaginaWeb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
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
            this.txTipoProducto.Location = new System.Drawing.Point(151, 131);
            this.txTipoProducto.Name = "txTipoProducto";
            this.txTipoProducto.Size = new System.Drawing.Size(302, 21);
            this.txTipoProducto.TabIndex = 14;
            this.txTipoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // dataGridProveedores
            // 
            this.dataGridProveedores.AllowUserToAddRows = false;
            this.dataGridProveedores.AllowUserToDeleteRows = false;
            this.dataGridProveedores.AllowUserToResizeColumns = false;
            this.dataGridProveedores.AllowUserToResizeRows = false;
            this.dataGridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProveedores.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridProveedores.Location = new System.Drawing.Point(23, 200);
            this.dataGridProveedores.Name = "dataGridProveedores";
            this.dataGridProveedores.ReadOnly = true;
            this.dataGridProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProveedores.Size = new System.Drawing.Size(643, 227);
            this.dataGridProveedores.TabIndex = 13;
            // 
            // ImgLogo
            // 
            this.ImgLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ImgLogo.Location = new System.Drawing.Point(510, 25);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(156, 55);
            this.ImgLogo.TabIndex = 12;
            this.ImgLogo.Text = "Logo Empresa";
            this.ImgLogo.UseVisualStyleBackColor = true;
            this.ImgLogo.Click += new System.EventHandler(this.ImgLogo_Click);
            // 
            // txRUC
            // 
            this.txRUC.Location = new System.Drawing.Point(151, 105);
            this.txRUC.Name = "txRUC";
            this.txRUC.Size = new System.Drawing.Size(302, 20);
            this.txRUC.TabIndex = 10;
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(151, 79);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(302, 20);
            this.txTelefono.TabIndex = 8;
            this.txTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txCalleProv
            // 
            this.txCalleProv.Location = new System.Drawing.Point(151, 51);
            this.txCalleProv.MaxLength = 9;
            this.txCalleProv.Name = "txCalleProv";
            this.txCalleProv.Size = new System.Drawing.Size(302, 20);
            this.txCalleProv.TabIndex = 7;
            this.txCalleProv.Tag = "";
            this.txCalleProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // txNombreProv
            // 
            this.txNombreProv.Location = new System.Drawing.Point(151, 25);
            this.txNombreProv.Name = "txNombreProv";
            this.txNombreProv.Size = new System.Drawing.Size(302, 20);
            this.txNombreProv.TabIndex = 6;
            this.txNombreProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // lTipoMercancia
            // 
            this.lTipoMercancia.AutoSize = true;
            this.lTipoMercancia.Location = new System.Drawing.Point(30, 130);
            this.lTipoMercancia.Name = "lTipoMercancia";
            this.lTipoMercancia.Size = new System.Drawing.Size(98, 13);
            this.lTipoMercancia.TabIndex = 5;
            this.lTipoMercancia.Text = "Tipo De Mercancia";
            // 
            // lRUC
            // 
            this.lRUC.AutoSize = true;
            this.lRUC.Location = new System.Drawing.Point(31, 105);
            this.lRUC.Name = "lRUC";
            this.lRUC.Size = new System.Drawing.Size(28, 13);
            this.lRUC.TabIndex = 4;
            this.lRUC.Text = "RFC";
            // 
            // IPaginaWeb
            // 
            this.IPaginaWeb.AutoSize = true;
            this.IPaginaWeb.Location = new System.Drawing.Point(30, 105);
            this.IPaginaWeb.Name = "IPaginaWeb";
            this.IPaginaWeb.Size = new System.Drawing.Size(66, 13);
            this.IPaginaWeb.TabIndex = 3;
            this.IPaginaWeb.Text = "Página Web";
            this.IPaginaWeb.Visible = false;
            // 
            // lExistencias
            // 
            this.lExistencias.AutoSize = true;
            this.lExistencias.Location = new System.Drawing.Point(30, 79);
            this.lExistencias.Name = "lExistencias";
            this.lExistencias.Size = new System.Drawing.Size(49, 13);
            this.lExistencias.TabIndex = 2;
            this.lExistencias.Text = "Telefono";
            // 
            // IDireccionProv
            // 
            this.IDireccionProv.AutoSize = true;
            this.IDireccionProv.Location = new System.Drawing.Point(31, 51);
            this.IDireccionProv.Name = "IDireccionProv";
            this.IDireccionProv.Size = new System.Drawing.Size(52, 13);
            this.IDireccionProv.TabIndex = 1;
            this.IDireccionProv.Text = "Direccion";
            // 
            // lNombreP
            // 
            this.lNombreP.AutoSize = true;
            this.lNombreP.Location = new System.Drawing.Point(31, 25);
            this.lNombreP.Name = "lNombreP";
            this.lNombreP.Size = new System.Drawing.Size(114, 13);
            this.lNombreP.TabIndex = 0;
            this.lNombreP.Text = "Nombre de la Empresa";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 466);
            this.Controls.Add(this.opcInventa);
            this.Controls.Add(this.LogoEmpresa);
            this.Controls.Add(this._Proveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.opcInventa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoEmpresa)).EndInit();
            this._Proveedores.ResumeLayout(false);
            this._Proveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox opcInventa;
        private System.Windows.Forms.Button BNuevoProv;
        private System.Windows.Forms.Button BActualizaProv;
        private System.Windows.Forms.Button BEliminaProv;
        private System.Windows.Forms.PictureBox LogoEmpresa;
        private System.Windows.Forms.GroupBox _Proveedores;
        private System.Windows.Forms.ComboBox txTipoProducto;
        private System.Windows.Forms.DataGridView dataGridProveedores;
        private System.Windows.Forms.Button ImgLogo;
        private System.Windows.Forms.TextBox txRUC;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txCalleProv;
        private System.Windows.Forms.TextBox txNombreProv;
        private System.Windows.Forms.Label lTipoMercancia;
        private System.Windows.Forms.Label lRUC;
        private System.Windows.Forms.Label IPaginaWeb;
        private System.Windows.Forms.Label lExistencias;
        private System.Windows.Forms.Label IDireccionProv;
        private System.Windows.Forms.Label lNombreP;
        private System.Windows.Forms.TextBox txPaginaWeb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}