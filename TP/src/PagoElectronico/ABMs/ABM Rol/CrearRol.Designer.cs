namespace PagoElectronico.ABMs.ABM_Rol
{
    partial class CrearRol
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
            this.Rol_NombreTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.HabilitadoOpButton = new System.Windows.Forms.RadioButton();
            this.InhabilitadoOpButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CrearRolButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Rol:";
            // 
            // Rol_NombreTextBox
            // 
            this.Rol_NombreTextBox.Location = new System.Drawing.Point(135, 26);
            this.Rol_NombreTextBox.MaxLength = 50;
            this.Rol_NombreTextBox.Name = "Rol_NombreTextBox";
            this.Rol_NombreTextBox.Size = new System.Drawing.Size(180, 20);
            this.Rol_NombreTextBox.TabIndex = 1;
            this.Rol_NombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rol_NombreTextBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Funcionalidades);
            this.groupBox1.Location = new System.Drawing.Point(24, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades";
            // 
            // Funcionalidades
            // 
            this.Funcionalidades.FormattingEnabled = true;
            this.Funcionalidades.Location = new System.Drawing.Point(12, 28);
            this.Funcionalidades.Name = "Funcionalidades";
            this.Funcionalidades.Size = new System.Drawing.Size(298, 109);
            this.Funcionalidades.TabIndex = 0;
            // 
            // HabilitadoOpButton
            // 
            this.HabilitadoOpButton.AutoSize = true;
            this.HabilitadoOpButton.Checked = true;
            this.HabilitadoOpButton.Location = new System.Drawing.Point(37, 19);
            this.HabilitadoOpButton.Name = "HabilitadoOpButton";
            this.HabilitadoOpButton.Size = new System.Drawing.Size(72, 17);
            this.HabilitadoOpButton.TabIndex = 3;
            this.HabilitadoOpButton.TabStop = true;
            this.HabilitadoOpButton.Text = "Habilitado";
            this.HabilitadoOpButton.UseVisualStyleBackColor = true;
            // 
            // InhabilitadoOpButton
            // 
            this.InhabilitadoOpButton.AutoSize = true;
            this.InhabilitadoOpButton.Location = new System.Drawing.Point(178, 19);
            this.InhabilitadoOpButton.Name = "InhabilitadoOpButton";
            this.InhabilitadoOpButton.Size = new System.Drawing.Size(79, 17);
            this.InhabilitadoOpButton.TabIndex = 4;
            this.InhabilitadoOpButton.Text = "Inhabilitado";
            this.InhabilitadoOpButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InhabilitadoOpButton);
            this.groupBox2.Controls.Add(this.HabilitadoOpButton);
            this.groupBox2.Location = new System.Drawing.Point(24, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 45);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Del Rol";
            // 
            // CrearRolButton
            // 
            this.CrearRolButton.Location = new System.Drawing.Point(227, 298);
            this.CrearRolButton.Name = "CrearRolButton";
            this.CrearRolButton.Size = new System.Drawing.Size(114, 40);
            this.CrearRolButton.TabIndex = 6;
            this.CrearRolButton.Text = "Crear Rol";
            this.CrearRolButton.UseVisualStyleBackColor = true;
            this.CrearRolButton.Click += new System.EventHandler(this.CrearRolButton_Click);
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(26, 300);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(106, 37);
            this.VolverButton.TabIndex = 7;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // CrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 355);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.CrearRolButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Rol_NombreTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CrearRol";
            this.Text = "CrearRol";
            this.Load += new System.EventHandler(this.CrearRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Rol_NombreTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton HabilitadoOpButton;
        private System.Windows.Forms.RadioButton InhabilitadoOpButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CrearRolButton;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.CheckedListBox Funcionalidades;
    }
}