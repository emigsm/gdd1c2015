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
            this.txtVerificarContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblVerifContraseña = new System.Windows.Forms.Label();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.checkBoxContraseña = new System.Windows.Forms.CheckBox();
            this.groupBoxPregunta = new System.Windows.Forms.GroupBox();
            this.checkBoxPregunta = new System.Windows.Forms.CheckBox();
            this.txtRespSec = new System.Windows.Forms.TextBox();
            this.txtPregSec = new System.Windows.Forms.TextBox();
            this.lblRespSecretanueva = new System.Windows.Forms.Label();
            this.lblPregSecreta = new System.Windows.Forms.Label();
            this.groupBoxRol = new System.Windows.Forms.GroupBox();
            this.cmbRolActual = new System.Windows.Forms.ComboBox();
            this.rbEliminarRol = new System.Windows.Forms.RadioButton();
            this.checkBoxCambioRol = new System.Windows.Forms.CheckBox();
            this.rbAgregarRol = new System.Windows.Forms.RadioButton();
            this.cmbCambioRol = new System.Windows.Forms.ComboBox();
            this.rbModificarRol = new System.Windows.Forms.RadioButton();
            this.lblCambioRol = new System.Windows.Forms.Label();
            this.lblRolActual = new System.Windows.Forms.Label();
            this.groupBoxEstado = new System.Windows.Forms.GroupBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnCambiarPregunta = new System.Windows.Forms.Button();
            this.btnCambiarRol = new System.Windows.Forms.Button();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.groupBoxContraseña.SuspendLayout();
            this.groupBoxPregunta.SuspendLayout();
            this.groupBoxRol.SuspendLayout();
            this.groupBoxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(568, 442);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 35);
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
            this.groupBoxContraseña.Location = new System.Drawing.Point(20, 20);
            this.groupBoxContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxContraseña.Name = "groupBoxContraseña";
            this.groupBoxContraseña.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxContraseña.Size = new System.Drawing.Size(480, 125);
            this.groupBoxContraseña.TabIndex = 1;
            this.groupBoxContraseña.TabStop = false;
            this.groupBoxContraseña.Text = "Cambio de contraseña";
            // 
            // txtVerificarContraseña
            // 
            this.txtVerificarContraseña.Enabled = false;
            this.txtVerificarContraseña.Location = new System.Drawing.Point(236, 62);
            this.txtVerificarContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVerificarContraseña.Name = "txtVerificarContraseña";
            this.txtVerificarContraseña.PasswordChar = '*';
            this.txtVerificarContraseña.Size = new System.Drawing.Size(234, 26);
            this.txtVerificarContraseña.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(236, 20);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(234, 26);
            this.txtContraseña.TabIndex = 3;
            // 
            // lblVerifContraseña
            // 
            this.lblVerifContraseña.AutoSize = true;
            this.lblVerifContraseña.Enabled = false;
            this.lblVerifContraseña.Location = new System.Drawing.Point(9, 72);
            this.lblVerifContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerifContraseña.Name = "lblVerifContraseña";
            this.lblVerifContraseña.Size = new System.Drawing.Size(155, 20);
            this.lblVerifContraseña.TabIndex = 2;
            this.lblVerifContraseña.Text = "Verificar contraseña:";
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Enabled = false;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(9, 31);
            this.lblNuevaContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(142, 20);
            this.lblNuevaContraseña.TabIndex = 1;
            this.lblNuevaContraseña.Text = "Nueva contraseña:";
            // 
            // checkBoxContraseña
            // 
            this.checkBoxContraseña.AutoSize = true;
            this.checkBoxContraseña.Location = new System.Drawing.Point(182, 0);
            this.checkBoxContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxContraseña.Name = "checkBoxContraseña";
            this.checkBoxContraseña.Size = new System.Drawing.Size(15, 14);
            this.checkBoxContraseña.TabIndex = 0;
            this.checkBoxContraseña.UseVisualStyleBackColor = true;
            this.checkBoxContraseña.CheckedChanged += new System.EventHandler(this.checkBoxContraseña_CheckedChanged);
            // 
            // groupBoxPregunta
            // 
            this.groupBoxPregunta.Controls.Add(this.checkBoxPregunta);
            this.groupBoxPregunta.Controls.Add(this.txtRespSec);
            this.groupBoxPregunta.Controls.Add(this.txtPregSec);
            this.groupBoxPregunta.Controls.Add(this.lblRespSecretanueva);
            this.groupBoxPregunta.Controls.Add(this.lblPregSecreta);
            this.groupBoxPregunta.Location = new System.Drawing.Point(18, 154);
            this.groupBoxPregunta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPregunta.Name = "groupBoxPregunta";
            this.groupBoxPregunta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPregunta.Size = new System.Drawing.Size(482, 125);
            this.groupBoxPregunta.TabIndex = 2;
            this.groupBoxPregunta.TabStop = false;
            this.groupBoxPregunta.Text = "Cambio de pregunta secreta";
            // 
            // checkBoxPregunta
            // 
            this.checkBoxPregunta.AutoSize = true;
            this.checkBoxPregunta.Location = new System.Drawing.Point(222, 0);
            this.checkBoxPregunta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPregunta.Name = "checkBoxPregunta";
            this.checkBoxPregunta.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPregunta.TabIndex = 5;
            this.checkBoxPregunta.UseVisualStyleBackColor = true;
            this.checkBoxPregunta.CheckedChanged += new System.EventHandler(this.checkBoxPregunta_CheckedChanged);
            // 
            // txtRespSec
            // 
            this.txtRespSec.Enabled = false;
            this.txtRespSec.Location = new System.Drawing.Point(237, 65);
            this.txtRespSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRespSec.Name = "txtRespSec";
            this.txtRespSec.Size = new System.Drawing.Size(234, 26);
            this.txtRespSec.TabIndex = 7;
            // 
            // txtPregSec
            // 
            this.txtPregSec.Enabled = false;
            this.txtPregSec.Location = new System.Drawing.Point(237, 25);
            this.txtPregSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPregSec.Name = "txtPregSec";
            this.txtPregSec.Size = new System.Drawing.Size(234, 26);
            this.txtPregSec.TabIndex = 5;
            // 
            // lblRespSecretanueva
            // 
            this.lblRespSecretanueva.AutoSize = true;
            this.lblRespSecretanueva.Enabled = false;
            this.lblRespSecretanueva.Location = new System.Drawing.Point(10, 65);
            this.lblRespSecretanueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespSecretanueva.Name = "lblRespSecretanueva";
            this.lblRespSecretanueva.Size = new System.Drawing.Size(195, 20);
            this.lblRespSecretanueva.TabIndex = 6;
            this.lblRespSecretanueva.Text = "Respuesta secreta nueva:";
            // 
            // lblPregSecreta
            // 
            this.lblPregSecreta.AutoSize = true;
            this.lblPregSecreta.Enabled = false;
            this.lblPregSecreta.Location = new System.Drawing.Point(10, 25);
            this.lblPregSecreta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPregSecreta.Name = "lblPregSecreta";
            this.lblPregSecreta.Size = new System.Drawing.Size(182, 20);
            this.lblPregSecreta.TabIndex = 5;
            this.lblPregSecreta.Text = "Pregunta secreta nueva:";
            this.lblPregSecreta.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxRol
            // 
            this.groupBoxRol.Controls.Add(this.cmbRolActual);
            this.groupBoxRol.Controls.Add(this.rbEliminarRol);
            this.groupBoxRol.Controls.Add(this.checkBoxCambioRol);
            this.groupBoxRol.Controls.Add(this.rbAgregarRol);
            this.groupBoxRol.Controls.Add(this.cmbCambioRol);
            this.groupBoxRol.Controls.Add(this.rbModificarRol);
            this.groupBoxRol.Controls.Add(this.lblCambioRol);
            this.groupBoxRol.Controls.Add(this.lblRolActual);
            this.groupBoxRol.Location = new System.Drawing.Point(18, 288);
            this.groupBoxRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRol.Name = "groupBoxRol";
            this.groupBoxRol.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRol.Size = new System.Drawing.Size(564, 86);
            this.groupBoxRol.TabIndex = 3;
            this.groupBoxRol.TabStop = false;
            this.groupBoxRol.Text = "Cambio de rol";
            this.groupBoxRol.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbRolActual
            // 
            this.cmbRolActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolActual.Enabled = false;
            this.cmbRolActual.FormattingEnabled = true;
            this.cmbRolActual.Location = new System.Drawing.Point(111, 26);
            this.cmbRolActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRolActual.Name = "cmbRolActual";
            this.cmbRolActual.Size = new System.Drawing.Size(148, 28);
            this.cmbRolActual.TabIndex = 14;
            // 
            // rbEliminarRol
            // 
            this.rbEliminarRol.AutoSize = true;
            this.rbEliminarRol.Enabled = false;
            this.rbEliminarRol.Location = new System.Drawing.Point(435, -5);
            this.rbEliminarRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEliminarRol.Name = "rbEliminarRol";
            this.rbEliminarRol.Size = new System.Drawing.Size(83, 24);
            this.rbEliminarRol.TabIndex = 13;
            this.rbEliminarRol.TabStop = true;
            this.rbEliminarRol.Text = "Eliminar";
            this.rbEliminarRol.UseVisualStyleBackColor = true;
            this.rbEliminarRol.CheckedChanged += new System.EventHandler(this.rbEliminarRol_CheckedChanged);
            // 
            // checkBoxCambioRol
            // 
            this.checkBoxCambioRol.AutoSize = true;
            this.checkBoxCambioRol.Location = new System.Drawing.Point(135, 0);
            this.checkBoxCambioRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxCambioRol.Name = "checkBoxCambioRol";
            this.checkBoxCambioRol.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCambioRol.TabIndex = 8;
            this.checkBoxCambioRol.UseVisualStyleBackColor = true;
            this.checkBoxCambioRol.CheckedChanged += new System.EventHandler(this.checkBoxCambioRol_CheckedChanged);
            // 
            // rbAgregarRol
            // 
            this.rbAgregarRol.AutoSize = true;
            this.rbAgregarRol.Enabled = false;
            this.rbAgregarRol.Location = new System.Drawing.Point(333, -3);
            this.rbAgregarRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAgregarRol.Name = "rbAgregarRol";
            this.rbAgregarRol.Size = new System.Drawing.Size(84, 24);
            this.rbAgregarRol.TabIndex = 12;
            this.rbAgregarRol.TabStop = true;
            this.rbAgregarRol.Text = "Agregar";
            this.rbAgregarRol.UseVisualStyleBackColor = true;
            this.rbAgregarRol.CheckedChanged += new System.EventHandler(this.rbAgregarRol_CheckedChanged);
            // 
            // cmbCambioRol
            // 
            this.cmbCambioRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCambioRol.Enabled = false;
            this.cmbCambioRol.FormattingEnabled = true;
            this.cmbCambioRol.Location = new System.Drawing.Point(366, 25);
            this.cmbCambioRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCambioRol.Name = "cmbCambioRol";
            this.cmbCambioRol.Size = new System.Drawing.Size(158, 28);
            this.cmbCambioRol.TabIndex = 10;
            // 
            // rbModificarRol
            // 
            this.rbModificarRol.AutoSize = true;
            this.rbModificarRol.Enabled = false;
            this.rbModificarRol.Location = new System.Drawing.Point(222, -3);
            this.rbModificarRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbModificarRol.Name = "rbModificarRol";
            this.rbModificarRol.Size = new System.Drawing.Size(91, 24);
            this.rbModificarRol.TabIndex = 11;
            this.rbModificarRol.TabStop = true;
            this.rbModificarRol.Text = "Modificar";
            this.rbModificarRol.UseVisualStyleBackColor = true;
            // 
            // lblCambioRol
            // 
            this.lblCambioRol.AutoSize = true;
            this.lblCambioRol.Enabled = false;
            this.lblCambioRol.Location = new System.Drawing.Point(272, 31);
            this.lblCambioRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambioRol.Name = "lblCambioRol";
            this.lblCambioRol.Size = new System.Drawing.Size(85, 20);
            this.lblCambioRol.TabIndex = 9;
            this.lblCambioRol.Text = "Cambiar a:";
            // 
            // lblRolActual
            // 
            this.lblRolActual.AutoSize = true;
            this.lblRolActual.Enabled = false;
            this.lblRolActual.Location = new System.Drawing.Point(15, 31);
            this.lblRolActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolActual.Name = "lblRolActual";
            this.lblRolActual.Size = new System.Drawing.Size(84, 20);
            this.lblRolActual.TabIndex = 0;
            this.lblRolActual.Text = "Rol actual:";
            // 
            // groupBoxEstado
            // 
            this.groupBoxEstado.Controls.Add(this.checkBoxEstado);
            this.groupBoxEstado.Controls.Add(this.cmbEstado);
            this.groupBoxEstado.Location = new System.Drawing.Point(20, 388);
            this.groupBoxEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEstado.Name = "groupBoxEstado";
            this.groupBoxEstado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEstado.Size = new System.Drawing.Size(243, 89);
            this.groupBoxEstado.TabIndex = 4;
            this.groupBoxEstado.TabStop = false;
            this.groupBoxEstado.Text = "Estado";
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(78, 0);
            this.checkBoxEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEstado.TabIndex = 11;
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.CheckedChanged += new System.EventHandler(this.checkBoxEstado_CheckedChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(9, 29);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(193, 28);
            this.cmbEstado.TabIndex = 11;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Enabled = false;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(508, 20);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(112, 125);
            this.btnCambiarContraseña.TabIndex = 5;
            this.btnCambiarContraseña.Text = "Cambiar";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnVerificarContraseña_Click);
            // 
            // btnCambiarPregunta
            // 
            this.btnCambiarPregunta.Enabled = false;
            this.btnCambiarPregunta.Location = new System.Drawing.Point(508, 154);
            this.btnCambiarPregunta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarPregunta.Name = "btnCambiarPregunta";
            this.btnCambiarPregunta.Size = new System.Drawing.Size(112, 125);
            this.btnCambiarPregunta.TabIndex = 13;
            this.btnCambiarPregunta.Text = "Cambiar";
            this.btnCambiarPregunta.UseVisualStyleBackColor = true;
            this.btnCambiarPregunta.Click += new System.EventHandler(this.btnCambiarPregunta_Click);
            // 
            // btnCambiarRol
            // 
            this.btnCambiarRol.Enabled = false;
            this.btnCambiarRol.Location = new System.Drawing.Point(591, 288);
            this.btnCambiarRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarRol.Name = "btnCambiarRol";
            this.btnCambiarRol.Size = new System.Drawing.Size(90, 86);
            this.btnCambiarRol.TabIndex = 14;
            this.btnCambiarRol.Text = "Cambiar";
            this.btnCambiarRol.UseVisualStyleBackColor = true;
            this.btnCambiarRol.Click += new System.EventHandler(this.btnCambiarRol_Click);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Enabled = false;
            this.btnCambiarEstado.Location = new System.Drawing.Point(272, 391);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(90, 86);
            this.btnCambiarEstado.TabIndex = 15;
            this.btnCambiarEstado.Text = "Cambiar";
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // ModificacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 489);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.btnCambiarRol);
            this.Controls.Add(this.btnCambiarPregunta);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.groupBoxEstado);
            this.Controls.Add(this.groupBoxRol);
            this.Controls.Add(this.groupBoxPregunta);
            this.Controls.Add(this.groupBoxContraseña);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBoxContraseña;
        private System.Windows.Forms.GroupBox groupBoxPregunta;
        private System.Windows.Forms.GroupBox groupBoxRol;
        private System.Windows.Forms.GroupBox groupBoxEstado;
        private System.Windows.Forms.Button btnCambiarContraseña;
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
        private System.Windows.Forms.ComboBox cmbCambioRol;
        private System.Windows.Forms.Label lblCambioRol;
        private System.Windows.Forms.RadioButton rbModificarRol;
        private System.Windows.Forms.CheckBox checkBoxCambioRol;
        private System.Windows.Forms.RadioButton rbAgregarRol;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Button btnCambiarPregunta;
        private System.Windows.Forms.Button btnCambiarRol;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.RadioButton rbEliminarRol;
        private System.Windows.Forms.ComboBox cmbRolActual;
    }
}