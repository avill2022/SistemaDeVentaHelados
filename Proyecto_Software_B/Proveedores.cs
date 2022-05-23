using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Software_B
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void _Proveedores_Enter(object sender, EventArgs e)
        {

        }
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void ImgLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string image = openFileDialog1.FileName;
                    LogoEmpresa.Image = Image.FromFile(image);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El Archivo Seleccionado no es un tipo de imagen valido");
            }
        }

        private void BNuevoProv_Click(object sender, EventArgs e)
        {

            if (LogoEmpresa.Image != null)
            {
                if (txNombreProv.Text != "" && txCalleProv.Text != "" && txTelefono.Text != "" && txRUC.Text != "" && txTipoProducto.Text != "")
                {
                    altaProvedor(txNombreProv.Text, txCalleProv.Text, txTelefono.Text, txRUC.Text, txTipoProducto.Text);
                    
                    
                }
                else
                    MessageBox.Show("Falta uno de los campos");
            }
            else
                MessageBox.Show("El campo imagen es obligatorio");
        }


        private bool altaProvedor(string nom, string dir, string tel, string rfc, string tipoProd)
        {
            Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
            bool band = false;
            string query = "select Count (*) From Provedores where Nombre = '" + nom + "'";
            if (conexion.ExisteConsulta(query) == false)
            {

                if (conexion.Conectar())
                {
                    try
                    {

                        SqlCommand SQLComand = new SqlCommand();
                        SQLComand.Connection = conexion.sqlConexion;
                        SQLComand.CommandText = "INSERT INTO Provedores VALUES(@Nombre, @Direccion, @Telefono, @RFC, @TipoProducto, @Logo)";
                        SQLComand.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar);
                        SQLComand.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar);
                        SQLComand.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar);
                        SQLComand.Parameters.Add("@RFC", System.Data.SqlDbType.VarChar);
                        SQLComand.Parameters.Add("@TipoProducto", System.Data.SqlDbType.VarChar);
           
                        SQLComand.Parameters.Add("@Logo", System.Data.SqlDbType.Image);


                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        // Se guarda la imagen en el buffer
                        this.LogoEmpresa.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        SQLComand.Parameters["@Nombre"].Value = nom;
                        SQLComand.Parameters["@Direccion"].Value = dir;
                        SQLComand.Parameters["@Telefono"].Value = tel;
                        SQLComand.Parameters["@RFC"].Value = rfc;
                        SQLComand.Parameters["@TipoProducto"].Value = tipoProd;
      
                        SQLComand.Parameters["@Logo"].Value = ms.GetBuffer();
                        SQLComand.ExecuteNonQuery();

                        Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
                        query = "Select ID_Provedor, Nombre, Direccion, Telefono, RFC, TipoProducto From Provedores ";
                        csql.UpdateDataGrid(this.dataGridProveedores, query);
                        LimpiaControles();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error " + ex);

                    }
                    conexion.Desconectar();
                }
            }

            return band;
           

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
            string query = "Select ID_Provedor, Nombre, Direccion, Telefono, RFC, TipoProducto From Provedores ";
            csql.UpdateDataGrid(this.dataGridProveedores, query);
        }

        private void BEliminaProv_Click(object sender, EventArgs e)
        {
            string query;
            Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
            try
            {
                int x = (int)dataGridProveedores.CurrentRow.Cells[0].Value;
                
                query = "delete from Provedores where ID_Provedor = '" + x.ToString() + "'";
                csql.ComandoSQL(query);

                
                                
            }
            catch (Exception Exc)
            {


            }
            LimpiaControles();
            query = "Select ID_Provedor, Nombre, Direccion, Telefono, RFC, TipoProducto From Provedores ";
            csql.UpdateDataGrid(this.dataGridProveedores, query);

        }

        private void BActualizaProv_Click(object sender, EventArgs e)
        {

        }

        private void LimpiaControles()
        {
            txNombreProv.Text = txCalleProv.Text = txTelefono.Text =  txRUC.Text = txTipoProducto.Text = "";
            LogoEmpresa.Image = null;
        }

    }
}
