using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In
{
    public partial class Login : Form
    {

        private string usuario;
        private string contrasena;
        private string Permiso;
        private string ID_Usuario;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void Evento_Button(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Text)
            {
                case "Ok":
                    if (validaUsuario())
                    {

                        muestraInterfaz();
                    }
                    else
                    {
                        MessageBox.Show("Usuario No Valido ");
                    }

                break;

                case "Cancel":

                break;
            }


        }

        private void clearControl()
        {
            foreach(var c in this.groupBox1.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }

        }

        private void muestraInterfaz()
        {
            ConexionSQL conexion;
            usuario = textBox1.Text;
            contrasena = textBox2.Text;
            string comando = "select Tipo_Usuario From Personal where User_Name = '" + usuario + "' AND Contrasena = '" + contrasena + "'";
            conexion = new ConexionSQL();

            object obj = conexion.ComandoEscalar(comando);
            if (obj != null)
            {
                Permiso = obj.ToString();
            }
            comando = "select ID_Usuario From Personal where User_Name = '" + usuario + "' AND Contrasena = '" + contrasena + "'";
            obj = conexion.ComandoEscalar(comando);
            if (obj != null)
            {
                ID_Usuario = obj.ToString();
            }
            Proyecto_Software_B.Interfaz interfaz = new Proyecto_Software_B.Interfaz(usuario,Permiso, ID_Usuario);
            this.clearControl();
            this.Hide();
            if (interfaz.ShowDialog() != DialogResult.Cancel)
            {
                this.Show();
                textBox1.Focus();
                
            }
            else
            {
                this.Close();
            }
            


        }

        private bool validaUsuario()
        {
        
            ConexionSQL conexion;
            usuario = textBox1.Text;
            contrasena = textBox2.Text;
            string comando = "select Count (*) From Personal where User_Name = '" + usuario + "' AND Contrasena = '" + contrasena + "'";
            conexion = new ConexionSQL();
            
            return conexion.ExisteConsulta(comando);
           
        }
    }
}
