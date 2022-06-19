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
        Empleado empleado;
        public CargarUsuarios(Ferreteria ferreteria)
        {
            InitializeComponent();
            this.ferreteria = ferreteria;
            //this.usuarioLogeado = usuarioLogeado;
            this.cmbEnum.DataSource = Enum.GetValues(typeof(Biblioteca.Personas.Empleado.Cargo));
            this.Load += Reset;
        }

        public CargarUsuarios (Ferreteria ferreteria, Empleado empleado)
            :this(ferreteria)
        {
            this.empleado = empleado;
            this.ModoEmpleado();
        }

        private void ModoEmpleado()
        {
            this.labContratacion.Visible = false;
            this.textSueldo.Visible = false;
            this.labSueldo.Visible = false;
            this.dateTimeContratacion.Visible = false;

            this.labEnum.Text = "Situacion fiscal";
            this.labTitulo.Text = "Cargar nuevo cliente";
            this.labLista.Text = "Lista de clientes";
            this.cmbEnum.DataSource = Enum.GetValues(typeof(Biblioteca.Personas.Cliente.SituacionFiscal));
        }

        
        /// <summary>
        /// Crea un empleado o un cliente nuevo y los guarda en su lista correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.empleado is not null)
                {
                    ferreteria = ferreteria + new Cliente(nombre: textNombre.Text,
                                                           apellido: textApellido.Text,
                                                           fechaNacimiento: dateTimeNacimiento.Value,
                                                           dni: int.Parse(textDni.Text),

                                                           contraseña: textContraseña.Text,
                                                           estadoFiscal: (Cliente.SituacionFiscal)cmbEnum.SelectedItem);
                   // richTextLista.Text = ferreteria.MostrarClientes();
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
                                                           cargo: (Empleado.Cargo)cmbEnum.SelectedItem);
                    //richTextLista.Text = ferreteria.MostrarEmpleados();
                }
                MessageBox.Show("Operacion realizada con exito");
                Reset(sender,e);


                DialogResult mensaje = MessageBox.Show("Desea crear otro?", "Continuar", MessageBoxButtons.YesNo);

                if (mensaje == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Limpia todos los campos del from
        /// </summary>
        private void Reset(object sender, EventArgs e)
        {
            textApellido.Text = String.Empty;
            textNombre.Text = String.Empty;
            textDni.Text = String.Empty;
            textContraseña.Text = String.Empty;
            textSueldo.Text = String.Empty;
            if (empleado is not null)
                this.list.DataSource = this.ferreteria.Clientes;
            else
                this.list.DataSource= this.ferreteria.Empleados;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
