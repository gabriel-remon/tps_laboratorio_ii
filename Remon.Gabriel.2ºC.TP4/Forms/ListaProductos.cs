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

        /// <summary>
        /// se carga la lista de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListaProductos_Load(object sender, EventArgs e)
        {
            this.listProdcutos.DataSource = ferreteria.Productos;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// cada ves que se preciona una techa en el textbox se actualiza la lista de prodcutos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.listProdcutos.DataSource = this.ferreteria.FiltrarProductos(txtCodigo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// haciendo doble click perimte cambiar los valores de stock y precio de un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listProdcutos_DoubleClick(object sender, EventArgs e)
        {
            Producto productoSeleccionado;

            if (listProdcutos.SelectedItems.Count != 0)
            {
                productoSeleccionado = this.listProdcutos.SelectedItem as Producto;
                UnProducto nuevoStock = new UnProducto(productoSeleccionado);
                nuevoStock.ShowDialog();

                if(nuevoStock.DialogResult == DialogResult.OK)
                {
                    productoSeleccionado.Precio = nuevoStock.NuevoPrecio;
                    productoSeleccionado.Stock = nuevoStock.NuevoStock;
                    this.listProdcutos.DataSource = ferreteria.Productos;
                }
            }
        }
    }
}
