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
    public partial class ListaProductos : Form
    {
        Interfaz Forma;
        String tipoProducto;
        public ListaProductos(Interfaz forma,String _tipoProducto)
        {
            InitializeComponent();
            Forma = forma;
            tipoProducto = _tipoProducto;
            //Se buscan los productos por tipo y se agregan a el grid Productos
        }

        private void Cancear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productos_SelectionChanged(object sender, EventArgs e)
        {
            int datos = Productos.Rows.GetRowCount(DataGridViewElementStates.Selected);
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            /*
            Productos.Rows.Add("Nombre", "Codigo", "Existencias", "Proveedor", "Precio","Tipo","Imagen");
            Productos.Rows.Add("Nombre", "4532345", "Existencias", "Proveedor", "Precio", "Tipo", "Imagen");
            Productos.Rows.Add("Nombre", "5454323", "Existencias", "Proveedor", "Precio", "Tipo", "Imagen");
            Productos.Rows.Add("Nombre", "5422234", "Existencias", "Proveedor", "Precio", "Tipo", "Imagen");
            Productos.Rows.Add("Nombre", "23454443", "Existencias", "Proveedor", "Precio", "Tipo", "Imagen");
            Productos.Rows.Add("Nombre", "5234555", "Existencias", "Proveedor", "Precio", "Tipo", "Imagen");
            */
            Log_In.ConexionSQL csql = new Log_In.ConexionSQL();
            string query = "Select NombreProducto, CodigoProducto, Tipo, Precio From Productos where Tipo = '"+tipoProducto+"'";

            csql.UpdateDataGrid(Productos, query);


        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            List<String> listaProductos = new List<string>();
            for (int i = 0; i < Productos.Rows.Count; i++)
            {
                if (Productos.Rows[i].Selected == true)
                {
                    //Se agrega la clave producto ala lista 
                    listaProductos.Add(Productos.Rows[i].Cells[1].Value.ToString());
                }
            }
            Forma.agregaProductosaCarrito(listaProductos);
            this.Close();
        }
    }
}
