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
    public partial class CargarNuevoProducto : Form
    {
        public CargarNuevoProducto()
        {
            InitializeComponent();
        }

        private void btnAñador_Click(object sender, EventArgs e)
        {

        }

        private void radButnCaño_CheckedChanged(object sender, EventArgs e)
        {
            textDescripcion.Enabled = false;

            EnableCaño(true);
            EnableTornillo(false);
        }

        private void radButnTornillo_CheckedChanged(object sender, EventArgs e)
        {
            textDescripcion.Enabled = false;

            EnableCaño(false);
            EnableTornillo(true);
        }

        private void radButnOtro_CheckedChanged(object sender, EventArgs e)
        {
            textDescripcion.Enabled = true;

            EnableCaño(false);
            EnableTornillo(false);
        }

        private void EnableTornillo(bool estado)
        {
            combTipoTornillo.Enabled = estado;
            textLargoTornillo.Enabled = estado;
            textMetrica.Enabled = estado;
        }
        private void EnableCaño(bool estado)
        {
            combTipoCaño.Enabled = estado;
            textDescripcion.Enabled = estado;
            textLargoCaño.Enabled = estado;
        }
    }
}
