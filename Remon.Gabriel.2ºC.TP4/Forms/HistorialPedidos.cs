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
using Archivos;

namespace Forms
{
    public partial class HistorialPedidos : Form
    {
        List<Venta> ventas;

        public HistorialPedidos(List<Venta> ventas)
        {
            InitializeComponent();
            this.ventas = ventas;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            StringBuilder ventasTxt = new StringBuilder();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            try
            {
                foreach(Venta venta in this.ventas)
                {
                    ventasTxt.AppendLine(venta.Mostrar());
                }
                Save<Venta> save = new Save<Venta>(saveFileDialog.FileName);
                save.GuardarTxtFechaActual(ventasTxt.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HistorialPedidos_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = this.ventas;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItems.Count != 0)
                {
                    MessageBox.Show((listBox1.SelectedItem as Venta).Mostrar(), "Descripcion de la venta");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
