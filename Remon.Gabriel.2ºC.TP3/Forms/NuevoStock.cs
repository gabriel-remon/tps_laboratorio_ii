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
    public partial class NuevoStock : Form
    {
        Producto producto;
        public NuevoStock(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            this.labStockActual.Text = $"Precio actual = { this.producto.Precio.ToString()}";
        }

        public NuevoStock(Producto producto, string titulo,string texto)
            :this(producto)
        {
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Text = "Aceptar";
            this.Text = titulo;
            this.labStockActual.Text = texto;

        }

        public string TextBox
        {
            get
            {
                return txtStockNuevo.Text;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                producto.Precio = decimal.Parse(txtStockNuevo.Text); 
                this.lblPrecioAtual.Text = this.producto.Precio.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NuevoStock_Load(object sender, EventArgs e)
        {
            this.labStockActual.Text = $"Precio actual = { this.producto.Precio.ToString()}";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
