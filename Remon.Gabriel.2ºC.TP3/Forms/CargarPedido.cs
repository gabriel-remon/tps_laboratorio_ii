using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Productos;
using Biblioteca;
using Biblioteca.Personas;


namespace Forms
{
    public partial class CargarPedido : Form
    {
        Ferreteria ferreteria;
        Venta venta;

        public CargarPedido(Ferreteria ferreteria)
        {
            InitializeComponent();
            this.ferreteria = ferreteria;
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listProductos_DoubleClick(object sender, EventArgs e)
        {
            int cantidadVentas = 0;
            try
            {
                if (this.listProductos.SelectedItems.Count != 0)
                {
                    NuevoStock nuevoStock = new NuevoStock(this.listProductos.SelectedItem as Producto, "Cantidad de productos", "Ingrese la cantidad de ventas");
                    nuevoStock.ShowDialog();

                    cantidadVentas = int.Parse(nuevoStock.TextBox);

                    venta += new Producto(this.listProductos.SelectedItem as Producto, cantidadVentas);
                    labInformacionCliente.Text = venta.Comprador.Mostrar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listCleintes_DoubleClick(object sender, EventArgs e)
        {
            if(this.lstClientes.SelectedItems.Count != 0)
            {
                venta = new Venta(this.lstClientes.SelectedItem as Cliente);
                labInformacionCliente.Text = venta.Comprador.Mostrar();
            }
        }

        private void textCodigoProducto_TextChanged(object sender, EventArgs e)
        {

            listProductos.DataSource = ferreteria.FiltrarProductos(textCodigoProducto.Text);
        }

        private void textDniClientes_TextChanged(object sender, EventArgs e)
        {
            lstClientes.DataSource = ferreteria.FiltrarClientes(textDniClientes.Text);
        }

        private void CargarPedido_Load(object sender, EventArgs e)
        {
            lstClientes.DataSource = ferreteria.Clientes;
            listProductos.DataSource = ferreteria.Productos;
        }
    }
}
