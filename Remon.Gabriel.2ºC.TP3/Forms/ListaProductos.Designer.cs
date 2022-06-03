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
            this.listProdcutos.FormattingEnabled = true;
            this.listProdcutos.ItemHeight = 15;
            this.listProdcutos.Location = new System.Drawing.Point(188, 42);
            this.listProdcutos.Name = "listProdcutos";
            this.listProdcutos.Size = new System.Drawing.Size(287, 244);
            this.listProdcutos.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(157, 23);
            this.txtCodigo.TabIndex = 3;
            // 
            // labListaProductos
            // 
            this.labListaProductos.AutoSize = true;
            this.labListaProductos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labListaProductos.Location = new System.Drawing.Point(233, 9);
            this.labListaProductos.Name = "labListaProductos";
            this.labListaProductos.Size = new System.Drawing.Size(194, 30);
            this.labListaProductos.TabIndex = 4;
            this.labListaProductos.Text = "Lista de productos";
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 304);
            this.Controls.Add(this.labListaProductos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listProdcutos);
            this.Controls.Add(this.labCodigo);
            this.Name = "ListaProductos";
            this.Text = "ListaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.ListBox listProdcutos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labListaProductos;
    }
}