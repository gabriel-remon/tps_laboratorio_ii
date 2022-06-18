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

namespace Forms
{
    public partial class CargarNuevoProducto : Form
    {
        Ferreteria ferreteria;

        public CargarNuevoProducto(Ferreteria ferreteria)
        {
            InitializeComponent();
            this.ferreteria = ferreteria;   
        }

        private void btnAñador_Click(object sender, EventArgs e)
        {
            Producto  nuevoProducto = null;

            try
            {
                if (radButnOtro.Checked)
                {
                    nuevoProducto = new Producto(codigo: int.Parse(textCodigo.Text),
                                                 descripcion: textDescripcion.Text,
                                                 precio: decimal.Parse(textPrecio.Text),
                                                 cantidadStock: int.Parse(textStockActual.Text),
                                                 cantidadEstandar: int.Parse(textStockStandar.Text));
                }
                if (radButnTornillo.Checked)
                {
                    nuevoProducto = new Tornillos(codigo: int.Parse(textCodigo.Text),
                                                 precio: decimal.Parse(textPrecio.Text),
                                                 cantidadStock: int.Parse(textStockActual.Text),
                                                 cantidadEstandar: int.Parse(textStockStandar.Text),
                                                 paso: (Tornillos.Paso)cmbMetrica.SelectedItem,
                                                 tipoTornillo: (Tornillos.TipoTornillo)combTipoTornillo.SelectedItem);
                }
                if (radButnCaño.Checked)
                {
                    nuevoProducto = new Caños(codigo: int.Parse(textCodigo.Text),
                                              precio: decimal.Parse(textPrecio.Text),
                                              cantidadStock: int.Parse(textStockActual.Text),
                                              cantidadEstandar: int.Parse(textStockStandar.Text),
                                              diametro: float.Parse(textDiametro.Text),
                                              largo: float.Parse(textLargoCaño.Text),
                                              tipoCaño: (Caños.TipoCaño)combTipoCaño.SelectedItem);
                }

                string aux = ferreteria.BuscarProducto(int.Parse(textCodigo.Text));

                if (ferreteria.AgregarProductoStock(nuevoProducto))
                    MessageBox.Show("Producto cargado con exito");
                else
                    MessageBox.Show("Ya existe un producto con ese id, \n"+
                                    ferreteria.BuscarProducto(int.Parse(textCodigo.Text)));


            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void radButnCaño_CheckedChanged(object sender, EventArgs e)
        {
            textDescripcion.Enabled = false;

            EnableCaño(true);
            EnableTornillo(false);
        }

        private void radButnTornillo_CheckedChanged(object sender, EventArgs e)
        {
            textDescripcion.Enabled = false;

            EnableCaño(false);
            EnableTornillo(true);
        }

        private void radButnOtro_CheckedChanged(object sender, EventArgs e)
        {
            textDescripcion.Enabled = true;

            EnableCaño(false);
            EnableTornillo(false);
        }

        private void EnableTornillo(bool estado)
        {
            combTipoTornillo.Enabled = estado;
            textLargoTornillo.Enabled = estado;
            cmbMetrica.Enabled = estado;
        }
        private void EnableCaño(bool estado)
        {
            combTipoCaño.Enabled = estado;
            textDescripcion.Enabled = estado;
            textLargoCaño.Enabled = estado;
        }

        private void CargarNuevoProducto_Load(object sender, EventArgs e)
        {
            this.combTipoCaño.DataSource = Enum.GetValues(typeof(Biblioteca.Productos.Caños.TipoCaño));
            this.cmbMetrica.DataSource = Enum.GetValues(typeof(Biblioteca.Productos.Tornillos.Paso));
            this.combTipoTornillo.DataSource = Enum.GetValues(typeof(Biblioteca.Productos.Tornillos.TipoTornillo));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
