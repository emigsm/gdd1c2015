namespace PagoElectronico.ABMs.ABM_de_Usuario
{
    partial class AltaUsuario
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblVerificarContraseña = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblPreguntaSecreta = new System.Windows.Forms.Label();
            this.lblRespuestaSecreta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRespuestaSecreta = new System.Windows.Forms.TextBox();
            this.txtPreguntaSecreta = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtVerificarContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(9, 51);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(9, 91);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 20);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblVerificarContraseña
            // 
            this.lblVerificarContraseña.AutoSize = true;
            this.lblVerificarContraseña.Location = new System.Drawing.Point(9, 131);
            this.lblVerificarContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarContraseña.Name = "lblVerificarContraseña";
            this.lblVerificarContraseña.Size = new System.Drawing.Size(155, 20);
            this.lblVerificarContraseña.TabIndex = 2;
            this.lblVerificarContraseña.Text = "Verificar contraseña:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(9, 198);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(37, 20);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol:";
            // 
            // lblPreguntaSecreta
            // 
            this.lblPreguntaSecreta.AutoSize = true;
            this.lblPreguntaSecreta.Location = new System.Drawing.Point(9, 248);
            this.lblPreguntaSecreta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreguntaSecreta.Name = "lblPreguntaSecreta";
            this.lblPreguntaSecreta.Size = new System.Drawing.Size(135, 20);
            this.lblPreguntaSecreta.TabIndex = 4;
            this.lblPreguntaSecreta.Text = "Pregunta secreta:";
            // 
            // lblRespuestaSecreta
            // 
            this.lblRespuestaSecreta.AutoSize = true;
            this.lblRespuestaSecreta.Location = new System.Drawing.Point(9, 303);
            this.lblRespuestaSecreta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuestaSecreta.Name = "lblRespuestaSecreta";
            this.lblRespuestaSecreta.Size = new System.Drawing.Size(148, 20);
            this.lblRespuestaSecreta.TabIndex = 5;
            this.lblRespuestaSecreta.Text = "Respuesta secreta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRespuestaSecreta);
            this.groupBox1.Controls.Add(this.txtPreguntaSecreta);
            this.groupBox1.Controls.Add(this.cmbRol);
            this.groupBox1.Controls.Add(this.txtVerificarContraseña);
            this.groupBox1.Controls.Add(this.lblRespuestaSecreta);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.lblPreguntaSecreta);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblVerificarContraseña);
            this.groupBox1.Controls.Add(this.lblContraseña);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(381, 345);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los siguientes datos:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtRespuestaSecreta
            // 
            this.txtRespuestaSecreta.Location = new System.Drawing.Point(166, 298);
            this.txtRespuestaSecreta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRespuestaSecreta.Name = "txtRespuestaSecreta";
            this.txtRespuestaSecreta.Size = new System.Drawing.Size(190, 26);
            this.txtRespuestaSecreta.TabIndex = 9;
            this.txtRespuestaSecreta.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPreguntaSecreta
            // 
            this.txtPreguntaSecreta.Location = new System.Drawing.Point(168, 243);
            this.txtPreguntaSecreta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPreguntaSecreta.Name = "txtPreguntaSecreta";
            this.txtPreguntaSecreta.Size = new System.Drawing.Size(190, 26);
            this.txtPreguntaSecreta.TabIndex = 8;
            this.txtPreguntaSecreta.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(168, 185);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(193, 28);
            this.cmbRol.TabIndex = 7;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // txtVerificarContraseña
            // 
            this.txtVerificarContraseña.Location = new System.Drawing.Point(168, 126);
            this.txtVerificarContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVerificarContraseña.Name = "txtVerificarContraseña";
            this.txtVerificarContraseña.PasswordChar = '*';
            this.txtVerificarContraseña.Size = new System.Drawing.Size(190, 26);
            this.txtVerificarContraseña.TabIndex = 6;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(168, 86);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(190, 26);
            this.txtContraseña.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(168, 46);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.Location = new System.Drawing.Point(18, 372);
            this.btnAltaUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(198, 48);
            this.btnAltaUsuario.TabIndex = 8;
            this.btnAltaUsuario.Text = "Alta de Usuario";
            this.btnAltaUsuario.UseVisualStyleBackColor = true;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(408, 322);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 35);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Enabled = false;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(250, 372);
            this.btnRegistrarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(198, 48);
            this.btnRegistrarCliente.TabIndex = 10;
            this.btnRegistrarCliente.Text = "Registrarse como Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 448);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAltaUsuario);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AltaUsuario";
            this.Text = "Alta de Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblVerificarContraseña;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblPreguntaSecreta;
        private System.Windows.Forms.Label lblRespuestaSecreta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtVerificarContraseña;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtRespuestaSecreta;
        private System.Windows.Forms.TextBox txtPreguntaSecreta;
        private System.Windows.Forms.Button btnAltaUsuario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarCliente;
    }
}