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
using Forms;

namespace Remon.Gabriel._2ºC.TP3
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
            PanelUsuarios panelUsuarios;


            switch(loging(RdUsuarios.Checked,RdEmpleados.Checked,TxbContraseña.Text,TxbUsuario.Text))
            {
                case 1:
                    CargarUsuarios cargarUsuarios = new CargarUsuarios(this.ferreteria);
                    cargarUsuarios.Show();
                    break;
                case 2:
                    panelUsuarios = new PanelUsuarios(this.ferreteria,false);
                    panelUsuarios.Show();
                    break;

                case 3:
                    panelUsuarios = new PanelUsuarios(this.ferreteria);
                    panelUsuarios.Show();
                    break;

                default:
                    MessageBox.Show("Contraseña incorrecta");

                    break;
            }
        }

        private int loging(bool clientesCheck, bool empleadosCheck,string contraseña, string usuario)
        {
            int retorno = 0;

            if(!clientesCheck && !empleadosCheck)
            {
                if(contraseña == contraseñaAdmin && usuarioAdmin == usuario)
                    retorno = 1;
            }
            else
            {
                if(clientesCheck)
                {
                    if (Usuarios.Logear(contraseña,usuario,ferreteria.Clientes))
                        retorno = 2;
                }
                else
                {
                    if (Usuarios.Logear(contraseña, usuario, ferreteria.Empleados))
                        retorno = 3;   
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
