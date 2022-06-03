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
using Biblioteca.Personas;

namespace Forms
{
    public partial class PanelUsuarios : Form
    {
        bool modoCliente;
        Ferreteria ferreteria;

        public PanelUsuarios(Ferreteria ferreteria)
        {
            InitializeComponent();
            modoCliente = false;
            this.ferreteria = ferreteria;
        }
        public PanelUsuarios(Ferreteria ferreteria,bool modoCliente)
            :this(ferreteria)
        {
            this.btnNuevoCliente.Visible = false;
            this.btnNuevoProducto.Visible = false;
            this.btnPedidoDistribuidora.Visible = false;
            this.btnActualizar.Visible = false;
            this.modoCliente = modoCliente;
        }

        private void PanelUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            CargarUsuarios carga = new CargarUsuarios(ferreteria, true);
            carga.Show();

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
