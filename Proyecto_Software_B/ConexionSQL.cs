using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Configuration;

namespace Log_In
{
    class ConexionSQL
    {
        private SqlConnection Conexion;
        public SqlConnection sqlConexion { get { return Conexion; } }
       
        string cadenaConexion = "Data Source=DESKTOP-RKLLN5E;Initial Catalog=ISB;Integrated Security=True";
       
        public bool Conectar()
        {

            try
            {
                Conexion = new SqlConnection(cadenaConexion);
                Conexion.Open();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos");
                return false;
            }
        }


      
        public void Desconectar()
        {
            Conexion.Close();
        }

        public bool ComandoSQL(string cmd)
        {

            bool band = false;
            if (Conectar())
            {
                SqlCommand SQLComand = new SqlCommand(cmd, this.Conexion);

                try
                    
                {
                    SQLComand.ExecuteNonQuery();
                    band = true;
                   // MessageBox.Show("Operacion Exitosa", "Modificacion a la base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex, "Operacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Desconectar();
            }

            return band;

        }

        public Object ComandoEscalar(string cmd)
        {
            Object obj = null;
            if (Conectar())
            {
                try
                {
                    SqlCommand SQLComand = new SqlCommand(cmd, this.Conexion);
                    obj = SQLComand.ExecuteScalar();
                    Desconectar();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Fallo : "+e);
                }
            }
            return obj;
        }

        public void UpdateDataGrid(DataGridView dataGrid, string Query)
        {
            // conexion a la base de datos
            if (this.Conectar())
            {
                try {
                    // creacion de dataset
                    DataSet dataSet = new DataSet();

                    //Adaptador de datos
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, this.Conexion);

                    dataAdapter.Fill(dataSet, "ISB");
                    dataGrid.DataSource = dataSet;
                    dataGrid.DataMember = "ISB";
                }
                catch(Exception exc)
                {

                }
                // desconectar de la base de Datos
                this.Desconectar();

            }
        }
        /// <summary>
        /// Busca si existe algun registro con la consulta recibida
        /// </summary>
        /// <param name="consulta"> Consulta de busqueda </param>
        /// <returns>Regresa True si existe y false sino existe </returns>
        public bool ExisteConsulta(string consulta)
        {
            bool band = false;
            try
            {
                if((int)ComandoEscalar(consulta) != 0)
                {
                    band = true;
                }

            }
            catch(Exception e)
            {
            //        MessageBox.Show("Error "+e.TargetSite);
            }

            return band;
        }
    }
}
