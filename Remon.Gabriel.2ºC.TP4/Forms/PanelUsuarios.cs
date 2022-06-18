using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Biblioteca;
using Biblioteca.Personas;
using System.IO;
using Biblioteca.DAO;
using Biblioteca.DTO;

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

        Usuarios usuarioLogiado;
        Ferreteria ferreteria;
        string pathGuardado;

        public PanelUsuarios(Ferreteria ferreteria)
            : this(ferreteria, null)
        {
        }

        public PanelUsuarios(Ferreteria ferreteria, Usuarios usuario)  
        {
            InitializeComponent();

            this.usuarioLogiado = usuario;
            this.ferreteria = ferreteria;
            

            if (usuario is Empleado)
            {
                this.ModoEmpleado();
            }
            else if (usuario is Cliente)
            {
                this.ModoCliente();
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
            Task.Run(() =>
            {
                while(true)
                {
                    ActualizarPedidos(this.ferreteria);
                    Thread.Sleep(5000);
                }
            });
        }

        private void ActualizarPedidos(Ferreteria ferreteria)
        {
            if(this.InvokeRequired)
            {
                Action<Ferreteria> delegado = this.ActualizarPedidos;
                this.Invoke(delegado,ferreteria);
            }
            else
            {
                this.listPedidos.DataSource = Venta.VentasPendiente(ferreteria.Ventas);
            }
        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            CargarPedido cargarPedido = new CargarPedido(ferreteria);
            cargarPedido.ShowDialog();
            this.listPedidos.DataSource = Venta.VentasPendiente(ferreteria.Ventas);
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
            if (ferreteria.Productos.Count == 0)
            {
                MessageBox.Show("No hay productos cargados, \n " +
                                " cargue un producto");
                this.btnNuevoProducto_Click(sender, e);
            }
            else
            {
                ListaProductos lista = new ListaProductos(this.ferreteria);
                lista.ShowDialog();
                //if(lista.DialogResult == DialogResult.OK)
                    //GuardarListaProductos
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

        private void listPedidos_DoubleClick(object sender, EventArgs e)
        {
            Venta venta;
            if(listPedidos.SelectedItems.Count != 0)
            {
                venta = listPedidos.SelectedItem as Venta;
                DialogResult dialog = MessageBox.Show( venta.Mostrar() , "Realizar venta", MessageBoxButtons.YesNo);

                if(dialog == DialogResult.Yes)
                {
                    ferreteria.Realizarventa(venta);
                }

            }
        }

        private void btnPedidoDistribuidora_Click(object sender, EventArgs e)
        {
            try
            {
                Archivos.Save<Ferreteria> guardar = new Archivos.Save<Ferreteria>(Environment.CurrentDirectory);
                guardar.GuardarTxtFechaActual(this.ferreteria.RealizarPedidoDistribuidora());
                MessageBox.Show($"Archivo guardado en {Environment.CurrentDirectory}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Archivos.Save<FerreteriaDto> guardar = new Archivos.Save<FerreteriaDto>(Environment.CurrentDirectory);
                guardar.GuardarXml(FerreteriaDao.CrearFerreteriaDto(this.ferreteria));
                MessageBox.Show($"Archivo guardado en {Environment.CurrentDirectory}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Archivos.Save<FerreteriaDto> cargar = new Archivos.Save<FerreteriaDto>(Environment.CurrentDirectory);
                this.ferreteria = FerreteriaDao.CrearOriginal(cargar.CargarXml());
                MessageBox.Show($"Archivo guardado en {Environment.CurrentDirectory}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
