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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvetirABinario_Click(object sender, EventArgs e)
        {
            Operando ingreso = new Operando();
            string decimall = ingreso.DecimalBinario(lblResultado.Text);

            lstOperaciones.Items.Add($"{lblResultado.Text} decimal = {decimall} binario");
            lblResultado.Text = decimall;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando ingreso = new Operando();
            string binario = ingreso.BinarioDecimal(lblResultado.Text);

            lstOperaciones.Items.Add($"{lblResultado.Text} binario = {binario} decimal");
            lblResultado.Text = binario;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            double numero1 = 0;
            double numero2 = 0;
            char operador = '+';

            double.TryParse(txtNumero1.Text, out numero1);
            double.TryParse(txtNumero2.Text, out numero2);
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            if(cmbOperador.Text != String.Empty)
            {
               char.TryParse(cmbOperador.Text, out operador);
            }

            lblResultado.Text = resultado.ToString();
            lstOperaciones.Items.Add($"{numero1} {operador} {numero2} = {resultado}");
        }

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            lblResultado.Text = String.Empty;
            cmbOperador.SelectedIndex = -1;
        }

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
