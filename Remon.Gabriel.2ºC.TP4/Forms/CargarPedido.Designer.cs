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
            this.lstClientes = new System.Windows.Forms.ListBox();
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
            this.labInformacionCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labInformacionCliente.AutoSize = true;
            this.labInformacionCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labInformacionCliente.Location = new System.Drawing.Point(506, 350);
            this.labInformacionCliente.Name = "labInformacionCliente";
            this.labInformacionCliente.Size = new System.Drawing.Size(191, 20);
            this.labInformacionCliente.TabIndex = 0;
            this.labInformacionCliente.Text = "Ingrese un cliente continuar\r\n";
            // 
            // listProductos
            // 
            this.listProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProductos.Enabled = false;
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 15;
            this.listProductos.Location = new System.Drawing.Point(29, 75);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(389, 229);
            this.listProductos.TabIndex = 1;
            this.listProductos.DoubleClick += new System.EventHandler(this.listProductos_DoubleClick);
            // 
            // lstClientes
            // 
            this.lstClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 15;
            this.lstClientes.Location = new System.Drawing.Point(506, 75);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(380, 229);
            this.lstClientes.TabIndex = 2;
            this.lstClientes.DoubleClick += new System.EventHandler(this.listCleintes_DoubleClick);
            // 
            // listPedidos
            // 
            this.listPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.ItemHeight = 15;
            this.listPedidos.Location = new System.Drawing.Point(29, 333);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(389, 244);
            this.listPedidos.TabIndex = 3;
            this.listPedidos.DoubleClick += new System.EventHandler(this.listPedidos_DoubleClick);
            // 
            // textDniClientes
            // 
            this.textDniClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDniClientes.Location = new System.Drawing.Point(506, 46);
            this.textDniClientes.Name = "textDniClientes";
            this.textDniClientes.Size = new System.Drawing.Size(133, 23);
            this.textDniClientes.TabIndex = 4;
            this.textDniClientes.TextChanged += new System.EventHandler(this.textDniClientes_TextChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.Location = new System.Drawing.Point(506, 552);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(106, 23);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar pedido";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(811, 552);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textCodigoProducto
            // 
            this.textCodigoProducto.Location = new System.Drawing.Point(29, 46);
            this.textCodigoProducto.Name = "textCodigoProducto";
            this.textCodigoProducto.Size = new System.Drawing.Size(162, 23);
            this.textCodigoProducto.TabIndex = 7;
            this.textCodigoProducto.TextChanged += new System.EventHandler(this.textCodigoProducto_TextChanged);
            // 
            // labpedidos
            // 
            this.labpedidos.AutoSize = true;
            this.labpedidos.Location = new System.Drawing.Point(29, 315);
            this.labpedidos.Name = "labpedidos";
            this.labpedidos.Size = new System.Drawing.Size(90, 15);
            this.labpedidos.TabIndex = 8;
            this.labpedidos.Text = "Lista del pedido";
            // 
            // labDniCliente
            // 
            this.labDniCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labDniCliente.AutoSize = true;
            this.labDniCliente.Location = new System.Drawing.Point(506, 28);
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
            this.AcceptButton = this.btnCargar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(914, 587);
            this.ControlBox = false;
            this.Controls.Add(this.labCodigoProducto);
            this.Controls.Add(this.labDniCliente);
            this.Controls.Add(this.labpedidos);
            this.Controls.Add(this.textCodigoProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.textDniClientes);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.listProductos);
            this.Controls.Add(this.labInformacionCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(930, 600);
            this.Name = "CargarPedido";
            this.Text = "CargarPedido";
            this.Load += new System.EventHandler(this.CargarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labInformacionCliente;
        private System.Windows.Forms.ListBox listProductos;
        private System.Windows.Forms.ListBox lstClientes;
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