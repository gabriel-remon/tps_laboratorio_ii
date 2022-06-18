namespace Forms
{
    partial class ListaProductos
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
            this.listProdcutos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.labListaProductos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Location = new System.Drawing.Point(12, 43);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(49, 15);
            this.labCodigo.TabIndex = 0;
            this.labCodigo.Text = "Codigo ";
            // 
            // listProdcutos
            // 
            this.listProdcutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProdcutos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listProdcutos.FormattingEnabled = true;
            this.listProdcutos.ItemHeight = 23;
            this.listProdcutos.Location = new System.Drawing.Point(188, 42);
            this.listProdcutos.Name = "listProdcutos";
            this.listProdcutos.Size = new System.Drawing.Size(535, 234);
            this.listProdcutos.TabIndex = 1;
            this.listProdcutos.DoubleClick += new System.EventHandler(this.listProdcutos_DoubleClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(12, 265);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(157, 23);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // labListaProductos
            // 
            this.labListaProductos.AutoSize = true;
            this.labListaProductos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labListaProductos.Location = new System.Drawing.Point(346, 9);
            this.labListaProductos.Name = "labListaProductos";
            this.labListaProductos.Size = new System.Drawing.Size(194, 30);
            this.labListaProductos.TabIndex = 4;
            this.labListaProductos.Text = "Lista de productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 105);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el codido del producto\r\n   buscado para filtrar la lista.\r\n\r\n\r\nLuego haga" +
    " doble click sobre\r\n      el item para cambiar su\r\n            precio y/o stock " +
    "\r\n";
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(744, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labListaProductos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listProdcutos);
            this.Controls.Add(this.labCodigo);
            this.MinimumSize = new System.Drawing.Size(760, 350);
            this.Name = "ListaProductos";
            this.Text = "ListaProductos";
            this.Load += new System.EventHandler(this.ListaProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.ListBox listProdcutos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labListaProductos;
        private System.Windows.Forms.Label label1;
    }
}