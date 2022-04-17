using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// cierra el formulario cuando se preciona el boton cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// convierte el numero que figura en lblResultado en un numero binario si es posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvetirABinario_Click(object sender, EventArgs e)
        {
            Operando ingreso = new Operando();
            string decimall = ingreso.DecimalBinario(lblResultado.Text);

            lstOperaciones.Items.Add($"{lblResultado.Text} decimal = {decimall} binario");
            lblResultado.Text = decimall;
        }

        /// <summary>
        /// convierte el numero que figura en lblResultado en un numero decimal si es posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando ingreso = new Operando();
            string binario = ingreso.BinarioDecimal(lblResultado.Text);

            lstOperaciones.Items.Add($"{lblResultado.Text} binario = {binario} decimal");
            lblResultado.Text = binario;
        }

        /// <summary>
        /// se llama al metodo limpiar para limpiar los elementos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// se llama a la funcion operar y se muestran los resultados por pantalla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado;
            double numero1 = 0;
            double numero2 = 0;
            char operador = '+';

            double.TryParse(txtNumero1.Text, out numero1);
            double.TryParse(txtNumero2.Text, out numero2);
            resultado = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text));
            if(cmbOperador.Text != String.Empty)
            {
               char.TryParse(cmbOperador.Text, out operador);
            }

            if (resultado == Convert.ToString(double.MinValue))
            {
                resultado = "Error";
            }

            lblResultado.Text = resultado;
            lstOperaciones.Items.Add($"{numero1} {operador} {numero2} = {resultado}");
        }

        /// <summary>
        /// inicializa los componentes del formulario 
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// limpia los cambos de txtNumero1, txtNumero2, lblResultado y cmbOperador
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            lblResultado.Text = String.Empty;
            cmbOperador.SelectedIndex = -1;
        }

        /// <summary>
        /// Realiza la operacion arecmetica de los valores pasados como parametro
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>retorna el resultado de la operacion</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            char operadorChar;
            Operando numero1Aux = new Operando(numero1);
            Operando numero2Aux = new Operando(numero2);

            char.TryParse(operador, out operadorChar);

            resultado = Calculadora.Operar(numero1Aux, numero2Aux, operadorChar);

            return resultado;
        }

        /// <summary>
        /// crea un cuadro de texto el cual pregunta al usuario si esta seguro de salir 
        /// del programa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Seguro que querer salir?", "Salir",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                                 MessageBoxDefaultButton.Button1);
            if(salir == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

    }
}
