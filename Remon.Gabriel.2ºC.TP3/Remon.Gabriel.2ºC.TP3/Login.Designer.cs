namespace Remon.Gabriel._2ºC.TP3
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxbUsuario = new System.Windows.Forms.TextBox();
            this.TxbContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLoging = new System.Windows.Forms.Button();
            this.RdUsuarios = new System.Windows.Forms.RadioButton();
            this.RdEmpleados = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // TxbUsuario
            // 
            this.TxbUsuario.Location = new System.Drawing.Point(52, 73);
            this.TxbUsuario.Name = "TxbUsuario";
            this.TxbUsuario.Size = new System.Drawing.Size(230, 23);
            this.TxbUsuario.TabIndex = 0;
            // 
            // TxbContraseña
            // 
            this.TxbContraseña.Location = new System.Drawing.Point(52, 127);
            this.TxbContraseña.Name = "TxbContraseña";
            this.TxbContraseña.Size = new System.Drawing.Size(230, 23);
            this.TxbContraseña.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // BtnLoging
            // 
            this.BtnLoging.Location = new System.Drawing.Point(123, 169);
            this.BtnLoging.Name = "BtnLoging";
            this.BtnLoging.Size = new System.Drawing.Size(75, 23);
            this.BtnLoging.TabIndex = 4;
            this.BtnLoging.Text = "Ingresar";
            this.BtnLoging.UseVisualStyleBackColor = true;
            this.BtnLoging.Click += new System.EventHandler(this.BtnLoging_Click);
            // 
            // RdUsuarios
            // 
            this.RdUsuarios.AutoSize = true;
            this.RdUsuarios.Location = new System.Drawing.Point(204, 192);
            this.RdUsuarios.Name = "RdUsuarios";
            this.RdUsuarios.Size = new System.Drawing.Size(70, 19);
            this.RdUsuarios.TabIndex = 7;
            this.RdUsuarios.TabStop = true;
            this.RdUsuarios.Text = "Usuarios";
            this.RdUsuarios.UseVisualStyleBackColor = true;
            // 
            // RdEmpleados
            // 
            this.RdEmpleados.AutoSize = true;
            this.RdEmpleados.Location = new System.Drawing.Point(204, 217);
            this.RdEmpleados.Name = "RdEmpleados";
            this.RdEmpleados.Size = new System.Drawing.Size(83, 19);
            this.RdEmpleados.TabIndex = 8;
            this.RdEmpleados.TabStop = true;
            this.RdEmpleados.Text = "Empleados";
            this.RdEmpleados.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 249);
            this.Controls.Add(this.RdEmpleados);
            this.Controls.Add(this.RdUsuarios);
            this.Controls.Add(this.BtnLoging);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbContraseña);
            this.Controls.Add(this.TxbUsuario);
            this.Name = "Login";
            this.Text = "Ferreteria Pepito";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbUsuario;
        private System.Windows.Forms.TextBox TxbContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLoging;
        private System.Windows.Forms.RadioButton RdUsuarios;
        private System.Windows.Forms.RadioButton RdEmpleados;
        private System.Windows.Forms.ImageList imageList1;
    }
}
