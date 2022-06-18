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
    public partial class Login : Form
    {
        private Ferreteria ferreteria;
        private string usuarioAdmin;
        private string contraseñaAdmin;


        public Login()
        {
            InitializeComponent();
            this.ferreteria = new Ferreteria();
        }

        private void BtnLoging_Click(object sender, EventArgs e)
        {
            //PanelUsuarios panelUsuarios;

            try
            {
                PanelUsuarios panelUsuarios = new PanelUsuarios(this.ferreteria, loging(clientesCheck: RdUsuarios.Checked,
                                                                                        empleadosCheck: RdEmpleados.Checked,
                                                                                        contraseña: TxbContraseña.Text,
                                                                                        usuario: TxbUsuario.Text));
                panelUsuarios.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private TipoUsuario loging(bool clientesCheck, bool empleadosCheck, string contraseña, string usuario)
        {
            TipoUsuario retorno = TipoUsuario.ninguno;

            if (!clientesCheck && !empleadosCheck)
            {
                if (contraseña == contraseñaAdmin && usuarioAdmin == usuario)
                    retorno = TipoUsuario.Admin;
            }
            else
            {
                if (clientesCheck)
                {
                    if (Usuarios.Logear(contraseña, usuario, ferreteria.Clientes))
                        retorno = TipoUsuario.Cliente;
                }
                else
                {
                    if (Usuarios.Logear(contraseña, usuario, ferreteria.Empleados))
                        retorno = TipoUsuario.Empleado;
                }
            }

            return retorno;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            contraseñaAdmin = "admin";
            usuarioAdmin = "admin";
        }
    }
}
