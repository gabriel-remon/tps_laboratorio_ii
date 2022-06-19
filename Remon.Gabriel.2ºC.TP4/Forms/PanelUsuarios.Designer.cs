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
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.labListaPedidos = new System.Windows.Forms.Label();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.btnListEmpleados = new System.Windows.Forms.Button();
            this.btnListClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarPedido
            // 
            this.btnGenerarPedido.Location = new System.Drawing.Point(12, 58);
            this.btnGenerarPedido.Name = "btnGenerarPedido";
            this.btnGenerarPedido.Size = new System.Drawing.Size(180, 40);
            this.btnGenerarPedido.TabIndex = 0;
            this.btnGenerarPedido.Text = "Generar Pedido  - F1";
            this.btnGenerarPedido.UseVisualStyleBackColor = true;
            this.btnGenerarPedido.Click += new System.EventHandler(this.btnGenerarPedido_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(12, 104);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(180, 40);
            this.btnHistorial.TabIndex = 1;
            this.btnHistorial.Text = "Historial de Pedidos - F2";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(12, 377);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(180, 40);
            this.btnNuevoProducto.TabIndex = 4;
            this.btnNuevoProducto.Text = "Cargar nuevo\r\nproducto - F5";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(12, 150);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(180, 40);
            this.btnNuevoCliente.TabIndex = 2;
            this.btnNuevoCliente.Text = "Cargar nuevo cliente - F3";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.Location = new System.Drawing.Point(12, 423);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 40);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar stock - F6";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // listPedidos
            // 
            this.listPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPedidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.ItemHeight = 20;
            this.listPedidos.Location = new System.Drawing.Point(220, 58);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(497, 404);
            this.listPedidos.TabIndex = 6;
            this.listPedidos.DoubleClick += new System.EventHandler(this.listPedidos_DoubleClick);
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
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(12, 331);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(180, 40);
            this.btnNuevoEmpleado.TabIndex = 3;
            this.btnNuevoEmpleado.Text = " Cargar nuevo \r\nEmpleado - F4";
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnListEmpleados
            // 
            this.btnListEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListEmpleados.Location = new System.Drawing.Point(734, 422);
            this.btnListEmpleados.Name = "btnListEmpleados";
            this.btnListEmpleados.Size = new System.Drawing.Size(180, 40);
            this.btnListEmpleados.TabIndex = 8;
            this.btnListEmpleados.Text = "   Lista de\r\n empleados F8";
            this.btnListEmpleados.UseVisualStyleBackColor = true;
            this.btnListEmpleados.Click += new System.EventHandler(this.btnListEmpleados_Click);
            // 
            // btnListClientes
            // 
            this.btnListClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListClientes.Location = new System.Drawing.Point(734, 377);
            this.btnListClientes.Name = "btnListClientes";
            this.btnListClientes.Size = new System.Drawing.Size(180, 40);
            this.btnListClientes.TabIndex = 9;
            this.btnListClientes.Text = "Lista de \r\nclientes - F7";
            this.btnListClientes.UseVisualStyleBackColor = true;
            this.btnListClientes.Click += new System.EventHandler(this.btnListClientes_Click);
            // 
            // PanelUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(926, 536);
            this.ControlBox = false;
            this.Controls.Add(this.btnListClientes);
            this.Controls.Add(this.btnListEmpleados);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.labListaPedidos);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnGenerarPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelUsuarios";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.PanelUsuarios_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PanelUsuarios_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarPedido;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ListBox listPedidos;
        private System.Windows.Forms.Label labListaPedidos;
        private System.Windows.Forms.Button btnNuevoEmpleado;
        private System.Windows.Forms.Button btnListEmpleados;
        private System.Windows.Forms.Button btnListClientes;
    }
}