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
using Biblioteca.DAO;
using Biblioteca.DTO;
using System.IO;


namespace Forms
{
    public partial class Login : Form
    {
        private Ferreteria ferreteria;
        private string usuarioAdmin;
        private string contraseñaAdmin;
        private string pathFerreteria = Path.Combine(Environment.CurrentDirectory, "Ferreteria.xml");


        public Login()
        {
            InitializeComponent();
            this.ferreteria = new Ferreteria();

        }
        /// <summary>
        /// Se iniciara aplicacion con distintos niveles de acceso, dependiendo el tipo 
        /// de usuario que quiera ingresar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoging_Click(object sender, EventArgs e)
        {
            Inicio? inicio = null;
            try
            {

                if (!RdUsuarios.Checked && !RdEmpleados.Checked)
                {
                    if (TxbContraseña.Text == this.contraseñaAdmin && TxbUsuario.Text == this.usuarioAdmin)
                        inicio = new Inicio(this.ferreteria,pathFerreteria);
                }
                else
                {
                        inicio = new Inicio(this.ferreteria, loging(clientesCheck: RdUsuarios.Checked,
                                                                    empleadosCheck: RdEmpleados.Checked,
                                                                    contraseña: TxbContraseña.Text,
                                                                    usuario: TxbUsuario.Text),              pathFerreteria);
                }
                if(inicio == null)
                {
                    throw new Exception("Usuario no encontrado");
                }
                inicio.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Compueba que la contraseña y el usuario existen y retorna el usuario
        /// que es duaño de esa cuenta, en caso contrario null
        /// </summary>
        /// <param name="clientesCheck"></param>
        /// <param name="empleadosCheck"></param>
        /// <param name="contraseña"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        private Usuarios loging(bool clientesCheck, bool empleadosCheck, string contraseña, string usuario)
        {
            Usuarios retorno = null;

            if (clientesCheck)
            {
                    retorno = Usuarios.Logear(contraseña, usuario, ferreteria.Clientes);
            }
            else
            {
                    retorno = Usuarios.Logear(contraseña, usuario, ferreteria.Empleados);
            }
            
            return retorno;
        }

        /// <summary>
        /// Se setea la contraseña de administrador y se carga la instancia de ferreteria si es que exsite 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            contraseñaAdmin = "admin";
            usuarioAdmin = "admin";
            Task.Run(() =>
            {
                while(true)
                {
                    ComprobarActualizacion();
                    Thread.Sleep(10000);
                }
            });
        }

        private void ComprobarActualizacion()
        {
            if(this.InvokeRequired)
            {
                Action delegado = ComprobarActualizacion;
                this.Invoke(delegado);
            }
            else
            {
                this.CargarFerreteria();
            }
        }

        private void CargarFerreteria()
        {
            try
            {
                Archivos.IOArchivos<FerreteriaDto> cargar = new Archivos.IOArchivos<FerreteriaDto>(pathFerreteria);
                this.ferreteria = FerreteriaDao.CrearOriginal(cargar.CargarXml());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }


    }
}
