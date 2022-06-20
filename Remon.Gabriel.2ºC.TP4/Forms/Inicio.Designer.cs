namespace Forms
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDistribuidoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negocioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDistribuidoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.cargarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negocioToolStripMenuItem,
            this.pedidoDistribuidoraToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // negocioToolStripMenuItem
            // 
            this.negocioToolStripMenuItem.Name = "negocioToolStripMenuItem";
            this.negocioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.negocioToolStripMenuItem.Text = "Negocio";
            this.negocioToolStripMenuItem.Click += new System.EventHandler(this.negocioGuardarMenu_Click);
            // 
            // pedidoDistribuidoraToolStripMenuItem
            // 
            this.pedidoDistribuidoraToolStripMenuItem.Name = "pedidoDistribuidoraToolStripMenuItem";
            this.pedidoDistribuidoraToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pedidoDistribuidoraToolStripMenuItem.Text = "Pedido Distribuidora";
            this.pedidoDistribuidoraToolStripMenuItem.Click += new System.EventHandler(this.pedidoDistribuidoraToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negocioToolStripMenuItem1,
            this.pedidoDistribuidoraToolStripMenuItem1});
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            // 
            // negocioToolStripMenuItem1
            // 
            this.negocioToolStripMenuItem1.Name = "negocioToolStripMenuItem1";
            this.negocioToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.negocioToolStripMenuItem1.Text = "Negocio";
            this.negocioToolStripMenuItem1.Click += new System.EventHandler(this.negocioGuardarComoMenu_Click);
            // 
            // pedidoDistribuidoraToolStripMenuItem1
            // 
            this.pedidoDistribuidoraToolStripMenuItem1.Name = "pedidoDistribuidoraToolStripMenuItem1";
            this.pedidoDistribuidoraToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.pedidoDistribuidoraToolStripMenuItem1.Text = "Pedido Distribuidora";
            this.pedidoDistribuidoraToolStripMenuItem1.Click += new System.EventHandler(this.pedidoDistribuidoraToolStripMenuItem1_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cargarToolStripMenuItem.Text = "Importar Ferreteria";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaProductosToolStripMenuItem,
            this.listaDeClientesToolStripMenuItem,
            this.listaDeVentasToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // listaProductosToolStripMenuItem
            // 
            this.listaProductosToolStripMenuItem.Name = "listaProductosToolStripMenuItem";
            this.listaProductosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.listaProductosToolStripMenuItem.Text = "Lista de productos stock";
            this.listaProductosToolStripMenuItem.Click += new System.EventHandler(this.listaProductosToolStripMenuItem_Click);
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de clientes";
            this.listaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listaDeClientesToolStripMenuItem_Click);
            // 
            // listaDeVentasToolStripMenuItem
            // 
            this.listaDeVentasToolStripMenuItem.Name = "listaDeVentasToolStripMenuItem";
            this.listaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.listaDeVentasToolStripMenuItem.Text = "Lista de ventas";
            this.listaDeVentasToolStripMenuItem.Click += new System.EventHandler(this.listaDeVentasToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoDistribuidoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negocioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidoDistribuidoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeVentasToolStripMenuItem;
    }
}