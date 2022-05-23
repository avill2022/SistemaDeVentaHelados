using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Data.SqlClient;



namespace Proyecto_Software_B
{
    public partial class Interfaz : Form
    {
        public bool mueveFormulario;
        public Point puntoMueve;
        private string ID_Usuario;
        bool band;
        public Interfaz(string us, string tipo, string idUsu)
        {
            InitializeComponent();
            txUsuario.Text = us;
            txPermiso.Text = tipo;
            ID_Usuario = idUsu;
            band = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
            _Inicio.Visible = true;
            this.LimpiaControles();
            Usuario u = new Usuario();
            u.UpdateUsuarios(dataGridUsuarios);

            _GraficaVentas.Series[0].LegendText = "Paletas";
            _GraficaVentas.Series.Add("Helados");
            _GraficaVentas.Series.Add("Bebidas");
            _GraficaVentas.Series.Add("Botanas");
           
        }
        #region Codigo de Barras
        private void txCodigoTexto_TextChanged(object sender, EventArgs e)
        {
            if (txCodigoTexto.Text.Length == 10)
            {
                //Valida si existe el producto
                this.codigo128("A" + txCodigoTexto.Text + "B");
            }
            else
            {
                CodigoDeBarras.Image = null;
            }
        }
        private void codigo128(String _Code)
        {
            BarcodeCodabar barcode = new BarcodeCodabar();
            barcode.StartStopText = true;
            barcode.BarHeight = 44;
            barcode.Code = _Code;
            Bitmap bm = new System.Drawing.Bitmap(barcode.CreateDrawingImage(Color.Black, Color.White));

            System.Drawing.Image bmT = new Bitmap(bm.Width, bm.Height + 15);
            Graphics g = Graphics.FromImage(bmT);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, bm.Width, bm.Height + 15);

            System.Drawing.Font pintarTexto = new System.Drawing.Font("Arial", 8);
            SolidBrush brocha = new SolidBrush(Color.Black);

            SizeF stringSize = new SizeF();
            stringSize = g.MeasureString(_Code, pintarTexto);
            Single centrox = (bm.Width - stringSize.Width) / 2;
            Single x = centrox;
            Single y = bm.Height;

            StringFormat drawformat = new StringFormat();
            drawformat.FormatFlags = StringFormatFlags.NoWrap;
            g.DrawImage(bm, 0, 0);

            String ncode = _Code.Substring(1, _Code.Length - 2);
            g.DrawString(ncode, pintarTexto, brocha, x, y, drawformat);
            CodigoDeBarras.Image = bmT;
        }
        #endregion

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

        private void clearControles(Control control)
        {
            foreach (var c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }
        #region Botones que seleccionan el tipo de producto
        private void Paletas_Click(object sender, EventArgs e)
        {
            ListaProductos lista = new ListaProductos(this,"Paleta");         
            lista.Show();
        }
        private void Helados_Click(object sender, EventArgs e)
        {
            ListaProductos lista = new ListaProductos(this, "Helado");
            lista.Show();
        }
        private void Bebidas_Click(object sender, EventArgs e)
        {
            ListaProductos lista = new ListaProductos(this, "Bebida");
            lista.Show();
        }
        private void Botanas_Click(object sender, EventArgs e)
        {
            ListaProductos lista = new ListaProductos(this, "Botana");
            lista.Show();
        }
        #endregion
        #region Botones de menu
        private void Inicio_Click(object sender, EventArgs e)
        {
            this.LimpiaControles();
            _Usuarios.Visible = false;
            _Usuarios.Visible = false;
            _Ventas.Visible = false;
            _Inicio.Visible = true;
            _Productos.Visible = false;
            _Provedores.Visible = false;

        }

        private void Administracion_Click(object sender, EventArgs e)
        {
            this.LimpiaControles();
            _Usuarios.Visible = false;
            _Usuarios.Visible = true;
            _Provedores.Visible = false;
            _Ventas.Visible = false;
            _Inicio.Visible = false;
            _Productos.Visible = false;
            Usuario us = new Usuario();
            us.UpdateUsuarios(dataGridUsuarios);
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            this.LimpiaControles();
            _Usuarios.Visible = false;
            _Usuarios.Visible = false;
            _Ventas.Visible = true;
            _Inicio.Visible = false;
            _Provedores.Visible = false;
            _Productos.Visible = false;
            cargaDatosGrafica();
        }

        private void Productos_Click(object sender, EventArgs e)
        {
            this.LimpiaControles();
            _Productos.Visible = true;
            _Usuarios.Visible = false;
            _Usuarios.Visible = false;
            _Ventas.Visible = false;
            _Inicio.Visible = false;
            _Provedores.Visible = false;
        }

        private void Provedores_Click(object sender, EventArgs e)
        {
            this.LimpiaControles();
            _Usuarios.Visible = false;
            _Productos.Visible = false;
            _Usuarios.Visible = false;
            _Ventas.Visible = false;
            _Inicio.Visible = false;
            _Provedores.Visible = true;

            Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
            string query = "Select ID_Provedor, Nombre, Direccion, Telefono, RFC, TipoProducto From Provedores ";
            csql.UpdateDataGrid(this.dataGridView1, query);
        }
        private void bSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
        #endregion
        private void Inventario_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from Provedores";
            Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
            object obj = csql.ComandoEscalar(query);
            if (obj != null && (int)obj > 0)
            {
                Inventario formInve = new Inventario();
                formInve.ShowDialog();
            }
            else
            {
                MessageBox.Show(" No hay provedores Registrados ");
            }
        }

        private void txCodigoTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char)Keys.Enter && txCodigoTexto.Text.Length==10)
             {
                //Busca el producto con clave:  txCodigoTexto.Text
                Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
                string query = "Select ID_Producto From Productos where CodigoProducto = '" + txCodigoTexto.Text + "'";
                object d1,d2,d3;
                if (csql.ExisteConsulta(query) == true)
                {
                    query = "Select NombreProducto, CodigoProducto, Tipo, Precio From Productos where CodigoProducto = '" + txCodigoTexto.Text + "'";
                    d1 = csql.ComandoEscalar(query);
                    
                    query = "Select  Tipo From Productos where CodigoProducto = '" + txCodigoTexto.Text + "'";
                    d2 = csql.ComandoEscalar(query);

                    query = "Select Precio From Productos where CodigoProducto = '" + txCodigoTexto.Text + "'";
                    d3 = csql.ComandoEscalar(query);
                    
                    query = "insert into TempVentas (NombreProducto, CodigoProducto, Tipo, Precio ) values ('" + d1.ToString() + "' , '"+ txCodigoTexto.Text.ToString() + "' ,'" + d2.ToString() + "' , '" + d3.ToString() + "')";
                    csql.ComandoSQL(query);

                    query = "select TempVentas.NombreProducto,TempVentas.CodigoProducto, Precio, Tipo, count(NombreProducto) as Total, precio * count(NombreProducto) as Subtotal from TempVentas group by CodigoProducto, NombreProducto, Precio, Tipo";

                    csql.UpdateDataGrid(ProductosCarrito, query);


                    query = "select sum(Precio) from TempVentas";
                    txTotal.Text = csql.ComandoEscalar(query).ToString();

                }
                else
                {
                    MessageBox.Show("No existe el Producto ");
                }
                    txCodigoTexto.Text="";
                //Se agrega a el grid ProductosCarrito
            }
        }

        private void ProductosCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txCodigoTexto.Text = ProductosCarrito.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void BbuscaProducto_Click(object sender, EventArgs e)
        {
            Log_In.ConexionSQL Conexion = new Log_In.ConexionSQL();
            
                try
                {
                    // conexion a la base de datos
                    if (Conexion.Conectar())
                    {
                        // creacion de dataset
                        DataSet dataSet = new DataSet();
                        string Query = "select ID_Producto, NombreProducto, CodigoProducto, Existencias, Tipo, Precio from Productos where CodigoProducto = '" + txBcodigo.Text + "' OR NombreProducto ='" + txBNombre.Text + "' OR Tipo = '" + txBTipoProducto.Text + "'";
                        //Adaptador de datos
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, Conexion.sqlConexion);

                        dataAdapter.Fill(dataSet, "ISB");

                        dataGridProductos.DataSource = dataSet;
                        dataGridProductos.DataMember = "ISB";
                        // desconectar de la base de Datos
                        Conexion.Desconectar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            
            
        }
        
        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String id = dataGridProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                string qry = "Select * from Productos where ID_Producto = '" + id + "'";

                Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
                try {
                    if (conexion.ExisteConsulta(qry))
                    {
                        qry = "Select Imagen from Productos where ID_Producto = '" + id + "'";
                        // El campo productImage primero se almacena en un buffer
                        byte[] imageBuffer = (byte[])conexion.ComandoEscalar(qry);
                        // Se crea un MemoryStream a partir de ese buffer
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        // Se utiliza el MemoryStream para extraer la imagen
                        this.ImageProducto.Image = System.Drawing.Image.FromStream(ms); 
                        //se busca el producto y se iguala la imagen:  imageProducto.Image
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }

        #region movimiento de ventana
        private void Interfaz_MouseDown(object sender, MouseEventArgs e)
        {
            mueveFormulario = true;
            puntoMueve = new Point(Cursor.Position.X-Location.X,Cursor.Position.Y-Location.Y);
        }

        private void Interfaz_MouseMove(object sender, MouseEventArgs e)
        {
            if (mueveFormulario)
            {
                this.Location = new Point(Cursor.Position.X - puntoMueve.X, Cursor.Position.Y- puntoMueve.Y);
            }
        }
        
        private void Interfaz_MouseUp(object sender, MouseEventArgs e)
        {
            mueveFormulario = false;
        }
        #endregion

        private void ClearCarritoCompras()
        {
            Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
            csql.ComandoSQL("delete  from TempVentas");
            csql.UpdateDataGrid(ProductosCarrito, "select TempVentas.NombreProducto,TempVentas.CodigoProducto, Precio, Tipo, count(NombreProducto) as Total, precio * count(NombreProducto) as Subtotal from TempVentas group by CodigoProducto, NombreProducto, Precio, Tipo");
        }


        public void agregaProductosaCarrito(List<String> listaCodigo)
        {
            //ProductosCarrito.Rows.Clear();
            //se buscan los productos por codigo y se llena el grid ProductosCarrito
            //Tambien suma el total y lo pone en el texview 
            object d1, d2, d3, d4, d5;
            Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
            string query;
            foreach (String s in listaCodigo)
            {
                band = true;
                query = "Select NombreProducto, CodigoProducto, Tipo, Precio From Productos where CodigoProducto = '" + s + "'";
                d1 = csql.ComandoEscalar(query);


                query = "Select  Tipo From Productos where CodigoProducto = '" + s + "'";
                d2 = csql.ComandoEscalar(query);

                query = "Select Precio From Productos where CodigoProducto = '" + s + "'";
                d3 = csql.ComandoEscalar(query);


                query = "insert into TempVentas (NombreProducto, CodigoProducto, Tipo, Precio ) values ('" + d1.ToString() + "' , '" + s + "' ,'" + d2.ToString() + "' , '" + d3.ToString() + "')";
                csql.ComandoSQL(query);

                query = "select TempVentas.NombreProducto,TempVentas.CodigoProducto, Precio, Tipo, count(NombreProducto) as Total, precio * count(NombreProducto) as Subtotal from TempVentas group by CodigoProducto, NombreProducto, Precio, Tipo";

                csql.UpdateDataGrid(ProductosCarrito, query);


                query = "select sum(Precio) from TempVentas";
                txTotal.Text = csql.ComandoEscalar(query).ToString();
                band = false;
            }
        }



        private void NuevaVenta()
        {
            Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();
            conexion.Conectar();
            SqlCommand SQLComand = new SqlCommand();
            SQLComand.Connection = conexion.sqlConexion;
            SQLComand.CommandText = "INSERT INTO Ventas VALUES(@ID_Empleado, @Fecha, @Total)";

            SQLComand.Parameters.Add("@ID_Empleado", System.Data.SqlDbType.Int);
            SQLComand.Parameters.Add("@Fecha", System.Data.SqlDbType.DateTime);
            SQLComand.Parameters.Add("@Total", System.Data.SqlDbType.Float);


            SQLComand.Parameters["@ID_Empleado"].Value = int.Parse(ID_Usuario);
            SQLComand.Parameters["@Fecha"].Value = DateTime.Now.ToString("yyyy-MM-dd");
            SQLComand.Parameters["@Total"].Value = float.Parse(txTotal.Text);
            
            SQLComand.ExecuteNonQuery();
            conexion.Desconectar();
 
            try {
                int max = (int)conexion.ComandoEscalar("select max(ID_Venta) from Ventas"); // obtiene el ultimo registro
                
                this.DetalleVenta(max, conexion);
            }
            catch(Exception exc)
            {
                MessageBox.Show("" + exc);
            }

        }

        private void DetalleVenta(int numVenta, Log_In.ConexionSQL csql)
        {
            int id_producto;
            object obj;
            string query;
            for(int i = 0; i< ProductosCarrito.Rows.Count; i++)
            {
                if(ProductosCarrito.Rows[i].Cells[0].Value != null)
                {
                    
                    obj = csql.ComandoEscalar("select ID_Producto From Productos where CodigoProducto =  " + ProductosCarrito.Rows[i].Cells[1].Value.ToString());
                    if (obj != null)
                    {
                        id_producto = (int)obj;
                        query = "insert into DetalleVenta (ID_Venta, ID_Producto, Precio, Cantidad, Subtotal) values ('";
                        query += numVenta.ToString() +"', '";
                        query += id_producto.ToString() + "' , '";
                        query += ProductosCarrito.Rows[i].Cells[2].Value.ToString() + "' , '";
                        query += ProductosCarrito.Rows[i].Cells[4].Value.ToString() + "' , '";
                        query += ProductosCarrito.Rows[i].Cells[5].Value.ToString() + "' )";

                        csql.ComandoSQL(query);
                    }
                    
                }
            }
        }

        private void btProveedores_Click(object sender, EventArgs e)
        {
            Proveedores p = new Proveedores();
            p.ShowDialog();
            string query;
            Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
            query = "Select ID_Provedor, Nombre, Direccion, Telefono, RFC, TipoProducto From Provedores ";
            csql.UpdateDataGrid(this.dataGridView1, query);
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            Usuario us = new Usuario();
            us.UpdateUsuarios(dataGridUsuarios);
            
            u.ShowDialog();
            us.UpdateUsuarios(dataGridUsuarios);
        }
        private void Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                txCodigoTexto.Text = "";

                NuevaVenta();
                ClearCarritoCompras();
                txTotal.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font f = new System.Drawing.Font("Arial", 10);
            int i;
            e.Graphics.DrawString(txUsuario.Text, f, new SolidBrush(Color.Black), new Point(10, 10));
            e.Graphics.DrawString(txPermiso.Text , f, new SolidBrush(Color.Black), new Point(350, 10));
            //e.Graphics.DrawImage(, new Point(10, 100));
            e.Graphics.DrawString("Producto" + "\t" + "Cantidad" + "\t" + "Precio Unitario" + "\t" + "Subtotal", f, new SolidBrush(Color.Black), new Point(10, 100));
            if (ProductosCarrito.Rows.Count >= 0)
            {
                for (i = 0; i < ProductosCarrito.Rows.Count; i++)
                {
                    e.Graphics.DrawString(ProductosCarrito.Rows[i].Cells[0].Value.ToString() + "\t" + ProductosCarrito.Rows[i].Cells[4].Value.ToString() + "\t" + ProductosCarrito.Rows[i].Cells[2].Value.ToString() + "\t" + ProductosCarrito.Rows[i].Cells[5].Value.ToString(), f, new SolidBrush(Color.Black), new Point(10, 100 + 50 * (i + 1)));

                }
                e.Graphics.DrawString("Total  " + "\t" + "  " + "\t" + " "+ "\t" + txTotal.Text, f, new SolidBrush(Color.Black), new Point(10, 100 + 50 * (i + 1)));
            }
            e.Graphics.DrawString(Calendario.TodayDate.ToString(), f, new SolidBrush(Color.Black), new Point(800, 10));
        }
        public void cargaDatosGrafica()
        {
            //_GraficaVentas.ChartAreas[0].Area3DStyle.Enable3D = true;_

            try
            {
                Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
                int d = (int)csql.ComandoEscalar("Select Count(*) from Productos as P inner join DetalleVenta as D on D.ID_Producto = P.ID_Producto where P.Tipo = 'Paleta'");
                _GraficaVentas.Series[0].Points.AddXY(10, d);  // paletas

                d = (int)csql.ComandoEscalar("Select Count(*) from Productos as P inner join DetalleVenta as D on D.ID_Producto = P.ID_Producto where P.Tipo = 'Helado'");
                _GraficaVentas.Series[1].Points.AddXY(20, d);

                d = (int)csql.ComandoEscalar("Select Count(*) from Productos as P inner join DetalleVenta as D on D.ID_Producto = P.ID_Producto where P.Tipo = 'Bebida'");
                _GraficaVentas.Series[2].Points.AddXY(30, d);

                d = (int)csql.ComandoEscalar("Select Count(*) from Productos as P inner join DetalleVenta as D on D.ID_Producto = P.ID_Producto where P.Tipo = 'Botana'");
                _GraficaVentas.Series[3].Points.AddXY(40, d);

            }
            catch(Exception exc)
            {

                MessageBox.Show("Error en la BD");
                _GraficaVentas.Series[0].Points.AddXY(10, 0);
                _GraficaVentas.Series[1].Points.AddXY(20, 0);
                _GraficaVentas.Series[2].Points.AddXY(30, 0);
                _GraficaVentas.Series[3].Points.AddXY(40, 0);
            }


        }
        private void btReporte_Click(object sender, EventArgs e)
        {

            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.Show();
        }

        private void ImprimirReporte_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font f = new System.Drawing.Font("Arial", 10);
            e.Graphics.DrawString(txUsuario.Text + "Aqui va el nombre de Usuario", f, new SolidBrush(Color.Black), new Point(10, 10));
            e.Graphics.DrawString(txPermiso.Text + "Aqui va el tipo de Usuario", f, new SolidBrush(Color.Black), new Point(350, 10));
            //e.Graphics.DrawImage(, new Point(10, 100));
            e.Graphics.DrawString(Calendario.TodayDate.ToString(), f, new SolidBrush(Color.Black), new Point(800, 10));
        }

        private void dataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txUser_Name.Text = this.dataGridUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                txTipo_Usuario.Text = this.dataGridUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
            }

        }

        /// <summary>
        ///  Click en los datos de Provedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txNomProv.Text= this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txRFC.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txTipoProdProv.Text = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string qry = "Select * from Provedores where ID_Provedor = '" + id + "'";
                Log_In.ConexionSQL conexion = new Log_In.ConexionSQL();

                try
                {
                    if (conexion.ExisteConsulta(qry))
                    {
                        qry = "Select Logo from Provedores where ID_Provedor = '" + id + "'";
                        // El campo productImage primero se almacena en un buffer
                        byte[] imageBuffer = (byte[])conexion.ComandoEscalar(qry);
                        // Se crea un MemoryStream a partir de ese buffer
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        // Se utiliza el MemoryStream para extraer la imagen
                        this.LogoProv.Image = System.Drawing.Image.FromStream(ms);
                        //se busca el producto y se iguala la imagen:  imageProducto.Image
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }

        }

        private void ProductosCarrito_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            if (band == false)
            {
                band = true;
                string query;
                Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
                query = "select TempVentas.NombreProducto,TempVentas.CodigoProducto, Precio, Tipo, count(NombreProducto) as Total, precio * count(NombreProducto) as Subtotal from TempVentas group by CodigoProducto, NombreProducto, Precio, Tipo";

                csql.UpdateDataGrid(ProductosCarrito, query);


                query = "select sum(Precio) from TempVentas";
                txTotal.Text = csql.ComandoEscalar(query).ToString();
                band = false;

            }
        }

        private void ProductosCarrito_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar =='\b' && band == false && ProductosCarrito.CurrentRow.Cells[1].Value != null)
            {
                band = true;
                
                Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
                string query = "delete top(1) from TempVentas where CodigoProducto = '" + ProductosCarrito.CurrentRow.Cells[1].Value.ToString() + "'";
                csql.ComandoSQL(query);
                query = "select TempVentas.NombreProducto,TempVentas.CodigoProducto, Precio, Tipo, count(NombreProducto) as Total, precio * count(NombreProducto) as Subtotal from TempVentas group by CodigoProducto, NombreProducto, Precio, Tipo";

                csql.UpdateDataGrid(ProductosCarrito, query);


                query = "select sum(Precio) from TempVentas";
                txTotal.Text = csql.ComandoEscalar(query).ToString();
                band = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LimpiaControles()
        {
            



        }

        private void MasDatos_Click(object sender, EventArgs e)
        {
            
            string inicio = timeInicio.Value.Date.ToString("yyyy-MM-dd");
            string fin = timeFin.Value.Date.ToString("yyyy-MM-dd");
            string cad = " And Fecha >= '"+inicio+"' And  Fecha <= '"+fin+"' ";
            try
            {
                Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
                int d = (int)csql.ComandoEscalar("Select Count(*) from Productos as P inner join DetalleVenta as D on D.ID_Producto = P.ID_Producto inner join Ventas as V on V.ID_Venta = D.ID_Venta where P.Tipo = 'Paleta' " + cad);
                _GraficaVentas.Series[0].Points.AddXY(10, d);  // paletas

                d = (int)csql.ComandoEscalar("Select Count(*) from Productos as P inner join DetalleVenta as D on D.ID_Producto = P.ID_Producto inner join Ventas as V on V.ID_Venta = D.ID_Venta where P.Tipo = 'Helado'" + cad);
                _GraficaVentas.Series[1].Points.AddXY(20, d);

                d = (int)csql.ComandoEscalar("Select Count(*) from Productos as P inner join DetalleVenta as D on D.ID_Producto = P.ID_Producto inner join Ventas as V on V.ID_Venta = D.ID_Venta where P.Tipo = 'Bebida'" + cad);
                _GraficaVentas.Series[2].Points.AddXY(30, d);

                d = (int)csql.ComandoEscalar("Select Count(*) from Productos as P inner join DetalleVenta as D on D.ID_Producto = P.ID_Producto inner join Ventas as V on V.ID_Venta = D.ID_Venta where P.Tipo = 'Botana''" + cad);
                _GraficaVentas.Series[3].Points.AddXY(40, d);

            }
            catch (Exception exc)
            {

                MessageBox.Show("Error en la BD");
                _GraficaVentas.Series[0].Points.AddXY(10, 0);
                _GraficaVentas.Series[1].Points.AddXY(20, 0);
                _GraficaVentas.Series[2].Points.AddXY(30, 0);
                _GraficaVentas.Series[3].Points.AddXY(40, 0);
            }



        }


    }
}
