using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Informacion : Form
    {
        string texto;

        public Informacion(string texto)
        {
            InitializeComponent();
            this.texto = texto;
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            richTextBox1.Text= texto;
        }
    }
}
