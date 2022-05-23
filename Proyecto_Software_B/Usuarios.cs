using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Software_B
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BNuevoUsuario_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch (b.Text)
            {
                case "Nuevo Usuario":
                    Usuario usuario = new Usuario();
                    if (usuario.altaUsuario(NombreUsuario.Text, ApPaternoUsuario.Text, ApMatUsuario.Text, UserName.Text, Contrasena.Text, TipoUsuario.Text, CorreoElectrico.Text, this.ImagenEmpleado) == true)
                    {
                        usuario.UpdateUsuarios(dataGridUsuarios);
                        limpiaControles();
                        //this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    break;
            }
        }
        private void ImagenEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string image = openFileDialog1.FileName;
                    ImagenEmpleado.Image = System.Drawing.Image.FromFile(image);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El Archivo Seleccionado no es un tipo de imagen valido");
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.UpdateUsuarios(dataGridUsuarios);
        }

        private void BEliminaUsuario_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            string cad= "";
            if(dataGridUsuarios.CurrentRow.Cells[4].Value != null)
            {
                cad = dataGridUsuarios.CurrentRow.Cells[4].Value .ToString();
                us.EliminaUsuario(cad);
                us.UpdateUsuarios(dataGridUsuarios);
                limpiaControles();
            }
        }

        private void BActualizaUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (dataGridUsuarios.CurrentRow.Cells[0].Value != null)
            {
                usuario.modificaUSuario(dataGridUsuarios.CurrentRow.Cells[0].Value.ToString(), NombreUsuario.Text, ApPaternoUsuario.Text, ApMatUsuario.Text, UserName.Text, Contrasena.Text, TipoUsuario.Text, CorreoElectrico.Text, this.ImagenEmpleado);

                usuario.UpdateUsuarios(dataGridUsuarios);
                limpiaControles();
                //this.Close(); 
            }
        }

        private void dataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               
            if (e.RowIndex >= 0)
            {
                String id = dataGridUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                string qry = "Select * from Personal where ID_Usuario = '" + id + "'";
                this.NombreUsuario.Text = dataGridUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.ApPaternoUsuario.Text = dataGridUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.ApMatUsuario.Text = dataGridUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.UserName.Text = dataGridUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.TipoUsuario.Text = dataGridUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
                try
                {
                    if (conexion.ExisteConsulta(qry))
                    {
                        qry = "Select Foto from Personal where ID_Usuario = '" + dataGridUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                        // El campo productImage primero se almacena en un buffer
                        object obj = conexion.ComandoEscalar(qry);
                        byte[] imageBuffer = (byte[])obj;
                        // Se crea un MemoryStream a partir de ese buffer
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        // Se utiliza el MemoryStream para extraer la imagen
                        this.ImagenEmpleado.Image = System.Drawing.Image.FromStream(ms);
                        //se busca el producto y se iguala la imagen:  imageProducto.Image
                    }
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("" + ex);

                }


            }
        

        }

        private void limpiaControles()
        {
            NombreUsuario.Text = ApPaternoUsuario.Text = ApMatUsuario.Text = UserName.Text = Contrasena.Text = TipoUsuario.Text = CorreoElectrico.Text ="";
            ImagenEmpleado.Image = null;
        }
    }
}
