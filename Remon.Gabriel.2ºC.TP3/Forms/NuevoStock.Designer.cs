﻿namespace Forms
{
    partial class NuevoStock
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
            this.txtStockNuevo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labStockActual
            // 
            this.labStockActual.AutoSize = true;
            this.labStockActual.Location = new System.Drawing.Point(13, 30);
            this.labStockActual.Name = "labStockActual";
            this.labStockActual.Size = new System.Drawing.Size(92, 15);
            this.labStockActual.TabIndex = 0;
            this.labStockActual.Text = "Stock actual = X";
            // 
            // labStockNuevo
            // 
            this.labStockNuevo.AutoSize = true;
            this.labStockNuevo.Location = new System.Drawing.Point(13, 64);
            this.labStockNuevo.Name = "labStockNuevo";
            this.labStockNuevo.Size = new System.Drawing.Size(74, 15);
            this.labStockNuevo.TabIndex = 1;
            this.labStockNuevo.Text = "Nuevo Stock";
            // 
            // txtStockNuevo
            // 
            this.txtStockNuevo.Location = new System.Drawing.Point(12, 93);
            this.txtStockNuevo.Name = "txtStockNuevo";
            this.txtStockNuevo.Size = new System.Drawing.Size(215, 23);
            this.txtStockNuevo.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 135);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(152, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // NuevoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 170);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtStockNuevo);
            this.Controls.Add(this.labStockNuevo);
            this.Controls.Add(this.labStockActual);
            this.Name = "NuevoStock";
            this.Text = "NuevoStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStockActual;
        private System.Windows.Forms.Label labStockNuevo;
        private System.Windows.Forms.TextBox txtStockNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}