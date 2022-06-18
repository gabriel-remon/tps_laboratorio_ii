namespace Forms
{
    partial class PanelUsuarios
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
            this.btnGenerarPedido = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnPedidoDistribuidora = new System.Windows.Forms.Button();
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.labListaPedidos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarPedido
            // 
            this.btnGenerarPedido.Location = new System.Drawing.Point(12, 12);
            this.btnGenerarPedido.Name = "btnGenerarPedido";
            this.btnGenerarPedido.Size = new System.Drawing.Size(180, 40);
            this.btnGenerarPedido.TabIndex = 0;
            this.btnGenerarPedido.Text = "Generar Pedido";
            this.btnGenerarPedido.UseVisualStyleBackColor = true;
            this.btnGenerarPedido.Click += new System.EventHandler(this.btnGenerarPedido_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(12, 58);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(180, 40);
            this.btnHistorial.TabIndex = 1;
            this.btnHistorial.Text = "Historial de Pedidos";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(12, 196);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(180, 40);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "Cargar nuevo producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(12, 104);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(180, 40);
            this.btnNuevoCliente.TabIndex = 3;
            this.btnNuevoCliente.Text = "Cargar nuevo cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 242);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 40);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar stock";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnPedidoDistribuidora
            // 
            this.btnPedidoDistribuidora.Location = new System.Drawing.Point(12, 292);
            this.btnPedidoDistribuidora.Name = "btnPedidoDistribuidora";
            this.btnPedidoDistribuidora.Size = new System.Drawing.Size(180, 40);
            this.btnPedidoDistribuidora.TabIndex = 5;
            this.btnPedidoDistribuidora.Text = "Generar pedido\r\nDistribuidora\r\n";
            this.btnPedidoDistribuidora.UseVisualStyleBackColor = true;
            // 
            // listPedidos
            // 
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.ItemHeight = 15;
            this.listPedidos.Location = new System.Drawing.Point(220, 58);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(234, 319);
            this.listPedidos.TabIndex = 6;
            // 
            // labListaPedidos
            // 
            this.labListaPedidos.AutoSize = true;
            this.labListaPedidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labListaPedidos.Location = new System.Drawing.Point(220, 25);
            this.labListaPedidos.Name = "labListaPedidos";
            this.labListaPedidos.Size = new System.Drawing.Size(185, 25);
            this.labListaPedidos.TabIndex = 7;
            this.labListaPedidos.Text = "Pedidos pendientes";
            this.labListaPedidos.Click += new System.EventHandler(this.labListaPedidos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 338);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 40);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(12, 150);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(180, 40);
            this.btnNuevoEmpleado.TabIndex = 9;
            this.btnNuevoEmpleado.Text = "Cargar nuevo Empleado";
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // PanelUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 408);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.labListaPedidos);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.btnPedidoDistribuidora);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnGenerarPedido);
            this.MaximizeBox = false;
            this.Name = "PanelUsuarios";
            this.Text = "Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.PanelUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarPedido;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnPedidoDistribuidora;
        private System.Windows.Forms.ListBox listPedidos;
        private System.Windows.Forms.Label labListaPedidos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoEmpleado;
    }
}