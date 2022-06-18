namespace Forms
{
    partial class CargarNuevoProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labCodigo = new System.Windows.Forms.Label();
            this.textDiametro = new System.Windows.Forms.TextBox();
            this.radButnOtro = new System.Windows.Forms.RadioButton();
            this.radButnTornillo = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.labMetrica = new System.Windows.Forms.Label();
            this.labTipoTornillo = new System.Windows.Forms.Label();
            this.labStockStandar = new System.Windows.Forms.Label();
            this.labLargoTornillo = new System.Windows.Forms.Label();
            this.labStockActual = new System.Windows.Forms.Label();
            this.labLargoCaño = new System.Windows.Forms.Label();
            this.labPrecio = new System.Windows.Forms.Label();
            this.labTipoCaño = new System.Windows.Forms.Label();
            this.labDiametro = new System.Windows.Forms.Label();
            this.radButnCaño = new System.Windows.Forms.RadioButton();
            this.btnAñador = new System.Windows.Forms.Button();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textLargoTornillo = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textStockActual = new System.Windows.Forms.TextBox();
            this.textStockStandar = new System.Windows.Forms.TextBox();
            this.textLargoCaño = new System.Windows.Forms.TextBox();
            this.combTipoCaño = new System.Windows.Forms.ComboBox();
            this.combTipoTornillo = new System.Windows.Forms.ComboBox();
            this.cmbMetrica = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Location = new System.Drawing.Point(26, 58);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(46, 15);
            this.labCodigo.TabIndex = 0;
            this.labCodigo.Text = "Codigo";
            // 
            // textDiametro
            // 
            this.textDiametro.Enabled = false;
            this.textDiametro.Location = new System.Drawing.Point(330, 76);
            this.textDiametro.Name = "textDiametro";
            this.textDiametro.Size = new System.Drawing.Size(100, 23);
            this.textDiametro.TabIndex = 6;
            // 
            // radButnOtro
            // 
            this.radButnOtro.AutoSize = true;
            this.radButnOtro.Checked = true;
            this.radButnOtro.Location = new System.Drawing.Point(26, 237);
            this.radButnOtro.Name = "radButnOtro";
            this.radButnOtro.Size = new System.Drawing.Size(49, 19);
            this.radButnOtro.TabIndex = 13;
            this.radButnOtro.TabStop = true;
            this.radButnOtro.Text = "Otro\r\n";
            this.radButnOtro.UseVisualStyleBackColor = true;
            this.radButnOtro.CheckedChanged += new System.EventHandler(this.radButnOtro_CheckedChanged);
            // 
            // radButnTornillo
            // 
            this.radButnTornillo.AutoSize = true;
            this.radButnTornillo.Location = new System.Drawing.Point(184, 237);
            this.radButnTornillo.Name = "radButnTornillo";
            this.radButnTornillo.Size = new System.Drawing.Size(64, 19);
            this.radButnTornillo.TabIndex = 14;
            this.radButnTornillo.Text = "Tornillo";
            this.radButnTornillo.UseVisualStyleBackColor = true;
            this.radButnTornillo.CheckedChanged += new System.EventHandler(this.radButnTornillo_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(498, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labDescripcion
            // 
            this.labDescripcion.AutoSize = true;
            this.labDescripcion.Location = new System.Drawing.Point(26, 119);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(69, 15);
            this.labDescripcion.TabIndex = 5;
            this.labDescripcion.Text = "Descripcion";
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTitulo.Location = new System.Drawing.Point(178, 21);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(225, 25);
            this.labTitulo.TabIndex = 6;
            this.labTitulo.Text = "Cargar Nuevo producto";
            // 
            // labMetrica
            // 
            this.labMetrica.AutoSize = true;
            this.labMetrica.Enabled = false;
            this.labMetrica.Location = new System.Drawing.Point(184, 58);
            this.labMetrica.Name = "labMetrica";
            this.labMetrica.Size = new System.Drawing.Size(47, 15);
            this.labMetrica.TabIndex = 7;
            this.labMetrica.Text = "metrica";
            // 
            // labTipoTornillo
            // 
            this.labTipoTornillo.AutoSize = true;
            this.labTipoTornillo.Enabled = false;
            this.labTipoTornillo.Location = new System.Drawing.Point(184, 119);
            this.labTipoTornillo.Name = "labTipoTornillo";
            this.labTipoTornillo.Size = new System.Drawing.Size(85, 15);
            this.labTipoTornillo.TabIndex = 8;
            this.labTipoTornillo.Text = "tipo de tornillo";
            // 
            // labStockStandar
            // 
            this.labStockStandar.AutoSize = true;
            this.labStockStandar.Location = new System.Drawing.Point(473, 119);
            this.labStockStandar.Name = "labStockStandar";
            this.labStockStandar.Size = new System.Drawing.Size(84, 15);
            this.labStockStandar.TabIndex = 9;
            this.labStockStandar.Text = "Stock estandar";
            // 
            // labLargoTornillo
            // 
            this.labLargoTornillo.AutoSize = true;
            this.labLargoTornillo.Enabled = false;
            this.labLargoTornillo.Location = new System.Drawing.Point(184, 175);
            this.labLargoTornillo.Name = "labLargoTornillo";
            this.labLargoTornillo.Size = new System.Drawing.Size(101, 15);
            this.labLargoTornillo.TabIndex = 10;
            this.labLargoTornillo.Text = "largo en pulgadas";
            // 
            // labStockActual
            // 
            this.labStockActual.AutoSize = true;
            this.labStockActual.Location = new System.Drawing.Point(471, 58);
            this.labStockActual.Name = "labStockActual";
            this.labStockActual.Size = new System.Drawing.Size(73, 15);
            this.labStockActual.TabIndex = 11;
            this.labStockActual.Text = "Stock Actual";
            // 
            // labLargoCaño
            // 
            this.labLargoCaño.AutoSize = true;
            this.labLargoCaño.Enabled = false;
            this.labLargoCaño.Location = new System.Drawing.Point(330, 175);
            this.labLargoCaño.Name = "labLargoCaño";
            this.labLargoCaño.Size = new System.Drawing.Size(98, 15);
            this.labLargoCaño.TabIndex = 12;
            this.labLargoCaño.Text = "largo (en metros)";
            // 
            // labPrecio
            // 
            this.labPrecio.AutoSize = true;
            this.labPrecio.Location = new System.Drawing.Point(26, 175);
            this.labPrecio.Name = "labPrecio";
            this.labPrecio.Size = new System.Drawing.Size(100, 15);
            this.labPrecio.TabIndex = 13;
            this.labPrecio.Text = "Precio de compra";
            // 
            // labTipoCaño
            // 
            this.labTipoCaño.AutoSize = true;
            this.labTipoCaño.Enabled = false;
            this.labTipoCaño.Location = new System.Drawing.Point(330, 119);
            this.labTipoCaño.Name = "labTipoCaño";
            this.labTipoCaño.Size = new System.Drawing.Size(73, 15);
            this.labTipoCaño.TabIndex = 14;
            this.labTipoCaño.Text = "tipo de caño";
            // 
            // labDiametro
            // 
            this.labDiametro.AutoSize = true;
            this.labDiametro.Enabled = false;
            this.labDiametro.Location = new System.Drawing.Point(330, 58);
            this.labDiametro.Name = "labDiametro";
            this.labDiametro.Size = new System.Drawing.Size(55, 15);
            this.labDiametro.TabIndex = 15;
            this.labDiametro.Text = "diametro";
            // 
            // radButnCaño
            // 
            this.radButnCaño.AutoSize = true;
            this.radButnCaño.Location = new System.Drawing.Point(336, 237);
            this.radButnCaño.Name = "radButnCaño";
            this.radButnCaño.Size = new System.Drawing.Size(53, 19);
            this.radButnCaño.TabIndex = 15;
            this.radButnCaño.Text = "Caño";
            this.radButnCaño.UseVisualStyleBackColor = true;
            this.radButnCaño.CheckedChanged += new System.EventHandler(this.radButnCaño_CheckedChanged);
            // 
            // btnAñador
            // 
            this.btnAñador.Location = new System.Drawing.Point(110, 276);
            this.btnAñador.Name = "btnAñador";
            this.btnAñador.Size = new System.Drawing.Size(159, 35);
            this.btnAñador.TabIndex = 11;
            this.btnAñador.Text = "Añadir producto";
            this.btnAñador.UseVisualStyleBackColor = true;
            this.btnAñador.Click += new System.EventHandler(this.btnAñador_Click);
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(26, 76);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 23);
            this.textCodigo.TabIndex = 0;
            // 
            // textLargoTornillo
            // 
            this.textLargoTornillo.Enabled = false;
            this.textLargoTornillo.Location = new System.Drawing.Point(184, 193);
            this.textLargoTornillo.Name = "textLargoTornillo";
            this.textLargoTornillo.Size = new System.Drawing.Size(100, 23);
            this.textLargoTornillo.TabIndex = 5;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(26, 193);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 23);
            this.textPrecio.TabIndex = 2;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(26, 137);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(100, 23);
            this.textDescripcion.TabIndex = 1;
            // 
            // textStockActual
            // 
            this.textStockActual.Location = new System.Drawing.Point(473, 76);
            this.textStockActual.Name = "textStockActual";
            this.textStockActual.Size = new System.Drawing.Size(100, 23);
            this.textStockActual.TabIndex = 9;
            // 
            // textStockStandar
            // 
            this.textStockStandar.Location = new System.Drawing.Point(473, 137);
            this.textStockStandar.Name = "textStockStandar";
            this.textStockStandar.Size = new System.Drawing.Size(100, 23);
            this.textStockStandar.TabIndex = 10;
            // 
            // textLargoCaño
            // 
            this.textLargoCaño.Enabled = false;
            this.textLargoCaño.Location = new System.Drawing.Point(330, 193);
            this.textLargoCaño.Name = "textLargoCaño";
            this.textLargoCaño.Size = new System.Drawing.Size(100, 23);
            this.textLargoCaño.TabIndex = 8;
            // 
            // combTipoCaño
            // 
            this.combTipoCaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTipoCaño.Enabled = false;
            this.combTipoCaño.FormattingEnabled = true;
            this.combTipoCaño.Location = new System.Drawing.Point(330, 137);
            this.combTipoCaño.Name = "combTipoCaño";
            this.combTipoCaño.Size = new System.Drawing.Size(100, 23);
            this.combTipoCaño.TabIndex = 7;
            // 
            // combTipoTornillo
            // 
            this.combTipoTornillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTipoTornillo.Enabled = false;
            this.combTipoTornillo.FormattingEnabled = true;
            this.combTipoTornillo.ItemHeight = 15;
            this.combTipoTornillo.Location = new System.Drawing.Point(184, 137);
            this.combTipoTornillo.Name = "combTipoTornillo";
            this.combTipoTornillo.Size = new System.Drawing.Size(101, 23);
            this.combTipoTornillo.TabIndex = 28;
            // 
            // cmbMetrica
            // 
            this.cmbMetrica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetrica.Enabled = false;
            this.cmbMetrica.FormattingEnabled = true;
            this.cmbMetrica.Location = new System.Drawing.Point(184, 76);
            this.cmbMetrica.Name = "cmbMetrica";
            this.cmbMetrica.Size = new System.Drawing.Size(101, 23);
            this.cmbMetrica.TabIndex = 3;
            // 
            // CargarNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 333);
            this.Controls.Add(this.cmbMetrica);
            this.Controls.Add(this.combTipoTornillo);
            this.Controls.Add(this.combTipoCaño);
            this.Controls.Add(this.textLargoCaño);
            this.Controls.Add(this.textStockStandar);
            this.Controls.Add(this.textStockActual);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textLargoTornillo);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.btnAñador);
            this.Controls.Add(this.radButnCaño);
            this.Controls.Add(this.labDiametro);
            this.Controls.Add(this.labTipoCaño);
            this.Controls.Add(this.labPrecio);
            this.Controls.Add(this.labLargoCaño);
            this.Controls.Add(this.labStockActual);
            this.Controls.Add(this.labLargoTornillo);
            this.Controls.Add(this.labStockStandar);
            this.Controls.Add(this.labTipoTornillo);
            this.Controls.Add(this.labMetrica);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.labDescripcion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.radButnTornillo);
            this.Controls.Add(this.radButnOtro);
            this.Controls.Add(this.textDiametro);
            this.Controls.Add(this.labCodigo);
            this.Name = "CargarNuevoProducto";
            this.Text = "CargarNuevoProducto";
            this.Load += new System.EventHandler(this.CargarNuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.TextBox textDiametro;
        private System.Windows.Forms.RadioButton radButnOtro;
        private System.Windows.Forms.RadioButton radButnTornillo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labDescripcion;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labMetrica;
        private System.Windows.Forms.Label labTipoTornillo;
        private System.Windows.Forms.Label labStockStandar;
        private System.Windows.Forms.Label labLargoTornillo;
        private System.Windows.Forms.Label labStockActual;
        private System.Windows.Forms.Label labLargoCaño;
        private System.Windows.Forms.Label labPrecio;
        private System.Windows.Forms.Label labTipoCaño;
        private System.Windows.Forms.Label labDiametro;
        private System.Windows.Forms.RadioButton radButnCaño;
        private System.Windows.Forms.Button btnAñador;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textLargoTornillo;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textStockActual;
        private System.Windows.Forms.TextBox textStockStandar;
        private System.Windows.Forms.TextBox textLargoCaño;
        private System.Windows.Forms.ComboBox combTipoCaño;
        private System.Windows.Forms.ComboBox combTipoTornillo;
        private System.Windows.Forms.ComboBox cmbMetrica;
    }
}