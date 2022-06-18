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
    public partial class CargarUsuarios : Form
    {
        Ferreteria ferreteria;
        TipoUsuario usuarioLogeado;
        public CargarUsuarios(Ferreteria ferreteria, TipoUsuario usuarioLogeado)
        {
            InitializeComponent();
            this.ferreteria = ferreteria;
            this.usuarioLogeado = usuarioLogeado;

            switch(usuarioLogeado)
            {
                case TipoUsuario.Admin:
                    this.ModoAdmin();
                    break;
                case TipoUsuario.Empleado:
                    this.ModoEmpleado();
                    break;
                default:
                    throw new Exception("No cuenta con permisos necesarios");
            }
        }

        private void ModoEmpleado()
        {
            this.labContratacion.Visible = false;
            this.textSueldo.Visible = false;
            this.labSueldo.Visible = false;
            this.dateTimeContratacion.Visible = false;

            this.labEnum.Text = "Situacion fiscal";
            this.labTitulo.Text = "Cargar nuevo cliente";
            this.cmbEnum.DataSource = Enum.GetValues(typeof(Biblioteca.Personas.Cliente.SituacionFiscal));
        }
        
        private void ModoAdmin()
        {
            this.cmbEnum.DataSource = Enum.GetValues(typeof(Biblioteca.Personas.Empleado.Cargo));
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.usuarioLogeado == TipoUsuario.Empleado)
                {
                    ferreteria = ferreteria + new Cliente(nombre: textNombre.Text,
                                                           apellido: textApellido.Text,
                                                           fechaNacimiento: dateTimeNacimiento.Value,
                                                           dni: int.Parse(textDni.Text),
                                                           
                                                           contraseña: textContraseña.Text,
                                                           estadoFiscal: (Cliente.SituacionFiscal) cmbEnum.SelectedItem);
                    richTextLista.Text = ferreteria.MostrarClientes();
                }
                else
                {
                    ferreteria = ferreteria + new Empleado(nombre: textNombre.Text,
                                                           apellido: textApellido.Text,
                                                           fechaNacimiento: dateTimeNacimiento.Value,
                                                           dni: int.Parse(textDni.Text),
                                                           contraseña: textContraseña.Text,
                                                           fechaContratacion: dateTimeContratacion.Value,
                                                           sueldo: decimal.Parse(textSueldo.Text),
                                                           cargo: (Empleado.Cargo) cmbEnum.SelectedItem);
                    //richTextLista.Text = ferreteria.MostrarEmpleados();
                }
                MessageBox.Show("Operacion realizada con exito");
                Reset();


                DialogResult mensaje = MessageBox.Show( "Desea crear otro?", "Continuar", MessageBoxButtons.YesNo);

                if(mensaje == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            textApellido.Text = String.Empty;
            textNombre.Text = String.Empty;
            textDni.Text = String.Empty;
            textContraseña.Text = String.Empty;
            textSueldo.Text = String.Empty;
        
        }

        private void CargarUsuarios_Load(object sender, EventArgs e)
        {
            //if (modoCliente)
            //    richTextLista.Text = ferreteria.MostrarClientes();
            //else
            //    richTextLista.Text = ferreteria.MostrarEmpleados();


        }
    }
}
