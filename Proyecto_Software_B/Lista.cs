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
    public partial class Lista : Form
    {
        private int idProv;
        public int ID_Prov { get { return idProv; } }
        public Lista()
        {
            InitializeComponent();
        }

        private void Lista_Load(object sender, EventArgs e)
        {

            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Log_In.ConexionSQL csq = new Log_In.ConexionSQL();
            string query = "Select ID_Provedor, Nombre, Direccion, Telefono, RFC, TipoProducto From Provedores";
            csq.UpdateDataGrid(this.dataGridView1, query);

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            idProv = (int) dataGridView1.CurrentRow.Cells[0].Value;
            this.Close();

        }

        private void Cancear_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }



    }
}
