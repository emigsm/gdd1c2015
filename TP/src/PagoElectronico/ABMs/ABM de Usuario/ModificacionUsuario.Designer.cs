namespace PagoElectronico.ABMs.ABM_de_Usuario
{
    partial class ModificacionUsuario
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBoxContraseña = new System.Windows.Forms.GroupBox();
            this.groupBoxPregunta = new System.Windows.Forms.GroupBox();
            this.groupBoxRol = new System.Windows.Forms.GroupBox();
            this.groupBoxEstado = new System.Windows.Forms.GroupBox();
            this.btnVerificarContraseña = new System.Windows.Forms.Button();
            this.checkBoxContraseña = new System.Windows.Forms.CheckBox();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.lblVerifContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtVerificarContraseña = new System.Windows.Forms.TextBox();
            this.lblPregSecreta = new System.Windows.Forms.Label();
            this.lblRespSecretanueva = new System.Windows.Forms.Label();
            this.txtPregSec = new System.Windows.Forms.TextBox();
            this.txtRespSec = new System.Windows.Forms.TextBox();
            this.checkBoxPregunta = new System.Windows.Forms.CheckBox();
            this.lblRolActual = new System.Windows.Forms.Label();
            this.txtRolActual = new System.Windows.Forms.TextBox();
            this.lblCambioRol = new System.Windows.Forms.Label();
            this.cmbCambioRol = new System.Windows.Forms.ComboBox();
            this.rbModificarRol = new System.Windows.Forms.RadioButton();
            this.rbAgregarRol = new System.Windows.Forms.RadioButton();
            this.checkBoxCambioRol = new System.Windows.Forms.CheckBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.groupBoxContraseña.SuspendLayout();
            this.groupBoxPregunta.SuspendLayout();
            this.groupBoxRol.SuspendLayout();
            this.groupBoxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(339, 287);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBoxContraseña
            // 
            this.groupBoxContraseña.Controls.Add(this.txtVerificarContraseña);
            this.groupBoxContraseña.Controls.Add(this.txtContraseña);
            this.groupBoxContraseña.Controls.Add(this.lblVerifContraseña);
            this.groupBoxContraseña.Controls.Add(this.lblNuevaContraseña);
            this.groupBoxContraseña.Controls.Add(this.checkBoxContraseña);
            this.groupBoxContraseña.Location = new System.Drawing.Point(13, 13);
            this.groupBoxContraseña.Name = "groupBoxContraseña";
            this.groupBoxContraseña.Size = new System.Drawing.Size(320, 81);
            this.groupBoxContraseña.TabIndex = 1;
            this.groupBoxContraseña.TabStop = false;
            this.groupBoxContraseña.Text = "Cambio de contraseña";
            // 
            // groupBoxPregunta
            // 
            this.groupBoxPregunta.Controls.Add(this.checkBoxPregunta);
            this.groupBoxPregunta.Controls.Add(this.txtRespSec);
            this.groupBoxPregunta.Controls.Add(this.txtPregSec);
            this.groupBoxPregunta.Controls.Add(this.lblRespSecretanueva);
            this.groupBoxPregunta.Controls.Add(this.lblPregSecreta);
            this.groupBoxPregunta.Location = new System.Drawing.Point(12, 100);
            this.groupBoxPregunta.Name = "groupBoxPregunta";
            this.groupBoxPregunta.Size = new System.Drawing.Size(321, 81);
            this.groupBoxPregunta.TabIndex = 2;
            this.groupBoxPregunta.TabStop = false;
            this.groupBoxPregunta.Text = "Cambio de pregunta secreta";
            // 
            // groupBoxRol
            // 
            this.groupBoxRol.Controls.Add(this.checkBoxCambioRol);
            this.groupBoxRol.Controls.Add(this.cmbCambioRol);
            this.groupBoxRol.Controls.Add(this.lblCambioRol);
            this.groupBoxRol.Controls.Add(this.txtRolActual);
            this.groupBoxRol.Controls.Add(this.lblRolActual);
            this.groupBoxRol.Location = new System.Drawing.Point(12, 187);
            this.groupBoxRol.Name = "groupBoxRol";
            this.groupBoxRol.Size = new System.Drawing.Size(376, 56);
            this.groupBoxRol.TabIndex = 3;
            this.groupBoxRol.TabStop = false;
            this.groupBoxRol.Text = "Cambio de rol";
            this.groupBoxRol.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxEstado
            // 
            this.groupBoxEstado.Controls.Add(this.checkBoxEstado);
            this.groupBoxEstado.Controls.Add(this.cmbEstado);
            this.groupBoxEstado.Location = new System.Drawing.Point(13, 252);
            this.groupBoxEstado.Name = "groupBoxEstado";
            this.groupBoxEstado.Size = new System.Drawing.Size(162, 58);
            this.groupBoxEstado.TabIndex = 4;
            this.groupBoxEstado.TabStop = false;
            this.groupBoxEstado.Text = "Estado";
            // 
            // btnVerificarContraseña
            // 
            this.btnVerificarContraseña.Enabled = false;
            this.btnVerificarContraseña.Location = new System.Drawing.Point(339, 33);
            this.btnVerificarContraseña.Name = "btnVerificarContraseña";
            this.btnVerificarContraseña.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarContraseña.TabIndex = 5;
            this.btnVerificarContraseña.Text = "Verificar";
            this.btnVerificarContraseña.UseVisualStyleBackColor = true;
            // 
            // checkBoxContraseña
            // 
            this.checkBoxContraseña.AutoSize = true;
            this.checkBoxContraseña.Location = new System.Drawing.Point(121, 0);
            this.checkBoxContraseña.Name = "checkBoxContraseña";
            this.checkBoxContraseña.Size = new System.Drawing.Size(15, 14);
            this.checkBoxContraseña.TabIndex = 0;
            this.checkBoxContraseña.UseVisualStyleBackColor = true;
            this.checkBoxContraseña.CheckedChanged += new System.EventHandler(this.checkBoxContraseña_CheckedChanged);
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Enabled = false;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(6, 20);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(98, 13);
            this.lblNuevaContraseña.TabIndex = 1;
            this.lblNuevaContraseña.Text = "Nueva contraseña:";
            // 
            // lblVerifContraseña
            // 
            this.lblVerifContraseña.AutoSize = true;
            this.lblVerifContraseña.Enabled = false;
            this.lblVerifContraseña.Location = new System.Drawing.Point(6, 47);
            this.lblVerifContraseña.Name = "lblVerifContraseña";
            this.lblVerifContraseña.Size = new System.Drawing.Size(104, 13);
            this.lblVerifContraseña.TabIndex = 2;
            this.lblVerifContraseña.Text = "Verificar contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(157, 13);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(157, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // txtVerificarContraseña
            // 
            this.txtVerificarContraseña.Enabled = false;
            this.txtVerificarContraseña.Location = new System.Drawing.Point(157, 40);
            this.txtVerificarContraseña.Name = "txtVerificarContraseña";
            this.txtVerificarContraseña.Size = new System.Drawing.Size(157, 20);
            this.txtVerificarContraseña.TabIndex = 4;
            // 
            // lblPregSecreta
            // 
            this.lblPregSecreta.AutoSize = true;
            this.lblPregSecreta.Enabled = false;
            this.lblPregSecreta.Location = new System.Drawing.Point(7, 16);
            this.lblPregSecreta.Name = "lblPregSecreta";
            this.lblPregSecreta.Size = new System.Drawing.Size(124, 13);
            this.lblPregSecreta.TabIndex = 5;
            this.lblPregSecreta.Text = "Pregunta secreta nueva:";
            this.lblPregSecreta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRespSecretanueva
            // 
            this.lblRespSecretanueva.AutoSize = true;
            this.lblRespSecretanueva.Enabled = false;
            this.lblRespSecretanueva.Location = new System.Drawing.Point(7, 42);
            this.lblRespSecretanueva.Name = "lblRespSecretanueva";
            this.lblRespSecretanueva.Size = new System.Drawing.Size(132, 13);
            this.lblRespSecretanueva.TabIndex = 6;
            this.lblRespSecretanueva.Text = "Respuesta secreta nueva:";
            // 
            // txtPregSec
            // 
            this.txtPregSec.Enabled = false;
            this.txtPregSec.Location = new System.Drawing.Point(158, 16);
            this.txtPregSec.Name = "txtPregSec";
            this.txtPregSec.Size = new System.Drawing.Size(157, 20);
            this.txtPregSec.TabIndex = 5;
            // 
            // txtRespSec
            // 
            this.txtRespSec.Enabled = false;
            this.txtRespSec.Location = new System.Drawing.Point(158, 42);
            this.txtRespSec.Name = "txtRespSec";
            this.txtRespSec.Size = new System.Drawing.Size(157, 20);
            this.txtRespSec.TabIndex = 7;
            // 
            // checkBoxPregunta
            // 
            this.checkBoxPregunta.AutoSize = true;
            this.checkBoxPregunta.Location = new System.Drawing.Point(148, 0);
            this.checkBoxPregunta.Name = "checkBoxPregunta";
            this.checkBoxPregunta.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPregunta.TabIndex = 5;
            this.checkBoxPregunta.UseVisualStyleBackColor = true;
            this.checkBoxPregunta.CheckedChanged += new System.EventHandler(this.checkBoxPregunta_CheckedChanged);
            // 
            // lblRolActual
            // 
            this.lblRolActual.AutoSize = true;
            this.lblRolActual.Enabled = false;
            this.lblRolActual.Location = new System.Drawing.Point(10, 20);
            this.lblRolActual.Name = "lblRolActual";
            this.lblRolActual.Size = new System.Drawing.Size(58, 13);
            this.lblRolActual.TabIndex = 0;
            this.lblRolActual.Text = "Rol actual:";
            // 
            // txtRolActual
            // 
            this.txtRolActual.Enabled = false;
            this.txtRolActual.Location = new System.Drawing.Point(74, 17);
            this.txtRolActual.Name = "txtRolActual";
            this.txtRolActual.Size = new System.Drawing.Size(101, 20);
            this.txtRolActual.TabIndex = 8;
            this.txtRolActual.TextChanged += new System.EventHandler(this.txtRolActual_TextChanged);
            // 
            // lblCambioRol
            // 
            this.lblCambioRol.AutoSize = true;
            this.lblCambioRol.Enabled = false;
            this.lblCambioRol.Location = new System.Drawing.Point(181, 20);
            this.lblCambioRol.Name = "lblCambioRol";
            this.lblCambioRol.Size = new System.Drawing.Size(57, 13);
            this.lblCambioRol.TabIndex = 9;
            this.lblCambioRol.Text = "Cambiar a:";
            // 
            // cmbCambioRol
            // 
            this.cmbCambioRol.Enabled = false;
            this.cmbCambioRol.FormattingEnabled = true;
            this.cmbCambioRol.Location = new System.Drawing.Point(244, 16);
            this.cmbCambioRol.Name = "cmbCambioRol";
            this.cmbCambioRol.Size = new System.Drawing.Size(121, 21);
            this.cmbCambioRol.TabIndex = 10;
            // 
            // rbModificarRol
            // 
            this.rbModificarRol.AutoSize = true;
            this.rbModificarRol.Enabled = false;
            this.rbModificarRol.Location = new System.Drawing.Point(394, 203);
            this.rbModificarRol.Name = "rbModificarRol";
            this.rbModificarRol.Size = new System.Drawing.Size(68, 17);
            this.rbModificarRol.TabIndex = 11;
            this.rbModificarRol.TabStop = true;
            this.rbModificarRol.Text = "Modificar";
            this.rbModificarRol.UseVisualStyleBackColor = true;
            // 
            // rbAgregarRol
            // 
            this.rbAgregarRol.AutoSize = true;
            this.rbAgregarRol.Enabled = false;
            this.rbAgregarRol.Location = new System.Drawing.Point(394, 226);
            this.rbAgregarRol.Name = "rbAgregarRol";
            this.rbAgregarRol.Size = new System.Drawing.Size(62, 17);
            this.rbAgregarRol.TabIndex = 12;
            this.rbAgregarRol.TabStop = true;
            this.rbAgregarRol.Text = "Agregar";
            this.rbAgregarRol.UseVisualStyleBackColor = true;
            // 
            // checkBoxCambioRol
            // 
            this.checkBoxCambioRol.AutoSize = true;
            this.checkBoxCambioRol.Location = new System.Drawing.Point(90, 0);
            this.checkBoxCambioRol.Name = "checkBoxCambioRol";
            this.checkBoxCambioRol.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCambioRol.TabIndex = 8;
            this.checkBoxCambioRol.UseVisualStyleBackColor = true;
            this.checkBoxCambioRol.CheckedChanged += new System.EventHandler(this.checkBoxCambioRol_CheckedChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(6, 19);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(130, 21);
            this.cmbEstado.TabIndex = 11;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(52, 0);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEstado.TabIndex = 11;
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.CheckedChanged += new System.EventHandler(this.checkBoxEstado_CheckedChanged);
            // 
            // ModificacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 318);
            this.Controls.Add(this.rbAgregarRol);
            this.Controls.Add(this.rbModificarRol);
            this.Controls.Add(this.btnVerificarContraseña);
            this.Controls.Add(this.groupBoxEstado);
            this.Controls.Add(this.groupBoxRol);
            this.Controls.Add(this.groupBoxPregunta);
            this.Controls.Add(this.groupBoxContraseña);
            this.Controls.Add(this.btnVolver);
            this.Name = "ModificacionUsuario";
            this.Text = "Modificacion de Usuario";
            this.groupBoxContraseña.ResumeLayout(false);
            this.groupBoxContraseña.PerformLayout();
            this.groupBoxPregunta.ResumeLayout(false);
            this.groupBoxPregunta.PerformLayout();
            this.groupBoxRol.ResumeLayout(false);
            this.groupBoxRol.PerformLayout();
            this.groupBoxEstado.ResumeLayout(false);
            this.groupBoxEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBoxContraseña;
        private System.Windows.Forms.GroupBox groupBoxPregunta;
        private System.Windows.Forms.GroupBox groupBoxRol;
        private System.Windows.Forms.GroupBox groupBoxEstado;
        private System.Windows.Forms.Button btnVerificarContraseña;
        private System.Windows.Forms.CheckBox checkBoxContraseña;
        private System.Windows.Forms.TextBox txtVerificarContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblVerifContraseña;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Label lblPregSecreta;
        private System.Windows.Forms.CheckBox checkBoxPregunta;
        private System.Windows.Forms.TextBox txtRespSec;
        private System.Windows.Forms.TextBox txtPregSec;
        private System.Windows.Forms.Label lblRespSecretanueva;
        private System.Windows.Forms.Label lblRolActual;
        private System.Windows.Forms.TextBox txtRolActual;
        private System.Windows.Forms.ComboBox cmbCambioRol;
        private System.Windows.Forms.Label lblCambioRol;
        private System.Windows.Forms.RadioButton rbModificarRol;
        private System.Windows.Forms.CheckBox checkBoxCambioRol;
        private System.Windows.Forms.RadioButton rbAgregarRol;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.CheckBox checkBoxEstado;
    }
}