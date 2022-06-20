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
using Biblioteca.Productos;
using System.IO;
using Biblioteca.DAO;
using Biblioteca.DTO;
using Biblioteca.IO;

namespace Forms
{
    public partial class Inicio : Form
    {
        Ferreteria ferreteria;
        Usuarios usuario;
        PanelUsuarios panelUsuarios;

        string pathDistribuidora;
        string pathFerreteria;

        public delegate void ActualizarFerreteria(Ferreteria ferreteria);
        public event ActualizarFerreteria ActualizarFerreteriaEvent;

        private Inicio()
        {
            InitializeComponent();
            pathDistribuidora = Path.Combine(Environment.CurrentDirectory, "Pedidos");
           
        }

        public Inicio(Ferreteria ferreteria,string path)
            :this()
        {
            this.ferreteria = ferreteria;
            panelUsuarios = new PanelUsuarios(ferreteria);
            this.pathFerreteria = path;
        }

        public Inicio(Ferreteria ferreteria,Usuarios usuario,string path)
            :this(ferreteria,path)
        {
            this.usuario = usuario;
            panelUsuarios = new PanelUsuarios(ferreteria,usuario);
            this.serverToolStripMenuItem.Visible = false;

            if (usuario is Cliente)
            {
                this.guardarToolStripMenuItem.Visible = false;
                this.guardarComoToolStripMenuItem.Visible = false;
                this.cargarToolStripMenuItem.Visible = false;

            }
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists(pathDistribuidora))
            {
                Directory.CreateDirectory(pathDistribuidora);
            }
            pathDistribuidora += "\\Pedidos";
            
            this.panelUsuarios.MdiParent = this;
            this.panelUsuarios.WindowState = FormWindowState.Maximized;
            this.panelUsuarios.Show();
            this.panelUsuarios.FormClosed += salirToolStripMenuItem_Click;
            this.ActualizarFerreteriaEvent += panelUsuarios.CargarFerreteria;
            this.FormClosing += negocioGuardarMenu_Click;
        }

        private void salirToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir?", "Salir",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        /// <summary>
        /// Crea un archivo txt con los articulos faltantes de la ferreteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pedidoDistribuidoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Archivos.IOArchivos<Ferreteria> guardar = new Archivos.IOArchivos<Ferreteria>(pathDistribuidora);
                guardar.GuardarTxtFechaActual(this.ferreteria.RealizarPedidoDistribuidora());
                MessageBox.Show($"Se creo el pedido para la distribuidora \n" +
                                $"Ubicacion: {pathDistribuidora}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// Genera un archivo txt con los productos que hay que pedir a la distribuidora,
        /// preguntando donde se quiere guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pedidoDistribuidoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog nuevoPath = new SaveFileDialog();
            nuevoPath.ShowDialog();
            this.pathDistribuidora = nuevoPath.FileName;
            this.pedidoDistribuidoraToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Guarda al instancia de Ferreteria en un archivo xml,
        /// preguntando donde se quiere guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void negocioGuardarComoMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog nuevoPath = new SaveFileDialog();
            nuevoPath.ShowDialog();
            this.GuardarFerreteria(nuevoPath.FileName);
        }

        /// <summary>
        /// Guarda al instancia de Ferreteria en un archivo xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void negocioGuardarMenu_Click(object sender, EventArgs e)
        {
            this.GuardarFerreteria(this.pathFerreteria);
        }

        public void GuardarFerreteria(string path)
        {
            try
            {
                Archivos.IOArchivos<FerreteriaDto> guardar = new Archivos.IOArchivos<FerreteriaDto>(path);
                guardar.GuardarXml(FerreteriaDao.CrearFerreteriaDto(this.ferreteria));
                Server.Clear();
                Server.Guardar(this.ferreteria);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivo .xml |*.xml";
                openFileDialog.ShowDialog();
                Archivos.IOArchivos<FerreteriaDto> cargar = new Archivos.IOArchivos<FerreteriaDto>(openFileDialog.FileName);
                this.ferreteria = FerreteriaDao.CrearOriginal(cargar.CargarXml());
                //MessageBox.Show($"Archivo cargado con exito \n path: {pathFerreteria}");
                if (ActualizarFerreteriaEvent is not null)
                {
                    ActualizarFerreteriaEvent(this.ferreteria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void listaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionSql informacionSql = new InformacionSql(Server.LeerVenta());
                informacionSql.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionSql informacionSql = new InformacionSql(Server.LeerClientes());
                informacionSql.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionSql informacionSql = new InformacionSql(Server.LeerEmpleados());
                informacionSql.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   
    }
}
