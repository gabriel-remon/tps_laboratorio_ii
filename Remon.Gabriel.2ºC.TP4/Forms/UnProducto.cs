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

namespace Forms
{
    public partial class UnProducto : Form
    {
        Producto producto;
        public UnProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
           
        }
        /// <summary>
        /// Solo muesta los datos de stock y precio actual de un producto
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="titulo"></param>
        public UnProducto(Producto producto, string titulo)
            : this(producto)
        {
            this.btnCancelar.Visible = false;
            this.lblNuevoPrecio.Visible = false;
            this.numericPrecio.Visible = false;
            this.labStockNuevo.Visible = false;
            this.numericStock.Visible = false;
            this.Text = titulo;
            //this.labStockActual.Text = texto;

        }
        public UnProducto(string titulo, Producto producto)
            :this(producto,titulo)
        {
            this.numericStock.Visible = true;
            this.labStockNuevo.Visible = true;
            this.labStockNuevo.Text = "Cantidad solicitados =";
        }

        public int NuevoStock
        {
            get
            {
                return (int)this.numericStock.Value;
            }
        }
        public decimal NuevoPrecio
        {
            get
            {
                return this.numericPrecio.Value;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NuevoStock_Load(object sender, EventArgs e)
        {
            this.lblPrecioActual.Text = $"Precio actual = $ {this.producto.Precio.ToString()}";
            this.labStockActual.Text = $"Stock actual = {this.producto.Stock}";
            this.numericPrecio.Value = this.producto.Precio;
            this.numericStock.Value = this.producto.Stock;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
