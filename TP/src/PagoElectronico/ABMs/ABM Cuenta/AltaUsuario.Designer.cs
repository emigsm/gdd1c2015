namespace PagoElectronico.ABMs.ABM_Cuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblPreguntaSecreta = new System.Windows.Forms.Label();
            this.lblRespuestaSecreta = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtPreguntaSecreta = new System.Windows.Forms.TextBox();
            this.txtRespuestaSecreta = new System.Windows.Forms.TextBox();
            this.btnVerificarUsuario = new System.Windows.Forms.Button();
            this.lblVerificarContraseña = new System.Windows.Forms.Label();
            this.txtVerificarContraseña = new System.Windows.Forms.TextBox();
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los siguientes datos:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(12, 63);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(12, 157);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol:";
            // 
            // lblPreguntaSecreta
            // 
            this.lblPreguntaSecreta.AutoSize = true;
            this.lblPreguntaSecreta.Location = new System.Drawing.Point(12, 198);
            this.lblPreguntaSecreta.Name = "lblPreguntaSecreta";
            this.lblPreguntaSecreta.Size = new System.Drawing.Size(91, 13);
            this.lblPreguntaSecreta.TabIndex = 4;
            this.lblPreguntaSecreta.Text = "Pregunta secreta:";
            // 
            // lblRespuestaSecreta
            // 
            this.lblRespuestaSecreta.AutoSize = true;
            this.lblRespuestaSecreta.Location = new System.Drawing.Point(12, 241);
            this.lblRespuestaSecreta.Name = "lblRespuestaSecreta";
            this.lblRespuestaSecreta.Size = new System.Drawing.Size(99, 13);
            this.lblRespuestaSecreta.TabIndex = 5;
            this.lblRespuestaSecreta.Text = "Respuesta secreta:";
            this.lblRespuestaSecreta.Click += new System.EventHandler(this.lblRespuestaSecreta_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(128, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(122, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(128, 63);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(122, 20);
            this.txtContraseña.TabIndex = 7;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(128, 154);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 8;
            // 
            // txtPreguntaSecreta
            // 
            this.txtPreguntaSecreta.Location = new System.Drawing.Point(128, 198);
            this.txtPreguntaSecreta.Name = "txtPreguntaSecreta";
            this.txtPreguntaSecreta.Size = new System.Drawing.Size(122, 20);
            this.txtPreguntaSecreta.TabIndex = 9;
            // 
            // txtRespuestaSecreta
            // 
            this.txtRespuestaSecreta.Location = new System.Drawing.Point(127, 241);
            this.txtRespuestaSecreta.Name = "txtRespuestaSecreta";
            this.txtRespuestaSecreta.Size = new System.Drawing.Size(122, 20);
            this.txtRespuestaSecreta.TabIndex = 10;
            // 
            // btnVerificarUsuario
            // 
            this.btnVerificarUsuario.Location = new System.Drawing.Point(277, 29);
            this.btnVerificarUsuario.Name = "btnVerificarUsuario";
            this.btnVerificarUsuario.Size = new System.Drawing.Size(80, 23);
            this.btnVerificarUsuario.TabIndex = 11;
            this.btnVerificarUsuario.Text = "Verificar";
            this.btnVerificarUsuario.UseVisualStyleBackColor = true;
            // 
            // lblVerificarContraseña
            // 
            this.lblVerificarContraseña.AutoSize = true;
            this.lblVerificarContraseña.Location = new System.Drawing.Point(12, 96);
            this.lblVerificarContraseña.Name = "lblVerificarContraseña";
            this.lblVerificarContraseña.Size = new System.Drawing.Size(105, 13);
            this.lblVerificarContraseña.TabIndex = 12;
            this.lblVerificarContraseña.Text = "Verificar Contraseña:";
            // 
            // txtVerificarContraseña
            // 
            this.txtVerificarContraseña.Location = new System.Drawing.Point(128, 93);
            this.txtVerificarContraseña.Name = "txtVerificarContraseña";
            this.txtVerificarContraseña.Size = new System.Drawing.Size(122, 20);
            this.txtVerificarContraseña.TabIndex = 13;
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.Location = new System.Drawing.Point(277, 151);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(80, 110);
            this.btnAltaUsuario.TabIndex = 14;
            this.btnAltaUsuario.Text = "Dar de alta";
            this.btnAltaUsuario.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 263);
            this.panel1.TabIndex = 15;
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 287);
            this.Controls.Add(this.btnAltaUsuario);
            this.Controls.Add(this.txtVerificarContraseña);
            this.Controls.Add(this.lblVerificarContraseña);
            this.Controls.Add(this.btnVerificarUsuario);
            this.Controls.Add(this.txtRespuestaSecreta);
            this.Controls.Add(this.txtPreguntaSecreta);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblRespuestaSecreta);
            this.Controls.Add(this.lblPreguntaSecreta);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AltaUsuario";
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblPreguntaSecreta;
        private System.Windows.Forms.Label lblRespuestaSecreta;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtPreguntaSecreta;
        private System.Windows.Forms.TextBox txtRespuestaSecreta;
        private System.Windows.Forms.Button btnVerificarUsuario;
        private System.Windows.Forms.Label lblVerificarContraseña;
        private System.Windows.Forms.TextBox txtVerificarContraseña;
        private System.Windows.Forms.Button btnAltaUsuario;
        private System.Windows.Forms.Panel panel1;
    }
}