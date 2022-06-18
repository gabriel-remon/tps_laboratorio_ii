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
            this.venta = new Venta();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                ferreteria.AgregarPedido(venta);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void listProductos_DoubleClick(object sender, EventArgs e)
        {
           // int cantidadVentas = 0;
            try
            {
                if (this.listProductos.SelectedItems.Count != 0 && this.lstClientes.SelectedItems.Count != 0)
                {
                    UnProducto nuevoStock = new UnProducto( "Ingrese la cantidad de productos a vender", this.listProductos.SelectedItem as Producto);
                   // nuevoStock.ShowDialog();
                    if(nuevoStock.ShowDialog() == DialogResult.OK)
                    {

                        //cantidadVentas = nuevoStock.NuevoStock;
                        this.venta += new Producto(this.listProductos.SelectedItem as Producto, nuevoStock.NuevoStock);
                    listPedidos.DataSource = this.venta.Productos;
                    }

                    //labInformacionCliente.Text = venta.Comprador.Mostrar();
                    labInformacionCliente.Text = venta.Comprador.Mostrar() + $"\n Total a pagar: ${this.venta.Total()}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listCleintes_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstClientes.SelectedItems.Count != 0)
            {
                venta.Comprador = this.lstClientes.SelectedItem as Cliente;
                labInformacionCliente.Text = venta.Comprador.Mostrar() + $"\n Total a pagar: ${this.venta.Total()}";
                this.listProductos.Enabled = true;
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
