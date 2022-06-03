namespace Forms
{
    partial class CargarPedido
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
            this.labInformacionCliente = new System.Windows.Forms.Label();
            this.listProductos = new System.Windows.Forms.ListBox();
            this.listCleintes = new System.Windows.Forms.ListBox();
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.textDniClientes = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textCodigoProducto = new System.Windows.Forms.TextBox();
            this.labpedidos = new System.Windows.Forms.Label();
            this.labDniCliente = new System.Windows.Forms.Label();
            this.labCodigoProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labInformacionCliente
            // 
            this.labInformacionCliente.AutoSize = true;
            this.labInformacionCliente.Location = new System.Drawing.Point(215, 244);
            this.labInformacionCliente.Name = "labInformacionCliente";
            this.labInformacionCliente.Size = new System.Drawing.Size(38, 15);
            this.labInformacionCliente.TabIndex = 0;
            this.labInformacionCliente.Text = "label1";
            // 
            // listProductos
            // 
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 15;
            this.listProductos.Location = new System.Drawing.Point(29, 75);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(164, 124);
            this.listProductos.TabIndex = 1;
            // 
            // listCleintes
            // 
            this.listCleintes.FormattingEnabled = true;
            this.listCleintes.ItemHeight = 15;
            this.listCleintes.Location = new System.Drawing.Point(267, 75);
            this.listCleintes.Name = "listCleintes";
            this.listCleintes.Size = new System.Drawing.Size(158, 124);
            this.listCleintes.TabIndex = 2;
            // 
            // listPedidos
            // 
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.ItemHeight = 15;
            this.listPedidos.Location = new System.Drawing.Point(29, 244);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(164, 169);
            this.listPedidos.TabIndex = 3;
            // 
            // textDniClientes
            // 
            this.textDniClientes.Location = new System.Drawing.Point(267, 46);
            this.textDniClientes.Name = "textDniClientes";
            this.textDniClientes.Size = new System.Drawing.Size(158, 23);
            this.textDniClientes.TabIndex = 4;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(215, 390);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(106, 23);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar pedido";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(350, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // textCodigoProducto
            // 
            this.textCodigoProducto.Location = new System.Drawing.Point(29, 46);
            this.textCodigoProducto.Name = "textCodigoProducto";
            this.textCodigoProducto.Size = new System.Drawing.Size(164, 23);
            this.textCodigoProducto.TabIndex = 7;
            // 
            // labpedidos
            // 
            this.labpedidos.AutoSize = true;
            this.labpedidos.Location = new System.Drawing.Point(29, 226);
            this.labpedidos.Name = "labpedidos";
            this.labpedidos.Size = new System.Drawing.Size(90, 15);
            this.labpedidos.TabIndex = 8;
            this.labpedidos.Text = "Lista del pedido";
            // 
            // labDniCliente
            // 
            this.labDniCliente.AutoSize = true;
            this.labDniCliente.Location = new System.Drawing.Point(267, 28);
            this.labDniCliente.Name = "labDniCliente";
            this.labDniCliente.Size = new System.Drawing.Size(84, 15);
            this.labDniCliente.TabIndex = 9;
            this.labDniCliente.Text = "DNI del cliente";
            // 
            // labCodigoProducto
            // 
            this.labCodigoProducto.AutoSize = true;
            this.labCodigoProducto.Location = new System.Drawing.Point(29, 28);
            this.labCodigoProducto.Name = "labCodigoProducto";
            this.labCodigoProducto.Size = new System.Drawing.Size(117, 15);
            this.labCodigoProducto.TabIndex = 10;
            this.labCodigoProducto.Text = "Codigo del producto";
            // 
            // CargarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 429);
            this.Controls.Add(this.labCodigoProducto);
            this.Controls.Add(this.labDniCliente);
            this.Controls.Add(this.labpedidos);
            this.Controls.Add(this.textCodigoProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.textDniClientes);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.listCleintes);
            this.Controls.Add(this.listProductos);
            this.Controls.Add(this.labInformacionCliente);
            this.Name = "CargarPedido";
            this.Text = "CargarPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labInformacionCliente;
        private System.Windows.Forms.ListBox listProductos;
        private System.Windows.Forms.ListBox listCleintes;
        private System.Windows.Forms.ListBox listPedidos;
        private System.Windows.Forms.TextBox textDniClientes;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textCodigoProducto;
        private System.Windows.Forms.Label labpedidos;
        private System.Windows.Forms.Label labDniCliente;
        private System.Windows.Forms.Label labCodigoProducto;
    }
}