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

namespace Remon.Gabriel._2ºC.TP3
{
    public partial class Form1 : Form
    {
        Ferreteria ferreteria;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //decimal sueldo = 10;
            //ferreteria = new Ferreteria(new List<Persona>(new Empleado("pepe", "dominguez", new DateTime(10 / 10 / 1998),4111922,
            //                                                        "pepe", "Dominguez", new DateTime(10 / 10 / 2000), sueldo ,"pepe")));
        }
    }
}
