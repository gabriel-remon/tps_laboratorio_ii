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
    public enum TipoUsuario
    {
        Admin,
        Cliente,
        Empleado,
        ninguno
    }
    public partial class PanelUsuarios : Form
    {

        TipoUsuario usuarioLogiado;
        Ferreteria ferreteria;

        public PanelUsuarios(Ferreteria ferreteria, TipoUsuario usuario)
        {
            InitializeComponent();

            this.usuarioLogiado = usuario;
            this.ferreteria = ferreteria;

            switch(usuario)
            {
                case TipoUsuario.Admin:
                    this.ModoAdmin();
                    break;

                case TipoUsuario.Empleado:
                    this.ModoEmpleado();
                    break;

                case TipoUsuario.Cliente:
                    this.ModoCliente();
                    break;

                default:
                    throw new Exception("Usuario no encontrado");
            }
        }

        private void ModoAdmin()
        {
            //this.btnNuevoCliente.Text = "Cargar nuevo Empleado";
        }

        private void ModoEmpleado()
        {
            this.btnNuevoCliente.Visible = false;
            this.btnPedidoDistribuidora.Visible = false;
            this.btnNuevoEmpleado.Visible = false;
        }
        private void ModoCliente()
        {
            this.btnNuevoCliente.Visible = false;
            this.btnNuevoProducto.Visible = false;
            this.btnActualizar.Visible = false;
            this.btnPedidoDistribuidora.Visible = false;
         
        }


        private void PanelUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            CargarUsuarios carga = new CargarUsuarios(ferreteria, TipoUsuario.Empleado);
            carga.ShowDialog();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            
             CargarUsuarios carga = new CargarUsuarios(ferreteria, TipoUsuario.Admin);
             carga.ShowDialog(); 
            
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            CargarNuevoProducto cargaProducto = new CargarNuevoProducto(ferreteria);
            cargaProducto.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(ferreteria.Productos.Count == 0)
            {
                MessageBox.Show("No hay productos cargados, \n " +
                                " cargue un producto");
                this.btnNuevoProducto_Click(sender, e);
            }
            else
            {
                ListaProductos lista = new ListaProductos(this.ferreteria);
                lista.ShowDialog();
            }
        }

        private void labListaPedidos_Click(object sender, EventArgs e)
        {

        }

        private void PanelUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir?", "Salir",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
