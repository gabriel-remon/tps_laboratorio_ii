using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Biblioteca.Productos;


namespace Forms
{
    public partial class ListaProductos : Form
    {
        private Ferreteria ferreteria;

        public ListaProductos(Ferreteria ferreteria)
        {
            InitializeComponent();
            this.ferreteria = ferreteria;
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            this.listProdcutos.DataSource = ferreteria.Productos;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.listProdcutos.DataSource = this.ferreteria.FiltrarProductos(txtCodigo.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listProdcutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listProdcutos_DoubleClick(object sender, EventArgs e)
        {

            if (listProdcutos.SelectedItems.Count != 0)
            {
                NuevoStock nuevoStock = new NuevoStock(this.listProdcutos.SelectedItem as Producto);

                nuevoStock.ShowDialog();
            }
        }
    }
}
