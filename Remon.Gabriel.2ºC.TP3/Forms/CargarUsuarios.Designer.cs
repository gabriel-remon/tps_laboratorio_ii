namespace Forms
{
    partial class CargarUsuarios
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
            this.labTitulo = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labDni = new System.Windows.Forms.Label();
            this.labSueldo = new System.Windows.Forms.Label();
            this.labEnum = new System.Windows.Forms.Label();
            this.labNacimiento = new System.Windows.Forms.Label();
            this.labContratacion = new System.Windows.Forms.Label();
            this.labContraseña = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.richTextLista = new System.Windows.Forms.RichTextBox();
            this.labLista = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.textSueldo = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dateTimeContratacion = new System.Windows.Forms.DateTimePicker();
            this.cmbEnum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTitulo.Location = new System.Drawing.Point(171, 29);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(226, 25);
            this.labTitulo.TabIndex = 0;
            this.labTitulo.Text = "Cargar nuevo empleado";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Location = new System.Drawing.Point(40, 126);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(51, 15);
            this.labApellido.TabIndex = 1;
            this.labApellido.Text = "Apellido";
            // 
            // labDni
            // 
            this.labDni.AutoSize = true;
            this.labDni.Location = new System.Drawing.Point(40, 181);
            this.labDni.Name = "labDni";
            this.labDni.Size = new System.Drawing.Size(27, 15);
            this.labDni.TabIndex = 2;
            this.labDni.Text = "DNI";
            // 
            // labSueldo
            // 
            this.labSueldo.AutoSize = true;
            this.labSueldo.Location = new System.Drawing.Point(340, 126);
            this.labSueldo.Name = "labSueldo";
            this.labSueldo.Size = new System.Drawing.Size(43, 15);
            this.labSueldo.TabIndex = 3;
            this.labSueldo.Text = "Sueldo";
            // 
            // labEnum
            // 
            this.labEnum.AutoSize = true;
            this.labEnum.Location = new System.Drawing.Point(168, 126);
            this.labEnum.Name = "labEnum";
            this.labEnum.Size = new System.Drawing.Size(39, 15);
            this.labEnum.TabIndex = 4;
            this.labEnum.Text = "Cargo";
            // 
            // labNacimiento
            // 
            this.labNacimiento.AutoSize = true;
            this.labNacimiento.Location = new System.Drawing.Point(171, 73);
            this.labNacimiento.Name = "labNacimiento";
            this.labNacimiento.Size = new System.Drawing.Size(101, 15);
            this.labNacimiento.TabIndex = 5;
            this.labNacimiento.Text = "Fecha nacimiento";
            // 
            // labContratacion
            // 
            this.labContratacion.AutoSize = true;
            this.labContratacion.Location = new System.Drawing.Point(340, 181);
            this.labContratacion.Name = "labContratacion";
            this.labContratacion.Size = new System.Drawing.Size(110, 15);
            this.labContratacion.TabIndex = 7;
            this.labContratacion.Text = "Fecha Contratacion";
            // 
            // labContraseña
            // 
            this.labContraseña.AutoSize = true;
            this.labContraseña.Location = new System.Drawing.Point(171, 181);
            this.labContraseña.Name = "labContraseña";
            this.labContraseña.Size = new System.Drawing.Size(63, 15);
            this.labContraseña.TabIndex = 8;
            this.labContraseña.Text = "Contaseña";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(40, 73);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(51, 15);
            this.labNombre.TabIndex = 9;
            this.labNombre.Text = "Nombre";
            // 
            // richTextLista
            // 
            this.richTextLista.Enabled = false;
            this.richTextLista.Location = new System.Drawing.Point(469, 78);
            this.richTextLista.Name = "richTextLista";
            this.richTextLista.Size = new System.Drawing.Size(207, 194);
            this.richTextLista.TabIndex = 10;
            this.richTextLista.Text = "";
            // 
            // labLista
            // 
            this.labLista.AutoSize = true;
            this.labLista.Location = new System.Drawing.Point(469, 48);
            this.labLista.Name = "labLista";
            this.labLista.Size = new System.Drawing.Size(108, 15);
            this.labLista.TabIndex = 11;
            this.labLista.Text = "Lista de empleados";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(40, 91);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 23);
            this.textNombre.TabIndex = 12;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(40, 144);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 23);
            this.textApellido.TabIndex = 13;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(40, 199);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(100, 23);
            this.textDni.TabIndex = 14;
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(171, 199);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(130, 23);
            this.textContraseña.TabIndex = 17;
            // 
            // textSueldo
            // 
            this.textSueldo.Location = new System.Drawing.Point(340, 144);
            this.textSueldo.Name = "textSueldo";
            this.textSueldo.Size = new System.Drawing.Size(111, 23);
            this.textSueldo.TabIndex = 19;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(152, 251);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(130, 35);
            this.btnCrear.TabIndex = 21;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNacimiento.Location = new System.Drawing.Point(168, 92);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(133, 23);
            this.dateTimeNacimiento.TabIndex = 22;
            this.dateTimeNacimiento.Value = new System.DateTime(2022, 6, 3, 15, 34, 13, 0);
            // 
            // dateTimeContratacion
            // 
            this.dateTimeContratacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeContratacion.Location = new System.Drawing.Point(340, 198);
            this.dateTimeContratacion.Name = "dateTimeContratacion";
            this.dateTimeContratacion.Size = new System.Drawing.Size(111, 23);
            this.dateTimeContratacion.TabIndex = 23;
            this.dateTimeContratacion.Value = new System.DateTime(2022, 6, 3, 15, 34, 13, 0);
            // 
            // cmbEnum
            // 
            this.cmbEnum.FormattingEnabled = true;
            this.cmbEnum.Location = new System.Drawing.Point(168, 144);
            this.cmbEnum.Name = "cmbEnum";
            this.cmbEnum.Size = new System.Drawing.Size(133, 23);
            this.cmbEnum.TabIndex = 24;
            // 
            // CargarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 312);
            this.Controls.Add(this.cmbEnum);
            this.Controls.Add(this.dateTimeContratacion);
            this.Controls.Add(this.dateTimeNacimiento);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.textSueldo);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labLista);
            this.Controls.Add(this.richTextLista);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.labContraseña);
            this.Controls.Add(this.labContratacion);
            this.Controls.Add(this.labNacimiento);
            this.Controls.Add(this.labEnum);
            this.Controls.Add(this.labSueldo);
            this.Controls.Add(this.labDni);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labTitulo);
            this.Name = "CargarUsuarios";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.CargarUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labDni;
        private System.Windows.Forms.Label labSueldo;
        private System.Windows.Forms.Label labEnum;
        private System.Windows.Forms.Label labNacimiento;
        private System.Windows.Forms.Label labContratacion;
        private System.Windows.Forms.Label labContraseña;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.RichTextBox richTextLista;
        private System.Windows.Forms.Label labLista;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textSueldo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimeContratacion;
        private System.Windows.Forms.ComboBox cmbEnum;
    }
}