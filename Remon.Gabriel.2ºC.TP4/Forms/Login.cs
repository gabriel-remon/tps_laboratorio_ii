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
                PanelUsuarios panelUsuarios = null;

                if (!RdUsuarios.Checked && !RdEmpleados.Checked)
                {
                    if (TxbContraseña.Text == this.contraseñaAdmin && TxbUsuario.Text == this.usuarioAdmin)
                        panelUsuarios = new PanelUsuarios(this.ferreteria);
                }
                else
                {
                 panelUsuarios = new PanelUsuarios(this.ferreteria, loging(clientesCheck: RdUsuarios.Checked,
                                                                                        empleadosCheck: RdEmpleados.Checked,
                                                                                        contraseña: TxbContraseña.Text,
                                                                                        usuario: TxbUsuario.Text));
                }
                panelUsuarios.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private Usuarios loging(bool clientesCheck, bool empleadosCheck, string contraseña, string usuario)
        {
            Usuarios retorno = null;


            if (clientesCheck)
            {
                //if (Usuarios.Logear(contraseña, usuario, ferreteria.Clientes))
                    retorno = Usuarios.Logear(contraseña, usuario, ferreteria.Clientes);
            }
            else
            {
               // if (Usuarios.Logear(contraseña, usuario, ferreteria.Empleados))
                    retorno = Usuarios.Logear(contraseña, usuario, ferreteria.Empleados);
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
