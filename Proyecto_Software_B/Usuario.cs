using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Software_B
{
    class Usuario
    {

        public Usuario()
        {

        }

        public bool altaUsuario(string nom, string apPat, string apMat, string nomUsuario, string contra, string tipo, string correo, PictureBox Imagen)
        {
            Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
            bool band = false;
            string query = "select Count (*) From Personal where User_Name = '" + nomUsuario + "'";
            if (conexion.ExisteConsulta(query) == false)
            {

                try {

                    conexion.Conectar();
                    SqlCommand SQLComand = new SqlCommand();
                    SQLComand.Connection = conexion.sqlConexion;
                    SQLComand.CommandText = "INSERT INTO Personal VALUES(@Nombre, @Apellido_Paterno , @Apellido_Materno ,@User_Name, @Contrasena, @Tipo_Usuario, @Foto, @Email)";
                    SQLComand.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@Apellido_Paterno", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@Apellido_Materno", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@User_Name", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@Contrasena", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@Tipo_Usuario", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@Foto", System.Data.SqlDbType.Image);
                    SQLComand.Parameters.Add("@Email", System.Data.SqlDbType.VarChar);

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    SQLComand.Parameters["@Nombre"].Value = nom;
                    SQLComand.Parameters["@Apellido_Paterno"].Value = apPat;
                    SQLComand.Parameters["@Apellido_Materno"].Value = apMat;
                    SQLComand.Parameters["@User_Name"].Value = nomUsuario;
                    SQLComand.Parameters["@Contrasena"].Value = contra;
                    SQLComand.Parameters["@Tipo_Usuario"].Value = tipo;
                    
                    SQLComand.Parameters["@Foto"].Value = ms.GetBuffer();
                    SQLComand.Parameters["@Email"].Value = correo;
                    SQLComand.ExecuteNonQuery();
                    conexion.Desconectar();
                    band = true;
                  //  MessageBox.Show("Alta Exitosa", "Alta de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(""+ex);
                }
            }
            else
            {

                MessageBox.Show("Ya existe Registrado ese nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return band;
        }


        public void modificaUSuario(string id,string nom, string apPat, string apMat, string nomUsuario, string contra, string tipo, string correo, PictureBox Imagen)
        {
            Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
            string query = "select Count (*) From Personal where User_Name = '" + nomUsuario + "' AND ID_Usuario != '"+id+"'";
            if (conexion.ExisteConsulta(query) == false)
            {

                try
                {

                    conexion.Conectar();
                    SqlCommand SQLComand = new SqlCommand();
                    SQLComand.Connection = conexion.sqlConexion;
                    SQLComand.CommandText = "UPdate Personal Set Nombre = @Nombre, Apellido_Paterno =  @Apellido_Paterno , Apellido_Materno = @Apellido_Materno , User_Name = @User_Name, Contrasena = @Contrasena, Tipo_Usuario = @Tipo_Usuario, Foto = @Foto where ID_Usuario = '"+id+"'";
                    SQLComand.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@Apellido_Paterno", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@Apellido_Materno", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@User_Name", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@Contrasena", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@Tipo_Usuario", System.Data.SqlDbType.VarChar);
                    SQLComand.Parameters.Add("@Foto", System.Data.SqlDbType.Image);
                   

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    SQLComand.Parameters["@Nombre"].Value = nom;
                    SQLComand.Parameters["@Apellido_Paterno"].Value = apPat;
                    SQLComand.Parameters["@Apellido_Materno"].Value = apMat;
                    SQLComand.Parameters["@User_Name"].Value = nomUsuario;
                    SQLComand.Parameters["@Contrasena"].Value = contra;
                    SQLComand.Parameters["@Tipo_Usuario"].Value = tipo;

                    SQLComand.Parameters["@Foto"].Value = ms.GetBuffer();
                 
                    SQLComand.ExecuteNonQuery();
                    conexion.Desconectar();
                    
                    //  MessageBox.Show("Alta Exitosa", "Alta de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
            {

                MessageBox.Show("Ya existe Registrado ese nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        public void EliminaUsuario(string usuario)
        {
            string query = "delete from Personal where User_Name = '" + usuario+"'";
            Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
            csql.ComandoSQL(query);

        }

        public void UpdateUsuarios(DataGridView data)
        {
            Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
            string cmd = "select ID_Usuario, Nombre, Apellido_Paterno, Apellido_Materno, User_Name, Tipo_Usuario from Personal";
            conexion.UpdateDataGrid(data, cmd);
        }
    }
}
