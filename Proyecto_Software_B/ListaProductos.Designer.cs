namespace Proyecto_Software_B
{
    partial class ListaProductos
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
            this.Cancear = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancear
            // 
            this.Cancear.Location = new System.Drawing.Point(666, 455);
            this.Cancear.Name = "Cancear";
            this.Cancear.Size = new System.Drawing.Size(75, 23);
            this.Cancear.TabIndex = 0;
            this.Cancear.Text = "Cancelar";
            this.Cancear.UseVisualStyleBackColor = true;
            this.Cancear.Click += new System.EventHandler(this.Cancear_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(747, 455);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Productos
            // 
            this.Productos.AllowUserToAddRows = false;
            this.Productos.AllowUserToDeleteRows = false;
            this.Productos.AllowUserToResizeColumns = false;
            this.Productos.AllowUserToResizeRows = false;
            this.Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Productos.Location = new System.Drawing.Point(12, 12);
            this.Productos.Name = "Productos";
            this.Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Productos.Size = new System.Drawing.Size(810, 437);
            this.Productos.TabIndex = 2;
            this.Productos.SelectionChanged += new System.EventHandler(this.Productos_SelectionChanged);
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 490);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaProductos";
            this.Load += new System.EventHandler(this.ListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancear;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.DataGridView Productos;
    }
}