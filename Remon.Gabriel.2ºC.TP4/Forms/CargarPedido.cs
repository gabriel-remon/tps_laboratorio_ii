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
        private Ferreteria ferreteria;
        private Venta venta;
        

        public CargarPedido(Ferreteria ferreteria)
        {
            InitializeComponent();
            this.ferreteria = ferreteria;
            this.venta = new Venta();
        }

        public CargarPedido(Ferreteria ferreteria, Cliente? cliente)
            :this(ferreteria)
        {
            this.venta.Comprador = cliente;
            this.lstClientes.Visible = false;
            this.listProductos.Enabled = true;
            this.textDniClientes.Visible = false;
            this.ActuaizarPedido();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.venta.Comprador is null)
                {
                    MessageBox.Show("Ingrese un cliente Para realizar el pedido");
                }
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
            try
            {
                if (this.listProductos.SelectedItems.Count != 0)
                {
                    UnProducto unProducto = new UnProducto( "Ingrese la cantidad de productos a vender", this.listProductos.SelectedItem as Producto);

                    if(unProducto.ShowDialog() == DialogResult.OK)
                    {
                        this.venta += new Producto(this.listProductos.SelectedItem as Producto, unProducto.NuevoStock);
                        this.ActuaizarPedido();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// selecciona un cliente de la lista y lo carga a la venta como el comprador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listCleintes_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstClientes.SelectedItems.Count != 0)
            {
                venta.Comprador = this.lstClientes.SelectedItem as Cliente;
                labInformacionCliente.Text = venta.Comprador.Mostrar() + $"\n Total a pagar: {this.venta.Total()}";
                this.listProductos.Enabled = true;
            }
        }

        /// <summary>
        /// al ingresar una letra en el textBox productos actualiza la lista productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textCodigoProducto_TextChanged(object sender, EventArgs e)
        {

            this.listProductos.DataSource = ferreteria.FiltrarProductos(textCodigoProducto.Text);
        }
        /// <summary>
        /// al ingresar una letra en el textBox clientes actualiza la lista clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textDniClientes_TextChanged(object sender, EventArgs e)
        {
            lstClientes.DataSource = ferreteria.FiltrarClientes(textDniClientes.Text);
        }

        private void CargarPedido_Load(object sender, EventArgs e)
        {
            lstClientes.DataSource = ferreteria.Clientes;
            listProductos.DataSource = ferreteria.Productos;
            listPedidos.DataSource = null;
        }

        /// <summary>
        /// Activa evento doble click de la lista de pedidos y pregunta si se  
        /// desea eliminar el articulo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listPedidos_DoubleClick(object sender, EventArgs e)
        {
            if (this.listPedidos.SelectedItems.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Desea eliminar este articulo del pedido?","Modificar pedido"
                                                            , MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(dialogResult == DialogResult.Yes)
                {
                    this.venta -= this.listPedidos.SelectedItem as Producto;
                    //this.listPedidos.DataSource = this.venta.Productos;

                    this.ActuaizarPedido();

                }
            }
        }

        private void ActuaizarPedido()
        {
            this.listPedidos.Items.Clear();
            foreach (Producto p in this.venta.Productos)
            {
                this.listPedidos.Items.Add(p);
            }
            labInformacionCliente.Text = venta.Comprador.Mostrar() + $"\n Total a pagar: ${this.venta.Total()}";
        }


    }
}
