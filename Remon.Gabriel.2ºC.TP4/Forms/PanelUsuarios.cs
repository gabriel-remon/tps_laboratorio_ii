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
    

    public partial class PanelUsuarios : Form
    {

        Usuarios usuarioLogiado;
        Ferreteria ferreteria;
        //string pathGuardado;

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

        private void ModoEmpleado()
        {
            //this.btnNuevoCliente.Visible = false;
            this.btnNuevoEmpleado.Visible = false;
            this.btnListEmpleados.Visible = false;
            this.btnListEmpleados.Visible = false;
            this.btnNuevoProducto.Visible = false;
            this.btnActualizar.Visible = false;
            this.btnListEmpleados.Visible = false;
        }
        private void ModoCliente()
        {
            this.btnNuevoCliente.Visible = false;
            this.btnNuevoProducto.Visible = false;
            this.btnActualizar.Visible = false;
            this.btnNuevoEmpleado.Visible = false;
            this.btnNuevoCliente.Visible = false;
            this.btnListEmpleados.Visible = false;
            this.btnListClientes.Visible = false;
        }


        private void PanelUsuarios_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                while(true)
                {
                    ActualizarPedidos(this.ferreteria);
                    Thread.Sleep(1000);
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
                if(this.usuarioLogiado is Cliente)
                {
                    this.listPedidos.DataSource = Venta.VentasPendiente(ferreteria.Ventas,usuarioLogiado);
                }
                else
                {
                    this.listPedidos.DataSource = Venta.VentasPendiente(ferreteria.Ventas);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            CargarPedido cargarPedido;
            try
            {
                //Crear una execcion personalizada para este proceso asi se llama
                //al boton crear cliente o crear empleado
                if(this.ferreteria.Clientes.Count ==0 && this.ferreteria.Empleados.Count == 0)
                {
                    throw new Exception("Primero deve cargar al menos un cliente y un prodcuto");
                }
                if(this.usuarioLogiado is Cliente)
                {
                    cargarPedido = new CargarPedido(ferreteria,usuarioLogiado as Cliente);
                }
                else
                {
                    cargarPedido = new CargarPedido(ferreteria);
                }
                cargarPedido.ShowDialog();
                this.ActualizarPedidos(this.ferreteria);
                //this.listPedidos.DataSource = Venta.VentasPendiente(ferreteria.Ventas);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Permite cargar un nuevo cliente
        /// En futuras versiones se registrar que empleado cargo a cada cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            CargarUsuarios carga = new CargarUsuarios(ferreteria, new Empleado());
            carga.ShowDialog();
        }

        /// <summary>
        /// Permite cargar un nuevo empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            CargarUsuarios carga = new CargarUsuarios(ferreteria);
            carga.ShowDialog();
        }

        /// <summary>
        /// Permitira agregar un producto nuevo a la lista 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            CargarNuevoProducto cargaProducto = new CargarNuevoProducto(ferreteria);
            cargaProducto.ShowDialog();
        }

        /// <summary>
        /// Permite cambiar el precio y el stock a los productos en stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            }
        }

        

        /// <summary>
        /// Evento doble click de la lista de pedidos. Al activar el evento
        /// se infoma la descripcion del pedido selecciolnado y se pregunta 
        /// si se vendio. si se vendio se cambia el estado del pedido a vendido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listPedidos_DoubleClick(object sender, EventArgs e)
        {
            Venta? venta;
            if(listPedidos.SelectedItems.Count != 0)
            {
                venta = listPedidos.SelectedItem as Venta;
                if (usuarioLogiado is Cliente)
                {
                    MessageBox.Show(venta.Mostrar(), "Realizar venta");
                }
                else if (MessageBox.Show(venta.Mostrar(), "Realizar venta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ferreteria.Realizarventa(venta);
                }
            }
        }

        

        /// <summary>
        /// Guarda el objeto ferreteria en un archivo xml con una ruta ya definida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Archivos.Save<FerreteriaDto> guardar = new Archivos.Save<FerreteriaDto>(Environment.CurrentDirectory);
        //        guardar.GuardarXml(FerreteriaDao.CrearFerreteriaDto(this.ferreteria));
        //        MessageBox.Show($"Archivo guardado en {Environment.CurrentDirectory}");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        /// <summary>
        /// Carga el objeto ferreteria en un archivo xml con una ruta ya definida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Archivos.Save<FerreteriaDto> cargar = new Archivos.Save<FerreteriaDto>(Environment.CurrentDirectory);
        //        this.ferreteria = FerreteriaDao.CrearOriginal(cargar.CargarXml());
        //        MessageBox.Show($"Archivo guardado en {Environment.CurrentDirectory}");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialPedidos historialPedidos;

            if (this.usuarioLogiado is Cliente)
            {
                historialPedidos = new HistorialPedidos(this.ferreteria.VentasRealizadas(this.usuarioLogiado as Cliente));
            }
            else
            {
                historialPedidos = new HistorialPedidos(this.ferreteria.VentasRealizadas());
            }

            historialPedidos.ShowDialog();
        }

      

        private void PanelUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void PanelUsuarios_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1) { this.btnGenerarPedido_Click(sender, e); }
            
            if (e.KeyCode == Keys.F2) { this.btnHistorial_Click(sender, e); }
            
            if (e.KeyCode == Keys.F3) { this.btnNuevoCliente_Click(sender, e); }
            
            //if (e.KeyCode == Keys.F4) { this.btnPedidoDistribuidora_Click(sender, e); }
            
            if (e.KeyCode == Keys.F4) { this.btnNuevoEmpleado_Click(sender, e); }
            
            if (e.KeyCode == Keys.F5) { this.btnNuevoProducto_Click(sender, e); }
            
            if (e.KeyCode == Keys.F6) { this.btnActualizar_Click(sender, e); }

            if (e.KeyCode == Keys.F7) { this.btnListClientes_Click(sender, e); }

            if (e.KeyCode == Keys.F8) { this.btnListEmpleados_Click(sender, e); }

           // if (e.KeyCode == Keys.Escape) { this.Close(); }
           
        }

        private void btnListClientes_Click(object sender, EventArgs e)
        {
            if (this.ferreteria.Clientes.Count > 0)
            {
                Informacion informacion = new Informacion(Ferreteria.Mostrar(this.ferreteria.Clientes));
                informacion.ShowDialog();
            }
        }

        private void btnListEmpleados_Click(object sender, EventArgs e)
        {
            if (this.ferreteria.Empleados.Count > 0)
            {
                Informacion informacion = new Informacion(Ferreteria.Mostrar(this.ferreteria.Empleados));
                informacion.ShowDialog();
            }
        }

        internal void CargarFerreteria(Ferreteria ferreteria)
        {
            this.ferreteria = ferreteria;
        }
        
    }
}
