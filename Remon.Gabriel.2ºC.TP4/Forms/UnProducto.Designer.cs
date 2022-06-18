namespace Forms
{
    partial class UnProducto
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
            this.labStockActual = new System.Windows.Forms.Label();
            this.labStockNuevo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecioActual = new System.Windows.Forms.Label();
            this.lblNuevoPrecio = new System.Windows.Forms.Label();
            this.numericPrecio = new System.Windows.Forms.NumericUpDown();
            this.numericStock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).BeginInit();
            this.SuspendLayout();
            // 
            // labStockActual
            // 
            this.labStockActual.AutoSize = true;
            this.labStockActual.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labStockActual.Location = new System.Drawing.Point(13, 20);
            this.labStockActual.Name = "labStockActual";
            this.labStockActual.Size = new System.Drawing.Size(128, 25);
            this.labStockActual.TabIndex = 0;
            this.labStockActual.Text = "Stock actual = ";
            // 
            // labStockNuevo
            // 
            this.labStockNuevo.AutoSize = true;
            this.labStockNuevo.Location = new System.Drawing.Point(13, 112);
            this.labStockNuevo.Name = "labStockNuevo";
            this.labStockNuevo.Size = new System.Drawing.Size(74, 15);
            this.labStockNuevo.TabIndex = 1;
            this.labStockNuevo.Text = "Nuevo Stock";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 177);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPrecioActual
            // 
            this.lblPrecioActual.AutoSize = true;
            this.lblPrecioActual.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioActual.Location = new System.Drawing.Point(12, 54);
            this.lblPrecioActual.Name = "lblPrecioActual";
            this.lblPrecioActual.Size = new System.Drawing.Size(114, 25);
            this.lblPrecioActual.TabIndex = 5;
            this.lblPrecioActual.Text = "Precio Actual";
            // 
            // lblNuevoPrecio
            // 
            this.lblNuevoPrecio.AutoSize = true;
            this.lblNuevoPrecio.Location = new System.Drawing.Point(13, 144);
            this.lblNuevoPrecio.Name = "lblNuevoPrecio";
            this.lblNuevoPrecio.Size = new System.Drawing.Size(78, 15);
            this.lblNuevoPrecio.TabIndex = 6;
            this.lblNuevoPrecio.Text = "Nuevo precio";
            // 
            // numericPrecio
            // 
            this.numericPrecio.Location = new System.Drawing.Point(124, 144);
            this.numericPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericPrecio.Name = "numericPrecio";
            this.numericPrecio.Size = new System.Drawing.Size(103, 23);
            this.numericPrecio.TabIndex = 7;
            // 
            // numericStock
            // 
            this.numericStock.Location = new System.Drawing.Point(124, 112);
            this.numericStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericStock.Name = "numericStock";
            this.numericStock.Size = new System.Drawing.Size(103, 23);
            this.numericStock.TabIndex = 8;
            // 
            // NuevoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 222);
            this.Controls.Add(this.numericStock);
            this.Controls.Add(this.numericPrecio);
            this.Controls.Add(this.lblNuevoPrecio);
            this.Controls.Add(this.lblPrecioActual);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labStockNuevo);
            this.Controls.Add(this.labStockActual);
            this.Name = "NuevoStock";
            this.Text = "NuevoStock";
            this.Load += new System.EventHandler(this.NuevoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStockActual;
        private System.Windows.Forms.Label labStockNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecioActual;
        private System.Windows.Forms.Label lblNuevoPrecio;
        private System.Windows.Forms.NumericUpDown numericPrecio;
        private System.Windows.Forms.NumericUpDown numericStock;
    }
}