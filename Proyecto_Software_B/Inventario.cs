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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            UpdateProductos();

        }
        private void AgregaImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string image = openFileDialog1.FileName;
                    ImagenProducto.Image = Image.FromFile(image);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El Archivo Seleccionado no es un tipo de imagen valido");
            }
        }
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {

        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void prodnew_Click(object sender, EventArgs e)
        {
            if (ImagenProducto.Image != null)
            {
                if (txCodigoP.Text != "" && txExistencias.Text != "" && txNombreP.Text != "" && txPrecio.Text != "" && txProveedor.Text != "" && txTipoProducto.Text != "")
                {
                    if (txCodigoP.Text.Length == 10)
                    {
                        //Agrega un producto a la tabla
                        if (validaCodigoUnico(txCodigoP.Text))
                        {
                            agregaProductoNuevo(txCodigoP.Text, txExistencias.Text, txNombreP.Text, txPrecio.Text, txProveedor.Text, txTipoProducto.Text);
                            limpiaControles();
                        }
                        else
                            MessageBox.Show("El codigo de producto no puede repetirse");
                    }
                    else
                        MessageBox.Show("El código del producto debe ser de 8 digitos");
                }else
                    MessageBox.Show("Falta uno de los campos");
            }
            else
                MessageBox.Show("El campo imagen es obligatorio");
        }

        // coloca los datos en el formulario
        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
            if (e.RowIndex >= 0)
            {
                String id = dataGridProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                string qry = "Select * from Productos where ID_Producto = '" + id + "'";
                txNombreP.Text = dataGridProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txCodigoP.Text = dataGridProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txExistencias.Text = dataGridProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txProveedor.Text = dataGridProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txPrecio.Text = dataGridProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txTipoProducto.Text = dataGridProductos.Rows[e.RowIndex].Cells[4].Value.ToString();

                Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
                try
                {
                    if (conexion.ExisteConsulta(qry))
                    {
                        qry = "Select Imagen from Productos where ID_Producto = '" + dataGridProductos.Rows[e.RowIndex].Cells[0].Value.ToString()+"'";
                        // El campo productImage primero se almacena en un buffer
                        byte[] imageBuffer = (byte[])conexion.ComandoEscalar(qry);
                        // Se crea un MemoryStream a partir de ese buffer
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        // Se utiliza el MemoryStream para extraer la imagen
                        this.ImagenProducto.Image = System.Drawing.Image.FromStream(ms);
                        //se busca el producto y se iguala la imagen:  imageProducto.Image
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }


            }
        }
        //Abre la baase de datos y busca un producto coneste codigo, si existe uno retorna falso la clave unica no se puede repetir
        public bool validaCodigoUnico(String codigo)
        {
            return true;
        }
        public bool agregaProductoNuevo(String codigo,String existencias,String nombre,String precio,String proveedor,String tipoProducto)
        {
            
            Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
            bool band = false;
            string query = "select Count (*) From Productos where NombreProducto = '" + nombre + "' AND  CodigoProducto = '"+codigo+"'";
            if (conexion.ExisteConsulta(query) == false)
            {

                if (conexion.Conectar())
                {
                    try {

                        SqlCommand SQLComand = new SqlCommand();
                        SQLComand.Connection = conexion.sqlConexion;
                        SQLComand.CommandText = "INSERT INTO Productos VALUES(@NombreProducto, @CodigoProducto, @Existencias, @ID_Provedor, @Precio, @Tipo, @Imagen)";
                        SQLComand.Parameters.Add("@NombreProducto", System.Data.SqlDbType.NVarChar);
                        SQLComand.Parameters.Add("@CodigoProducto", System.Data.SqlDbType.Int);
                        SQLComand.Parameters.Add("@Existencias", System.Data.SqlDbType.Int);
                        SQLComand.Parameters.Add("@ID_Provedor", System.Data.SqlDbType.Int);
                        SQLComand.Parameters.Add("@Precio", System.Data.SqlDbType.Float);
                        SQLComand.Parameters.Add("@Tipo", System.Data.SqlDbType.NVarChar);
                        SQLComand.Parameters.Add("@Imagen", System.Data.SqlDbType.Image);


                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        // Se guarda la imagen en el buffer
                        this.ImagenProducto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        SQLComand.Parameters["@NombreProducto"].Value = nombre;
                        SQLComand.Parameters["@CodigoProducto"].Value = int.Parse(codigo);
                        SQLComand.Parameters["@Existencias"].Value = int.Parse(existencias);
                        SQLComand.Parameters["@ID_Provedor"].Value = int.Parse(proveedor);
                        SQLComand.Parameters["@Precio"].Value = float.Parse(precio);
                        SQLComand.Parameters["@Tipo"].Value = tipoProducto;
                        SQLComand.Parameters["@Imagen"].Value = ms.GetBuffer();
                        SQLComand.ExecuteNonQuery();

                        MessageBox.Show("Registro de producto Correcto");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error " + ex);

                    }
                    this.UpdateProductos();
                    conexion.Desconectar();
                }
            }

                return band;
           
        }

        /// <summary>
        /// Busca y actualiza la informacion del producto
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="existencias"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="proveedor"></param>
        /// <param name="tipoProducto"></param>
        public bool actualizaProducto(String codigo, String existencias, String nombre, String precio, String proveedor, String tipoProducto, string id_prod)
        {
            Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
            bool band = false;

            
            string query = "select Count (*) From Productos where NombreProducto = '" + nombre + "' AND  CodigoProducto = '" + codigo + "'";
            if (conexion.ExisteConsulta(query) == false)
            {

                if (conexion.Conectar())
                {
                    try
                    {

                        SqlCommand SQLComand = new SqlCommand();
                        SQLComand.Connection = conexion.sqlConexion;
                        SQLComand.CommandText = "Update Productos Set NombreProducto = @NombreProducto, CodigoProducto = @CodigoProducto, Existencias = @Existencias, ID_Provedor = @ID_Provedor, Precio = @Precio,Tipo = @Tipo, Imagen = @Imagen where  ID_Producto = '" + id_prod + "'";
                        SQLComand.Parameters.Add("@NombreProducto", System.Data.SqlDbType.NVarChar);
                        SQLComand.Parameters.Add("@CodigoProducto", System.Data.SqlDbType.Int);
                        SQLComand.Parameters.Add("@Existencias", System.Data.SqlDbType.Int);
                        SQLComand.Parameters.Add("@ID_Provedor", System.Data.SqlDbType.Int);
                        SQLComand.Parameters.Add("@Precio", System.Data.SqlDbType.Float);
                        SQLComand.Parameters.Add("@Tipo", System.Data.SqlDbType.NVarChar);
                        SQLComand.Parameters.Add("@Imagen", System.Data.SqlDbType.Image);


                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        // Se guarda la imagen en el buffer
                        this.ImagenProducto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        SQLComand.Parameters["@NombreProducto"].Value = nombre;
                        SQLComand.Parameters["@CodigoProducto"].Value = int.Parse(codigo);
                        SQLComand.Parameters["@Existencias"].Value = int.Parse(existencias);
                        SQLComand.Parameters["@ID_Provedor"].Value = int.Parse(proveedor);
                        SQLComand.Parameters["@Precio"].Value = float.Parse(precio);
                        SQLComand.Parameters["@Tipo"].Value = tipoProducto;
                        SQLComand.Parameters["@Imagen"].Value = ms.GetBuffer();
                        SQLComand.ExecuteNonQuery();

                        MessageBox.Show("Registro de producto Correcto");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error " + ex);

                    }
                    this.UpdateProductos();
                    conexion.Desconectar();
                }
            }

            return band;
            //busca el producto y lo actualiza
        }
        public void eliminaProducto(String codigo)
        {

        }

        private void _Usuarios_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateProductos()
        {
            Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
            if (conexion.Conectar())
            {
                string Query = "select ID_Producto, NombreProducto, CodigoProducto, Existencias, Tipo, Precio from Productos";
                conexion.UpdateDataGrid(this.dataGridProductos, Query);
                conexion.Desconectar();
            }
        }

        
        
        private void updateProducto()
        {

            
                if(dataGridProductos.CurrentRow.Cells[0].Value != null)
                {
                    string id = dataGridProductos.CurrentRow.Cells[0].Value.ToString();
                    actualizaProducto(txCodigoP.Text, txExistencias.Text, txNombreP.Text, txPrecio.Text, txProveedor.Text, txTipoProducto.Text, id);
                }
        }

        private void deletprod_Click(object sender, EventArgs e)
        {
            
            string cad = "";
            if (this.dataGridProductos.CurrentRow.Cells[0].Value != null)
            {
                cad = dataGridProductos.CurrentRow.Cells[0].Value.ToString();
                string query = "delete from Productos where ID_Producto = '" + cad + "'";
                Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
                csql.ComandoSQL(query);
                UpdateProductos();
                limpiaControles();
            }
        }

        private void updatprod_Click(object sender, EventArgs e)
        {
            updateProducto();
            limpiaControles();
        }

        private void BProvedores_Click(object sender, EventArgs e)
        {
            Lista l = new Lista();
            l.ShowDialog();
            if(l.DialogResult == DialogResult.OK)
            {
                txProveedor.Text = l.ID_Prov.ToString();

            }
            else
            {

            }

        }


        private void limpiaControles()
        {
            txCodigoP.Text = txExistencias.Text = txNombreP.Text = txPrecio.Text = txProveedor.Text = txTipoProducto.Text = "";
            ImagenProducto.Image = null;
            
        }
    }
}
