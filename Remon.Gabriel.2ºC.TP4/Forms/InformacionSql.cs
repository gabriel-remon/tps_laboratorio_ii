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
    public partial class InformacionSql : Form
    {
        DataTable tabla;
        public InformacionSql(DataTable tabla)
        {
            InitializeComponent();
            this.tabla = tabla;
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InformacionSql_Load(object sender, EventArgs e)
        {
            this.dataGrid.DataSource = this.tabla;
        }
    }
}
